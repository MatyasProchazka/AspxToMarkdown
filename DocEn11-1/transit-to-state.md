# Transit to status
 
Use this form to move the selected request to a specific status in the [solving process](../request). The specific content of the form depends on the system settings and some fields may not be displayed in certain situations.
  
Options:

- **Comment for requesters** - write a message for requester that will be sent to them in an email notification of a change in the status of the request.

> [!NOTE]
> This field is only displayed if a status change notification is to be sent to the requester during the status transition and the [Requester Status Change Notification Template](../../administration/service-desk/process/detail/status-request/requester-notification-template) has a variable [$CommentForRequester$] representing a comment to the requester.

- **Attachments**- a list of attachments for the comment for the requester
    - **Add attachment** - select the file to attach as an attachment.
- **Preview of notifications to requester about the change of status** - preview the resulting notification that the applicant will receive.
- **Comments for approvers** - write a message for approver, which will be sent to the approver, among other things, in the email notification. In the case of a multi-step approval scheme, this comment is sent to the current approvers at the beginning of each step. This field is only displayed on the form if the transition to a new status automatically triggers the approval of the request. 

> [!NOTE]
> This block of form only appears if the [Approval message template](../../administration/service-desk/process/detail/status-request/approval-message-template) has variable [$CommentForApprover$] representing the comment for the approver.

- **Attachments**- a list of attachments for the approver comment
    - **Add attachment** - select the file to attach as an attachment.
- **Preview of the message for approvers** - preview the resulting notification to the approvers.
  
- *Mandatory Items* - the following are the items in the request that are **required** for the status that the request transitions to. Mandatory items that already have a value are also displayed on the form for checking and possibly changing values.
- **Cost Report** - if applicable, [show the work time](../../../../alvao-service-desk/requests/work-time) spent resolving the request.

> [!NOTE]
> If the request is currently in the approval process, the status of the request cannot be changed
