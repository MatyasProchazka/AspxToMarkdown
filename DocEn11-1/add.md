# New rule
     
Use this form to create a new rule that automatically creates a new linked request when the source request transitions to a certain status.
     
Options:
     
- **Automatically create a request when the source request transfers to status** - or change the status if you want to add the rule to a different process status.
- **Request template**- select the request template to create the new request.
    - [Edit Template](../../../../../../ticket-templates/edit-template) - edit the selected request template.
    - [New template](../../../../../../ticket-templates/new-template) - create a new request template.
- **Link type** - select the type of link to create between the new and source request. For example, if you want to create a child request, select the *Is a child of* type.
- **Request name template** - if applicable, specify a template to build the name of the new request. You can use static text in the template and also variables representing the values of the request items. You can use the same variables in the template as in [message templates](../../../../service/message-template).
    - **Insert variable** - in the request name template, place the cursor where you want to insert the variable, and then select the variable from this menu.
- **Requester**
    - **Source request field** - choose whether the *Requester* or *Solver* of the source request will become the requester of the new request. Request [custom fields](../../../../../custom-items) of type *User*are also available in the drop-down menu.  

                If you choose the *Solver* option and the source request does not have a solver, the *Requester* option will be applied.
    - **Change requester to** - select a specific person to be the requester of the request.
- **Copy item values from source request**- list the source request items whose values will be copied to the new request.
    - [Edit](edit/items-copying) - edit the list of copied items.
- **Condition** - specify the [SQL condition](https://docs.microsoft.com/en-us/sql/t-sql/queries/search-condition-transact-sql?view=sql-server-ver15)that the source request must meet in order for the linked request to be created. You can use the values of all request items in the condition.
    - **Insert variable** - in the condition, place the cursor where you want to insert the variable, and then select the variable from this menu.
    - Examples:
        - tHdTicketCust.BusinessCards = 1 AND tHdTicketCust.WorkPosition != N'Programmer'
        - tHdTicketCust.ComputerType = N'Desktop' OR tHdTicketCust.ComputerType = N'Notebook'
        - tHdTicketCust.WorkHoursPerWeek >= 20
        - tHdTicketCust.Mentor = (SELECT iPersonId FROM tPerson WHERE sPerson=N'John Smith')
