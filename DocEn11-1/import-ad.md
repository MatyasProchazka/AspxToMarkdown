# ImportAD utility
      
## Function description
      
This utility is used to import (synchronize) users and groups from Active Directory for the entire Alvao system. The utility also allows you to import objects (users, computers, and organizational divisions) into the Asset Management module.
      
The utility can be found in the ALVAO Asset Management Console installation folder ("%ProgramFiles%\ALVAO\Asset Management Console\ImportUtilities")or you can copy it from the application server from the ALVAO Service installation folder ("%ProgramFiles%\ALVAO\AlvaoService\utilities").
      
The account under which you run the utility must be a member of the *Domain Admins* groupor have the delegated permission to *Read all user information*.

> [!NOTE]
> If members from other trusted domains appear in the imported groups, in some cases you will need to list those domains in the [AdTrustedDomain](ad-trusted-domains) table.

> [!NOTE]
> The user's language is set by the *prefferedLanguage* attribute or *countryCode* when importing from Active Directory.

## Syntax command lines
      
**ImportAD.exe /adpath** *"LDAP path"* {**/conn** *"connection string"* | **/server**         *"database server name"* **/db** *"database name"*} [**/users**[remove,outsidegroups]]  [**/usermap** *"attribute mapping"*] [**/objects**         {users,computers,ou,flat}] [**/objectparentid** "NodeId"] [**/login** *"login name"*] [**/pswd** *"password"*] [**/log**         *"file"*] [**/progress**] [**/wait**]  [**/help**]****         [**/noportraits**]
      
## Detailed description of parameters

| Parameter | Description |
| --- | --- |
| /adpath &lt;LDAP path&gt; | An Active Directory path in LDAP format. Three variants are supported:
                    <ol>
                        <li>Import DC (entire AD) - all users and groups are imported, including group and user membership settings (&quot;copy&quot; of the entire AD).</li>
                        <li>Import of a specific OU (organizational unit) -
 all users and groups within the specified OU are imported. It is possible to use the <strong translate="no">outsidegroups</strong>, see more detailed description below.</li>
                        <li>Import of a specific CN (group) - all users and groups that are members of a specific group are imported (in depth - see note below).</li>
                    </ol>
                    <br>
                        <br><br>
                        <br>Note:<br>
                    <br>
                    <br>
                        <br><br>
> [!NOTE]
> <br>


                        <ul>
                            <li>Browsing group memberships in depth involves going through all groups that are members of a particular group, then going through their members, going through their members again, etc.<br>
                                Ex: Group C is a member of group B, which is a member of group A. The import imports all groups A+B+C. </li>
                            <li>The <strong>/objects</strong> switch (importing objects into Asset Management) does not work with a path routed from a specific group (CN).</li>
                        </ul> |
| /conn &lt;chain&gt;  <br>
                    /server&lt;server name&gt;  <br>
                    /db &lt;database name&gt; | These parameters are used to set the connection to the Alvao database. It is possible to use a connection string (e.g. **/conn** *"Data source=.\sqlexpress;Initial Catalog=test;Integrated Security = True;TrustServerCertificate=True"*), or simply specify a specific SQL server and DB (e.g. **/server** *".\sqlexpress"*
                    **/db***"test"*).  <br>
                    In case you use the **/server** parameters
 and **/db**, the database connection is made using Windows Integrated Authentication. If you specify all these parameters, only **/conn** is used
 parameter, **/server** and **/db**
                    will be ignored. |
