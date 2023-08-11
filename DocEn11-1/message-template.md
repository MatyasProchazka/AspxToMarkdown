# Message template
     
In this window, define a template for a custom [notifications](../../../../../alvao-service-desk/implementation/services/notifications).
     
Options:
     
- **Subject**- enter the subject of the message.
    - **Insert variable** - use the drop-down menu to select the variable you want to insert into the subject of the message at the current cursor position.

> [!TIP]
> At the beginning of the subject, use the *Insert Variable* button to insert a pair of variables *Request - Tag* and *Request - Name*, which will be replaced by the tag and name of the specific requirement in the message.

- **Message body**
            - enter the text of the message. You can use variables in the text, see the *Insert Variable* button below the input field.  
The message text is formatted according to the same style used by standard system notifications. If you want to display any text in the message in bold, insert it between the "&lt;b&gt;" and "&lt;/b&gt;" tags.
  Other HTML tags are not supported.
    - **Insert variable** - use the drop-down menu to select the variable you want to insert into the message text at the current cursor position.

You can use the following variables in the subject or body of the message:

| Name | Variable | Description | Custom Notification Template | [Template of notifications to requester about the change of status](../process/detail/status-request/requester-notification-template) | [Approval message template](../process/detail/status-request/approval-message-template) |
| --- | --- | --- | --- | --- | --- |
| Subject | Message body |
| --- | --- |
| Message for applicants | [$MessageForRequester$] | The message to the requester that the solver fills in the field when the request is resolved, rescheduled, or reopened. This variable cannot be used in [notifications](../../../../../alvao-service-desk/implementation/services/notifications) of type *Request created*.
    <br>
                        In the message template for the approver, this is the message to the requester that the solver wrote when resolving the request, including images and attachments. This variable can only be used for approvals in the Resolved status. | No | Yes | No | Yes |
| Comments for applicants | [$CommentForRequester$] | Comment from the researcher to the requester. In place of this tag, the comment that the researcher provided in the *Go to status* form will be added. If the researcher does not provide any comment, the variable will contain a dash. In the template, we recommend that this variable be indicated by a line such as "&lt;b&gt;Message to the requester:&lt;/b&gt;", or "&lt;b&gt;Message from the investigator:&lt;/b&gt;". | No | No | Yes | No |
| Approval result | [$ApprovalResultWithComment$] | The result of the last approval including the approver's comment. If there was no approval in the request, the variable contains a dash. You can use the variable in the [status change notification to the requester](../process/detail/status-request/requester-notification-template) and in the request resolution notification. | No | No | Yes | No |
| Approval - Commentary for approvers | [$CommentForApprover$] | In place of this tag, the comment that the user filled in when starting the approval in the *Go to status* or *Let Approval* form will be added. | No | No | No | Yes |
| Approval - Approve/Deny buttons (form) | [$ApprovalByForm$] | Approve or reject *Button* to open the form to approve or reject the request. This button will only be inserted in the notification to the approver. If used concurrently with the [$ApprovalByEmail$] variable, the name of the button will be *Approve or Reject on Web*. | No | No | No | Yes |
| Approval - Approve/Deny buttons (e-mail) | [$ApprovalByEmail$] | Approve and Reject *buttons* for email approval. When the approver presses one of them, a window opens with a pre-populated new message, after which Alvao approves and rejects the request respectively. When used simultaneously with the [$ApprovalByForm$] variable, the button names will be *Approve by Email* and *Decline by Email*.  <br>
                        <br>
                            <br><br>
                            <br>Caution:<br>
