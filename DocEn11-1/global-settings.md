# Installation settings

- **SMTP Server**
   
If you don't use notifications, you can skip the SMTP server settings.
    - **SMTP server for sending emails and notifications** - enter the name of the SMTP server. For example:
 smtp.company.com:25.
    - **Use SSL** - provides encrypted communication.
    - **Login to SMTP server**
        - **Windows Integrated Authentication**
 - Option to use integrated Windows authentication.
        - **User** - option to enter a username.
        - **Password** - option to enter a user password.
    - **Message Sender Address** - option to enter the sender's email address. E.g.: ALVAO &lt;alvao@domain.com&gt;.
     See also *Administration – Settings –*[Sending messages](../../alvao-webapp/administration/settings/messaging)*– Message sender*.
    - **E-mail address to test connection with SMTP server** - option to enter an e-mail address to test connection with SMTP server. For example: info@company.com.
- **Active Directory Authentication**
    - **Active Directory server address for user authentication** - Option to specify the Active Directory server address for user authentication. For example: LDAP://domainserver. If you want to use the default AD server, enter only "LDAP://".

> [!NOTE]
> If you need to use LDAPS, you must add AD server hostname and port. For example: "LDAP://domainserver**:636**".

    - **Default login domain** -
 Enter the name of the default login domain. For example:
 company.local.
