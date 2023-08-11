# Sending messages
 
This page is used to set up basic messaging in Alvao.
 
Options:

- **SMTP Server**
    - **Address** - enter the address or name of the SMTP server on the network.
    - **Port** - enter the port number of the SMTP server. For a secure connection (SSL) this is usually 465, for an insecure connection it is 25.
    - **Authentication**- select the authentication method from the menu.
        - **User Name and Password** - enter the name and password of the user who is authorized to send messages from the SMTP server in the following fields. 

> [!CAUTION]
> The username and password are stored in the Alvao database in unencrypted form.

> [!NOTE]
> If a username and password are filled in, this user must have send permission (SendAs) for all service email addresses.

        - **Integrated Authentication** - select this option if the SMTP server is able to authenticate the user in an integrated way. The user account running the Alvao Service service must have permissions to send messages from that SMTP server.
    - **User Name** - Enter the username of the user who is authorized to send messages from the specified SMTP server.
    - **Password** - enter the password of the user.
    - **SSL** - enable if you want to connect to the SMTP server securely (encrypted).
- **Message Sender**
    - **Address** - enter an email address to send general messages from Alvao.
   
For example: ALVAO &lt;alvao@domain.com&gt;
  
        We recommend entering an email address of an existing service used for [receiving messages to Service Desk](../service-desk/service/loading-messages).       If you don‘t use ALVAO Service Desk, the system does not load messages from the mailbox, so we recommend entering a non-existent email address       or an address where you can arrange message pickup in another way. E.g.: ALVAO DontReply [do-not-reply@domain.com](mailto:do-not-reply@domain.com).

        This address is used for sending [current news](../../../../alvao-service-desk/news), [periodic alerts](../../../../alvao-asset-management/implementation/periodic-alerts),        [notifications about problems in system settings](settings-check), etc.

> [!NOTE]
> Messages associated with requests in Alvao Service Desk are sent from the email addresses of the requests‘ services.
