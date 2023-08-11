# Application templates
      
Application templates are ready-made applications that you can use immediately (see *Application installation* below),   or you can customize them and create your own apps with specific functionality.

| Template | Description | Prerequisites |
| --- | --- | --- |
| To the [Object](../../../list-of-windows/alvao-webapp/objects/object) page, adds the **MS Intune** command that opens the MS Intune page representing 
                    the selected object based on the *Intune device id* property. 
                      <br>
                    The template contains the following types of program extensions: [IEntityCommand](../../alvao-sd-custom-apps/applications/custom-commands/ticket-custom-commands) | AM |
| To the [Object](../../../list-of-windows/alvao-webapp/objects/object) page, adds the **Manufacturer support** command that opens the manufacturer’s web page 
                    representing the selected object based on the object properties *Manufacturer*, and *Serial number* (or *BIOS serial number*). Works only for manufacturers 
                    Dell and Lenovo. 
                      <br>
                    The template contains the following types of program extensions: [IEntityCommand](../../alvao-sd-custom-apps/applications/custom-commands/ticket-custom-commands) | AM |
| To the [Object](../../../list-of-windows/alvao-webapp/objects/object) page, adds the **Chat with user** command that starts a Microsoft Teams chat with the 
                    user who is responsible for the object or has been entrusted with its use. 
                      <br>
                    The template contains the following types of program extensions: [IEntityCommand](../../alvao-sd-custom-apps/applications/custom-commands/ticket-custom-commands) | AM |
| To the [Request](../../../list-of-windows/alvao-webapp/requests/request) page, adds the **Create task** command that creates a new task in MS To Do.
                      <br>
                    To view the command, the user must be a member of the of the solution team of the service and be imported from AAD. The *Microsoft Graph Tasks.ReadWrite* permission must be enabled to create a task.
                      <br>
                    The template contains the following types of program extensions: [IEntityCommand](../../alvao-sd-custom-apps/applications/custom-commands/ticket-custom-commands) | SD |
| To the [Request](../../../list-of-windows/alvao-webapp/requests/request) page, adds the **Create meeting** command that creates a new task in MS Outlook calendar.
                      <br>
                    To view the command, the user must be a member of the of the solution team of the service.
                      <br>
                    The template contains the following types of program extensions: [IEntityCommand](../../alvao-sd-custom-apps/applications/custom-commands/ticket-custom-commands) | SD |
| The command will sum the values from the *SW Costs* and *HW Costs* custom fields for the request.
                      <br>
                    To execute the example, it requires adding custom fields *costSW*, *costHW* and *costTotal* of type *int* to the *tHdTicketCust* table.
                      <br>
                    Then with *StateId* and with *ServiceId* specify, where the request should be displayed.
                      <br>
                    The template contains the following types of program extensions: [IEntityCommand](../../alvao-sd-custom-apps/applications/custom-commands/ticket-custom-commands) | SD |
| To the [Request](../../../list-of-windows/alvao-webapp/requests/request) page, adds the **Open attachments** command for opening an attachment 
                    link saved in *Attachments* custom field of the request.
                      <br>
                    To execute the example, it requires adding [custom field](../../../list-of-windows/alvao-webapp/administration/custom-items) named *Attachments* 
                    of type *nvarchar* to the *tHdTicketCust* table.
                      <br>
                    The template contains the following types of program extensions: [IEntityCommand](../../alvao-sd-custom-apps/applications/custom-commands/ticket-custom-commands) | SD |
| Example of a multilingual application. 
                      <br>
                    The template contains the following types of program extensions: [IEntityCommand](../../alvao-sd-custom-apps/applications/custom-commands/ticket-custom-commands) | SD |
| Adds **Report problem** command in the main menu. Using the command, the requester can report a problem via the *Service Catalog*.
                      <br>
                    The template contains the following types of program extensions: [IGeneralCommand](../../alvao-sd-custom-apps/applications/custom-commands/general-custom-commands) | SD |
| When approval of a request gets started, this application automatically adds a member of a particular user group to the Approving tab of the request. 
                    The group member is chosen by the value of the Office field which must be equal to the value of the Office field of the request’s requester.
                      <br>
                    To run the example, a custom field *ApprovalGroupName* of type *nvarchar* is assumed to be added to the *TicketStateCust* table.
                      <br>
                    The template contains the following types of program extensions: [ITicketAutoAction](../../alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/ticket-custom-actions) | SD |
| This app automatically assigns a request to a solver from the Testers group if the request is in the *Program Modifications* service and in a state with ID 1.
                      <br>
                    To run the example, a custom field *solvedInVersion* of type *nvarchar* is assumed to be added to the *tHdTicketCust* table.
                      <br>
                    The template contains the following types of program extensions: [ITicketAutoAction](../../alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/ticket-custom-actions) | SD |
| When a new request is created in the *Program modifications* service, a linked request is also created in the *Program modifications/Designs and analyses* service to create a design for the created request.
                      <br>
                    To run the example, a custom field *createAnalysis* of type *bool* is assumed to be added to the *tHdTicketCust* table.
                      <br>
                    The template contains the following types of program extensions: [ITicketAutoAction](../../alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/ticket-custom-actions) | SD |
