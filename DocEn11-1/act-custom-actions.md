# IActAutoAction
     By implementing the IActAutoAction interface in a [application script](../../../../list-of-windows/alvao-webapp/administration/applications/app/scripts), you can define custom actions when creating an event on a request.       
     In the newly created script, set the value of the Name property (the name of the automatic action) in the constructor of the action class.      

> [!TIP]
> To store properties and action settings, we recommend defining the *Settings* class in a separate script that you create from the *Class Library* template.

> [!CAUTION]
> If you want to use only some of the methods of the implemented interface in the automatic action, leave an exception in the body of the other methods from the interface: throw new NotImplementedException();.

## Interface Methods

| Method | Description |
| --- | --- |
| OnActChanged | Edit Event. |
| OnActCreated | Event creation. |
| OnActRemoved | Delete an event. |

## OnActChanged
     Custom action based on event modification.       
     In the implemented method, define both the conditions for executing the operations and the event operations themselves.     
- Syntax: **void** OnActChanged(SqlConnection **con**, SqlTransaction **trans**, int **actId**, int **personId**, string **properties**)
- Parameters:
    - **con** - SqlConnection to the database.
    - **trans** - SqlTransaction of the database transaction in progress.
    - **actId** - The ID of the event (tAct.iActId) that was changed.
    - **personId** - The ID of the user (tPerson.iPersonId) who changed the event.
    - **properties** - the changed event items separated by a comma (*table.column*).

        | table.column | Event Item |
        | --- | --- |
        | tAct.dAct | Date |
        | tAct.liActKindId | To whom |
        | tAct.sActTo | Date |
        | tAct.sAct | Subject |
        | tAct.mActNotice | Text |
        | tDocument.liDocumentActId | Attachments |
        | tActHd.bActHdUserRead | Show Requester |
        | tAct.bWaitingForUser | Waiting for a requester |
        | tAct.nActWorkHours | Work |
        | tAct.nActTravelHours | Travel time |
        | tAct.nActTravelKm | Distance |
        | tAct.bNoCharge | NoCharge |
- Return value: **none**.

## OnActCreated
     Custom action based on event creation.       
In the implemented method, define both the conditions for executing the operations and the event operations themselves.
- Syntax: **void** OnActCreated(SqlConnection **con**, SqlTransaction **trans**, int **actId**, int **personId**)
- Parameters:
    - **con** - SqlConnection to the database.
    - **trans** - SqlTransaction of the ongoing database transaction.
    - **actId** - ID of the newly created event (tAct.iActId).
    - **personId** - ID of the user (tPerson.iPersonId) who created the event.
- Return value: **none**.

Automatic actions can be performed in the following situations:
- Manual creation of any event with *New Event* or *Note*.
- Sending a message with *Send Message*, *Reply*, etc.
- Read an email from the service mailbox using Alvao Service.
- Manually retrieve a message from Outlook using the *Outlook Add-in - Save to Request Log*.
- Creating a triggering event when a new request is created.
- Calling the *CreateAct* or *CreateTicket* web method to create the founding message.

      You can find an example usage in the [SendMailsAboutNewEvent](../../../../modules/alvao-am-custom-apps/applications/templates) application template.      
## OnActRemoved
     Custom action based on event removal.       
In the implemented method, define both the conditions for executing the operations and the event operations themselves.
- Syntax: **void** OnActRemoved(SqlConnection **con**, SqlTransaction **trans**, int **actId**, int **personId**)
- Parameters:
    - **con** - SqlConnection to the database.
    - **trans** - SqlTransaction of the ongoing database transaction.
    - **actId** - ID of the event being removed (tAct.iActId).
    - **personId** - ID of the user (tPerson.iPersonId) who deleted the event.
- Return value: **none**.
