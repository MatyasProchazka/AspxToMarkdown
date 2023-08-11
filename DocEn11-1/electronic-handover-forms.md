# Signing documents via the web
   Use this form to set up signing of handover protocols and other documents over the web and to notify users of unsigned documents. The form is part of the [ALVAO Electronic Handover Forms](../../../../../modules/alvao-electronic-handover-forms) module. 
Features:
  
- **Recipient Message**
    - [Edit message template](electronic-handover-forms-message-template) - edit the message template that will be sent to the recipient of the asset after the document is issued.
- **Require login password when signing** - enable if you want the asset recipient to have to enter their login password when signing the document. This functionality only works for users who authenticate via Active Directory or with a password set in WebApp - Administration - [Users](../../users).
- **Alert Recipient**- turn on if you wish to send notifications to the recipient of the asset when the document is not signed.
    - **If the beneficiary does not sign the document within (days)** - enter the number of days. If the document is not signed after this number of days, a notification will be sent to the beneficiary.
    - [Edit message template](electronic-handover-forms-message-template) - edit the notification template.
- **Notify Handing Technician**- turn on if you wish to send a notification to the handing technician when a document is not signed.
    - **If the recipient does not sign the document within (days)** - enter the number of days. If the document is not signed after this number of days, a notification is sent to the transferring technician.
    - [Edit message template](electronic-handover-forms-message-template) - edit the notification template.
- **Alert recipient's direct supervisor**- turn on if you wish to send a notification to the direct supervisor when a document is not signed.
    - **If the recipient does not sign the document within (days)** - enter the number of days. If the document is not signed after this number of days, a notification is sent to the recipient's direct supervisor.
    - [Edit message template](electronic-handover-forms-message-template) - edit the notification template.
- **Alert Team**- turn on if you want to send notifications to members of a specific user group.
    - **If the recipient does not sign the document by (days)** - enter the number of days. If the document is not signed after this number of days, a notification will be sent to the selected user group.
    - **Notify group members** - select the user group. 

> [!NOTE]
> - **Automatically repeat this alert after (days since last alert)** - enable if you want to send alerts repeatedly and specify the period of sending in days).

    - [Edit message template](electronic-handover-forms-message-template) - edit the notification template.
- **Alert sending time** - enter the time when alerts should be sent (in hh:mm format).

Note:
Notifications to the submitting engineer, team and direct supervisor are sent in bulk for all unsigned documents.
