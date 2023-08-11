# Loading messages
     
This section on the [New Service](create-service) form is used to set up retrieval of messages from the mailbox.  
         If the message contains a tag of an existing request in the subject line, it will be automatically loaded into its log. Based on messages without a request tag, [a new request is created](../../../../../alvao-service-desk/requests/new-request).
     
Options:
     
- **Server**
    - **Exchange Server** - enter the name of the Exchange server, e.g.:
                            outlook.office365.com.
        - **Authentication**
            - **OAuth 2.0 (Exchange Online)** - First, [register the Alvao Service application](https://docs.microsoft.com/en-us/exchange/client-developer/exchange-web-services/how-to-authenticate-an-ews-application-by-using-oauth#register-your-application) in your Azure Active Directory and [set permissions](https://docs.microsoft.com/en-us/exchange/client-developer/exchange-web-services/how-to-authenticate-an-ews-application-by-using-oauth#configure-for-app-only-authentication) for the *full\_access\_as\_app*. We also recommend [limiting permissions](https://docs.microsoft.com/en-us/graph/auth-limit-mailbox-access)so that can only access the listed mailboxes.
                - **Application (client) ID** - enter the Alvao Service application ID from AAD.
                - **Directory (tenant) ID** - enter the directory ID of the Alvao Service application from AAD.
                - **Client secret** - enter the secret code of the Alvao Service application from AAD.
                - **E-mail** - enter the email address of the retrieved mailbox
            - **Basic**
                - **User name** - enter a username to log in to the service mailbox, see [New Service](../../../../../list-of-windows/alvao-webapp/administration/service-desk/service/create-service)*- General - Email*.
  The username is usually the same as the mailbox email address.  

                                            If you want to retrieve messages from another mailbox, such as a [shared mailbox](https://docs.microsoft.com/en-us/microsoft-365/admin/email/about-shared-mailboxes?view=o365-worldwide) in Microsoft 365, put a backslash at the end followed by the email address of that mailbox. For example, the username *service\_account@contoso.com* will retrieve messages from the *servicedesk@contoso.com* mailbox and log into that mailbox as the *service\_account@contoso.com* user.
                - **Password** - enter the password to log in. 

> [!CAUTION]
> The password for accessing the mailbox is stored in the database in unencrypted form.

> [!NOTE]
> The interface is supported by Exchange Server 2016 (or later) and Office 365.

    - **IMAP Server**- enter the network name of the IMAP server.
        - **IMAP Port** - enter the TCP/IP port for communication with the IMAP server.
        - **SSL** - enable if you want secure communication with the server.
        - **Login**
            - **User Name** - enter the username of the user from whose default mailbox messages are to be retrieved.
            - **Password** - enter a password for logging in.

> [!CAUTION]
> The password for accessing the mailbox is stored in the database in unencrypted form.

> [!NOTE]
> Through the IMAP interface you can connect to a wide range of mail servers such as Exchange Server, HCL Domino, etc.

- **Settings**
    - **Load unread messages only** -
 turn on if you only want to retrieve messages from the clipboard that are not marked as read.
    - **Mark uploaded messages as read**
                    - turn on if you want to automatically mark messages that Alvao has processed as read.
    - **Transfer uploaded messages to** - enter the folder name if you want to move the message to a specific folder in the mailbox after processing.
    - **Delete uploaded messages** - turn on if you want to delete processed messages from the clipboard. If you do not otherwise have a way to delete old clipboard contents, we recommend leaving this option on.
