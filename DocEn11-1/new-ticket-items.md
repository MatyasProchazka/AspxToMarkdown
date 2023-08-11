# Request form
     
In this window, you can specify the form of the *New Request Form* that requesters use to submit their requests self-service. This form may look different in each service and may contain different fields. Main solvers who write requester requests also see this form, but it has additional fields for operators compared to requester requests.
     
Options:
     
- **Commands Panel**
    - **Save and Close** - save changes and close the window.
    - **Add Item** - [add](new-ticket-form-add-item) an item or section to the end of the form.
    - **Design Form/Custom Form (URL)** - select whether to design the form by selecting the request items, or use [custom programmed form](../../../../../../modules/alvao-sd-custom-apps/custom-form-template) and enter only its URL.
    - **...**
        - **Default request template** - select [default request template](select-template) to populate the default form field values. This command is only displayed in *Form Design* mode.
        - **Javascript** - specify custom javascript that is added to the form page and can modify its appearance and behavior. This command is only available after activating the [ALVAO Service Desk Custom Apps](../../../../../../modules/alvao-sd-custom-apps).
        - **Process** - displays the [process page](../../process/detail) of the service being edited.
- **Form Design Mode** - in this mode, form items are displayed in the window. You can add additional items to the form by using the *Add Item*command in the command bar or by clicking the button below the last item. Clicking on the item name will expand the item body with additional options. You can change the order of items on the form by dragging them with the mouse.
    - **Requested for** - the item appears on the form only to members of the *Users with permission to create requests for other users* system group. This item cannot be removed from the form or moved to another location.
    - **Request Name**- This item is displayed in the editor even if it is hidden on the form.
        - **Display in the form** - turn this on if you want to show a field on the form for requesters to enter a request name.
        - **Hide on form and build request name by template**- turn on if you do not want the requester to enter the request name on the form, but want the name to be built automatically from the values of other items. Specify a template to automatically build the title according to. You can use static text in the template and also variables representing the values of the request items. The template is applied only to newly created requests. If the template contains variables, the request is not automatically renamed when the value of the request item (variable) is changed.
            - **Insert Variable** - in the request name template, place the cursor where you want to insert the variable, and then select the variable from this menu.
    - **Objects**
        - **Required** - see this option in the *Other Items* block
        - **Insert into request name template** - see this option in the *Other Items* block
        - **Limit field by object kind** - if you want the requester to be able to fill in only objects of certain types in the *Objects* field when submitting a request, specify those allowed types.
    - **Sections** - to make the form clearer, you can group its items into sections and name these sections. Insert a section into the form using the Add Item command and then move it to the place where the block of items should start. The block will include all subsequent items until the end of the form or the beginning of the next section. In the [New Request](../../../../requests/new-request)form, the user can then collapse or expand each section of items as needed.
        - **Edit (pencil icon)** - edit section name.
        - **Remove from form (trashcan icon)**- removal of the section. Section entries are not removed from the form
        - **More options after expanding**
            - **When the form is displayed, section - Collapse/Expand** - select the default section display mode on the [New Request](../../../../requests/new-request) form
    - Additional Items - a list of additional form items.
        - Header items
            - **Form Item (lock icon)** - this icon indicates items that are only on the form for submitting a new request. These items, unlike process-defined items, do not appear on the General tab of the request, and members of the solution team cannot change their values in the request. Like process-defined items, these items are written to the request creation message and can be displayed in the columns of the request table.
            - **Edit (pencil icon)** - [edit](new-ticket-form-edit-item) the selected custom request item.
            - **Remove from form (trashcan icon)** - remove the selected item from the form. Items that are set as mandatory for the *New* status in the [process](../../../../../alvao-webapp/administration/service-desk/process/detail/request-items) of the service cannot be removed from the form.
        - Item body
            - **Mandatory** - turn on if you want to prevent the requester from submitting a request without filling in a value for this item. For items that are set as mandatory for the *New* status in the [process](../../../../../alvao-webapp/administration/service-desk/process/detail/request-items) service, this option cannot be disabled. The *Request Name*, *Request Description*, and *Request Attachments* items cannot be marked as mandatory.
            - **Add to request name template** - a variable representing the value of this item is added to the end of the request name template, see *Request name*.
- **Custom Form Mode (URL)**
    - **Custom Form URL** - alternatively, enter the path to the [form for submitting a new request](../../../../../../modules/alvao-sd-custom-apps/custom-form-template), usually in the form *~/Custom/&lt;extension name&gt;/&lt;form name without the .cshtml&gt;*.

The *New Request* form displays all mandatory items for the *New* status in addition to the selected optional items, according to the [process settings](../../../../../alvao-webapp/administration/service-desk/process/detail/request-items).

> [!NOTE]
> Service - Edit - [Extended](../extended) section - the *Show Requester Optional Items* option does not specify the items displayed on the *New Request* form.