| Approvals - Approvers of the current step | [$ApprovalStepCurrentApprovers$] | List of current approvers including email addresses in the form "Name &lt;email address&gt;&quot. Individual approvers are separated by semicolons. | No | No | No | Yes |
| Approval - Expiration of current step | [$ApprovalStepExpirationTime$] | Expiration time of the current approval step. | No | No | No | Yes |
| Request - Number | [$TicketID$] | Request Number. | Yes | Yes | Yes | Yes |
| Request - Brand | [$TicketMessageTag$] | Request tag in emails, e.g. "T45412HD". | Yes | Yes | Yes | Yes |
| Request - Name | [$TicketTitle$] | Request name. | Yes | Yes | Yes | Yes |
| Request - First Response Time | [$FirstReactionDeadline$] | First response deadline as per [SLA](../../../../../alvao-service-desk/implementation/services/sla). | Yes | Yes | Yes | Yes |
| Request - Resolution Date | [$TicketDeadline$] | The deadline set to resolve the request. | Yes | Yes | Yes | Yes |
| Request - Foundation Report - Subject | [$OriginalMessageSubject$] | The subject of the original message that triggered the creation of the new request. | No | Yes | Yes | Yes |
| Request - Foundational Message - Text | [$OriginalMessage$] | The text of the original message that triggered the creation of the new request. | No | Yes | Yes | Yes |
| Request - Foundation Report - Annexes | [$OriginalMessageAttachments$] | The attachments of the original message that triggered the creation of the new request. If you want the notification to include these attachments, insert this variable in the message text in any location.
                          <br>
                        This variable can only be used for custom notifications to the solver. | No | Yes | No | No |
| Request - Inception Report - List of Annex Titles | [$OriginalMessageAttachmentList$] | List of attachment names of the original message that triggered the creation of the new request, including the names of the images in the message text. | No | Yes | Yes | Yes |
| Request - Latest important event | [$LatestImportantMessage$] | Text of the latest [important event](../../../../../alvao-service-desk/requests/important-communication) in the request log, including images and attachments. | No | Yes | Yes | Yes |
| Request - Link to request | [$TicketUrl$] | Request URL in [ALVAO WebApp](../../../../../alvao-service-desk/webApp). | No | Yes | Yes | Yes |
| Request - Link to request with tag | [$TicketMessageTagLink$] | Request tag as a link to the request page in the [ALVAO WebApp](../../../../../alvao-service-desk/webApp). | No | Yes | Yes | Yes |
| Request - Basic Information Table | [$TicketInfo$] | Request Basic Information Table. | No | Yes | Yes | Yes |
| Request - Satisfaction Survey (URL) | [$FeedbackUrl$] | Link to the satisfaction questionnaire. This variable is part of the module [ALVAO Satisfaction Feedback](../../../../../modules/alvao-satisfaction-feedback). | No | Yes | Yes | Yes |
| Request - Satisfaction Questionnaire | [$FeedbackGeneralForm$] | A graphical element that the requester can use directly in the notification to rate their overall satisfaction with the resolution of the request.  You can only use this variable in notifications sent to requesters. This variable is part of the module [ALVAO Satisfaction Feedback](../../../../../modules/alvao-satisfaction-feedback). | No | Yes | Yes | Yes |
| Request - Items - System | - | Request System Items. Only items that are assigned to the process of the service being modified are listed in the variable drop-down menu. | Yes | Yes | Yes | Yes |
| Request - Items - Custom | [$tHdTicketCust.*ColumnName*$] | Custom request item, where *ColumnName* represents the name of the corresponding column in the *tHdTicketCust* table. Only items that are assigned to the process of the service being modified or are displayed on the new request form are listed in the variable drop-down menu. | Yes | Yes | Yes | Yes |
| Applicant - Name | [$TicketRequesterName$] | Requester's first and last name. | Yes | Yes | Yes | Yes |
| Applicant - Mobil | [$TicketRequesterMobile$] | Requester's Mobile. | Yes | Yes | Yes | Yes |
| Applicant - E-mail | [$TicketRequesterEmail$] | Requester's e-mail address. | Yes | Yes | Yes | Yes |
| Applicant - E-mail 2 | [$TicketRequesterEmail2$] | Requester's second email. | Yes | Yes | Yes | Yes |
| Applicant - Telephone number | [$TicketRequesterPhoneToWork$] | The applicant's phone to work. | Yes | Yes | Yes | Yes |
| Applicant - Telephone number 2 | [$TicketRequesterPhoneToWork2$] | Requester's second phone to work. | Yes | Yes | Yes | Yes |
| Applicant - Other contacts | [$TicketRequesterOtherContacts$] | Other contacts of the requester. | Yes | Yes | Yes | Yes |
| Applicant - Department | [$TicketRequesterDepartment$] | Requester's Department. | Yes | Yes | Yes | Yes |
| Requester - Function | [$TicketRequesterPosition$] | Requester function. | Yes | Yes | Yes | Yes |
| Applicant - Office | [$TicketRequesterOffice$] | Requester's Office. | Yes | Yes | Yes | Yes |
| Applicant - Name of supervisor | [$TicketRequesterManagerName$] | The name of the Requester's immediate supervisor. | Yes | Yes | Yes | Yes |
| Applicant - Personal number | [$TicketRequesterPersonalNumber$] | Applicant's personal number. | Yes | Yes | Yes | Yes |
| Applicant - Organisation - Name | [$TicketRequesterAccountName$] | Name of the applicant organization. | Yes | Yes | Yes | Yes |
| Applicant - Organisation - Organisation's own items | [$TicketRequesterAccount.  <br>
                        tAccountCust.*ColumnName* $] | The requester's custom organization entry, where *ColumnName* represents the name of the corresponding column in the *tAccountCust* table. | Yes | Yes | Yes | Yes |
