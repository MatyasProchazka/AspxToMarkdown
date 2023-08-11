# ColumnsControl elementl
      
The ColumnsControl control displays the input field on the form for entering values directly into the request items.
      
ColumnsControl generates the entire form input field with description. For basic functionality, you need to set the displayed items (e.g. ShowColumns = "tHdTicket.mHdTicketNotice"), or required items (e.g. RequiredColumns="tHdTicket.mHdTicketNotice"). Items are displayed in the order specified from top to bottom.
     
Each ColumnControl element needs to be initialized. In the **.cs** file in the ConfigControls() function, use the following line for each ColumnsControl element used on the form:  
         *((DynamicModel)Model).GetControl*<columnscontrol><em translate="no">&lt;ColumnsControl&gt;(&quot;ColumnsControl0&quot;);<br>
        </em>Use the name of your element instead of <em translate="no">ColumnsControl0</em>.
    </columnscontrol>
     
If you insert this control into the form between &lt;div id="CustomFormContent" and &lt;/div&gt;, the values will be automatically saved when the CreateTicket function is called. The control can be used multiple times on the same page. See below for possible additional settings and an example.

> [!TIP]
> We recommend that you configure *ColumnsControl* using the attributes on the page (**.cshml**). *ColumnsControl* can also be configured in code (**.cs**).

> [!NOTE]
> To keep these items from being added to the request text, you need to place it outside of **&lt;div id="CustomFormContent"** and **&lt;/div&gt;**,but then you need to manually save the filled values by calling the **UpdateColumns(...)** function for each *ColumnsControl*

        and each request created.

> [!NOTE]
> When the page is displayed, the *ColumnsControl* tries to get the *SectionId*

        automatically from the specified web address. If the web address contains the address parameter **iHdSectionId=cislo**, the *"cislo"* is used as the ID of the selected service unless set otherwise. (E.g. *http://www.servicedesk.cz/Custom/ALVAO/NewTicket\_Template/?iHdSectionId=11*
        contains service ID #11. This will automatically be set as *SectionId*.)  

        This functionality can be disabled by setting *SectionId="0"* or by setting a specific service.

> [!NOTE]
> *ColumnsControl* performs a basic rights check:

<!-- Cancelled: <li>If <em translate="no">SectionId</em> or <em translate="no">SectionName</em> is set, the logged in user must have at least one SLA on that service, otherwise the user is redirected to an error page.</li> -->- If *TicketId* is set, the logged-in user needs to be able to view this request, otherwise the user is redirected to an error page.

## Parameter format
     
The following parameter formats are used in attribute and function descriptions:

- **columns**- a list of columns in the format "**table1.column1, table1.column2, ...**". In this way, one or more columns can be defined for the current *ColumnsControl*.  

 **Allowed columns:**

    | table.column | Request item | Notes |
    | --- | --- | --- |
    | tHdTicket.mHdTicketNotice | Notes |  |
    | tHdTicket.sHdTicketGroup | Group | Allows values other than the predefined values. |
    | tHdTicket.sHdTicketDeviceCode | Device number |  |
    | tHdTicket.FeedbackSolveSpeed | Solution Speed |  |
    | tHdTicket.FeedbackProfessionality | Professionalism |  |
    | tHdTicket.FeedbackExpertise | Excellence |  |
    | tHdTicket.FeedbackComment | Comments and Notes |  |
    | tHdTicket.RelatedAccountId | Related Organization |  |
    | tHdTicketCust.\* | custom fields | The individual columns in the tHdTicketCust table that represent custom fields. Instead of an asterisk, specify the name of the specific column. |
- **sectionId** - service id
- **sectionName** - the full name of the service, including the path (e.g. *"Helpdesk/Problems"*)
- **mode** - one of **Edit**(default) and **View**
- **msg** - string containing the text displayed for the unfilled requested item
- **ticketId** - the request number to view/save
.
      
## Attributes in cshtml

- **ShowColumns** = *columns* - columns to be generated per form and stored in db. The columns are displayed in the specified order from top to bottom.
- **RequiredColumns** = *columns* - columns that must be filled to enable saving. These columns must also be in the *ShowColumns* attribute. The order does not matter.
- **SectionId** = *sectionId* - sets the ID and name of the service. This influences the values to select for the code list items (if values are defined for a specific service).
- **SectionName** = *sectionName* - sets the ID and name of the service. This affects the values to select for the codebook items (if values are defined for a specific service).
- **Mode** = *mode* - sets the display mode.
- **TicketId** = *ticketId* - sets the request ID to edit/display/save.
- **CssClass** - css style class.
- **IgnoreColumns** = *columns* - columns that will not be displayed.
- **IncludeServiceColumns** - flag whether to display columns according to the service process specified in the SectionId
- **IncludeRequiredColumns** - flag if required columns should be displayed according to the service process specified in SectionId.

## Functions

> [!NOTE]
> It is not necessary to use these functions for the basic functionality of the *ColumnsControl* element.

- **UpdateColumns()** - stores the filled values in the db in the request whose id is set by the *TicketId* attribute.
- **UpdateColumns(int ticketId)** - stores the filled values in db to request number *ticketId*.

## Example of use
     
Example of displaying the Group (*tHdTicket.sHdTicketGroup*) and Notes (*tHdTicket.mHdTicketNotes*) items. The Group item is mandatory:

- .cshml + autosave (using the *CreateTicket* function call)
 
    .... Your form content....  

         **@Html.EditorFor(m=&gt; m["ColumnsControl0"], "ColumnsControl", new { ShowColumns="tHdTicket.sHdTicketGroup,tHdTicket.mHdTicketNotice",RequiredColumns="tHdTicket.sHdTicketGroup" })**  

         .... Rest of form....

Another example usage can be found at **"~/Custom/Templates/NewTicket\_Template.cshtml"**         and those derived from it.
