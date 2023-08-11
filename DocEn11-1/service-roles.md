# User roles in requests and services
 
User roles in services are set in **WebApp - Administration - Service Desk - Services - Edit -**[Permissions](../../../list-of-windows/alvao-webapp/administration/service-desk/service/detail/authorization).

| Permissions | Main solver | Solver | Solving group member | Exceptional solver | Manager | Reader | Requests reporter | Approver | Requester/Request participant |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| Display all requests in the service | ● | ● | ● |  | ● | ● |  |  |  |
| Creating a new request in a service |  |  |  |  |  |  |  |  |  |
| - For myself |  |  |  |  |  |  |  |  | ● |
| - Recording the request on behalf of the requester | ● | ● | ● |  |  |  | ● |  |  |
| Notifications |  |  |  |  |  |  |  |  |  |
| - About new requests in the service | ● |  |  |  |  |  |  |  |  |
| - About the requests without a solver and a solver group | ● |  |  |  |  |  |  |  |  |
| - About assigning the request to the solver group |  |  | ● |  |  |  |  |  |  |
| - About the requests in a given solver group, but without a specific solver |  |  | ● |  |  |  |  |  |  |
| - About the requests passed to a given user for resolution | ● | ● | ● | ● |  |  |  |  |  |
| Receive request for resolution | ● | ● | ● |  |  |  |  |  |  |
| Assign the request to another solver for resolution | ● | ● | ● | ● | ● |  |  |  |  |
| Requests Resolution |  |  |  |  |  |  |  |  |  |
| - Without solver and solver group | ● | ● | ● |  | ● |  |  |  |  |
| - Without solver but passed to the solver group | ● | ● | ● |  | ● |  |  |  |  |
| - Assigned to a given user for resolution | ● | ● | ● | ● |  |  |  |  |  |
| - Passed on to another solver | ● | ● | ● |  | ● |  |  |  |  |
| Approval or rejection of the request |  |  |  |  |  |  |  | ● |  |
| Request log |  |  |  |  |  |  |  |  |  |
| - Show all records | ● | ● | ● | ● | ● | ● |  | ● |  |
| - Display records for requesters | ● | ● | ● | ● | ● | ● |  | ● | ● |
| - Creating a record | ● | ● | ● | ● | ● | ● |  | ● | partly |
| Knowledge base in service |  |  |  |  |  |  |  |  |  |
| - Knowledge display for requesters | ● | ● | ● | ● | ● | ● |  |  | ● |
| - Knowledge display for solvers | ● | ● | ● | ● | ● | ● |  |  |  |
| - [Knowledge Management](../../../list-of-windows/alvao-webapp/knowledge-base/manage) | ● | ● | ● | ● | ● |  |  |  |  |
| Current messages in service |  |  |  |  |  |  |  |  |  |
| - Display messages for requesters | ● | ● | ● | ● | ● |  |  |  | ● |
| - View messages for solvers | ● | ● | ● | ● | ● |  |  |  |  |
| - [Message Management](../../../list-of-windows/alvao-webapp/news/manage) | ● | ● | ● | ● | ● |  |  |  |  |
| [Request Templates](../../../alvao-service-desk/requests/ticket-templates) in the service |  |  |  |  |  |  |  |  |  |
| - Use of templates | ● | ● | ● |  | ● |  |  |  |  |
| - [Template Management](../../../list-of-windows/alvao-webapp/ticket-templates) | ● | ● | ● |  | ● |  |  |  |  |

##### Main solver
  
The main solver handles new requests that do not yet have a solver and passes them on to other solvers as appropriate.
  
Each service should have at least one main solver. The only exceptions are services marked as [folders](../../../list-of-windows/alvao-webapp/administration/service-desk/service/create-service), in which new requests cannot be created.

> [!NOTE]
> The system itself periodically checks that all requesters in all services have an assigned main solver. If deficiencies are detected, an email alert is sent to the Alvao system  administrators (*Administrator* role) once a day. You can check service settings immediately after making changes in *WebApp Administration - Settings -*[Configuration check](../../../list-of-windows/alvao-webapp/administration/settings/settings-check).

Each main solver can select a representative to represent them in their absence in *User menu - Settings -* [Absence](../../../list-of-windows/alvao-webapp/settings/out-of-office).
   
##### Solver
  
The role of the service solver is to resolve requests that are passed to it by the main solver.
  
