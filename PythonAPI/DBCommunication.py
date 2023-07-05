import subprocess
from datetime import datetime

import mt940
from flask import Flask, request, jsonify
from pymongo import MongoClient
from connectionString import connection_string
import json
import mysql.connector
import dicttoxml2
from xml.dom.minidom import parseString
from validation.Validator import json_schema_validate, xml_schema_validate

# MySql connection
mydb = mysql.connector.connect(
    host='localhost',
    port=3306,
    user="root",
    password="",
    database="sportsaccounting",
    use_pure=True
)

# MongoDB connection
client = MongoClient(connection_string)
db = client["ProjTest"]
collection = db["MT940Parsed"]
mycursor = mydb.cursor()

app = Flask(__name__)


@app.route('/api/test', methods=["GET"])
def test():
    return json_response("Hi")


def json_response(data, status=200):
    return jsonify({"response": data}), status


@app.route('/api/PerformBackup', methods=["GET"])
def perform_backup():
    file_name = "backup_" + datetime.now().strftime("%d-%m-%Y") + ".sql"
    subprocess.Popen("C:/xampp/mysql/bin/mysqldump.exe -h localhost -P 3306 -u root sportsaccounting --routines > "
                     "../Backup/" + file_name, shell=True)
    return json_response("Backup performed")


@app.route('/api/uploadFile', methods=["POST"])
def save_file_to_database():
    file = request.files['file']
    if file.filename != '':
        file = parse_mt940_file(file)
        if json_schema_validate(file) is False:  # & xml_schema_validate(file) is False:
            return json_response("Unsupported file format")
        if is_duplicate(file):
            return json_response("File already exists")
        balances = list(key for key in file if "balance" in key)
        insert_file_info(file, collect_detailed_ids(file, balances))
        insert_transaction_info(file)
        collection.insert_one(file)
    return json_response("File uploaded")


@app.route('/api/getTransactions/<request_type>', methods=["GET"])
def retrieve_transactions(request_type):
    if request_type == "other":
        mycursor.execute("SELECT `bankReference` FROM transaction WHERE `categoryName` = 'other'")
    elif request_type == "all":
        mycursor.execute("SELECT `bankReference` FROM transaction")
    myresult = mycursor.fetchall()
    return myresult


@app.route('/api/updateTransactionDescription', methods=["GET"])
def update_transaction_description():
    custom_details = request.args.get('customDetails')
    bank_reference = request.args.get('bankReference')
    update_desc = "UPDATE transaction_details d JOIN transaction t ON d.id = t.transactionDetailsId SET " \
                  "d.customDetails = %s WHERE t.bankReference = %s"
    val = (custom_details, bank_reference)
    mycursor.execute(update_desc, val)
    mydb.commit()
    return json_response("Transaction description updated")


@app.route('/api/getTransactionDescription/<bank_ref>', methods=["GET"])
def get_transaction_description(bank_ref):
    mycursor.callproc('SowCustomDetailsBasedOnBankReference', [bank_ref])
    for result in mycursor.stored_results():
        myresult = result.fetchall()
        return myresult


@app.route('/api/getBalance', methods=["GET"])
def get_balance():
    mycursor.execute(
        "SELECT amount FROM detailedinfo WHERE Id = (SELECT availableBalanceId FROM file ORDER BY id DESC LIMIT 1)")
    myresult = mycursor.fetchall()
    print(myresult)
    if len(myresult) == 0:
        return json_response("No balance")
    return myresult


@app.route('/api/getTransactionsForChart', methods=["GET"])
def get_balance_for_chart():
    mycursor.execute(
        "SELECT amount, `date` FROM detailedinfo WHERE type = 'transaction'")
    myresult = mycursor.fetchall()
    print(myresult)
    if len(myresult) == 0:
        return json_response("No transactions")
    return myresult


