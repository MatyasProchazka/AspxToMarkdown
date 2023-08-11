# Notifications
      
Notifications are messages about a specific event (e.g. resolution, deadline change, etc.) related to a specific request that ALVAO Service Desk automatically sends to recipients.
     
## Other Notifications
      
The signs are divided into two basic groups:
      
- **Notification to solver** - the system automatically sends a message to the solver about the following events. If the request does not have a solver but is assigned to a solver group, then the message is sent to all members of that group. If the request has neither a solver nor a solver group, then the message is sent to all the main solvers of the service.
- **Request created**
- **New message received** - when a message is received for the request.

> [!NOTE]
> If a request is in the approval process, the approvers of the request also receive notification when a new message is received.

> [!NOTE]
> No notification is sent to the recipients of the original message.

> [!NOTE]
> If the message is an undeliverable email sent from the Service Desk or the sender's email is in the [MailerDaemons](../../requests/new-request) list, the notification is not sent.

- **Request Assigned** - notification to the solver to whom the request was assigned and the previous solver of the request (if any).  

> [!NOTE]
> If the request is being assigned by its current solver, no notification is sent to that solver when the request is assigned to another solver.

> [!NOTE]
> In case the solver has taken over the request for solving, the notification of the transfer of the request is not sent.

- **Request reopened** - when the request is reopened (for resolution after it has been closed).
- **Request moved to this service**  

> [!NOTE]
> In case the service change also changes the solver or the solver group, the notification will be sent to the new solver or the members of the solver group (or to the main solvers, if the solver has been removed from the request, for example due to insufficient rights).

> [!NOTE]
> If an existing solver moves a request and the move does not remove the request, no notification is sent to the solver when the request is moved to another service.

- **Request returned to Main solvers**
        -
 Notification to all Main solvers of the service.

          - **Notification to applicant**- the system automatically sends a message to the applicant about the following events.
- **Request created**
- **Request deadline changed** - when the deadline for resolving the request is changed.
- **Request resolved** - notification with a message from the user who resolved the request.
- **Request reopened** - when the request is reopened (to be resolved after it was closed).
         
## Notification levels
     
Notifications can be set at several levels. If notification is enabled or disabled on multiple levels simultaneously, the setting that is highest in the following table is used. If no notification is set at the top level, the setting from the lower level is used:

| User settings for a specific service | Each user can change it in:<br><ul>
                        <li><strong>ALVAO WebApp - User Menu - Settings</strong> -
   <a href="../../../list-of-windows/alvao-webapp/settings/custom-notification-settings">Notifications</a></li>
                    </ul> |
| User settings common to all services | Each user can change it by selecting **&lt;All services&gt;**in:<ul>
                        <li><strong>ALVAO WebApp - User Menu - Settings</strong> -
   <a href="../../../list-of-windows/alvao-webapp/settings/custom-notification-settings">Notifications</a></li>
                    </ul> |
| Service specific settings | This setting is done by the Alvao administrator in
 **ALVAO WebApp - Administration - Service Desk - Services - Edit (properties)**
                    -
 [Notification](../../../list-of-windows/alvao-webapp/administration/service-desk/service/notification). |
| Common settings for all services | This setting is done by the Alvao administrator in
 **ALVAO WebApp - Administration - Service Desk - Settings** -
 [Notifications](../../../list-of-windows/alvao-webapp/administration/service-desk/settings/notification).
 <br><br>| Notification to solver | Default settings |<br>| --- | --- |<br>| Request submitted | Send |<br>| Request created | Send |<br>| Request moved to this service | Do not send |<br>| Request opened | Send |<br>| New message received | Send |<br>| Request returned to main solvers | Send |<br>| Notification to applicant | Default settings |<br>| --- | --- |<br>| Request created | Send |<br>| Request deadline changed | Send |<br>| Request resolved | Send |<br>| Request opened | Send | |
| --- | --- |

## Custom Notifications
      
You can replace the default notification texts with your own notifications. Custom notifications are set for each service in **ALVAO WebApp - Administration - Service Desk - Services - Edit (properties)**- section [Notifications](../../../list-of-windows/alvao-webapp/administration/service-desk/service/notification).

> [!TIP]
> 


        You can also define custom notifications in multiple [languages](../multi-languages).

> [!TIP]
> You can also set up custom notifications in bulk for multiple services at once as follows: v**ALVAO WebApp - Manage** in the service tree, select **Show as table** from the menu, select the services for which you want to set custom notifications from the list, and select **Edit (properties)** from the local menu. In the **Notifications** section, set up custom notifications.

### Notification for members of the research team
      
You can add your own additional text to the subject line of the notifications addressed to members of the research team. The text is added after the original subject line with a hyphen. This modification is global for all services.
      
To add text to the subject, use this SQL script:  
         UPDATE tProperty SET sPropertyValue = 'enter the additional text string here' WHERE sProperty = 'ServiceDesk.OperatorsNotificationsSubject'
      
The following variables can be used in a text string:

| Variable | Description |
| --- | --- |
| [$TicketID$] | Request number. |
| [$TicketDeadline$] | Request resolution deadline |
| [$TicketSLA$] | Request SLA name |
| [$TicketService$] | Service Name |
| [$TicketServicePhone$] | Service Phone Number |
| [$TicketUserCompany$] | Requester's organization |
| [$TicketUserOffice$] | Requester's Requester Office |

To restore the default object, use this SQL script:  
         UPDATE tProperty SET sPropertyValue = NULL WHERE sProperty = 'ServiceDesk.OperatorsNotificationsSubject'
