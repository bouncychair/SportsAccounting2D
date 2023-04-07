schema = {
    "$schema": "http://json-schema.org/draft-04/schema#",
    "type": "object",
    "properties": {
        "_id": {
            "type": "object",
            "minLength": 0,
            "maxLength": 11,
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
            "type": "string",
            "minLength": 1,
            "maxLength": 37
        },
        "available_balance": {
            "type": "object",
            "minLength": 0,
            "maxLength": 11,
            "properties": {
                "amount": {
                    "type": "object",
                    "minLength": 0,
                    "properties": {
                        "amount": {
                            "type": "string"
                        },
                        "currency": {
                            "type": "string",
                            "minLength": 3,
                            "maxLength": 3,
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
                    "type": "string",
                    "minLength": 1,
                    "maxLength": 1,

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
            "minLength": 0,
            "maxLength": 11,
            "properties": {
                "amount": {
                    "type": "object",
                    "properties": {
                        "amount": {
                            "type": "string",
                        },
                        "currency": {
                            "type": "string",
                                    "minLength": 3,
                                    "maxLength": 3,
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
                    "type": "string",
                    "minLength": 1,
                    "maxLength": 1,
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
            "minLength": 0,
            "maxLength": 11,
            "properties": {
                "amount": {
                    "type": "object",
                    "properties": {
                        "amount": {
                            "type": "string"
                        },
                        "currency": {
                            "type": "string",
                            "minLength": 3,
                            "maxLength": 3,
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
                    "type": "string",
                    "minLength": 1,
                    "maxLength": 1,
                }
            },
            "required": [
                "amount",
                "date",
                "status"
            ]
        },
        "sequence_number": {
            "type": "string",
            "minLength": 0,
            "maxLength": 255,
        },
        "statement_number": {
            "type": "string",
            "minLength": 1,
            "maxLength": 255,
        },
        "transaction_reference": {
            "type": "string",
            "minLength": 1,
            "maxLength": 255,
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
                                    "type": "string",
                                    "minLength": 3,
                                    "maxLength": 3,
                                }
                            },
                            "required": [
                                "amount",
                                "currency"
                            ]
                        },
                        "bank_reference": {
                            "type": "string",
                            "minLength": 0,
                            "maxLength": 20,
                        },
                        "currency": {
                            "type": "string",
                            "minLength": 3,
                            "maxLength": 3,
                        },
                        "customer_reference": {
                            "type": "string",
                        },
                        "date": {
                            "type": "string"
                        },
                        "entry_date": {
                            "type": "string"
                        },
                        "extra_details": {
                            "type": "string",
                            "minLength": 0,
                            "maxLength": 255,
                        },
                        "funds_code": {
                            "type": "string"
                        },
                        "guessed_entry_date": {
                            "type": "string"
                        },
                        "id": {
                            "type": "string",
                            "minLength": 1,
                            "maxLength": 4,
                        },
                        "status": {
                            "type": "string",
                            "minLength": 0,
                            "maxLength": 1,
                        },
                        "transaction_details": {
                            "type": "string",
                            "minLength": 1,
                            "maxLength": 255,
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