@app.route('/api/updateCategory', methods=["POST"])
def update_transaction_category():
    category_info = request.get_json()
    bank_reference = category_info.get('bankReference')
    category = category_info.get('category')
    if category == "membership fee":
        member = category_info.get('member')
        make_connection = "INSERT INTO transaction_connect (memberId, bankReference) SELECT m.id, %s FROM member m WHERE m.name = %s "
        val = (bank_reference, member)
        mycursor.execute(make_connection, val)
        mydb.commit()
    update_category = "UPDATE transaction SET categoryName = %s WHERE bankReference = %s"
    val = (category, bank_reference)
    mycursor.execute(update_category, val)
    mydb.commit()
    return json_response("Transaction category updated")


@app.route('/api/ModuleInfo/<module>', methods=["GET"])
def get_modules_info(module):
    mydict = dict()
    mydict[module] = dict()
    mycursor.execute("SELECT * FROM %s" % module)
    myresult = mycursor.fetchall()
    for x in myresult:
        mydict[module]['expense'] = x[0]
        mydict[module]['income'] = x[1]
        mydict[module]['turnover'] = x[2]
    return json.dumps(mydict)


@app.route('/api/Tables', methods=["GET"])
def get_tables():
    mycursor.execute("SHOW TABLES")
    tables = mycursor.fetchall()
    return tables


@app.route('/api/user/register', methods=["POST"])
def register():
    user_info = request.get_json()
    username = user_info.get('username')
    password = user_info.get('password')
    first_name = user_info.get('firstName')
    last_name = user_info.get('lastName')
    email = user_info.get('email')
    role = user_info.get('role')
    date_of_join = datetime.now().strftime("%Y-%m-%d")

    try:
        sql = "INSERT INTO user (username, firstName, lastName, password, email, joinDate, userType) VALUES (%s, %s, %s, %s, %s, %s, %s)"
        val = (username, first_name, last_name, password, email, date_of_join, role)
        mycursor.execute(sql, val)
        mydb.commit()
        return json_response("Registration successful")
    except mysql.connector.Error as err:
        return json_response(err.msg)


@app.route('/api/user/login', methods=["POST"])
def login():
    user_info = request.get_json()
    username = user_info.get('username')
    password = user_info.get('password')

    if check_if_exist(username) == password:
        return json_response("Login successful")
    return json_response("Login failed")


@app.route('/api/addMember', methods=["POST"])
def add_member():
    member_info = request.get_json()
    name = member_info.get('name')
    email = member_info.get('email')
    try:
        insert_member = "INSERT INTO member (name, email) VALUES (%s, %s)"
        val = (name, email)
        mycursor.execute(insert_member, val)
        mydb.commit()
        return json_response("Member added")
    except mysql.connector.Error as err:
        return json_response("User already exists")


def check_if_exist(username):
    mycursor.execute("SELECT * FROM user WHERE username = '%s'" % username)
    myresult = mycursor.fetchall()
    if len(myresult) == 0:
        return False
    else:
        return myresult[0][5]


@app.route('/api/Columns/<table>', methods=["GET"])
def get_columns(table):
    mycursor.execute(
        "SELECT DISTINCT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'sportsaccounting' AND TABLE_NAME = '%s'" % table)
    columns = mycursor.fetchall()
    return columns


@app.route('/api/searchKeyword', methods=["GET"])
def search_keyword():
    table = request.args.get('table')
    column = request.args.get('column')
    keyword = request.args.get('keyword')
    mycursor.execute("SELECT * FROM %s WHERE %s LIKE '%%%s%%'" % (table, column, keyword))
    myresult = mycursor.fetchall()
    return myresult


@app.route('/api/ModulesSummary', methods=["GET"])
def make_modules_summary():
    bar_information = json.loads(get_modules_info('bar_information'))
    rental_information = json.loads(get_modules_info('rental_information'))

    modules_information = {}
    modules_information.update(bar_information)
    modules_information.update(rental_information)
    summary = {"modules_information": modules_information}
    # convert dict to json
    json_summary = json.dumps(summary, indent=4)
    # convert dict to xml and make it look nice
    xml_summary = parseString(dicttoxml2.dicttoxml(summary)).toprettyxml(indent="\t", encoding="utf-8")
    with open("../Summaries/modules_summary.json", "w") as outfile:
        outfile.write(json_summary)
    with open("../Summaries/modules_summary.xml", "wb") as outfile:
        outfile.write(xml_summary)
    return json_summary


