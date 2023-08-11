# ITicketAutoAction
     By implementing the ITicketAutoAction interface in a [application script](../../../../list-of-windows/alvao-webapp/administration/applications/app/scripts), you can define custom actions based on a change in the value of a request item or respond to a newly created request.       
     In the newly created script, set the value of the Name property (the name of the automatic action) in the action class constructor.      

> [!TIP]
> To store properties and action settings, we recommend defining the *Settings* class in a separate script that you create from the *Class Library* template.

> [!CAUTION]
> If you want to use only some of the methods of the implemented interface in the automatic action, leave an exception in the body of the other methods from the interface: throw new NotImplementedException();.

## Interface Methods

| Method | Description |
| --- | --- |
| OnTicketChanged | Change the request item. |
| OnTicketCreated | Create a request. |

## OnTicketChanged
     Custom action based on a change in the value of a request item (custom/system).       
     In the implemented method, define both the conditions for performing the operations and the operations themselves.     
- Syntax: **void** OnTicketChanged(SqlConnection **con**, SqlTransaction **trans**, int **ticketId**, int **personId**, string **properties**)
- Parameters:
    - **con** - SqlConnection to the database.
    - **trans** - SqlTransaction of the database transaction in progress.
    - **ticketId** - The ID of the request (tHdTicket.iHdTicketId) to which the custom action applies.
    - **personId** - The ID of the user (tPerson.iPersonId) who executed the event on the request. In some cases it could be the system, then the value is NULL.
    - **properties** - the changed request items separated by a comma (*table.column*).

        | table.column | Request item |
        | --- | --- |
        | tHdTicket.TicketStateId | Status |
        | tHdTicket.liHdTicketSlaId | SLA |
        | tHdTicket.dHdTicketDeadline | Deadline |
        | tHdTicket.liHdTicketHdSectionId | Service |
        | tHdTicket.iHdTicketUser | Requester |
        | tHdTicket.liHdTicketSolverPersonId | Solver |
        | tHdTicket.SolverGroupRoleId | Solver group |
        | tHdTicket.sHdTicket | Request name |
        | tHdTicket.liHdTicketPriorityId | Priority |
        | tHdTicket.Impact | Impact |
        | tHdTicket.Urgency | Urgency |
        | tHdTicket.mHdTicketNotice | Notes |
        | tHdTicket.sHdTicketGroup | Group |
        | tHdTicket.sHdTicketDeviceCode | Device number |
        | tHdTicket.FeedbackSolveSpeed | Solve speed |
        | tHdTicket.FeedbackProfessionality | Professionality |
        | tHdTicket.FeedbackExpertise | Expertise |
        | tHdTicket.FeedbackComment | Comments and Notes |
        | tHdTicket.RelatedAccountId | Related organization |
        | tHdTicket.Objects | Objects |
        | tHdTicket.RequestedForPersonId | Requested for |
        | tHdTicketCust.\* | Custom fields |
- Return value: **none**.

      For an example use case, see the [AssignToTester](../../../../modules/alvao-am-custom-apps/applications/templates) application template.      
## OnTicketCreated
     Custom action based on the creation of a request.       
In the implemented method, define both the conditions for executing the operations and the operations with the request itself.
- Syntax: **void** OnTicketCreated(SqlConnection **con**, SqlTransaction **trans**, int **ticketId**, int **personId**)
- Parameters:
    - **con** - SqlConnection to the database.
    - **trans** - SqlTransaction of the ongoing database transaction.
    - **ticketId** - New request ID (tHdTicket.iHdTicketId).
    - **personId** - ID of the user (tPerson.iPersonId) who created the request (does not always have to be the requester).
- Return value: **none**.

      For an example use case, see the [CreateAnalysis](../../../../modules/alvao-am-custom-apps/applications/templates) application template.
