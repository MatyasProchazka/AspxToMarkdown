# ITicketApprovalAutoAction
     You can define custom actions by implementing the ITicketApprovalAutoAction interface in [application scripts](../../../../list-of-windows/alvao-webapp/administration/applications/app/scripts).       
     Automatic actions are only called for manually triggered approvals with automatic status transition disabled.       
     In the newly created script, set the value of the Name property (the name of the automatic action) in the action class constructor.      

> [!TIP]
> To store properties and action settings, we recommend defining the *Settings* class in a separate script that you create from the *Class Library* template.

> [!CAUTION]
> If you want to use only some of the methods of the implemented interface in the automatic action, leave an exception in the body of the other methods from the interface: throw new NotImplementedException();.

## Interface Methods

| Method | Description |
| --- | --- |
| OnApproved | Approval of the request. |
| OnRejected | Reject request. |
| OnApproverAdded | Adding an approver to the approval. |
| OnApproverCanceled | Cancellation of a specific approver. |

## OnApproved
     Custom action based on request approval.       
     In the implemented method, define both the conditions for executing the operations and the operations themselves.     
- Syntax: **void** OnApproved(SqlConnection **con**, SqlTransaction **trans**, int **ticketId**, int **approvalItemId**)
- Parameters:
    - **con** - SqlConnection to the database.
    - **trans** - SqlTransaction of the ongoing database transaction.
    - **ticketId** - Request ID (tHdTicket.iHdTicketId).
    - **approvalItemId** - approval step ID (tHdTicketApprovalItem.iHdTicketApprovalItemId).
- Return value: **none**.

      For an example use case, see the [OrderAfterApproval](../../../../modules/alvao-am-custom-apps/applications/templates) application template.      
## OnRejected
     Custom action based on the approval of the request rejection.       
In the implemented method, define both the conditions for executing the operations and the operations themselves.
- Syntax: **void** OnRejected(SqlConnection **con**, SqlTransaction **trans**, int **ticketId**, int **approvalItemId**)
- Parameters:
    - **con** - SqlConnection to the database.
    - **trans** - SqlTransaction of the ongoing database transaction.
    - **ticketId** - Request ID (tHdTicket.iHdTicketId).
    - **approvalItemId** - approval step ID (tHdTicketApprovalItem.iHdTicketApprovalItemId).
- Return value: **none**.

## OnApproverAdded
     Custom action based on adding a request approver.       
In the implemented method, define both the conditions for executing the operations and the operations themselves.
- Syntax: **void** OnApproverAdded(SqlConnection **con**, SqlTransaction **trans**, int **ticketId**, IEnumerable&lt;int&gt; **approvalItemIds**)
- Parameters:
    - **con** - SqlConnection to the database.
    - **trans** - SqlTransaction of the ongoing database transaction.
    - **ticketId** - Request ID (tHdTicket.iHdTicketId).
    - **approvalItemIds** - List of approval step IDs (tHdTicketApprovalItem.iHdTicketApprovalItemId).
- Return value: **none**.

## OnApproverCanceled
     Custom action based on the removal of the request approver.       
In the implemented method, define both the conditions for executing the operations and the operations themselves.
- Syntax: **void** OnApproverCanceled(SqlConnection **con,** SqlTransaction **trans**, int **ticketId**, IEnumerable&lt;int&gt; **approvalItemIds**)
- Parameters:
    - **con** - SqlConnection to the database.
    - **trans** - SqlTransaction of the ongoing database transaction.
    - **ticketId** - Request ID (tHdTicket.iHdTicketId).
    - **approvalItemIds** - List of approval step IDs (tHdTicketApprovalItem.iHdTicketApprovalItemId).
- Return value: **none**.
