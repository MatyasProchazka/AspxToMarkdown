# Import users from CSV
      
## Regular automatic import
     
Create a scheduled task on the server with a recurrence period of e.g. 1 time per day that runs the following command:  
         %ProgramFiles%\ALVAO\AlvaoService\utilities\ImportUsersCsv.exe /csv &lt;path to CSV file&gt; /server &lt;sql\_server&gt; /db &lt;database\_alvao&gt; /add /remove
      
## One-time import
     
For a one-time import of portraits on the server, run the created scheduled task once or copy the *ImportUsersCsv* application from the server to your computer and run it from the command line. The application is installed together with the ALVAO Service in the "%ProgramFiles%\ALVAO\AlvaoService\utilities" folder.
      
## Utility ImportUsersCSV
     
This utility imports users from a CSV file into Alvao. You can use it, for example, to update users in Alvao according to data in the HR system, etc.
      
### Syntax command lines
      
**ImportUsersCSV** **/csv** *"path and name of CSV file"* {**/con** *"connection string"*         |   **/server** *"database server name"* **/db** *"database name"*} [**/key** "key column"] [**/cols** "column list"] [**/utcdate**]  [**/nohdrs**] [**/add**] [**/remove**]  [**/help**]
      
### Detailed description of parameters

| Parameter | Description |
| --- | --- |
| /csv | The path and name of the CSV file from which the import is to be performed. |
| /con  <br>
                    /server  <br>
                    /db | These parameters are used to set the connection to the Alvao database. It is possible to use a connection string (e.g. **/con** *"Data source=.\sqlexpress;Initial Catalog=test;Integrated Security = True;TrustServerCertificate=True"*), or simply specify a specific SQL server and DB (e.g. **/server** *".\sqlexpress"* **/db** *"test"*).  <br>
                    In case you use the **/server** parameters
 and **/db**, the database connection is made using Windows Integrated Authentication. If you specify all these parameters, only **/con** is used
 parameter, **/server** and **/db**
                    will be ignored. |
| /key | The key column is used to search for an existing user in Administration. If no parameter is specified, the key column is **Login** (must exist in the CSV). |
| /cols | Allows you to specify the meaning and order of the columns in the CSV (CSV does not contain headers). If **0** is specified in the list
 (zero), the corresponding column from the CSV will not be imported (ignored).  <br>
> [!NOTE]
> The list on the command line may not contain the same number of columns as the CSV (unlisted columns will be skipped -

 ignored). |
| /utcdate | Date columns are in UTC time. If the switch is not specified, the time data in the CSV is considered in the current time zone of the computer (local time). |
| /nohdrs | The imported CSV does not contain a header (first row) with column descriptions. |
| /add | Create new users in Alvao.
                      <br>
> [!NOTE]
> If this switch is not specified, the import will not create new users, but only update existing ones. |

| /remove | Remove users from Alvao that it does not find in the CSV file. |

### Description of all supported columns

| Name of column in CSV  <br>(on the command line - /cols) | Importance | Related column in tPerson | Note |
| --- | --- | --- | --- |
| ID | The unique identification number of the person in the CSV (e.g. the ID from the system from which the CSV is exported). | - | If the CSV contains a **ManagerID** or **DelegateID**, the import requires this column, otherwise it will exit with an error. |
| FullName | Person's first and last name | withPerson | Must not be filled in - in this case the value will be composed as [**FirstName LastName**] (if filled in). |
| Login | UserName | withPersonLogin (if the value is of the form *domain* and is an AD user, then SamAccountName) | The username can be entered in the following forms:
                    <ul>
                        <li><em>login@domain (UPN)</em></li>
                        <li><em>login</em></li>
                        <li><em>domain/login</em></li>
                    </ul> |
| Email | E-mail | withPersonEmail |  |
| Phone | Phone | withPersonPhone |  |
| Mobile | Mobile | withPersonMobile |  |
| Office | Office | withPersonOffice |  |
| Department | Department | withPersonDepartment |  |
| JobTitle | Job Position | withPersonWorkPosition |  |
| Pswd | SHA1 hash of the user's password | sPersonPswd |  |
| IsAccountDisabled | "Account is disabled" | bPersonAccountDisabled | Values allowed: 0,1 |
| OtherContacts | Other Contacts | mPersonContact |  |
| Notes | Notes | mPersonNotes |  |
| City | City | withPersonCity |  |
| ManagerID | Manager ID. The person ID must exist in the CSV. | - | Requires **ID** column. |
| DelegateID | Delegate ID number. The person ID must exist in the CSV and the related persons must have the same company (**Company**). | - | Requires **ID** column. |
| PersonalNumber | Personal Number | withPersonPersonalNumber |  |
| OutOfOfficeSinceDate | Unavailable as of date. Common date and time formats are supported.  <br>
                    Example of supported formats:  <br>
                    - 2012-11-21  <br>
                    - 2012-10-9 15:24:48  <br>
                    - 2010-08-15 14:18:44  <br>
                    - 2010-07-14 | OutOfOfficeSince |  |
| OutOfOfficeUntilDate | Do not include the date and time. Common date and time formats are supported (see OutOfOfficeSinceDate). | OutOfOfficeUntil |  |
| LocaleId | User's preferred language, this is the "language code",
 e.g.:  <br>
                    - Czech: 1029  <br>
                    - English: 1033  <br>
                    - Polish: 1045  <br>
                    - Germany: 1031 | iPersonLocaleId | A good number. |
