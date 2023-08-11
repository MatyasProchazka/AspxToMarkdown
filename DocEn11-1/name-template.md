# User Name Template
     
The user name template specifies the format of the user names in Alvao, e.g. "Veronika Kind" or "Kind Veronika".  By default, the template contains the AD attribute *cn*, which typically contains the user's first and last name.
     
You can change the template by running this SQL script on the Alvao database:
     
exec dbo.spUpdateInsertProperty 'ImportUsersLDAP.PersonNamePattern', 'cn', null, null.
     
Replace the 'cn' argument with the new template. You can use any AD attributes of the *User* object separated by a space in the template, for example:

| Attribute name in AD | Value |
| --- | --- |
| cn | First and last name |
| displayName | DisplayName for display in the contacts directory |
| givenName | First name |
| sn | Surname |

Example template for the "Last Name First Name" format:
     
exec dbo.spUpdateInsertProperty 'ImportUsersLDAP.PersonNamePattern', 'sn givenName', null, null, null