| /users &lt;parameters&gt; | Import users and groups to Administration. Parameters are separated by a comma.
                      <br>
                      <br>
                    Description of possible parameters:
                    <br><br>| Parameter | Significance |<br>| --- | --- |<br>| remove | Remove users it can't find in AD. This flag only works when importing a group, organizational unit, container, or the entire AD (DC).
                                      <br>
                                    Only accounts that were originally imported from AD are removed. Manually created accounts are not removed. |<br>| outsidegroups | If the import is running on an OU (organizational unit), import also members of groups (groups within an OU) lying outside the selected OU.<br>
                                    <br><br>
                                    <br>Note:<br>
                                <br>
                                    **Example:**
                                      <br>
                                    We import an OU "CZ" in which the group is "CZA". The member of the group "CZA" is the group "SKA",
 located in another OU "SK". A member of the "SKA" group is the person "Peter".  <br>
                                    If we use this switch, "SKA" and "Peter" are imported (even if they lie outside the imported OU "SK"). Any additional members of the "SKA" group are also imported to unlimited depth (group members).  <br>
                                    If the switch is not used, neither the group "SKA" nor the person "Peter" will be created. | |
| --- | --- |
| /usermap &lt;mapping&gt; | Use this switch to specify the mapping of certain attributes when importing users and groups into Administration. The switch works only in combination with the **/users**.  <br>
                      <br>
                    Supported attributes:  <br>
                    <br><br>| Attribute | Field name in Administration |<br>| --- | --- |<br>| Company | Organisation |<br>| PersonalNumber | Personal Number |<br>| @tPersonCust.Column | Person's own items - see note |<br><br>
                      <br>
                    Attributes can be mapped either to a constant string on the command line (e.g. you want all persons to have the same Organization entered manually), or to a specific field from AD. See the usage examples for more details.  <br>
                    <br>
                        <br><br>
                        <br>Note:<br>
                        Attributes can also be mapped to any existing custom fields from the *tPersonCust* table (except fields of type *int* that use a list of values, and type *users*). The attribute name must be *"@"+[tPersonCust] +[database column name]*, e.g. *@tPersonCust.Title*.
                    <br>
                    <br>
                        <br><br>
                        <br>Tip:<br>
| --- | --- |
| /objects &lt;parameters&gt; | Import objects to Asset Management. Parameters are separated by commas.  <br>
                      <br>
                    Description of possible parameters:
                    <br><br>| Parameter | Significance |<br>| --- | --- |<br>| users | Import users. |<br>| computers | Import computers. |<br>| ou | Import organizational breakdown. |<br>| flat | Import only objects in the specified path and do not search including subfolders. |<br><br>
                    <br>
                        <br><br>
                        <br>Caution:<br>
                    <br>
                    <br>
                        <br><br>
> [!NOTE]
> <br>

                        The mapping of AD attributes to AM properties is set using the [table
 tblADMap](ad-object-property-mapping).  <br>
                        The import creates new objects in the *folder*.
 Objects retrieved from Active Directory. |
| --- | --- |
| /objectparentid &lt;NodeId&gt; | Create new objects as child objects under an object with ID: &lt;NodeId&gt;. Works only in conjunction with the /objects switch.  <br>
                    <br>
                        <br><br>
> [!NOTE]
> <br>

                        You can find the NodeId value in the AM Console on the *Objects* tab.
 by displaying the NodeId system column, or in the tblNode. intNodeId table. |
| /noportraits | Import without portraits. |
| /wait | Wait for a keystroke at the end of the import. |
| /progress | Display the progress of the import. |
| /login &lt;login&gt; | User login name. This account will be used to access AD.  <br>
                    <br>
                        <br><br>
> [!NOTE]
> <br>

                        If this parameter is not specified, the import will access AD under the account under which the utility was run (the currently logged in Windows user). |
| /pswd &lt;password&gt; | The password of the user whose account will be used to access Active Directory. |
| /log &lt;file&gt; | Log to file. Enter the path and name of the file.  <br>
                    <br>
                        <br><br>
> [!NOTE]
> <br>

                        Log will be overwritten on each run. |
