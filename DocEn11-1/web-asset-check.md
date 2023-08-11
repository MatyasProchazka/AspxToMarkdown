# Web Inventory
 
The form is used to set up the [ALVAO Inventory Audits](../../../../../modules/alvao-inventory-audits).
  
Options:

- **Command Panel**
    - **Save** - saves the settings and closes the form.
    - **Restore default text**
        - **Notification** - in the *Notification Text* field
 inserts the default text.
        - **Forms** - inserts default text in the *Form Text* field.
- **Notification**- template message sent to users at the start and possibly during the inventory. You can edit the text before sending each message. 
    - **From** - enter the email address from which notifications will be sent. You can enter only the email address or display name and email address, e.g. Alvao DontReply &lt;do-not-reply@domain.com&gt;
    - **Subject** - enter the subject of the notification.
    - **Text** - enter the text of the notification. In the text, we always recommend to include a link to the web inventory form in the ALVAO WebApp.

> [!TIP]
> You can return the notification text to its default status by using the *Restore Default Text - Notifications* command.

- **Form**
    - **Form Text** - enter explanatory text that will be displayed to users at the top of the web inventory form. 

> [!TIP]
> You can return this text to its default status by using the *Restore Default Text - Form* command.

> [!NOTE]
> In [multi-language environment](../../../../../alvao-service-desk/implementation/multi-languages), after changing the *Subject*, *Notification Text* or *Form Text*, it is necessary to update the translations into other languages as well. If you don't update the translations, users will see an unupdated translation or text in the system language.
