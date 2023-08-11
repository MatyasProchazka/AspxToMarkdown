# ALVAO Satisfaction Feedback
     
This module contains a satisfaction questionnaire for service requesters to complete after or during the resolution of each of their requests.
      
## Technical requirements
     
- ALVAO Service Desk

## Installing and activating the module
      
The module is part of the ALVAO Service Desk installation. The module must be activated with an activation key, which you can obtain from your Alvao system supplier. In the application **.             ALVAO WebApp - Administration - License** select the **Insert Activation Key** and enter the activation key.
      
## Satisfaction Questionnaire

1. In **ALVAO WebApp - Administration - Service Desk**, navigate to the **Services** page.
2. In the service tree, select the service on which you want to enable the questionnaire and use the **Edit - Properties** command.
3. In the [Extended](../list-of-windows/alvao-webapp/administration/service-desk/service/extended), enable the **Use satisfaction survey** option.

This adds an element to the standard notifications to the requester to evaluate overall satisfaction. The questionnaire will also be accessible to requesters throughout the resolution of the request in the ALVAO WebApp in the command menu on the request page.

> [!NOTE]
> The values that the requester fills in the questionnaire are stored as normal request entries.

## Satisfaction Survey Items
     
The standard satisfaction questionnaire contains the following items:

- Total satisfaction
- Speed of resolution
- Responsiveness
- Professionalism

Response options for overall satisfaction:

| Text value | Numeric value |
| --- | --- |
| Satisfied | 1 |
| Dissatisfied | 4 |

Other standard items have the following response options:

| Text value | Numeric value |
| --- | --- |
| Satisfied | 1 |
| Partially satisfied | 2 |
| Satisfied | 3 |
| Satisfied | 4 |

The textual value is displayed in the requirements table. The numerical value is used in the satisfaction analysis.
      
## Create your own questionnaire
      
Copy the *Custom/Templates/Feedback* folder to the *Custom/* folder. You can rename the included *Feedback.cshtml* and *Feedback.cs* files, but name both files (.cshtml and .cs) the same. You can also rename the folder name.

1. In the .cs file, at the beginning of the file after the word *namespace*
            include the namespace naming Alvao.​ServiceDesk.​ServiceDeskWebApp.​Controllers.​&lt;the name of the satisfaction survey folder&gt;.
2. In the .cs file at the beginning of the file at the keyword *class*
            change the name to *&lt;filename&gt;Controller* if you have renamed the file.

> [!CAUTION]
> All form names used must be unique.

Enable anonymous access to the new questionnaire by adding the following section to the web.config file:

    <location path="Custom/<folder name with satisfaction questionnaire>/Feedback"
        <system.web>
            <authorization> 
                <allow users="*> 
            </authorization> 
        </system.web>
    </location>
    <location path="Custom/<folder name with satisfaction questionnaire>/FeedbackAccepted" 
        <system.web> 
            <authorization> 
                <allow users="*"/> 
            </authorization>
        </system.web>
    </location>

The word *Feedback*         replace it with the name of your questionnaire.
      
### Modifying the questionnaire
      
In a custom questionnaire in a .cshtml file (usually *Custom/Feedback/Feedback.cshtml*) find the HTML div tag with id *CustomFormContent*.  
         Here are the *ShowColumns* and *RequiredColumns* lists.

- *ShowColumns* is the list of items that will be displayed.
- *RequiredColumns* specifies the items that must be filled in to submit the form. These columns must also be in the *ShowColumns* attribute.

The limitation of columns that can be displayed is given by the [alvao:ColumnsControl](../modules/alvao-sd-custom-apps/columns-control).
     
You can add new columns and their values in **ALVAO WebApp - Manage -    Custom fields**.
      
Other modifications can be made, similar to creating [custom forms to submit a new request](../modules/alvao-sd-custom-apps/custom-form-template).
      
To store values in custom fields that are not displayed and managed by the ColumnsControl control, use the following structure in the Process(...) method implemented in the .cs file of the custom questionnaire:

    int ticketId = ((ColumnsControl)Model.ColumnsControl0).TicketId;
    var customCols = tHdTicket.Get(ticketId).CustomColumns();
    customCols.Values.Single(cc => cc.Column.sColumn == "feedbackImprovement").Value = Model.NametKeImprovements.Value;
    customCols.SaveTicketChanges();
    customCols.UpdateValues();

After executing this code, the data will be saved to the custom field whose column in the database corresponds to the *feedbackImprovement* value. The value *NametKeImprovement* from the questionnaire model is taken for saving.
      
### Setting the address of your own questionnaire
      
In **ALVAO WebApp - Administration - Service Desk -  Services** - section [Extended](../list-of-windows/alvao-webapp/administration/service-desk/service/extended) - in **Custom Questionnaire (URL)** enter the address of the custom questionnaire, i.e. usually *Custom/Feedback/Feedback*.

> [!NOTE]
> If the address starts with "http" or "https", it is used as is. Otherwise, the path to the root of the ALVAO WebApp is automatically added to the beginning.

## Custom Notifications
      
If you are using custom request resolution notifications, add an element to evaluate overall satisfaction using the [$FeedbackGeneralForm$] variable. Alternatively, prompt for a satisfaction survey by inserting the [$FeedbackURL$] variable.
     
## Satisfaction Analysis
     
You can analyze applicant satisfaction in the MS Excel workbook [Service Desk Analysis](../alvao-service-desk/evaluation-of-system-operation/data-analysis) on the **Satisfaction Questionnaire** worksheet.