| /datetimeformat | Date format in text strings (e.g. dd/mm/yyyy).
 If the parameter is not specified, the format is automatically recognized during conversion.  <br>
                    A detailed description of the possible formats can be found in [MSDN](https://msdn.microsoft.com/en-us/library/8kb3ddd4%28v=vs.110%29). |

## Mapping fields to AD attributes on persons

| Field Name | Attribute name in AD |
| --- | --- |
| First and last name | cn  <br>
                    <br>
                        <br><br>
                        <br>Note:<br>
| Email | email |
| Phone | telephoneNumber |
| Mobile | mobile |
| Office | physicalDeliveryOfficeName |
| Organisation | company |
| Division | department |
| Working position | title |
| User name | userPrincipalName |
| UserName (for legacy systems) | sAMaccountName |
| Supervisor | manager |
| Account is blocked | userAccountControl |

## Examples of use
     
1. Import all members of the *mygroup* group by entering a simple SQL server login:  
                 **ImportAD.exe /adpath** "LDAP://CN=mygroup,DC=my,DC=domain" **/server** "server\sql2005" **/db** "alvao"**/users**
2. Import the entire AD and specific SQL Server connection, removing users it can't find in AD:  
                 **ImportAD.exe /adpath**                 "LDAP://DC=my,DC=domain" **/conn** "Data Source=.\sqlexpress;Initial Catalog=alvao;Integrated Security=True;TrustServerCertificate=True" **/users** remove
3. Import a specific organizational folder and a simple SQL login. The *Organization* field will be set to the string *ALVAO* for all users. The *PersonalNumber* field will carry the value from the AD attribute *PersonalNumber*. The *Title* custom field will carry the value from the AD attribute *Personal*.   PersonalTitle. Groups outside the OU that are members of groups inside the OU are also imported:  
                 **ImportAD.exe /adpath**                 "LDAP://OU=ou1,DC=my,DC=domain" **/server** server1 **/db** alvao **/users** outsidegroups**/usermap**                 "Company='ALVAO'" **/usermap**                 "PersonalNumber=AD.EmployeeID" **/usermap**                 "@tPersonCust.Title=AD.PersonalTitle"
4. Import of new hires. None of them are freelancers, all are part-time, and they start on Aug. 15 at 10 a.m. in the building at 12 Waterfront St. in room 007. All will be placed in their own line items of their respective types.  
                 **ImportAD.exe** **/adpath**                 "LDAP://DC=new,DC=domain" **/conn** "Data Source=.\sqlexpress;Initial Catalog=alvao;Integrated Security=True;TrustServerCertificate=True" **/users** **/usermap** "@tPersonCust.Externist='0'" **/usermap** "@tPersonCust.Part\_time='0,5'" **/usermap**                 "@tPersonCust.Date\_of\_onboard='8/15/2015 10:00:00'" **/usermap**                 "@tPersonCust.Building\_address='Nábřežní 12'" **/usermap**                 "@tPersonCust.Room\_number='007'"
5. Import objects of type *Computer* and *User* into Asset Management:  
                 **ImportAD.exe /adpath**                 "LDAP://OU=ou1,DC=my,DC=domain" **/server** server1 **/db** alvao **/objects** computers,users
6. Import objects of type *Computer* and *User* to Asset Management and also users and groups to Administration:  
                 **ImportAD.exe /adpath**                 "LDAP://OU=ou1,DC=my,DC=domain" **/server** server1 **/db** alvao **/objects** computers,users **/users**
7. Import computers from the standard Computers container to Asset Management:  
                 **ImportAD.exe /adpath**                 "LDAP://CN=Computers,DC=my,DC=domain" **/server**                 server1 **/db** alvao **/objects** computers

## Key identifiers for creating or updating a user/PC 

| Entity | Identifier |
| --- | --- |
| WebApp - Administration - Persons | <ul>
                        <li>AD GUID</li>
                        <li>login name without domain (and the AD GIUD of the person is also NULL - i.e. a manually created user)</li>
                    </ul> |
| WebApp - Administration - Groups | <ul>
                        <li>AD GUID</li>
                        <li>Group (name)</li>
                    </ul> |
| AM - Users/Computers/Folders | <ul>
                        <li>AD GUID</li>
                        <li>key attribute according to <a href="ad-object-property-mapping">tblAdMap</a> (and the AD GUID of the object is also NULL)</li>
                    </ul> |

## Supported scenarios
      
### Synchronization with the whole AD (including deleting users)
      
Execute an AD-wide import (LDAP://DC=...) and use the **remove** parameter when importing groups and users into Administration.  (/users remove).
      
### Importing a few selected AD groups into Alvao

1. Create a new group *ALVAO* in AD and set all the selected groups you want to import into Alvao as members.
2. Set the import and path in the **/adpath** parameter.
 set *ALVAO* to this group.  

            Ex: **/adpath**
            "LDAP://CN=alvao,OU=import,DC=domain"
3. All selected groups and their members (including users) will appear in Administration. The membership of the groups will be set correctly.

### Import without photos directly from AD 
      
When importing users from AD, portraits are also loaded by default from the *thumbnailPhoto* and *jpegPhoto* properties.   User portraits are stored in the Alvao database.  
         If you don't want to retrieve portraits from AD, then run the import from the command line and add the */noportraits.*  
         For example:
     
**ImportAD.exe /adpath**         "LDAP://OU=ou1,DC=my,DC=domain" **/server** server1 **/db** alvao **/objects**         computers,users **/users /portraits**

> [!NOTE]
> Thus, to automatically load a scheduled job, it is necessary to modify the *ImportAD* command by adding the /noportraits parameter.

### Import objects to Asset Management
      
Start the import on the entire AD (cannot import blocked accounts) or selected OU and use the Switch         **/objects** switch to specify what to import. Use the **/objectparentid** switch to define where to import the objects (optional).
      
### Find Blocked Users from Active Directory

1. In the tree in the main AM Console window, select the entire organization and click the *Objects - All* tab.
2. Show the *Account is blocked* column.
3. Set the filter in the *Type* column to *User*
            and set the filter for the *Account is blocked* column to *Yes*.
4. After creating a list of blocked users, use the *Show in object lists* command to more easily navigate through the list items.
5. The filtered list contains users who have a blocked account in Active Directory. Move these users to the folder for excluded users.

### Removing old users
     
If you want to delete old users who have not been found in Active Directory for some time, follow this procedure:

1. In the Administration page, on the *Users* page, sort the users by the *Last Imported from AD* column in ascending order.
2. Select and delete users who have not been found in AD for a long time.

### Remove old objects from Asset Management
     
To remove old objects that have not been found in Active Directory for some time, follow this procedure:

1. In the AM Console, select the entire organization in the object tree and go to the *Objects* tab.
2. Show the *Last Imported from AD* column.
3. Use the filter in the *Type* column to display only computers or users.
4. Set the filter on the *Update imported from AD* column to not "" and sort the table in ascending order.
5. From the local menu, use the *Show in object lists* command.
6. In the *Object Lists* window, step through the old objects. If the user had an asset, complete the user's return.
7. Move the objects to the *Classified Assets* folder.

### Rename the computer
     
If a computer is loaded from Active Directory (AD) and you need to rename it:

1. Rename the computer in Windows (the computer will remain the same GUID in AD).

> [!NOTE]
> 


        The next time you import from AD, the ImportAD utility will automatically rename the computer in Asset Management as well.

### Reinstall (reimage) a computer with name preservation
     
If a computer is loaded from Active Directory (AD) and you need to reinstall its operating system or restore it from a disk image and preserve its name on the network:

1. Remove the computer from AD.
2. Go to the AM Console, find the computer in the tree, and use the *Edit* command from the local menu.

            Delete the value in the *GUID field of the object in Active Directory*.
3. Reinstall the operating system or restore it from an image disk. Give the computer its original name.
4. Register the computer in AD again (the computer gets a new GUID in AD).

> [!NOTE]
> 


        The next time you import from AD, the ImportAD utility will automatically pair the new AD computer with the computer in Asset Management according to the *Network Name* property.
