# Active Directory authentication
     
Users who have an Active Directory (AD) account can log in to Alvao applications using:
     
- **Windows Integrated Authentication** - the user account under which the user is currently logged into Windows on that computer is used for authentication in Alvao. The user don't need to enter any login credentials into Alvao applications.
- **Form authentication** - when running Alvao applications, the user enters their username and password stored in AD.

## Import users from Active Directory
     
In order for a user to be authenticated in Alvao using AD, their account must first be imported from AD into Alvao using the [ImportAD](../../../../alvao-asset-management/implementation/users/authentication/ad/import-ad) utility. We recommend to import users into Alvao on a regular basis, for example, by scheduling a task on the server to run once every day.
     
When first imported, Alvao will create all users and groups according to the specified LDAP path. The next time it is imported, only new users and groups are created, and the information about existing users and groups is updated. Users and groups removed from AD are not automatically removed from Alvao. If you import users from the entire AD, some auxiliary user accounts such as IUSR\_..., IWAM\_... will also be imported into Alvao. It is recommended to hide these auxiliary accounts with the **Hide** command. If you were to remove these users with **Remove**, they would be re-created the next time they are imported.
      
## Manual import
     
To import users beyond schedule, manually run the scheduled task created on the server or run the [ImportAD](../../../../alvao-asset-management/implementation/users/authentication/ad/import-ad) utility directly from the command line.
      
## Settings
     
On the **WebApp - Administration - Settings -**[Active Directory](../../../../list-of-windows/alvao-webapp/administration/settings/activedirectory) page, set the AD authentication parameters.
