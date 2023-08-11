# Inactive user accounts
      
There are three types of user account restrictions in Alvao.
     
The following restrictions are managed in the ALVAO WebApp: in **Management** - **Users**, view user accounts.  
         Select a user account and choose **Delete** or **Hide Accounts** from the local menu.  
         Or select **Edit -**[Properties](../../../list-of-windows/alvao-webapp/administration/users/create-user) from the local menu and check **Account is disabled** or **Hide in menus**.
      
## Disabled account
     
A disabled user is expected to be undisabled soon. Therefore, the disabled or hidden users do not draw [licenses](sd-licenses).  
         Account disabling can also be set directly in administration, or set when [importing from AD](../../../alvao-asset-management/implementation/users/authentication/ad) (where the account is disabled after three failed logins, for example).
      
A user whose account has been disabled is temporarily unable to log in to Alvao, does not appear in menus and stops receiving notifications. Unlike a removed account, a disabled account is still "active" in the Alvao system and the user will return to work "without interruption" once undisabled.

> [!NOTE]
> If an employee leaves, we recommend removing the account instead of disabling it.

## Removed account
     
If necessary, the account can be restored, but restoration is not expected. Therefore, a removed user does not [draw a license](sd-licenses).
      
The user has no access to the system, does not appear in menus and does not receive notifications, and does not "exist" in the Alvao system.
     
To restore, view deleted accounts in the user accounts using the **View Deleted** command. For the selected deleted accounts, then select **Restore Deleted** from the local menu.
      
## Account hidden in menus
     
The account is not assumed to be used by the actual user, but at the same time it cannot be deleted. Typically, it is a system account in Active Directory that would be recreated on each import.
      
The hidden account does not show up in menus or receive notifications, and does not "exist" in the Alvao system.

> [!NOTE]
> If the account is displayed in the menus, you can assign its user to a group, ask for approval or assign a request for resolution, for example.
