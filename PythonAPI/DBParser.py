import mt940
from flask import Flask, jsonify, request, make_response
from recieveRequest import parse_mt940_file
import json
import mysql.connector

mydb = mysql.connector.connect(
    host='localhost',
    port=3306,
    user="root",
    password="",
    database="sportsaccounting",
    use_pure=True
)

mycursor = mydb.cursor()
app = Flask(__name__)


@app.route('/api/test', methods=["GET"])
def test():
    return "Hi"


@app.route('/api/uploadFile', methods=["POST"])
def save_file_to_database():
    file = request.files['file']
    file = parse_mt940_file(file)
    available_balance_id = insert_detailed_info(file, 'available_balance')
    final_closing_balance_id = insert_detailed_info(file, 'final_closing_balance')
    final_opening_balance_id = insert_detailed_info(file, 'final_opening_balance')
    forward_available_balance_id = insert_detailed_info(file, 'forward_available_balance')
    insert_file_info(file, available_balance_id, final_closing_balance_id, final_opening_balance_id,
                     forward_available_balance_id)
    insert_transaction_info(file)
    return "File added to db SUCCESSFULLY"


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


def insert_file_info(file, available_balance_id, final_closing_balance_id, final_opening_balance_id,
                     forward_available_balance_id):
    account_identification = file['account_identification']
    sequence_number = file['sequence_number']
    statement_number = file['statement_number']
    transaction_reference = file['transaction_reference']

    insert_to_file = "INSERT INTO file (accountIdentification, sequenceNumber, statementNumber, " \
                     "transactionReference, availableBalanceId, finalClosingBalanceId, " \
                     "finalOpeningBalanceId, forwardAvailableBalanceId) VALUES (%s, %s, %s, %s, %s, %s, %s, %s)"
    val = (account_identification, sequence_number, statement_number, transaction_reference, available_balance_id,
           final_closing_balance_id, final_opening_balance_id, forward_available_balance_id)

    mycursor.execute(insert_to_file, val)
    mydb.commit()
    return mycursor.lastrowid


def insert_transaction_info(file):
    transactions = file['transactions']
    for transaction in transactions:
        detailed_info_id = insert_detailed_info(transaction, 'transaction')
        bank_reference = transaction['bank_reference']
        entry_date = transaction['entry_date']
        extra_details = transaction['extra_details']
        funds_code = transaction['funds_code']
        guessed_entry_date = transaction['guessed_entry_date']
        transaction_id = transaction['id']
        transaction_details = transaction['transaction_details']
        transaction_reference = file['transaction_reference']
        category = 'other'

        insert_to_transaction = "INSERT INTO transaction (bankReference, transactionReference, categoryName, " \
                                "balanceId, entryDate, guessedEntryDate, id, transactionDetails, " \
                                "extraDetails, fundsCode) VALUES (%s, %s, %s, %s, %s, %s, %s, %s, %s, %s)"
        val = (bank_reference, transaction_reference, category, detailed_info_id, entry_date, guessed_entry_date,
               transaction_id, transaction_details, extra_details, funds_code)
        mycursor.execute(insert_to_transaction, val)
        mydb.commit()


@app.route('/api/getTransactions', methods=["GET"])
def retrieve_transactions():
    mycursor.execute("SELECT `bankReference` FROM transaction")
    myresult = mycursor.fetchall()
    return myresult


@app.route('/api/updateCategory', methods=["POST"])
def update_transaction_category():
    bank_reference = request.form['bankReference']
    category = request.form['category']

    update_category = "UPDATE transaction SET categoryName = %s WHERE bankReference = %s"
    val = (category, bank_reference)
    mycursor.execute(update_category, val)
    mydb.commit()

    return "Category updated"

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=122)