from bson import json_util
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
        return "File GOT successfully"

    # THE INTENDED WAY: IF FILE IS SEND FROM C# APP, IT WILL ADD THE FILE TO THE COLLECTION
    if request.method == "POST":
        file = request.get_json()
        file = json.dumps(file, default=json_util.default)
        file = json.loads(file)
        collection.insert_one(file)
        return "File POSTED successfully"


if __name__ == '__main__':
    app.run(host='0.0.0.0', port=122)
