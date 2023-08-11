# New rule
 
This form is used to create a new rule for incoming messages.
 
Options:

- **Rule Name** - enter the name of the rule.
- **Conditions**- enter one or more of the following conditions. If you specify more than one condition, the rule will be executed only if all the specified conditions are met. 
    - **Message Subject Contains** - enter the text that must be included in the message subject. For example, if you specify: *Application installation*, the condition will be met for messages with the subject line: *Office application installation*; *Remote installation of applications on a computer*; *Application installation*. *Basic Application Installation* will not satisfy the condition.
    - **Message body contains** - enter the text that must be included in the message body.
    - **Sender contains** - enter the text that must be contained in the *From* field of the message.
    - **Recipient contains** - enter the text that must be contained in the *To* field of the message.
- **Send a message**
    - **Send Message** - if you enable this option, the rule sends the message that is defined in the following fields.
    - **To whom** - specify the recipient of the message. You can enter multiple email addresses in the field, which can be separated by semicolons or commas.
    - **Subject** - enter the subject of the message.
    - **Text** - enter the text of the message.
- **Next Action**- select which actions to perform on the request that was created based on the incoming message.
    - **Create in Service** - the request is created directly in the selected service.
    - **Resolve Request** - the request is automatically resolved immediately.
    - **Delete Request** - the request is automatically deleted immediately.