| When an event is created in a request in the *Program Modifications* service this event is forwarded by email to each service manager, 
                    unless they are the author or recipient of the event (or their account is disabled). 
                      <br>
                    The template contains the following types of program extensions: [IActAutoAction](../../alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/act-custom-actions) | SD |
| Modifies the notification about a message rejection if the sender does not have any *SLA*.
                      <br>
                    The template contains the following types of program extensions: [IMailMessageAutoAction](../../alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/mail-message-custom-actions) | SD |
| When a message is retrieved, the message text for an existing request is examined for a command to pass to the solver *ASSIGNTO: solver name*. If the command is found 
                    and the solver is found by name, the request is automatically assigned to the solver and the message is not logged in the request log.  Otherwise, the message is processed 
                    in the standard way. 
                      <br>
                    The template contains the following types of program extensions: [IMailMessageAutoAction](../../alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/mail-message-custom-actions) | SD |
| When a request is approved in *Purchase* service by all approvers, the request goes into the *Order* state.
                      <br>
                    The template contains the following types of program extensions: [ITicketApprovalAutoAction](../../alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/ticket-approval-custom-actions) | SD |
| To the [Object](../../../list-of-windows/alvao-webapp/objects/object) page, adds the **Knowledge base** tab displaying knowledge base articles that 
                    contain the manufacturer and model of the object. 
                      <br>
                    The template contains the following types of program extensions: [IEntityTab](../../alvao-sd-custom-apps/applications/ticket-custom-tabs) | AM |
| To the [Request](../../../list-of-windows/alvao-webapp/requests/request) page, adds the **Knowledge base** tab displaying a list of the relevant 
                    knowledge base articles (assigned to the request service) to the members of the solution team of the service.
                      <br>
                    The template contains the following types of program extensions: [IEntityTab](../../alvao-sd-custom-apps/applications/ticket-custom-tabs) | SD |
| If the selected request is in the defined service and status, the [Request](../../../list-of-windows/alvao-webapp/requests/request) page will display
                    the **Show requester's address** tab with the requester's address (by organization) in the map.
                      <br>
                      <br>

                    The example works with classes whose libraries are not part of the default *CodeExtension\_Template.cs* file.
                      <br>
                    These are the WebClientWebClient, XmlDocument and StringBuilder classes.
                      <br>
                    For the correct functionality of the example, the following libraries were added to the beginning of the file: System.Net, System.Xml, System.Text.  <br>

                      <br>
                    The template contains the following types of program extensions: [IEntityTab](../../alvao-sd-custom-apps/applications/ticket-custom-tabs) | SD |
| This app automatically closes a resolved request after the deadline for the requester to reopen the request has passed. 
                      <br>
                    The template contains the following types of program extensions: [IPeriodicAction](../../alvao-sd-custom-apps/applications/periodic-custom-actions) | SD |
| The resolved requests are checked to see if they have passed the time limit for the requester to reopen the request (days) and have the automatic transition to the *Closed* status turned off. If these requests are not closed within 14 days, they are closed automatically. 
                      <br>
                    The template contains the following types of program extensions: [IPeriodicAction](../../alvao-sd-custom-apps/applications/periodic-custom-actions) | SD |
| This app automatically fills a particular user group with all superiors of users from a particular organization. The user group can then be used for instance in a definition of a custom field of the type User. 
                      <br>
                    The template contains the following types of program extensions: [IPeriodicAction](../../alvao-sd-custom-apps/applications/periodic-custom-actions) | SD |
| Objects that do not have all mandatory properties filled in cannot be moved from a *warehouse* to another location in the object tree.
                      <br>
                    The template contains the following types of program extensions: [IObjectMoveAutoAction](../../alvao-am-custom-apps/applications/object-custom-actions-by-object-move) | AM |
| When you move a computer out of a *Warehouse*, the detection profile named *Standard* is automatically assigned to the computer.
                      <br>
                    The template contains the following types of program extensions: [IObjectMoveAutoAction](../../alvao-am-custom-apps/applications/object-custom-actions-by-object-move) | AM |
| This app checks the format of the new *Phone number* object property value.
                      <br>
                    The template contains the following types of program extensions: [IObjectPropertyAutoAction](../../alvao-am-custom-apps/applications/object-custom-actions-by-property-change) | AM |
| This app writes the new value of the *Phone number* property to the *Phone* property of the same object if it is empty. 
                      <br>
                    The template contains the following types of program extensions: [IObjectPropertyAutoAction](../../alvao-am-custom-apps/applications/object-custom-actions-by-property-change) | AM |

## Application installation
      
1. Download the file with the selected template to your computer.
2. In **WebApp - Administration -**[Applications](../../../list-of-windows/alvao-webapp/administration/applications)
            Use the **Import** command to import the downloaded file.
3. Use **Edit -**[Scripts](../../../list-of-windows/alvao-webapp/administration/applications/app/scripts)
            Edit the **Settings** script according to the instructions therein so that the application settings match your Alvao settings.  Save your changes using the **Compile and Save** command.
4. Finally, in **WebApp - Administration -**[Applications](../../../list-of-windows/alvao-webapp/administration/applications)
            Use the **Allow** command to allow the application to run.

> [!NOTE]
> Full backward compatibility of scripts is not guaranteed.  It is possible that when upgrading Alvao to the next version, application scripts may need to be updated with templates for the current version of Alvao.
