# Extended
 
This section on the [New Service](create-service) form contains additional service settings.
 
Options:
 
- **Show optional items to the requester**  - specify the optional request items that will be displayed on the request page to Requesters without any other user role.

    You can enter one or more comma-separated values, where each value corresponds to one request item:

    | Value | Request item |
    | --- | --- |
    | tHdTicket.RelatedAccountId | Related Organization |
    | tHdTicket.Impact | Fall |
    | tHdTicket.Urgency | Urgency |
    | tHdTicket.Priority | Priority |
    | tHdTicket.sHdTicketDeviceCode | Device number |
    | tHdTicket.Objects | Objects - requesters will see the Objects tab on the request page. |
    | tHdTicket.liHdTicketSlaId | SLA and its description |
    | tHdTicketCust.&lt;db column name of custom field&gt; | [Custom fields](../../../../../alvao-service-desk/implementation/custom-items) |

    On the request page, requesters see only the items enabled in the [process](../../../../../alvao-service-desk/implementation/services/processes) of the service.

> [!NOTE]
> On the [new-ticket-request form](detail/new-ticket-items), you can display items to the requester independently of this setting..

- **Time limit for reopening the request by the requester (days)**
  - Enter the number of days from resolution that the Requester can [reopen the request](../../../../../alvao-service-desk/requests/reopen-for-further-resolution). A value of 0 means that the Requester cannot reopen the resolved request.
- **In the case of attempted reopening after the expiry of the time limit, create a new request** - if this option is disabled and after the deadline to reopen a resolved request has expired, the requester sends a message to the request (e.g., responds to a resolution notification), the system responds by notifying the requester that message has been rejected (message is saved in the request communication and the solver(s) or service operators are notified by a notification, but the request remains resolved). If you enable this option, the system then creates a new request based on the Requester's message and informs the Requester with the usual notification of request creation. A link is automatically created between the new request and the request to which the message was originally directed.
- **In the service** - select the service in which the new request is to be created. The *&lt;This service&gt;* option represents the service being modified. You can also select a service from the tree by clicking [...] after the input field. The requester must have an SLA assigned to the selected service, otherwise the new request will not be created in that service.

> [!TIP]
> After enabling this option, we recommend setting the time limit for reopening a request above to more than 0 days, otherwise a new request will be created each time the requester responds after the request is resolved.

- **Applicants see the requests of other applicants**
 - Enable if you want to allow applicants on this service to also view requests from other applicants from the same organization.
- **Supervisors can see requests from their subordinates**
 - Enable if you want to allow supervisors of applicants on this service to view the requests of their subordinates.
- **Custom Workflow (URL)**- specify the URL of the custom request page to be used instead of the default system request page, if desired.
- **Use satisfaction survey** - enable if you want to use a satisfaction questionnaire. Add a short message to each standard request resolution notification with a link to [this questionnaire](../../../../../modules/alvao-satisfaction-feedback).
- **Custom survey (URL)** - enter the URL [custom satisfaction questionnaire](../../../../../modules/alvao-satisfaction-feedback#special) to use instead of the system questionnaire.   
For example, Custom/&lt;company name&gt;/&lt;questionnaire name&gt;.