| Applicant - Other - Person's custom fields | [$TicketRequester.tPersonCust.*ColumnName* $] | The requester's custom field, where *ColumnName* represents the name of the corresponding column in the *tPersonCust* table. | Yes | Yes | Yes | Yes |
| Required for - Name | [$TicketRequestedForName$] | The first and last name of the user for whom the request is made. | Yes | Yes | Yes | Yes |
| Required for - Mobil | [$TicketRequestedForMobile$] | Mobile of the user for whom the request is made. | Yes | Yes | Yes | Yes |
| Required for - E-mail | [$TicketRequestedForEmail$] | Email of the user for whom the request is made. | Yes | Yes | Yes | Yes |
| Required for - E-mail 2 | [$TicketRequestedForEmail2$] | The second email of the user for whom the request is made. | Yes | Yes | Yes | Yes |
| Required for - Telephone to work | [$TicketRequestedForPhoneToWork$] | The phone to work of the user for whom the request is made. | Yes | Yes | Yes | Yes |
| Required for - Telephone to work 2 | [$TicketRequestedForPhoneToWork2$] | The second phone to work of the user for whom the request is made. | Yes | Yes | Yes | Yes |
| Required for - Other contacts | [$TicketRequestedForOtherContacts$] | Other contacts of the user for whom the request is made. | Yes | Yes | Yes | Yes |
| Required for - Department | [$TicketRequestedForDepartment$] | The department of the user for whom the request is made. | Yes | Yes | Yes | Yes |
| Required for - Functions | [$TicketRequestedForPosition$] | Function of the user for whom the request is made. | Yes | Yes | Yes | Yes |
| Required for - Office | [$TicketRequestedForOffice$] | The office of the user for whom the request is made. | Yes | Yes | Yes | Yes |
| Required for - Name of supervisor | [$TicketRequestedForManagerName$] | The name of the direct supervisor of the user for whom the request is made. | Yes | Yes | Yes | Yes |
| Required for - Personal number | [$TicketRequestedForPersonalNumber$] | The personal number of the user for whom the request is being made. | Yes | Yes | Yes | Yes |
| Required for - Organisation - Name | [$TicketRequestedForAccountName$] | The organization name of the user for whom the request is made. | Yes | Yes | Yes | Yes |
| Required for - Organisation - Organisation's own items | [$TicketRequestedForAccount.  <br>
                        tAccountCust.*ColumnName* $] | The custom organization entry of the user for whom the request is created, where *ColumnName* represents the name of the corresponding column in the *tAccountCust* table. | Yes | Yes | Yes | Yes |