@app.route('/api/getMembers', methods=["GET"])
def get_members():
    mycursor.execute("SELECT name FROM member")
    myresult = mycursor.fetchall()
    return myresult


def get_transaction_details(details_id):
    get_details = "SELECT transactionDetails,extraDetails,customDetails FROM transaction_details WHERE Id = %s" % details_id
    mycursor.execute(get_details)
    details = mycursor.fetchall()
    t_details = []
    for y in details:
        t_details.append({"transactionDetails": y[0], "extraDetails": y[1], "customDetails": y[2]})
    return t_details


def get_file_info():
    get_summary = "SELECT * FROM file"
    mycursor.execute(get_summary)
    summary = mycursor.fetchall()
    f_summary = []
    for y in summary:
        f_summary.append({"transactionReference": y[0],
                          "availableBalanceId": get_detailed_info(y[1]),
                          "finalClosingBalanceId": get_detailed_info(y[2]),
                          "finalOpeningBalanceId": get_detailed_info(y[3]),
                          "forwardAvailableBalanceId": get_detailed_info(y[4]),
                          "accountIdentification": y[5],
                          "sequenceNumber": y[6]})
    return f_summary


def get_transaction_info():
    get_transactions = "SELECT * FROM transaction"
    mycursor.execute(get_transactions)
    myresult = mycursor.fetchall()
    transactions = []
    for x in myresult:
        transactions.append({"bankReference": x[0], "transactionReference": x[1], "category": x[2],
                             "detailedInfo": get_detailed_info(x[3]), "entryDate": str(x[4]),
                             "guessedEntryDate": str(x[5]), "id": x[6], "fundsCode": x[7],
                             "transactionDetails": get_transaction_details(x[8])})
    return transactions


def get_detailed_info(info_id):
    get_info = "SELECT amount,currency,date,status,type FROM detailedinfo WHERE Id = %s" % info_id
    mycursor.execute(get_info)
    info = mycursor.fetchall()
    d_info = []
    for y in info:
        d_info.append({"amount": y[0], "currency": y[1], "date": str(y[2]), "status": y[3], "type": y[4]})
    return d_info


@app.route('/api/Summary', methods=["GET"])
def make_summary():
    summary = {"file": get_file_info(), "transactions": get_transaction_info()}
    # convert dict to json
    json_summary = json.dumps(summary, indent=4)
    # convert dict to xml and make it look nice
    xml_summary = parseString(dicttoxml2.dicttoxml(summary)).toprettyxml(indent="\t", encoding="utf-8")
    with open("../Summaries/summary.json", "w") as outfile:
        outfile.write(json_summary)
    with open("../Summaries/summary.xml", "wb") as outfile:
        outfile.write(xml_summary)
    return json_response("Summary created successfully")


@app.route('/api/getCustomDetails', methods=["GET"])
def get_custom_details():
    mycursor.execute("SET @p0 = '00000000001005'; CALL ShowCustomDetailsBasedOnBankReference(@p0);", multi=True)
    myresult = mycursor.fetchall()
    return myresult


def is_duplicate(file):
    transaction_reference = file['transaction_reference']
    mycursor.execute("SELECT * FROM file WHERE transactionReference = %s LIMIT 1", (transaction_reference,))
    myresult = mycursor.fetchall()
    if len(myresult) > 0:
        return True
    return False


def collect_detailed_ids(file, balances):
    ids = [None] * 4
    for balance in balances:
        if balance == "available_balance":
            ids[0] = insert_detailed_info(file, balance)
        elif balance == "final_closing_balance":
            ids[1] = insert_detailed_info(file, balance)
        elif balance == "final_opening_balance":
            ids[2] = insert_detailed_info(file, balance)
        elif balance == "forward_available_balance":
            ids[3] = insert_detailed_info(file, balance)
    return ids


