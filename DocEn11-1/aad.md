# Azure Active Directory authentication
      
Only users from a single Azure Active Directory (AAD) tenant and external users (guests) of that tenant can log in to Alvao. If you enable AAD authentication in Alvao, no other users outside of AAD will be able to log in to Alvao.

> [!CAUTION]
> If you are switching from [Active Directory (AD)](../../../../alvao-asset-management/implementation/users/authentication/ad) authentication to AAD authentication, pay attention to the options for limiting the set of users and groups imported from AAD that differ from AD, see *Scope* below. Before setting up user import from AAD, first disable the existing user import from AD ([ImportAD](../../../../alvao-asset-management/implementation/users/authentication/ad/import-ad)).  

## Import users from AAD (user provisioning)
      
1. In the [Microsoft Azure portal](https://portal.azure.com/#home), navigate to **Azure Active Directory - Enterprise Applications**, click **New application**, find **ALVAO** application in the Azure AD Gallery and click **Create**.
2. In the application details, go to the **Provisioning** tab, click **Get started**and set the following provisioning parameters:
    1. **Provisioning mode**: Automatic
    2. In the **Admin Credentials** section:

                **Tenant URL**: {address ALVAO REST API}/scim 

                E.g.: *https://app.contoso.com/alvaorestapi/scim*

                **Secret Token**: In **WebApp – Administration – Settings -**[Active Directory and Azure Active Directory](../../../../list-of-windows/alvao-webapp/administration/settings/activedirectory) generate new client secret key and copy it to this field.
                
        Use the **Test connection** command to verify that everything is set up correctly.

                ![](text_connection.png)
3. In the **Settings** section:  

            Optionally, fill in the email address to which notifications will be sent in case any errors occur.  

            Under **Scope**, select if you want to sync all users from AAD or only selected users.

            ![](settings_scope.png)
4. Set **Provisioning status** to *On*.
5. If you selected in *Scope* that you want to synchronize only selected users and groups, go to the **Users and Groups** tab and assign the users and groups you want to synchronize with Alvao to the application. 

> [!CAUTION]
> Direct members (users and groups) of groups assigned to the application are always imported into Alvao as well.   However, members of these direct members are no longer automatically imported.   For more information, see [Understand how Application Provisioning in Azure Active Directory | Microsoft Docs](https://docs.microsoft.com/en-us/azure/active-directory/app-provisioning/how-provisioning-works#assignment-based-scoping).

For more information on the various options in the setup, see [User provisioning management for enterprise apps in Azure Active Directory | Microsoft Docs](https://docs.microsoft.com/en-us/azure/active-directory/app-provisioning/configure-automatic-user-provisioning-portal).
       
## Setting up AAD authentication

1. In the [Microsoft Azure portal](https://portal.azure.com/#home), navigate to **Azure Active Directory - App registrations** and select the first created **ALVAO** app.
2. On the **Overview** page, set **Redirect URIs** to *https://&lt;WebApp&gt;/Account/LoginMicrosoftEndpoint*.
3. On the **Authentication** page, check **Access tokens (used for implicit flows)** and save the settings.
4. On the **API permissions**page:
    1. Click **Add a permission**, go to APIs my organization uses tab and select the first created **ALVAO** app.
    2. Check **user\_impersonation** permission and click **Add** permissions.
    3. **Grant admin consent** for previously added permission
    4. Click **Add a permission**, select **Microsoft Graph**, select **Delegated permissions**, check **Presence.Read.All** and click **Add** permissions. This allows to enable Show users presence option.
5. Make a note of the values from the application registration that you will need later:
    1. **Client ID**
    2. **Directory (tenant) ID**
    3. **Client credentials - Client secrets - New client secret - Client Secret**
6. In the following SQL script, insert the *Directory (tenant) ID* and *Client ID* values obtained above and run the script on your Alvao database.  

            INSERT INTO [AzureAdTenant](../../../../alvao-asset-management/implementation/customization/database#U_dbo.AzureAdTenant) (AzureTenantId) VALUES (N'*&lt;Directory (tenant) ID&gt;*')

                EXEC spUpdateInsertProperty N'AzureApplicationId', N'*&lt;Client ID&gt;*'
7. On the server in **IIS Manager**:
    1. In **Alvao** (WebApp), change the authentication method to *anonymous* and *forms*.  

                    In the forms login details, specify

                    *~/Account/LoginMicrosoft* address.
    2. In **AssetWebService** (AM WS), set the authentication method to *anonymous*.
    3. In **AlvaoRestApi**, set the authentication method to *anonymous*.
    4. In **AlvaoCustomAppsWebService** (CA WS), set the authentication method to *anonymous*.
8. In the following configuration files, write the **AAD\_ClientSecret** setting to the *Client Secret*value obtained above:
    1. WebApp – web.config file
    2. AssetWebService – web.config
    3. AlvaoService – appsettings.json
    4. AlvaoRestApi – web.config
    5. AlvaoCustomAppsWebService – web.config

For more information on registering apps in AAD, see [Register your app with the Azure AD v2.0 endpoint - Microsoft Graph | Microsoft Docs](https://docs.microsoft.com/en-us/graph/auth-register-app-v2).
      
## Import users into the object tree in ALVAO Asset Management
     
If *ALVAO Asset Management* is activated, users are also automatically imported into the [object tree](../../../../alvao-asset-management/objects-and-properties) in the *Read Objects from Active Directory* folder, from where they are moved to the correct location in the tree. The same set of users is imported into the object tree as in *WebApp - Administration -*[Users](../../../../list-of-windows/alvao-webapp/administration/users).
      
When removing a user from the AAD, the user is automatically blocked in the object tree (see the *Account is blocked* property) but not removed. Once in a while, we recommend checking the tree for blocked users and removing them if necessary.
      
If you activate *Asset Management* after the fact, when you have already imported users into *Report*, the existing users are not automatically created in the tree. You can additionally create them with a prepared [SQL script](../../../../alvao-asset-management/implementation/users/aad-provisioning-scim/am-import-users.sql) that creates all users from *Report* that do not already exist in the object tree. The property values are set according to the default attribute mapping. Existing users will remain unchanged.

> [!NOTE]
> You can also manually create a small number of users in the object tree and set their property values according to the information in the *Message* (especially the *User Name* property, which is key).

> [!NOTE]
> You can disable the import of users into the object tree with this SQL script if needed:  

     EXEC spUpdateInsertProperty 'AM.Scim.ImportUsers', NULL, 0;     
After executing the script, we recommend recycling the Alvao application pool on the IIS server so that the import shutdown takes effect immediately.
     
You can turn the import back on with the script:
     EXEC spUpdateInsertProperty 'AM.Scim.ImportUsers', NULL, 1;       
## SCIM
     
Importing (provisioning) users from AAD to Alvao uses the [SCIM](https://docs.microsoft.com/en-us/azure/active-directory/app-provisioning/user-provisioning) interface, through which Alvao automatically:

- Create, edit and delete users in *WebApp - Administration -*[Users](../../../../list-of-windows/alvao-webapp/administration/users)
- Create, edit, and delete groups in *WebApp - Administration -*[Groups](../../../../list-of-windows/alvao-webapp/administration/groups)
- Updates user and group memberships in groups
- Created and edited by users in the [object tree](../../../../alvao-asset-management/objects-and-properties) in *ALVAO Asset Management*

AAD sends information about changes to Alvao via the SCIM interface on an ongoing basis. Most changes are reflected in Alvao within 40 minutes, some, such as locking out a user, even sooner. This interval is entirely under the control of AAD and cannot be changed.
     
The SCIM interface is part of the ALVAO REST API, which must be installed on a server accessible from the Internet (or Azure).
