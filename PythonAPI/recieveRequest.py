import mt940
from bson import json_util, ObjectId
from flask import Flask, jsonify, request, make_response
from pymongo import MongoClient
import json
from connectionString import connection_string

app = Flask(__name__)

# CONNECTING TO THE DATABASE
client = MongoClient(connection_string)
db = client["ProjTest"]
collection = db["MT940Parsed"]


@app.route('/api/test', methods=["GET"])
def test():
    return "Hi"


# IF FILE IS SEND FROM THE C# APP, IT WILL ADD THE FILE TO THE COLLECTION
@app.route('/api/uploadFile', methods=["POST"])
def save_file_to_collection():
    file = request.files['file']
    file = parse_mt940_file(file)
    collection.insert_one(file)
    return "File ADDED successfully"


# GETS ALL THE DOCUMENTS FROM THE COLLECTION
@app.route('/api/getTransactions', methods=["GET"])
def get_transactions():
    return make_response(json.loads(json_util.dumps(collection.find())))


# GETS THE DOCUMENT WITH THE GIVEN ID
@app.route('/api/getTransaction/<transaction_id>', methods=["GET"])
def get_transaction(transaction_id):
    return make_response(json.loads(json_util.dumps(collection.find({"_id": ObjectId(transaction_id)}))))


# GETS THE FINAL BALANCE OF THE DOCUMENT WITH THE GIVEN ID
@app.route('/api/getBalance/<transaction_id>', methods=["GET"])
def get_balance(transaction_id):
    balance = collection.find({"_id": ObjectId(transaction_id)},
                              {"forward_available_balance": {"amount": 1}, "_id": 0})
    balance = json.loads(json_util.dumps(balance))
    return make_response(balance)


# GETS THE DOCUMENT WITH THE GIVEN ID AND THE GIVEN ELEMENT AND POSITION IF THE ELEMENT IS "TRANSACTIONS" ELEMENT CAN
# BE ANY MAIN ELEMENT IN THE DOCUMENT, LIKE "TRANSACTIONS", "FORWARD_AVAILABLE_BALANCE", "SEQUENCE_NUMBER", ETC.
# EXAMPLE:http://127.0.0.1:122/api/searchKeyword?transaction_id=63e3aadd91fbc6374c13ef54&element=forward_available_balance
@app.route('/api/searchKeyword', methods=["GET"])
def search():
    transaction_id = request.args.get('transaction_id')
    element_to_get = request.args.get('element')
    if element_to_get == "transactions" and request.args.get('position') is not None:
        position = int(request.args.get('position'))
        balance = collection.find({"_id": ObjectId(transaction_id)},
                                  {element_to_get: {"$slice": [position, 1]}, "_id": 0})
    else:
        balance = collection.find({"_id": ObjectId(transaction_id)},
                                  {element_to_get: 1, "_id": 0})
    balance = json.loads(json_util.dumps(balance))
    return make_response(balance)


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