def insert_detailed_info(file, type):
    if type == 'transaction':
        balance_amount = file['amount']['amount']
        balance_currency = file['amount']['currency']
        balance_date = file['date']
        balance_status = file['status']
    else:
        balance_amount = file[type]['amount']['amount']
        balance_currency = file[type]['amount']['currency']
        balance_date = file[type]['date']
        balance_status = file[type]['status']

    insert_to_detailed_info = "INSERT INTO detailedinfo (amount, currency,date,status,type) VALUES (%s, %s, %s, %s,%s)"
    val = (balance_amount, balance_currency, balance_date, balance_status, type)
    mycursor.execute(insert_to_detailed_info, val)
    mydb.commit()
    return mycursor.lastrowid


def insert_transaction_details(transaction_details, extra_details):
    insert_to_transaction_details = "INSERT INTO transaction_details (transactionDetails, extraDetails, " \
                                    "customDetails) VALUES (%s, %s, %s)"
    val = (transaction_details, extra_details, "")
    mycursor.execute(insert_to_transaction_details, val)
    mydb.commit()
    return mycursor.lastrowid


def insert_file_info(file, ids):
    account_identification = file['account_identification']
    sequence_number = file['sequence_number']
    statement_number = file['statement_number']
    transaction_reference = file['transaction_reference']

    available_balance_id = ids[0]
    final_closing_balance_id = ids[1]
    final_opening_balance_id = ids[2]
    forward_available_balance_id = ids[3]

    insert_to_file = "INSERT INTO file (accountIdentification, sequenceNumber, statementNumber, " \
                     "transactionReference, availableBalanceId, finalClosingBalanceId, " \
                     "finalOpeningBalanceId, forwardAvailableBalanceId) VALUES (%s, %s, %s, %s, %s, %s, %s, %s)"
    val = (account_identification, sequence_number, statement_number, transaction_reference, available_balance_id,
           final_closing_balance_id, final_opening_balance_id, forward_available_balance_id)
    mycursor.execute(insert_to_file, val)
    mydb.commit()
    return mycursor.lastrowid


def check_if_transaction_exists(bank_reference):
    mycursor.execute("SELECT * FROM transaction WHERE bankReference = %s LIMIT 1", (bank_reference,))
    myresult = mycursor.fetchall()
    if len(myresult) > 0:
        return True
    return False


def insert_transaction_info(file):
    transactions = file['transactions']
    for transaction in transactions:
        bank_reference = transaction['bank_reference']
        if check_if_transaction_exists(bank_reference):
            return
        detailed_info_id = insert_detailed_info(transaction, 'transaction')
        entry_date = transaction['entry_date']
        funds_code = transaction['funds_code']
        guessed_entry_date = transaction['guessed_entry_date']
        transaction_id = transaction['id']
        transaction_reference = file['transaction_reference']
        category = 'other'

        transaction_details = transaction['transaction_details']
        extra_details = transaction['extra_details']
        custom_details = ""

        mycursor.callproc('InsertTransactionWithDetails',
                          [bank_reference, transaction_reference, category, detailed_info_id, entry_date,
                           guessed_entry_date, funds_code, transaction_id, transaction_details, extra_details,
                           custom_details])


def parse_mt940_file(file_path):
    # PARSES THE MT940 FILE AND RETURNS A COLLECTION
    transaction = mt940.parse(file_path)
    # CONVERTS THE COLLECTION TO JSON STRING
    transaction = json.dumps(transaction, indent=4, sort_keys=True, cls=mt940.JSONEncoder)
    # CONVERTS THE JSON STRING TO A DICTIONARY
    transaction = json.loads(transaction)
    return transaction


if __name__ == '__main__':
    app.run(host='0.0.0.0', port=122)
