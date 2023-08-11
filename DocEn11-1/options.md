# ALVAO Add-in settings

- **Connection**
    - **Alvao domain name (or REST API url)** - enter the domain name of your, e.g., *contoso.onalvao.com*.  
	If your Alvao REST API application has a non-standard address, or you are using HTTP protocol instead of HTTPS, enter the full REST API address, e.g., *http://app.company.com/RestApi*.
    - **Authentication**- choose a user authentication method:
        - **Azure Active Directory authentication** - a Microsoft 365 user account or other AAD user account will be used for authentication.
        - **Integrated Windows authentication** - the user account you are currently logged in to Windows on this computer will be automatically used for authentication without re-entering your credentials.
        - **Windows username and password**- use any other Windows user account, e.g., Active Directory user account.
            - **User name** - enter a user name.
            - [Enter password](password)
 - press this button and enter the password.
- **Taskbar**
    - **Display and hide automatically** - if the selected Outlook item (message, meeting, event, task) contains a tag of an existing request in the subject or name, the request will be automatically displayed in the [taskbar](task-pane). Otherwise, the taskbar is automatically hidden.
