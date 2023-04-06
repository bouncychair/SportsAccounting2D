schema = {
    "$schema": "http://json-schema.org/draft-04/schema#",
    "type": "object",
    "properties": {
        "_id": {
            "type": "object",
            "properties": {
                "$oid": {
                    "type": "string"
                }
            },
            "required": [
                "$oid"
            ]
        },
        "account_identification": {
            "type": "string"
        },
        "available_balance": {
            "type": "object",
            "properties": {
                "amount": {
                    "type": "object",
                    "properties": {
                        "amount": {
                            "type": "string"
                        },
                        "currency": {
                            "type": "string"
                        }
                    },
                    "required": [
                        "amount",
                        "currency"
                    ]
                },
                "date": {
                    "type": "string"
                },
                "status": {
                    "type": "string"
                }
            },
            "required": [
                "amount",
                "date",
                "status"
            ]
        },
        "final_closing_balance": {
            "type": "object",
            "properties": {
                "amount": {
                    "type": "object",
                    "properties": {
                        "amount": {
                            "type": "string"
                        },
                        "currency": {
                            "type": "string"
                        }
                    },
                    "required": [
                        "amount",
                        "currency"
                    ]
                },
                "date": {
                    "type": "string"
                },
                "status": {
                    "type": "string"
                }
            },
            "required": [
                "amount",
                "date",
                "status"
            ]
        },
        "final_opening_balance": {
            "type": "object",
            "properties": {
                "amount": {
                    "type": "object",
                    "properties": {
                        "amount": {
                            "type": "string"
                        },
                        "currency": {
                            "type": "string"
                        }
                    },
                    "required": [
                        "amount",
                        "currency"
                    ]
                },
                "date": {
                    "type": "string"
                },
                "status": {
                    "type": "string"
                }
            },
            "required": [
                "amount",
                "date",
                "status"
            ]
        },
        "sequence_number": {
            "type": "string"
        },
        "statement_number": {
            "type": "string"
        },
        "transaction_reference": {
            "type": "string"
        },
        "transactions": {
            "type": "array",
            "items": [
                {
                    "type": "object",
                    "properties": {
                        "amount": {
                            "type": "object",
                            "properties": {
                                "amount": {
                                    "type": "string"
                                },
                                "currency": {
                                    "type": "string"
                                }
                            },
                            "required": [
                                "amount",
                                "currency"
                            ]
                        },
                        "bank_reference": {
                            "type": "string"
                        },
                        "currency": {
                            "type": "string"
                        },
                        "customer_reference": {
                            "type": "string"
                        },
                        "date": {
                            "type": "string"
                        },
                        "entry_date": {
                            "type": "string"
                        },
                        "extra_details": {
                            "type": "string"
                        },
                        "funds_code": {
                            "type": "string"
                        },
                        "guessed_entry_date": {
                            "type": "string"
                        },
                        "id": {
                            "type": "string"
                        },
                        "status": {
                            "type": "string"
                        },
                        "transaction_details": {
                            "type": "string"
                        }
                    },
                    "required": [
                        "amount",
                        "bank_reference",
                        "currency",
                        "customer_reference",
                        "date",
                        "entry_date",
                        "extra_details",
                        "funds_code",
                        "guessed_entry_date",
                        "id",
                        "status",
                        "transaction_details"
                    ]
                }
            ]
        }
    },
    "required": [
        "_id",
        "account_identification",
        "available_balance",
        "final_closing_balance",
        "final_opening_balance",
        "sequence_number",
        "statement_number",
        "transaction_reference",
        "transactions"
    ]
}

