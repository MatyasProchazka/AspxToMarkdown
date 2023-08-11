# Active Directory and Azure Active Directory
 
Use this page to set the Active Directory server address and default domain to generate the secret key needed to import users from Azure Active Directory.
 
Options:

- **Active Directory**
    - **Active Directory Server** – the address of the LDAP server where users imported from Active Directory are authenticated when formally logging into Alvao applications. By default, "LDAP://" will automatically use the root AD controller on the network to authenticate users. If this value is blank, authentication via Active Directory is disabled.

> [!NOTE]
> If you need to use LDAPS, you must specify AD server hostname and port: "LDAP://**&lt;AD server hostname&gt;:636**".

                    
    - **Default Domain** – Enter the name of the most common network domain in your organization. Users from this domain will be able to log in to Alvao applications with their username without the domain name. Users from other domains will need to provide their username including the domain.
- **Azure Active Directory**
    - **Generate new key** – press if you want to generate new secret key needed to [import users from Azure Active Directory](../../../../alvao-asset-management/implementation/users/authentication/aad). The new secret key is immediately stored in the database and invalidates the previous one.
