# Custom form for submitting a new request
     
The system form for submitting a new request to the ALVAO WebApp can be replaced by a custom form with specific content and behavior. The custom form can also accommodate multiple requests at the same time and thus can be used to support complex business processes such as onboarding a new employee.

> [!TIP]
> Instead of custom forms, we recommend using a combination of [standard form](../../list-of-windows/alvao-webapp/administration/service-desk/service/detail/new-ticket-items) for submitting a new service request and [custom javascript on the form for submitting a new request](../../modules/alvao-sd-custom-apps/javascript).

> [!NOTE]
> The custom form can also be a generic ALVAO WebApp page that is not used to create requests. Creating such a page requires advanced programming knowledge.

> [!TIP]
> In a custom form, you can use the [Alvao.API](../../alvao-asset-management/implementation/customization/alvao-api) to handle requests, however, using the API requires advanced programming knowledge.

Templates for creating your own forms can be found in the **\Custom\Templates\**         in the ALVAO WebApp installation folder.
      
List of standard templates:

| Name | Description |
| --- | --- |
| NewTicket | Example of a form for creating multiple requests in conjunction with each other. It also shows how to use some of the controls and how to work with the element to report the time to the request being created. |
| EmptyPage | Blank template. Used for pages that are not intended for making requests. This type of page is only used for special purposes, such as the content of custom tabs on a request. |

The **.cshtml** file defines the appearance of the form, the **.cs** file, located in the **\Code** folder, describes the logic of sending data from the filled form.
       
## Preparing a new form
     
In the **\Custom** folder, first create a folder for the functionality that the new custom form will cover, e.g. *HrProcessAutomation* (for HR process automation). Multiple forms can be placed in a single functionality folder.
     
Then, in the **\Custom\Templates** folder, choose a form template that is as close to your intent as possible. Copy the contents of the template folder to the **Custom&lt;name of functionality&gt;** folder. Rename the .cshtml and .cs files appropriately. Give both files (.cshtml and .cs) the same name. We recommend starting the form name with the name of the functionality, then the name of the service it is for, and finally the operation, e.g. *HrProcessAutomation\_Onboarding\_NewTicket*, where *HrProcessAutomation* is the name of the functionality, *Onboarding*         is the service name, and *NewTicket* is the operation name.

> [!CAUTION]
> The names of all forms used across all functionality must be unique.

Now you also need to modify the inside of the form according to the new name:
     
- In the .cs file, at the beginning of the file after the word **namespace**, include the namespace name *Alvao.ServiceDesk.ServiceDeskWebApp.Custom.&lt;function\_name&gt;*. For the name of the functionality, specify the name of the folder on disk where the form resides, e.g. *Alvao.ServiceDesk.ServiceDeskWebApp.Custom.HrProcessAutomation*.
- In the .cs file, at the beginning of the file for the **class** keyword, change the name of the class. The class name must be *&lt;the name of the cshtml page&gt;Controller*, e.g. in the form *HrProcessAutomation\_Onboarding\_NewTicket.cshtml* the class would be named *HrProcessAutomation\_Onboarding\_NewTicketController*.

## Form layout definition
     
The .cshtml file contains a description of the form layout and specifies the elements to be displayed. When the user submits data, the data entered into the displayed elements is then converted to text, and this text can then be used further in the behavior definition.
     
In the .cshtml file, edit only the part delimited between the line **&lt;div id="CustomFormContent" &gt; and &lt;/div&gt;**, form elements are converted to text only in this part. Elements outside the CustomFormContent will not be converted to the request text, but will be displayed in the form.
      
The following form elements are converted to request text:

| Element name | Conversion method | Rowing |
| --- | --- | --- |
| &lt;label&gt; | The displayed text is inserted into the request text and followed by a colon. | No |
| Editor "StringField" | The text that the user types into the input line is inserted into the request text. If you add the value "UniquedId = Model.TicketBodyGuid" to the element parameter, it will be possible to enter formatted text (HTML).
  <br>
      <br><br>
      <br>Note:<br>
| Editor "BoolField" | The displayed text is inserted into the request text and followed by Yes or No, as selected by the user. | Yes |
| Editor "DateTimeField" | The date specified by the user is inserted into the request text. | Yes |
| Editor "DropDownListField" | The selected item is inserted into the request text. | Yes |
| Editor "RadioButtonList" | The selected item is inserted into the request text. | Yes |
| Editor "CheckBoxList" | All selected items are inserted sequentially into the request text. | Yes |
| Editor "DoubleField" | An integer or decimal number entered by the user is inserted into the request text. | Yes |
| [Editor "ColumnsControl"](columns-control) | All displayed items are inserted sequentially into the request text. It also inserts the values directly into the properties of the based request. | Yes |
| Editor "AttachmentField" | Attachments will be inserted to the request's creation message. | No |
<tfoot>
        </tfoot>
        
Elements not listed in the table are not inserted in the text. Examples of using all elements can be found in the NewTicket template.
     
In the .cshtml file, adding the "btn-command" class to the button ensures that the button is copied as a command to the command bar.

> [!NOTE]
> The format of the number in the DoubleField is checked when the form is submitted, and if it is not correct, it is highlighted in red and *enter the number in the correct format* is displayed.  

        The correct Czech format for writing a decimal number is with a decimal point.

## Form Behavior Definitions
     
The description of the behavior is in the .cs file. In the first part of the code, a comment marks the area that is intended for editing. Do not interfere with other parts of the code!
     
The most important thing here is creating requests. There is already an example of creating a request in the file, which you can use to make your own modifications.
     
The basic structure of the request creation command is as follows:
     **CreateTicket("Service name", "Request name","Custom request text" + TicketBody);**      
