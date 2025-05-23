---
title: POST Agents/EMail/GetEMailFromDocumentAttachmentId
uid: v1EMailAgent_GetEMailFromDocumentAttachmentId
generated: true
---

# POST Agents/EMail/GetEMailFromDocumentAttachmentId

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentAttachmentId
```

Get an e-mail based on an email in the archive system and attachment id


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentAttachmentId?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

DocId, AttachmentIds, IncludeAttachments 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocId | Integer |  |
| AttachmentIds | Array |  |
| IncludeAttachments | Boolean |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: EMailEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| To | array | To recipients of e-mail |
| Cc | array | Cc recipients of e-mail |
| Bcc | array | Bcc recipient of e-mail |
| Subject | string | Subject of the e-mail |
| HTMLBody | string | Body formatted in HTML |
| From | EMailAddress | Who did the e-mail originate from |
| Sent | date-time | When was the e-mail sent |
| Size | int32 | Total size of the e-mail |
| Priority | string | Importance of the e-mail |
| Flags | string | Flag status of this mail (unread, replied, deleted ) |
| MessageID | string | Unique id of e-mails |
| PlainBody | string | Body formatted in plain text |
| IsSent | bool | Is this a sent e-mail (not new) |
| EMailSOInfo | EMailSOInfo | Glue between SuperOffice data and an e-mail. |
| ServerId | int32 | Unique id for the e-mail on the server |
| Attachments | array |  |
| CustomHeaderList | array | Non standard e-mail headers |
| FolderName | string | Name of folder the e-mail belongs in |
| EmailItemId | int32 | Primary key |
| AccountId | int32 | Account Id |
| ReceivedAt | date-time | Received date time |
| InReplyTo | EMailEnvelope | The envelope of the email this email is a reply to, if it exists |
| RepliedAt | date-time | When this email was replied at |
| HasCalendarData | bool | If this email contains exactly one iCal appointment |
| CalMethod | string | Method stored in the associated iCal appointment. Indicates if the iCal data is a reply, counter proposal etc. |
| CalReplyStatus | string | Reply status stored in calendar data for the ical method is REPLY |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/EMail/GetEMailFromDocumentAttachmentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocId": 331,
  "AttachmentIds": [
    "odit",
    "animi"
  ],
  "IncludeAttachments": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 494,
      "ContactName": "Brekke-Stehr",
      "PersonId": 905,
      "PersonName": "Quitzon, Dietrich and Pouros",
      "AssociateId": 62,
      "Address": "odit",
      "EmailId": 203,
      "DuplicatePersonIds": [
        768,
        821
      ],
      "Name": "Anderson Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 935
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 127,
      "ContactName": "Ward Inc and Sons",
      "PersonId": 666,
      "PersonName": "Sanford, Witting and Zemlak",
      "AssociateId": 882,
      "Address": "et",
      "EmailId": 624,
      "DuplicatePersonIds": [
        964,
        612
      ],
      "Name": "Rolfson-Kovacek",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 927
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 310,
      "ContactName": "Ernser-Stark",
      "PersonId": 210,
      "PersonName": "Luettgen Inc and Sons",
      "AssociateId": 839,
      "Address": "maiores",
      "EmailId": 504,
      "DuplicatePersonIds": [
        119,
        115
      ],
      "Name": "Heidenreich-Hessel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 21
        }
      }
    }
  ],
  "Subject": "laborum",
  "HTMLBody": "sed",
  "From": null,
  "Sent": "2002-11-25T16:32:39.0551619+01:00",
  "Size": 739,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "praesentium",
  "PlainBody": "libero",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 855,
  "Attachments": [
    {
      "Description": "Up-sized human-resource algorithm",
      "Filename": "dolorem",
      "Size": 928,
      "Type": "eum",
      "Encoding": "libero",
      "Id": "omnis",
      "Disposition": "laboriosam",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 698
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Waelchi, Breitenberg and Altenwerth",
      "Values": [
        "non",
        "deserunt"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 171
        }
      }
    },
    {
      "Name": "Waelchi, Breitenberg and Altenwerth",
      "Values": [
        "non",
        "deserunt"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 171
        }
      }
    }
  ],
  "FolderName": "Wisozk Inc and Sons",
  "EmailItemId": 149,
  "AccountId": 104,
  "ReceivedAt": "2013-07-12T16:32:39.0551619+02:00",
  "InReplyTo": null,
  "RepliedAt": "2018-07-12T16:32:39.0551619+02:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 203
    }
  }
}
```