| Company | Organisation | - | Search for an organization by name. If it does not exist, a new organization is created by name. |
| FirstName | FirstName | withFirstName |  |
| LastName | LastName | withLastName |  |
| TimeZone | TimeZone - must match Windows time zone ID -
 more [here](http://technet.microsoft.com/en-us/library/cc749073%28v=ws.10%29). | TimeZone |  |
| AdGUID | GUID from Active Directory | withPersonAdGuid |  |
| AdPath | Path in ActiveDirectory | withPersonAdPath |  |
| AdSID | AD SID in text form (S-1-5-21-55544...) | withPersonSID |  |
| IsHidden | "Hide in menus" | bHidden | Allowed values: 0,1 |
| IsShared | This is a "shared account" | bPersonShared |  |
| Country | Country | withPersonCountry |  |
| CountryAbbr | Country (abbreviation, 2 characters) | withPersonCountryAbbr |  |
| CountryCode | CountryCode | andPersonCountryCode | Cell number |
| PreferredLang | Preferred language (abbreviation, 2 characters) | withPersonPreferredLanguage |  |

> [!NOTE]
> Attributes can also be mapped to any existing custom field from the tPersonCust table, except for items of type int that use a list of values, and type *user*. The attribute name must be *"@"+[tPersonCust] +[database column name]*, e.g. *@tPersonCust.Title*.

       
### Recommended CSV file structure
     
It is recommended that the imported CSV file contains the following columns:

| Name of column in CSV  <br>(on the command line - /cols) | Importance | Note |
| --- | --- | --- |
| ID | The unique identification number of the person in the CSV (e.g. the ID from the system from which the CSV is exported). | If the columns **ManagerID** and **DelegateID** are blank, they do not need to be filled in. |
| FirstName | FirstName | Must be filled in **FirstName** and **LastName**, or **FullName**. |
| LastName | Surname | The **FirstName** and **FirstName** must be filled in.
 **LastName**, or **FullName**. |
| FullName | Person's first and last name | Must not be filled in - in this case the value will be composed as [**FirstName LastName**]. |
| PersonalNumber | PersonalNumber |  |
| Login | User Name | The column must have values. |
| Phone | Phone |  |
| Mobile | Mobile |  |
| Email | E-mail |  |
| Office | Office |  |
| Department | Department |  |
| JobTitle | Job Position |  |
| Company | Organisation |  |
| IsAccountDisabled | "Account is disabled" | Allowed values: 0,1 |
| ManagerID | Manager identification number. The person ID must exist in the CSV. | Requires **ID** column. |
| DelegateID | Delegate ID. The person ID must exist in the CSV and the related persons must have the same company (**Company**). | Requires **ID** column. |
| LocaleId | User's preferred language, this is the "language code", e.g.:  <br>
                    - Czech: 1029  <br>
                    - English: 1033  <br>
                    - Polish: 1045  <br>
                    - Germany: 1031 | A whole number. |

> [!NOTE]
> Optional columns can be empty - be careful in this case the corresponding data for the person in Alvao will be removed (they will be empty).

##### Sample CSV file

    ID;FirstName;LastName;FullName;PersonalNumber;Login;Phone;Mobile;Email;Office;Department;JobTitle;Company;IsAccountDisabled;ManagerID;DelegateID;LocaleId;@tPersonCust.Title
    44;David;Ostrý;;PN1111;ostry;3256;+420987654321;ostry@demo.cz;321;Marketing;Manager;;0;46;45;1029;Mr
    45;Petr;Novák;;PN2222;novak;3247;+420111222333;novak@demo.cz;323;Promotions;Manager;;1;;;1029;Mr
    46;Veronika;Clements;;PN3333;clements;3244;+420121353255;clements@demo.cz;111;Marketing;Head of Department;;0;;44;1033;Mrs

#### Import CSV with recommended structure
      
CSV contains a header with column names. The import will do a full synchronization, i.e. it will remove users it doesn't find in the CSV and create new users. The key column is **Login**.   Import command line:

    ImportUsersCsv.exe /csv "c:\data\users.csv" /server server\sql2005 /db alvao /add /remove

### Use cases
      
#### HR system generates CSV with many columns, we want to import only some data into Alvao
      
HR system generates CSV with fixed structure. This structure cannot be changed. We want to create new users and at the same time remove users who are not in the CSV (full synchronization). Example: the CSV contains 30 columns. We want to import only "login name" (first column) and "first and last name" (4th column). The other columns have no meaning. The CSV does not contain headers (column names). We will use the command line:

    ImportUsersCsv.exe /csv "c:\data\users.csv" /server server\sql2005 /db alvao /cols "Login,0,0,FullName" /nohdrs /add /remove

#### Import of users from AD and additional update of persons from HR system
      
Import users from AD (new users are created and deleted). We need to update other data from the HR system - the key is the personal number (we don't want to create new or remove users based on the HR system). HR system generates column names to CSV according to Alvao definition.  
         Usage example:

    ImportAD.exe ...
    ImportUsersCsv.exe /csv "c:\data\users.csv" /server server\sql2005 /db alvao /key PersonalNumber
