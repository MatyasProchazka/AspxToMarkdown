# Requests
   
On this page you can see [requests](../../alvao-service-desk/requests) in ALVAO Service Desk. It is the default page for members of service resolution teams.
    
Options:
   
- **Command Panel**- The panel displays commands for working with requests, depending on the status and number of requests selected. These commands can also be found in the local menu under the right mouse button. 
    - [New request](requests/new-request) - create a new request, usually based on a call from the requester.
    - [Reply to Requester](requests/request/message) - [send a message](../../alvao-service-desk/requests/send-message)to the Requester of the request. To maintain a single conversation thread with the requester, the message is sent in response to the last message from or to the requester (i.e., the requester is one of the recipients of the message sent or received) within the selected request.
        - [Send a message](requests/request/message) - send a generic email message.
    - [Note](requests/request/note)****- write a new note in the log of the selected request. You can select other event types from the drop-down menu of this command:
        - **Phone Call** - record the contents of a phone call with a requester, supplier, colleague, etc.
        - **Personal Meeting** - minutes of a personal meeting.
        - **Other** - minutes of other means of communication.
    - [Resolve](requests/request/resolve) - [resolve](../../alvao-service-desk/requests/resolve-request) selected requests.
    - [Due date](requests/request/deadline) - change the deadline to resolve selected requests
    - [Approve or reject](requests/request/approve-or-reject) - approve or reject a request. This command is displayed only to the current approvers of the selected request.
    - [Begin approval](requests/request/have-approved) - initiate [approval](../../alvao-service-desk/implementation/services/processes/request-approval) of the selected request. This command only appears in the approval statuses of the selected request.
    - [Edit](requests/request/edit) - edit the items of the selected request.
    - [Transit to status](requests/request/transit-to-state)****- transition the selected request to the next status in the solving process. For other statuses that can be transitioned to, see the drop-down menu for this command.
    - [Assign](requests/request/assign-to-solver)**** - assign the selected requests to a specific solver or to the entire solver group.
    - **Assign to me** - quickly accept selected requests for solution. The command has the same effect as selecting yourself in the *Assign*.
    - [Return to the main solver](requests/request/assign-to-solver) - return selected requests to the service's master solvers.
    - [Move to another service](requests/request/move-to-another-service)****- [move](../../alvao-service-desk/requests/move-to-another-service) selected requests to another service.
    - [New linked request](requests/new-request-relations)****- create a new request that will be [linked](../../alvao-service-desk/requests/relations) to the selected request.
    - [Reopen](requests/request/reopen) - [reopen](../../alvao-service-desk/requests/reopen-for-further-resolution) the resolved request. This command will put the request into the system status *Reopened*.
    - **Tag** - select the color tag you want to use to mark the selected requests from the menu, see Requests - [Tag](requests/table-of-requests) column.
    - **...**
        - **More**
            - [Forward request](requests/request/message)****- forward a detailed log of the selected request via email. The message is compiled in plain text without formatting and all attachments from all log entries are included.
            - [Merge requests](requests/request/merge-request)****- merge selected [duplicate requests](../../alvao-service-desk/requests/duplicate-requests) into one.
            - **Delete** - delete selected requests. Removed requests will go to the *Removed* status, they will not appear in the request list, but will still be stored in the database. You can view them in the list of requests by using the command in the view menu - *View Options* - *Show Removed* and, if necessary, cancel their removal again by using the *Restore Removed* command.

> [!NOTE]
> - [Requests list](requests/table-of-requests) - shows all the requests you have the right to read.

- **Selected Requests** - when you select a request in the list, a panel with that [request](requests/request) will appear on the right or bottom of the page. You can choose the location of the panel in *User menu – Settings –* [View](../../list-of-windows/alvao-webapp/settings/view)*– Requests – Selected request to view*.
