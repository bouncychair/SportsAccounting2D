import json
import jsonschema
from lxml import etree
import os

current_directory = os.path.dirname(__file__)
json_file_path = os.path.join(current_directory, 'JSON', 'validation.json')
xml_file_path = os.path.join(current_directory, 'XML', 'XMLTest.xml')
xsd_file_path = os.path.join(current_directory, 'XML', 'XSDSchemav3.xsd')

# JSON Validation
with open(json_file_path, 'r') as file:
    schema = json.load(file)


def json_schema_validate(json_file):
    try:
        jsonschema.validate(json_file, schema)
        return True
    except jsonschema.exceptions.ValidationError:
        return False


# XML Validation
with open(xml_test_file_path, 'r', encoding='utf-8') as xml_file:
    xml_content = xml_file.read()

with open(xsd_file_path, 'r', encoding='utf-8') as xsd_file:
    xsd_content = xsd_file.read()


def xml_schema_validate(xml_file):
    xmlschema = etree.XMLSchema(etree.fromstring(xsd_content))
    parser = etree.XMLParser(schema=xmlschema)

    try:
        etree.fromstring(xml_file.encode(), parser)
        return True, None
    except etree.XMLSyntaxError as e:
        return False, str(e)
