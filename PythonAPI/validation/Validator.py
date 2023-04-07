import json
import jsonschema
# from validation.Draft07Schema import schema

# def JSONtoXMLconvert():
#     xml = json2xml.Json2xml(jsonFile).to_xml()
#     return xml
#
#
# def XMLSchemaValidate():
#     my_schema = xmlschema.XMLSchema('XSDSchema.xsd')
#     data = my_schema.is_valid(JSONtoXMLconvert())
#     print(data)

with open(r'validation\JSON\validation.json') as file:
    schema = json.load(file)


def json_schema_validate(json_file):
    try:
        jsonschema.validate(json_file, schema)
        return True
    except jsonschema.exceptions.ValidationError:
        return False