Where *TicketBody* is already prepared request text, which was created by converting form content to text. If necessary, text addition can be used in all items as shown. To insert line breaks into the actual text, use the \n tag.

> [!NOTE]
> If the "StringField" element is used on the form, which can be used to enter text in HTML format, use the string "&lt;br&gt;"

The service name must be filled in exactly as the service name appears in Administration. Sub-services are separated by the / character, for example "Internal/Personality/Employee Entry". You must enter the full path from the root service.
      
A version of the request creation command is also available that is extended to create links:
     **CreateTicket("Service name", "Request name","Custom request text" + TicketBody, MainTicketId, TicketRelationType. SystemTicketRelationType.IsChildOf);**      
Where *MainTicketId* is the number of the linked request. An example of getting the ID from the main request is also included in the template. The value          *TicketRelationType.SystemTicketRelationType.IsChildOf* defines the link type:

| Value | Link Type |
| --- | --- |
| RelatesTo | Relates to |
| IsParentOf | IsParentOf |
| IsChildOf | Is a child of |
| PrecedesBefore | Precedes before |
| FollowsAfter | Follows After |
| Blocks | Blocks |
| IsBlockedBy | Is blocked |
| IsDuplicatedBy | Is duplicated |
| Duplicates | Duplicates |

For example, in the case of *TicketRelationType.SystemTicketRelationType.IsChildOf*, the currently created request will be the child and the request with the number passed in the MainTicketId will be the parent.
     
To access the values of custom fields, use the following structure (example for the items "NoveName" and "NoveNumber"):
     **string NoveName =((ColumnsControl)Model.ColumnsControl["ColumnsControl0"]).Values.Find(Col =&gt; Col.Column.sColumn == "NoveJmeno").Value as string;          int NoveCislo =(int)((ColumnsControl)Model.ColumnsControl["ColumnsControl0"]).Values.Find(Col =&gt; Col.Column.sColumn == "NoveCislo").Value;**       
## Connecting the form to the application
     
If you specify a form path in the service settings, this form will be displayed on the ALVAO WebApp instead of the normal form for submitting a new request. See also [Service Desk service settings](../../alvao-service-desk/implementation/services/service-tree).

1. In **WebApp - Administration - Service Desk - Services**, select the service in which you want to display the custom form.
2. In the [New Request Form](../../list-of-windows/alvao-webapp/administration/service-desk/service/detail/new-ticket-items) section of the command panel, switch the mode from System Form Design to *Custom Form (URL)*.
3. Enter the path to the custom form in the form **~/Custom/&lt;name of the functionality&gt;/&lt;name of the form without the .cshtml&gt;** extension.

## Dynamic form language switching
     
When editing .cs and .cshtml files, you can use .resx files that contain localized strings for each language. Each user is then shown these strings read from the file according to their preferred language. If a .resx file is not created for a language, the .resx file for English is used.
     
### Creating a .resx file for a language
     
First, create a .resx file for English. From the **Custom\Templates\Resources**, copy the **SampleController.resx** file to the **Custom&lt;functionality&gt;\Resources** folder and rename it to **&lt;cshtml page name&gt;Controller.resx**.
     
Open this file in a text editor. After the line *"&lt;!-- Insert --!&gt;"*         insert the lines:
     
*&lt;data name="name" xml:space="preserve"&gt;                        &lt;value&gt;name&lt;/value&gt;            &lt;/data&gt;*
     
The result should be as follows:
     
*.&lt;!-- Insert --!&gt;            &lt;data name="name" xml:space="preserve"&gt;            &lt;value&gt;name&lt;/value&gt;            &lt;/data&gt;            &lt;!-- Do not change --!&gt;            &lt;/root&gt;*
     
Lines:
     
*.&lt;data name="name" xml:space="preserve"&gt;            &lt;value&gt;name&lt;/value&gt;            &lt;/data&gt;*
     
can be copied and modified again to create multiple localized strings. Each "&lt;data name="**name**" value must be unique within the file.
     
&lt;data name="**name**" specifies the name used as a parameter in the **GetResources()** function described in **Using a .resx file in .cs and .cshtml files**. The &lt;value&gt;**Name**&lt;/value&gt; specifies the value this function returns.
     
Let's now create a .resx file for the Czech language. Copy the modified **&lt;cshtml page name&gt;Controller.resx**. to the same folder and name it **&lt;cshtml page name&gt;Controller.cs.resx**. Edit the *&lt;value&gt;Name&lt;/value&gt;* so that the following text is in this file:
     
*&lt;!-- Insert --!&gt;            &lt;data name="name" xml:space="preserve"&gt;            &lt;value&gt;name&lt;/value&gt;            &lt;/data&gt;            &lt;!-- Do not change --!&gt;            &lt;/root&gt;*

> [!CAUTION]
> Do not change any other parts of the resx files.

In the same way that the **&lt;cshtml page name&gt;Controller.cs.resx** file is copied and edited, the files for other languages that can be set as the user's preferred languages can be copied and edited. These files are always named **&lt;cshtml page name&gt;Controller.&lt;language abbreviation&gt;.resx** (for example **&lt;cshtml page name&gt;Controller.de.resx**). The language abbreviations that can be used are defined at:
     
[http://msdn.microsoft.com/en-us/goglobal/bb896001](http://msdn.microsoft.com/en-us/goglobal/bb896001)
     
### Using a .resx file in .cs and .cshtml files
     
Some items created in .resx files can be used in both .cs and .cshtml files.
     
In the .cshtml file, use the string **label = "Name"** instead of the string **label = Model.GetResource("name")**. A user who has set English as the preferred language will see the label of the **Name** field. Other users will see **Name**.
     
When used in a .cs file, the same functionality would be achieved by using the **GetResource("name")**, instead of a string.
