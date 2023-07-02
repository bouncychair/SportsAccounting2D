import json
import jsonschema
from lxml import etree

# JSON Validation
with open(r'JSON\validation.json') as file:
    schema = json.load(file)


def json_schema_validate(json_file):
    try:
        jsonschema.validate(json_file, schema)
        return True
    except jsonschema.exceptions.ValidationError:
        return False


# XML Validation
with open('XML/XMLTest.xml', 'r', encoding='utf-8') as xml_file:
    xml_content = xml_file.read()

with open('XML/XSDSchemav3.xsd', 'r', encoding='utf-8') as xsd_file:
    xsd_content = xsd_file.read()


def xml_schema_validate(xml_file):
    xmlschema = etree.XMLSchema(etree.fromstring(xsd_content))
    parser = etree.XMLParser(schema=xmlschema)

    try:
        etree.fromstring(xml_file.encode(), parser)
        return True, None
    except etree.XMLSyntaxError as e:
        return False, str(e)
