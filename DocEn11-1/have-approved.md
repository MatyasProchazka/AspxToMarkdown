# Begin approval
   
You can use this form to initiate [approval](../../../../alvao-service-desk/requests/request-approval) of selected requests.
   
Options:
    
- **Change request status to** - select the request status from the menu that the request should change to before approval begins. This option only appears if multiple approval statuses can be moved from the current request status.
- **Select approver** - type part of the approver's name and select the person you are looking for from the menu. This will add the selected person to the list of approvers below the field. Select all the approvers you want to forward the request to for approval in this way. You can search for a group of users in the same way - all members of the group will then be added to the list of approvers.  

  If the process settings have [automatic transition](../../administration/service-desk/process/detail/status-request/behavior) to the next status after the approval is complete, this field is not available.
- **Approve with schema** - select from the list [the schema](../../administration/service-desk/approval-scheme) you want to have the request approved by. This option is only available if in the process settings is enabled [automatic transition](../../administration/service-desk/process/detail/status-request/behavior) to the next status after approval is complete.
- **Approve by** - select the person to approve the request from the menu. This option is only available if in the process setting is enabled [automatic transition](../../administration/service-desk/process/detail/status-request/behavior) to the next status after approval is complete.
- **Expires in (hours)** - enter the number of hours after which the approval will expire with the result *Expired*.
- **Message for the approver** - enter more detailed information for the approver, if applicable. The comment will be sent with attachments to the approver(s) in an email notification. In the case of a multi-step approval scheme, this comment is sent to the current approvers at the beginning of each step.
- **Attachments**- list of attachments to the comment for the approver
    - **Add attachment** - select the file to add as an attachment.
- **Preview of the message for approvers** - if applicable, preview the notifications received by the approvers.