| Required for - Other - Person's own items | [$TicketRequestedFor.  <br>
                        tPersonCust.*ColumnName* $] | The custom field of the user for whom the request is made, where *ColumnName* represents the name of the corresponding column in the *tPersonCust* table. | Yes | Yes | Yes | Yes |
| Solver - Name | [$TicketSolverName$] | Solver's first and last name. | Yes | Yes | Yes | Yes |
| Solver - Mobile | [$TicketSolverMobile$] | Solver's Mobile. | Yes | Yes | Yes | Yes |
| Solver - E-mail | [$TicketSolverEmail$] | E-mail of the solver. | Yes | Yes | Yes | Yes |
| Solver - E-mail 2 | [$TicketSolverEmail2$] | Solver's second email. | Yes | Yes | Yes | Yes |
| Solver - Telephone to work | [$TicketSolverPhoneToWork$] | Solver's phone to work. | Yes | Yes | Yes | Yes |
| Solver - Telephone to work 2 | [$TicketSolverPhoneToWork2$] | Solver's second phone to work. | Yes | Yes | Yes | Yes |
| Solver - Other contacts | [$TicketSolverOtherContacts$] | Other contacts of the solver. | Yes | Yes | Yes | Yes |
| Director - Department | [$TicketSolverDepartment$] | Solver's Department. | Yes | Yes | Yes | Yes |
| Solver - Functions | [$TicketSolverPosition$] | Solver function. | Yes | Yes | Yes | Yes |
| Solver - Office | [$TicketSolverOffice$] | Solver's Office. | Yes | Yes | Yes | Yes |
| Solver - Name of supervisor | [$TicketSolverManagerName$] | Name of the solver's direct supervisor. | Yes | Yes | Yes | Yes |
| Solver - Personal number | [$TicketSolverPersonalNumber$] | Solver's personal number. | Yes | Yes | Yes | Yes |
| Solver - Organisation - Name | [$TicketSolverAccountName$] | Name of the solver's organization. | Yes | Yes | Yes | Yes |
| Solver - Organisation - Organisation's own items | [$TicketSolverAccount.  <br>
                        tAccountCust.*ColumnName* $] | The solver's custom organization entry, where *ColumnName* represents the name of the corresponding column in the *tAccountCust* table. | Yes | Yes | Yes | Yes |
| Solver - Other - Person's own items | [$TicketSolver.tPersonCust.*ColumnName* $] | Solver's custom field, where *ColumnName* represents the name of the corresponding column in the *tPersonCust* table. | Yes | Yes | Yes | Yes |
| Service Name | [$TicketService$] | Name of the [service](../../../../../alvao-service-desk/implementation/services) including the path in the service tree. | Yes | Yes | Yes | Yes |
| Service - Telephone | [$TicketServicePhone$] | Service phone number. | Yes | Yes | Yes | Yes |
| Service - Process | [$TicketServiceProcess$] | Name of the [process](../../../../../alvao-service-desk/implementation/services/processes) of the service. | Yes | Yes | Yes | Yes |
| Service - Custom service items | [$TicketService.tHdSectionCust.*ColumnName* $] | A custom service item where *ColumnName* represents the name of the corresponding column in the *tHdSectionCust* table. | Yes | Yes | Yes | Yes |
| SLA - Name | [$TicketSLA$] | Name of the [SLA](../../../../../alvao-service-desk/implementation/services/sla) request. | Yes | Yes | Yes | Yes |
| SLA - Custom SLA items | [$TicketSLA.tSlaCust.*ColumnName*$] | Custom SLA item, where *ColumnName* represents the name of the corresponding column in the *tHdSectionCust* table. | Yes | Yes | Yes | Yes |
