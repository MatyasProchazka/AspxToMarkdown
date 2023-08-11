# Request
       
On this page you can see one specific [request](../../../alvao-service-desk/requests) in ALVAO Service Desk.
     
Options:
     
- Commands panel - the commands displayed in the commands panel are the same commands displayed on the [Requests](../requests) page.
- Request header
    - Requester portrait with service icon and user presence. The user's presence is displayed next to the requester's and other participants' names.
    - *Request Tag* - a request identifier consisting of a prefix, request number and suffix, e.g. *T123ALVAO*.
    - *Request Name* - the short name of the request
    - **Requester** - the user who submitted the request.
    - **Requested for**- the user for whom the request was created. Only displayed if different from the requester.
    - **Solver**- the member of the resolution team who is currently assigned to solve the request.
    - **Status** - the status of the request, see the *Solving process* tab.
    - **Current target/due date** - the target that the solver is currently supposed to achieve in the request, see [requests table](table-of-requests) - column *Current target*.
- Tabs
    - **Communication**This tab displays the request log, i.e. sent and received email messages, internal notes of the solution team, minutes of phone calls and personal meetings, records of changes in the values of request data items, etc. The name of the tab changes according to the view you can select in the drop-down menu: 
        - **Communications** (default view) - this view displays only records that contain some message or attachment from users. The requester of a request only has this view available and can only see records with the [Show to requester](request/note) option enabled.
        - **Important** - the view only displays events marked as [important or as resolving a request](../../../alvao-service-desk/requests/important-communication).
        - **Requester** - displays only communication involving the requester of the request.
        - **Attachments** - displays all communication containing any attachment.
        - **Detailed log** - view all request log entries.
        - **Expand All** - expand all records displayed on this tab.
        - **Find in log** - a search input box shows up at the top of the tab. Enter at least part of the author’s name, recipient’s name, subject, text, or attachment name, press Enter, and then the found log records appear on the tab.
    - **General**This tab displays the values of the request items, see the columns in the [requests table](table-of-requests).
    - **Solving process**  

                On this tab you see a diagram showing the current status of the request in the context of the entire solving process, i.e. the sequence of request statuses from creation to closure. The solving process is determined by service [process](../../../alvao-service-desk/implementation/services/processes).

                        Tip:
                    Click on a particular status in the diagram to easily invoke the [Transit to status](request/transit-to-state) command.
    - **Links**  

                This tab displays the requests that are [linked to this request](../../../alvao-service-desk/requests/relations) in a table. After the tab name, you can see the number of requests linked.  
In the command bar, you will also find the following commands.
        - [Add link](request/edit-link)
                        - add a new link to another request
        - [Edit link](request/edit-link)
                        - edit selected link
        - **Delete link** - remove selected link

        The table contains the same columns as the [requests table](table-of-requests) and you can also enable the display of nested links in it.

        The tab is only displayed to members of the request service resolution team.
- **Objects**  

                On this tab, you will find the objects from [ALVAO Asset Management](../../../alvao-asset-management) that are linked to this request (see the [Objects](table-of-requests) request entry). The number of linked objects is displayed after the tab name.  
In the command panel you will also find the following commands:
    - [Add object](request/add-object) - bind another object to this request
    - **Remove Object** - remove the link to the selected object
    - [Display in AM Console](../../../alvao-asset-management/searching/list-of-objects) - view linked objects in the [AM Console.](../../../alvao-asset-management/console)
                    You must have the AM Console application installed on your computer to use this command.
- **Approving**  

                On this tab, you can monitor and control the approval of the request. After the tab name, you can see the number of active approval steps. The approval steps and their details are displayed in a table.  
In addition, you can find the following commands in the command panel:
    - **Cancel approval process** - cancel the selected approval step.
