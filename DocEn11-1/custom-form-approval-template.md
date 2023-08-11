# Custom Request Approval Form
     
Templates for creating custom forms can be found in the **\Custom\Templates\Approval** in the ALVAO WebApp installation folder.
       
## Preparing a new form
     
Copy the sample form - **Approval** folder to the **Approval** folder         **Custom\&lt;functionality name&gt;**. Rename both the .cshtml and .cs files contained in the folder so that the name matches the meaning or functionality of the form.

> [!NOTE]
> A general description for setting up custom forms is described in the instructions for [Custom form for submitting a new request](custom-form-template).

## Form behaviour definition
      The description of the behavior is in the **.cs** file. In the code, comments indicate areas that are intended for modification. Do not interfere with other parts of the code! The most important thing here is request approval. In the file there is already an example of approval and rejection of a request, according to which you can make your own modifications.  
     The basic structure of the request approval/rejection commands is as follows:  
     
**TicketApprovalAccept(iHdTicketId, "Request approved:&lt;br&gt;"+MessageBody);**  
         **TicketApprovalReject(iHdTicketId, "Request denied:&lt;br&gt;"+MessageBody);**
     
Where **MessageBody** is the already prepared request approval/denial text that was created by converting the form content to text. If necessary, text concatenation can be used in all items as shown in the example. To insert line breaks into the actual text, use the &lt;br&gt; tag.

> [!NOTE]
> If the "StringField" element is not used on the form,which can be used to enter text in HTML format, use the string \n for line breaks.  

        To access the values of custom fields, use the following structure (example for items "NewName" and "NewNumber"):  

        **string newName = ((ColumnsControl)Model.ColumnsControl["ColumnsControl0"]).Values.Find(Col =&gt; Col.Column.sColumn == "NewName").Value as string;              int newNumber = (int)((ColumnsControl)Model.ColumnsControl["ColumnsControl0"]).Values.Find(Col =&gt; Col.Column.sColumn == "NewNumber").Value;**

> [!NOTE]
> If you want to approve the current step, prematurely terminate approval with it, and skip any subsequent steps in the running approval scheme, use the following structure:  

        **TicketApprovalAcceptAndFinish(iHdTicketId, "Request Approved:&lt;br&gt;"+ MessageBody);**  

## Connecting the form to the application
     
In ALVAO WebApp - Administration - Service Desk -             [Approval Schemes](../../list-of-windows/alvao-webapp/administration/service-desk/approval-scheme) select the schema you want to edit. Use the *Edit* command in the *Approval Steps* block to open a window to edit the approval step. In the **Custom Form (URL)** entry enter the URL of the created form (in the same format as used in the Service -   Edit - New Ticket Submission Form - Form Design - [Custom form (URL)](../../list-of-windows/alvao-webapp/administration/service-desk/service/detail/new-ticket-items)).
