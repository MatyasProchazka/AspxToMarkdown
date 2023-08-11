# IMailMessageAutoAction
     By implementing the IMailMessageAutoAction interface in the [application script](../../../../list-of-windows/alvao-webapp/administration/applications/app/scripts) you can define custom actions when retrieving a message from the service mailbox before saving the message to the log of an existing request or before creating a new request. In the newly created script, set the value of the Name property (the name of the automatic action) in the action class constructor.      

> [!TIP]
> To store properties and action settings, we recommend defining the *Settings* class in a separate script that you create from the *Class Library* template.

## Interface Methods

| Method | Description |
| --- | --- |
| OnMessageReceived | Read a new message from the service mailbox. |

## OnMessageReceived
     The actual action can be performed when retrieving a message from the service mailbox before saving the message to the log of an existing request or before creating a new request. In the implemented method, define both the conditions for executing the operations and the operations themselves.     

> [!NOTE]
> If the message is not further processed after automatic actions, a warning is written to the event log.

> [!CAUTION]
> If more than one of these automatic actions is implemented, they are called sequentially until one of them returns false,and the order in which they are called is not guaranteed.

- Syntax: **bool** OnMessageReceived(SqlConnection **con**, SqlTransaction **trans**, MailMessage **message**, int **sectionId**, int **ticketId**, int **fromPersonId**)
- Parameters:
    - **con** - SqlConnection to the database.
    - **trans** - SqlTransaction of the ongoing database transaction.
    - **message** - message object.
    - **sectionId** - the service ID (tHdSection.iSectionId) in which the message was retrieved.
    - **ticketId** - ID of the request (tHdTicket.iHdTicketId) to which the message belongs according to the subject, or zero if it is a new request creation.
    - **fromPersonId** - message sender ID (tPerson.iPersonId),
 or *Host* account, if the message sender is not found among the users.
- Return value:
    - **bool** - return the return value true or false
                    indicating whether or not the message should continue to be processed by default.

      For an example use case, see the [AssignToSolverByEmail](../../../../modules/alvao-am-custom-apps/applications/templates) application template.
