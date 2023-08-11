# Requests list
   
The list of requests is displayed in the ALVAO WebApp on the [Requests](../requests) page and also on some other pages.
    
If you want to customize the sorting or filtering of requests in the current view, use the **Table** command to switch the list view to a table, [customize the table as needed](../../../alvao-asset-management/working-with-tables), and then switch the view back using the **Table** command.   Commands to switch the view mode are also available in the view menu - **Display options - Show Table/Tables**. In **Settings** - [View](../settings/view)   you will find additional options for setting the appearance of both the tile list and the table.
    
In *Table* mode, unlike the default *Tiles* mode, you can select multiple requests at once and perform bulk operations on them.
    
## Number of unread requests in view
   
Use the command in the current view menu - **Display options - Show the number of unread requests** with the view name after it to display the number of unread requests in the view, even if the view is not currently active. This makes it easy to see on the page that a new request or message has been added to the view without having to refresh the page or switch views.
    
## Requests archive
   
Resolved and closed requests are automatically moved to the archive 6 months after resolution. By default, archived requests are not displayed in the request table. You can view them using the command in the view menu - **Display options - Display archive**. If a closed request is reopened, it is automatically moved from the archive back to the active requests.
    
## Request Links
   
If you are using linkss between requests, in *Table* mode, use the command in the current view menu - **Display options - Display links** to enable browsing [links](../../../alvao-service-desk/requests/relations) directly in the table. In the *RequestName* column, this will display arrows to expand the linkss for requests that have other requests linked to them. Then, in the view, to better navigate between the linked requests, we recommend that you also display the Link type column. You can use the **Hide links** command to turn off the display of linked requests in the table.
    
## Table columns
   
You can view the columns below in the requests table.
   
