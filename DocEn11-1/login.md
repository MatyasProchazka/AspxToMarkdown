# Login
 
In this window you can change the logged in user.
 
Options:

- **Use Windows Integrated Authentication** -
 Select this option if you want to log in to the application with the account you are currently logged in with on Windows. This option is only available if the AM Console is connected directly to the database.
- **- Use Azure Active Directory authentication** -
 Select if you want to log into AM Console with an Azure Active Directory account. This option is only available if this authentication method is enabled in the application settings.
- **Use the specified username and password**-
 Select if you want to enter login credentials.
    - **User name** - enter a username. If you want to log in to a different [default domain](../../alvao-webapp/administration/settings/activedirectory), use the form domain\login or login@domain.
    - **Password** - enter the password.
- **Don't logout** - if you enable this option, the next time you run the application, you will be logged in automatically. If you are idle for more than 7 days, the permanent login will expire.

> [!NOTE]
> If your current password has expired, you will be prompted to change it (not valid for Active Directory users).
