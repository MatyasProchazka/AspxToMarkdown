# Mapping Active Directory Attributes to Object Properties
     
The ALVAO Asset Management system allows you to retrieve data from Active Directory. Organizational objects, users, and computers are retrieved by default. To configure the retrieval of data from Active Directory, the tblADMap database table is used, which describes the mapping of the Active Directory object structure to ALVAO Asset Management objects.
     ![tblADMap](tblADMap.png)     
**Description of the tblADMap table:**
     
- **lintClassId** - the object kind, e.g. **5**,
 **47**, **48**, **49**, **50** - computer (see below); **7** - user; **30** - folder.
            
    Computer types: **5** -   Computer/desktop, **47** - Computer/laptop, **47** - Computer/notebook, **48** - Computer/virtual, **49** - Computer/terminal, **50** - Computer/server.
- **lintKindld** - object property identifier corresponding to the value of the intKindId attribute in the tblKind table. If you do not fill in this field, the value is loaded from Active Directory into the object name.
- **txtADClass** - the name of the Active Directory object class.
- **txtADAttr** - the name of the Active Directory object attribute. Special values are allowed: **sAMAccountNameWithDomain** - the username (sAMAccountName) with the entire domain, **lastFound** - the date the object was last found in AD, **Alvao.computerName** - the computer name (the value is governed by the [List-of-windows/alvao-asset-management-console/tools/settings/general">In computer names, specify the domain name (FQDN))](../../../../../list-of-windows/alvao-asset-management-console/tools/settings/general).
- **bolKey** - a value of True means that the attribute is unique.  

> [!CAUTION]
> Each class in the tblADMap table must have only one attribute that is unique.

In the tblADMap table, you can configure the loading of additional properties from Active Directory into ALVAO Asset Management.
     
For example, if you want to load the phone number property of a user from Active Directory into the phone property of the user object in ALVAO Asset Management, do the following:

1. Open the tblADMap table for editing.
2. Enter the values *in the lintClassId column.  "7"*- user.
3. Enter the *values in the lintKindld column.  "45"* - the Phone property (it is necessary to find out in the tblKind table what intKindId the Phone property has).
4. In the txtADClass column, enter *"user"*.
5. In the txtADAttr column, enter *"telephoneNumber"*.
6. In the bolKey column, enter the values *"False"*.
