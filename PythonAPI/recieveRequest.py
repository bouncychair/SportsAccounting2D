from bson import json_util, ObjectId
from flask import Flask, jsonify, request, make_response
from pymongo import MongoClient
import json

app = Flask(__name__)

# CONNECTING TO THE DATABASE
client = MongoClient("mongodb+srv://adman:qweasd123@projectdb.ud8fb4w.mongodb.net/?retryWrites=true&w=majority")
db = client["ProjTest"]
collection = db["MT940Parsed"]

alternative = {'description': 'salary',
               'amount': 5000}


@app.route('/api/upload', methods=["GET", "POST"])
# IF NO FILE IS UPLOADED, IT WILL ADD THE "ALTERNATIVE" DICTIONARY TO THE COLLECTION. JUST FOR TESTING
def save_file_to_collection():
    if request.method == "GET":
        collection.insert_one(alternative)

    # THE INTENDED WAY: IF FILE IS SEND FROM THE C# APP, IT WILL ADD THE FILE TO THE COLLECTION
    if request.method == "POST":
        file = request.get_json()
        file = json.dumps(file, default=json_util.default)
        file = json.loads(file)
        collection.insert_one(file)
    return "File ADDED successfully"


# GETS ALL THE DOCUMENTS FROM THE COLLECTION
@app.route('/api/getCollection', methods=["GET"])
def get_collection():
    return make_response(json.loads(json_util.dumps(collection.find())))


# GETS THE DOCUMENT WITH THE GIVEN ID
@app.route('/api/getBalance/<transaction_id>', methods=["GET"])
def get_transactions(transaction_id):
    balance = collection.find({"_id": ObjectId(transaction_id)},
                              {"forward_available_balance": {"amount": 1}, "_id": 0})
    balance = json.loads(json_util.dumps(balance))
    return make_response(balance)


# GETS THE DOCUMENT WITH THE GIVEN ID AND THE GIVEN ELEMENT AND POSITION IF THE ELEMENT IS "TRANSACTIONS" ELEMENT CAN
# BE ANY MAIN ELEMENT IN THE DOCUMENT, LIKE "TRANSACTIONS", "FORWARD_AVAILABLE_BALANCE", "SEQUENCE_NUMBER", ETC.
@app.route('/api/searchForSomething', methods=["GET"])
def search():
    transaction_id = request.args.get('transaction_id')
    element_to_get = request.args.get('element')
    if element_to_get == "transactions":
        position = int(request.args.get('position'))
        balance = collection.find({"_id": ObjectId(transaction_id)},
                                  {element_to_get: {"$slice": [position, 1]}, "_id": 0})
    else:
        balance = collection.find({"_id": ObjectId(transaction_id)},
                                  {element_to_get: 1, "_id": 0})
    balance = json.loads(json_util.dumps(balance))
    return make_response(balance)


if __name__ == '__main__':
    app.run(host='0.0.0.0', port=122)
