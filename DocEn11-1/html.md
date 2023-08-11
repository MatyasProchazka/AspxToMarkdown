# HTML print report templates
     
A HTML print report template is a document in HTML format. The document contains variables that are replaced by specific data when generating a print report.  Examples of templates can be found in the **AM Console** installation folder in the **Csy/ReportTemplates** folder or in folders for other languages.
      
## Creating a template
     
To create an HTML document, we recommend using any visual HTML editor (e.g. MS Word).
     
Suggest how the report will look like - what will be the title, where will be the table with information about the selected objects, possibly the text of the declaration, etc. Insert the appropriate variables in the places where specific data from Alvao should be inserted, see below.  Upload the created HTML file and, if applicable, the company logo image named "logo.png" to the database using *WebApp - Administration - Asset Management* - [Print Report Templates](../../../../list-of-windows/alvao-webapp/administration/asset-management/print-report-templates).
      
## Print Set Type
     
A print assembly can be one of the following types:

| Print report type | Description |
| --- | --- |
| General | General print report (default type). |
| TransferInnerDifferential | [transfer protocol](../../../documents/transfer-protocols) internal differential. Before the print report is generated, the application displays a form for selecting the transferor and recipient. |
| TransferInnerSummary | [Transfer protocol](../../../documents/transfer-protocols) internal summary. This report can only be generated for an object of type User. Before the print report is generated, the application displays a form for selecting the transferor and the recipient. |

You can specify the report type at the beginning of the HTML document body. For example, for the type *internal difference transfer report*, specify:

    @Model.PrintTemplateType = TransferInnerDifferential

If the report type is not specified in the HTML document, the default *General* type is used.
     
## Variables
     
### General variables

| Variable | Description |
| --- | --- |
| @Model.CompanyLogo | CompanyLogo. When the report is generated, the variable is replaced by an image in a file named "logo.png", which must be stored in the database along with the HTML file of the print report. |
| @Model.CreatedByPerson | Name of the user who generated the print report (logged in user). |

### Transmission logs
     
In print report templates of type *TransferInnerDifferential* and *TransferInnerSummary*, you can use variables that represent the data entered in the "sender and receiver" form:

| Variable | Description |
| --- | --- |
| @Model.DocumentNumber | DocumentNumber |
| @Model.IssueDate | Issue Date |
| @Model.TransferDate | Transfer Date |
| @Model.Text | Text entered on the form |
| @Model.Receiver.Name | Recipient's first and last name |
| @Model.Receiver.PersonalNumber | Recipient's personal number |
| @Model.Receiver.Location | Recipient Location |
| @Model.Receiver.Signature | Receiver's signature [with an electronic pen](../../../../modules/alvao-electronic-handover-forms/sign-with-electronic-pen) in the internal handover protocol. In other ways of signing the protocol, the value of the variable is empty. |
| @Model.Originator.Name | First and last name of the originator |
| @Model.Originator.PersonalNumber | Personal number of the submitter |
| @Model.Originator.Location | Location of the sender |
| @Model.Originator.Signature | Signature of the submitter [with-electronic-pen](../../../../modules/alvao-electronic-handover-forms/sign-with-electronic-pen) in the internal handover protocol. In other ways of signing the protocol, the value of the variable is empty. |

### Objects
     
Information about objects is given in the form of a table in the print reports. In the report template, create a table (< table >) with column headers and one row of data, and include the following variables as needed. In the resulting report, one row is created in the table for each selected object.

| Variable | Description |
| --- | --- |
| @Node.Name | Name of the selected object |
| @Node.Class | Object class |
| @Node.Path | Path in tree |
| @Node[<property name="">]</property> | The value of a specific object property, for example: *@Node[Inventory Number]*. The property name is in [Alvao system language](../../supported-languages). |
| @ResponsibleForNode.Name | The name of the object for which the selected user is further responsible. The *@ResponsibleForNode...* variables are available only in print reports of type *TransferInnerSummary*. |
| @ResponsibleForNode.Class | Object kind |
| @ResponsibleForNode.Path | Path in tree |
| @ResponsibleForNode [<property name="">]</property> | The value of a specific object property, e.g.: *@ResponsibleForNode[Inventory Number]*. |

> [!NOTE]
> - Only objects that have the *Inventory Number* or *Evidence Number* property will be displayed in the table.

- If the table does not contain any data (e.g. the user is not responsible for any other assets), a dash (-) will be shown in the print report instead.
