from json2xml import json2xml
from json2xml.utils import readfromurl
import xmlschema
from jsonschema import validate
from Draft07Schema import schema

jsonFile = readfromurl("http://127.0.0.1:122/api/getTransactions")

def JSONtoXMLconvert():
    xml = json2xml.Json2xml(jsonFile).to_xml()
    return xml


def XMLSchemaValidate():
    my_schema = xmlschema.XMLSchema('XSDSchema.xsd')
    data = my_schema.is_valid(JSONtoXMLconvert())
    print(data)

def JSONSchemaValidate(json_file):
    valid = validate(instance=json_file, schema=schema)
    return valid
