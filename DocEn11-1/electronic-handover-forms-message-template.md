# Message template
 
This window allows you to define the content of messages and notifications sent in connection with signing documents over the web.
 
Options:

- **Subject**- specify the subject of the email.
    - **Insert Variable** - select the variable you want to insert into the subject at the cursor position from the menu (see table below for more details).
- **Message body**- enter the text of the email.
    - **Insert Variable** - select the variable you want to insert into the message text at the cursor position from the menu (see table below for more information).

You can use the following variables in the subject or body of emails. The menu of variables depends on whether the message is a message to the recipient or an alert to the recipient, the forwarding engineer, or the team.

| Variable | Meaning |
| --- | --- |
| [$Date$] | Date the document was issued. |
| [$FromAlertDays$] | The number of days after which the alert is sent to the submitting engineer. |
| [$FromPersonName$] | Name of the transferring technician. |
| [$MyDocumentsURL$] | Link to the ALVAO WebApp page with the user's documents. |
| [$NotConfirmedDocuments$] | Table of users who have not yet signed the document, in the form: <br><br>| **Submission Date** | **User** | **Seller** | **Document** |<br>| --- | --- | --- | --- |<br>| 30.11.2014 | Mirek Vesely | Jan Chalupa | PP01189.pdf |<br>| 2.12.2014 | Veronika Vlídná | Jan Chalupa | PP01190.pdf | |
| --- | --- |
| [$TeamAlertDays$] | The number of days after which a team alert is sent. |
| [$Text$] | Text (document note). |
| [$ToAlertDays$] | The number of days after which the alert is sent to the recipient. |
| [$ToPersonName$] | Recipient's name. |
| [$TransferNumber$] | Document number. |

You can define message texts in multiple [languages](../../../../../modules/alvao-electronic-handover-forms/installation#multilanguage-environment).