Regular applicants (i.e., applicants who are not members of a service's project team) have, for simplicity, only a limited range of columns available, see the value *Yes* in the *Available to Regular Applicants* column in the table below.

| Column name | Description | Available to regular applicants |
| --- | --- | --- |
| Current target | The goal that the solver is currently expected to achieve in a given request, i.e., first response, request resolution, or other internal goal. For first response and resolution, the current goal and its deadline is [set automatically according to the selected SLA](../../../alvao-service-desk/implementation/services/operating-hours). | No |
| Current target (due date) | Deadline of [response, resolution](../../../alvao-service-desk/requests/deadline), or [internal target](../../../alvao-service-desk/requests/internal-target), i.e. the target specified in the *current-target* column. | No |
| Current target (remaining hours) | Time until the current target expires. Data is calculated in [operating hours](../../../alvao-service-desk/implementation/services/operating-hours)
  and can be supplemented with icons.  <br>
  ![Less than 8 hours left until deadline](../../../alvao-service-desk/requests/hdtlCloseToDeadline.png)
  Less than 8 hours left until the current target date.  <br>
  ![The deadline for the current goal is exceeded](../../../alvao-service-desk/requests/hdtlAfterDeadline.png)
  The deadline of the current target is exceeded.  <br>
  ![The request has a suspended SLA](../../../alvao-service-desk/requests/hdtlSlaPaused.png)
  The request has a suspended SLA. | No |
| Overall satisfaction | Feedback from the applicant - overall satisfaction with the solution | No |
| Time traveled (hours) | Sum of all the "time en route" items that have been reported for the request. | No |
| Waiting for email | E-mail to the recipient of the last email from which we are waiting for a response. | No |
| Waiting for requester (hours) | If Waiting for Requester is enabled - that is, the solution cannot currently proceed without a response from the Requester - the number of hours waited is listed in the field. The field is blank if waiting for the applicant is disabled. | No |
| Waiting for applicant (hours) | Total time in hours (including the current wait) for the Requester within the request. | No |
| Request number | The unique request number assigned to the request when it was created. | Yes |
| Device Number | The device number is the unique number that was assigned to the device when it was created in Asset Management. If you are using Service Desk in combination with Asset Management, you can include the device number to which the request applies in the request. | No |
| Read | Shows "Yes" if the logged-in user is only a reader of the service and not a member of its resolution team. | No |
| Time open (hours) | The total time the request has been open, i.e. from the time the request was submitted until the request is resolved or until the present time if the request is open. If the request has been reopened, the value in this column includes the time when the request was temporarily resolved. | No |
| Open time without waiting for the requester (hours) | The total number of hours the request was open, i.e. from the time the request was made until it was resolved (or up to the present), EXCEPT the time during which the Requester was pending (during which time resolution could not proceed). | No |
| Opening time without SLA pause (hours) | Opening time without SLA pause (hours) The total number of hours the request has been open, i.e. from the time the request was submitted to the time it was resolved (or up to the present), NOT including the time during which the SLA was suspended. | No |
| Impact | [Fall](../../../alvao-service-desk/implementation/services/impact-urgency) (un)resolved request | No |
| Icons | Icons illustrating the current status of the request:  <br>    ![Resolved request](../../../alvao-service-desk/requests/hdtlResolved.png)   Resolved request  <br>   ![Request removed](../../../alvao-service-desk/requests/removed.png)   Deleted request  <br>   ![Request has no solver](../../../alvao-service-desk/requests/hdtlNew.png)   The request has no solver.  <br>   ![Request has no resolution date set](../../../alvao-service-desk/requests/hdtlNoDeadline.png)   Request has no resolution date set.  <br>   ![Request has SLA suspended](../../../alvao-service-desk/requests/hdtlSlaPaused.png)   The request has a suspended SLA.  <br>   ![Request has approval in progress](../../../alvao-service-desk/requests/hdtlApproval.png)   Approval is in progress on the request.<br>
  Sort requests by this column:  <br>
  <ol>
  <li>request does not have a resolution date and does not have a solver</li>
  <li>request has a deadline for resolution and no resolution</li>
  <li>request has no deadline for resolution and has a solver</li>
  <li>request has a deadline for resolution and has a solver</li>
  <li>request is resolved</li>
  <li>request is closed</li>
  </ol>
  In the case of equal ranking, the secondary ranking is based on the amount of time the current goal deadline was exceeded, respectively, / by the time to the current goal deadline. | Yes |
| Internal target | The name of the internal goal in the request solution set by a member of the solution team. | No |
| Internal target (due date) | Deadline for internal target | No |
| To be resolved | A value of "Yes" ("1") means that you are currently responsible for resolving the request, i.e. you are the solver of the request, or you are a member of the resolution group to which the request has been assigned, or the request does not have a solver and you are the main solver of the request service (or the main solver of the service for the Requester).
  Otherwise, the column is set to "No" ("0"). | Yes |
| For approval | If the request is in [approval](../../../alvao-service-desk/requests/request-approval) and the logged-in user is one of the approvers, this entry is set to "1" ("Yes"). | Yes |
| Comments and notes | Feedback from the applicant - additional comments and notes on the resolution of the request. | No |
| The deadline for reopening a request by the requester is by (date) | Time by which the requester may reopen the request if not satisfied with the resolution of the request. The deadline for reopening is calculated from the resolution of the request and can be set in **ALVAO WebApp - Administration - Service Desk - Services - Edit Service - Properties** - **Advanced** section. | No |
| My Request | Displays "Yes" if you are the requester or co-requester of the request. | Yes |
| Urgency | [Urgency](../../../alvao-service-desk/implementation/services/impact-urgency) of request resolution | No |
| Request name | The current name of the request. | Yes |
| Highest service | The root service that is superior to the service in which the request is based. Root services are displayed on the home page of the [Service Catalog](../../../itil/service-catalog-management). | Yes |
| Objects | Name of the first object from ALVAO Asset Management that is linked to the request, see Request - [Objects](request) tab. | Yes |
| Expertise | Feedback from the applicant - evaluation of the expertise of the research team. | No |
| Deleted | Date of removal for removed requests.  <br>
  To view deleted requests in the **View** menu
  turn on Deleted Items. | No |
| Organization | [Organization](../../../alvao-service-desk/implementation/users/companies) associated with the request (can be the Requester organization or a manually set organization). | Yes |
| Number of open child requests | The number of open subrequests of the request. The specific requests can be found on the links tab of the request. For details, see [Request links](../../../alvao-service-desk/requests/relations). | Yes |
| Number of child requests | The number of child requests of the given request. See item above for more details. | Yes |
| Number of links | The number of requests for which a given request has any [links](../../../alvao-service-desk/requests/relations) entered. | Yes |
| Request Description | Description of the request as provided in the request creation message. | Yes |
| Order of request solving | The order in which the request will be resolved. The order of request solving is maintained for each solver separately. | No |
| Last activity (date) | Date and time of the last entry (activity) in the request log. | No |
| SLA Suspension (hours) | The number of hours of SLA suspension currently in progress due to waiting for a requester or request status. | No |
| SLA paused (hours) | Total time in hours that the SLA has been suspended for the request (including the SLA suspension currently in progress) |. No |
| Notes | Request Notes | Yes |
| Requested for | Name and surname of the user for whom the request was created. | Yes |
| Work (hours) | Total all the work reported for resolving the request. | No |
| Priority | Priority of addressing the request for the internal needs of the solution team.  <br>
  Meaning of displayed icons:  <br>
  ![Critical](../../../alvao-service-desk/requests/Priority5.png)
  Critical  <br>
  ![High](../../../alvao-service-desk/requests/Priority4.png)
  High  <br>
  (no icon) Medium  <br>
  ![Low](../../../alvao-service-desk/requests/Priority2.png)
  Low  <br>
  ![Scheduling](../../../alvao-service-desk/requests/Priority1.png)
  Scheduling  <br>
    <br>
  The priority can be set by the solution team members themselves, or it can be determined by the values of the [impact and urgency](../../../alvao-service-desk/implementation/services/impact-urgency) items. | Yes |
| Process |The [Process](../../../alvao-service-desk/implementation/services/processes) that is set on the service that handles the request. | Yes |
| Professionalism | Requester feedback - an evaluation of the professionalism of the request resolution. | No |
| Read | Contains a value of *Yes* if you have read the request, i.e. there are no new messages or other events in the request on the *Communications* tab that you have not yet read. A value of *No* means that you have not read the request.  <br>These values are only displayed in requests whose unreadness you are monitoring, see *WebApp - User Menu - Settings -*[Display](../../../list-of-windows/alvao-webapp/settings)*- Requests - In the request lists, highlight unread requests*.   In other requests, this column has a blank value. | Yes |
| Received | If the request was created from an email sent to the service mailbox, the date of receipt into the system is displayed. | No |
| Resolution speed | Feedback from applicant - satisfaction with resolution speed | No |
| Solver | Current solver of the request | Yes |
| Solver (e-mail) | E-mail address of the request solver | No |
| Solver (office) | solver's office | No |
| Solver (mobile) | Request handler's mobile phone number | No |
| Solver (department) | Request handler's department | No |
| Solver (work phone) | Solver's work telephone number | No |
| Solver group | Current resolution group to which the request is assigned for resolution. | Yes |
| Group | An item that allows further sorting of requests into groups, allowing easier filtering and statistical evaluation of requests. | No |
| SLA | [Service Level Agreement](../../../alvao-service-desk/implementation/services/sla) according to which a given request is addressed. | No |
| Request following | Shows Yes if the logged-in user is [following a request](../../../alvao-service-desk/requests/subscribers). | Yes |
| Service | [Service](../../../alvao-service-desk/implementation/services) within which the request is currently being addressed. | Yes |
| Related Organization | [Organization](../../../alvao-service-desk/implementation/users/companies) to which the request relates. Usually this is the requesting organization, but it can also be another organization, e.g.  in the case of an internal request for proactive remote control of the operation of a system at a specific customer, this is the customer, while the Requester of the request is an internal employee (e.g. a member of the service solution team). | Yes |
| Request participants | The first and last name of the [co-applicant](../../../alvao-service-desk/implementation/services/service-roles) of the request. If there are multiple co-users, the text "(multiple co-users)" is displayed. You can edit the co-users on the [Request](../../../list-of-windows/alvao-webapp/requests/request) - General tab. | Yes |
| Status | Status according to the request resolution procedure. The solving process is defined by the [process](../../../alvao-service-desk/implementation/services/processes) of the service. | Yes |
| Tag | The color of the tag with which you have marked this request, see the [Request](request) - Tag command. You can only label a request with one color. The selected tag is only displayed to you. Other users may have the same request tagged with a different color tag. | Yes |
| Link type | This column contains values only in the table on the [Request page](request) - *Links* tab, and in other request tables only when request links is enabled.  <br>
    <br>
  For example, on the request page 1 on the *Links* tab:<br><br>| Link type | Request Number | Request Name |<br>| --- | --- | --- |<br>| Precedes before | 2 | request 2 |<br><br>
  This row in the table means that request 1 [precedes](../../../alvao-service-desk/requests/relations) request 2.  <br>
  On the [requests](../requests) page, with links displayed, it will look like this:  <br>
  <br><br>| Link type | Request Number | Request Name |<br>| --- | --- | --- |<br>|  | 1 | in request 1 |<br>| Precedes before | 2 | &gt; Request 2 | | No |
| --- | --- | --- |
| Due date | A set [deadline for resolving](../../../alvao-service-desk/requests/deadline) the request | Yes |
| Warning | Warning of a problem with a request, e.g. an upcoming SLA request resolution deadline, see SLA - [Notification Rule](../administration/service-desk/sla/detail/notice-notice) | No |
| Closed | Date [closed](../../../alvao-service-desk/requests/close-request) request | Yes |
| Solved | Date of [resolved](../../../alvao-service-desk/requests/resolve-request) request | Yes |
| Created | Date of [request origination](../../../alvao-service-desk/requests/new-request) (i.e. the request was entered into the system) | Yes |
| Distance (km) | Sum of all kilometres that have been driven as part of the request resolution. | No |
| Alert severity | Alert severity for the request issue, see *Alert column*. | No |
| Request submission method | The way the request was created, i.e. the type of request creation event. <br>
  <br><br>
  <br>Tip:<br>
| Requester | Name and surname of the user who submitted the request.  <br>
  <br><br>
  <br>Note:<br>
| Applicant (e-mail) | E-mail of the Requester | Yes |
| Requester (e-mail 2) | Second Requester email | Yes |
| Requester (position) | Function held by the requester | Yes |
| Requester (other contact) | Other contact for the requester, if any | Yes |
| Requester (office) | Designation of the office of the requester | Yes |
| Requester (mobile) | Requester's mobile phone number | Yes |
| Requester (department) | Department where the requester works | Yes |
| Requester (organisation) | Organisation of the requester | Yes |
| Requester (work phone) | Employment phone to the Requester of the request | Yes |
| Requester (work phone 2) | Second work phone per claimant request | Yes |
| *request items, requester, solver, SLA, service, and related organization* | Additional columns representing [custom fields](../../../alvao-service-desk/implementation/custom-items) of the request, person, SLA, service, or organization. | No |
