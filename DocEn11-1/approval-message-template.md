# Message template for approvers
 
This window allows you to define an approver message template for the approval status of the request being edited. The message to the approver is sent to the approvers as a notification of the start of the approval. It is also displayed on the request approval or rejection form and in the request log in the approval initiation events.
 
Options:

- **Use default template** - use a default message template that is common to all processes and request statuses.

> [!NOTE]
> - **Use Custom Template** - use a custom template that is defined only for the request status being edited. Edit the message template in the text box. The resulting message should tell the approver what specifically is to be approved, i.e., what specifically to approve or reject in the request (e.g., the requester's original request, the proposed solution, the final implementation method, etc.).

> [!TIP]
> In the template, border the text you want to display in bold in the message with &lt;b&gt; and &lt;/b&gt; tags, e.g. &lt;b&gt;Important:&lt;/b&gt;. Other HTML tags are not supported.

    - **Restore Default** - overwriting the current content of the text field with the default template.
    - **Insert Variable** - use the drop-down menu to select the variable you want to insert into the template at the current cursor position. For a list of variables, see [Custom Notification Template (Approvers Message Template column)](../../../service/message-template)

> [!NOTE]
> Notifications sent to approvers are formatted according to the set [notification style](../../../settings/notification-style).