If a service has only one solver, new requests created or moved to that service are automatically passed to that solver for resolution.
 
##### Solving group member
  
A solver group is a group of solvers that functions as an autonomous team. The main solver (or other solver) can assign a request to the entire group for resolution, which then determines which member of the group will address the request. There can be multiple resolution groups in one service.
 
##### Exceptional solver
  
An exceptional solver only sees requests that another solver has assign for solution. He cannot see other requests in the service. Nor can they see requests that they have solved in the past but then passed on to another solver.
 
##### Service manager
  
The Service Manager oversees the resolution of requests.
  
If the manager resolves a request without a solver, it automatically becomes the solver. Otherwise, however, manager cannot take over any request for resolution and no one can pass it on.
 
##### Service team
  
The service team consists of main solvers, solvers, solver groups members and service managers.
  
Team members can only search for people who are from the same organisation as them, from the same solution team or are requesters of the service. When searching for organisations, they only see their organisation. They do not see the actual entries of people or their organisations.
  
A service team can be split into [several teams](../../../alvao-service-desk/implementation/services/service-roles/multiple-teams-for-service) according to group of requesters. Each applicant group is then served by a different resolution team.
 
##### Service reader
  
See all requests in a given service, but cannot resolve them.
  
Service reader can search for the same people and organizations as if were a member of the service team.

> [!TIP]
> To make only a specific request available to users, set the users as [Trackers](../../../alvao-service-desk/requests/subscribers) of that request.  

##### Requests reporter
  
A requests reporter is usually a member of the solver team of another service, and can move requests that do not belong in their service into the service in which they are a reporter, or create them directly for the requester. Once a request has been moved or created, the reporter can no longer view the request.
 
##### Request approver
  
The request approver is the user who currently has to approve or deny the request. A request can have multiple approvers at the same time. Any user can become an approver, as a request can be assigned to anyone for approval.
  
An approver can only see the requests they currently have to approve.
 
##### Service requester
  
A service requester is a user who has at least one SLA assigned to the service (see WebApp - Administration - Service Desk - Service - Edit - [SLA](../../../list-of-windows/alvao-webapp/administration/service-desk/service/detail/sla)).
  
The requesters only sees the requests they have assign. In the table of requests, they can only view [selected columns](../../../list-of-windows/alvao-webapp/requests/table-of-requests).
  
On the [request page](../../../list-of-windows/alvao-webapp/requests/request), it does not see the items:
   
- Priority
- Notes
- Work
- Internal Target
- Custom person and organisation entries for Applicant and Solver
- Details of the investigator if the investigator is from an organisation other than the applicant
- Custom entries Related organisations
- Details of the Related Organisation if the applicant is not from that organisation

Also sees additional request items enabled, see WebApp - Administration - Service Desk - Services - Service - Edit - [Extended](../../../list-of-windows/alvao-webapp/administration/service-desk/service/extended) - Show Requester optional items.
  
Only see records in the request log that have the *Show to requester* option enabled.
  
Has limited commands available for working with requests.
  
A requester (or request participant) can reopen their request if the [reopen deadline](../../../list-of-windows/alvao-webapp/administration/service-desk/service/extended) (set on the request service) has not expired.
  
Can only search for people in your organization. It does not see custom entries of people or organizations in the search results.
  
A request can have other co-requesters, which gives them the same permissions to the request as the requester. Any requester of a service can be a co-requester of a request.
 
##### Other users
  
Users who are not assigned a role in a service do not see any requests in that service, even if they are members of the [Administrators](../../../alvao-asset-management/implementation/users/groups) group or other [system groups](../../../alvao-service-desk/implementation/users/groups).
  
## Common permission settings in services

1. **Main solvers only** - the service has only main solvers who take over new requests to solve themselves. This model is usually suitable for smaller teams of peer solvers.
2. **Main solvers and solvers** - main solvers take on new requests to solve or pass them on to other solvers. Other solvers only handle requests that are passed to them by a lead solver and do not actively queue new requests.  This model is suitable for larger teams whose members are divided into several lines. Thus, the main solvers are in the first line (L1) and the other solvers are in the second or next line (L2, L3, etc.).
3. **Main solvers, solvers and solver groups** - compared to the previous model, there are additionally one or more solver groups in the service. Main solvers can then assign requests to autonomous solver groups, whose members determine which member will solve the request.  The solver groups usually represent autonomous teams from other departments or external organizations (outsourced services), usually in the higher L2, L3, etc.
