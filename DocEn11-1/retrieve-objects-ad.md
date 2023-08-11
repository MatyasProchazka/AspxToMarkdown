# Load objects from Active Directory
 
In this Window, you can retrieve objects from Microsoft Active Directory (AD).

- **LDAP path** - Enter the path to the Active Directory folder from which you want to retrieve objects.
- **Login**
    - **Use Windows Integrated Authentication**
 - Select if you want to log in to ActiveDirectory under the currently logged in Windows user,
    - **Use name and password** - select if you want to log in to the service using a name and password, and fill in these details.
- **Load objects**- enable the types of objects you want to load:
    - **Computer** - AD class: computer,
    - **User** - AD class: user,
    - **Organizational Unit** - AD class: organizationalUnit.
- **Search in**- select the AD tree search level:
    - **Only in specified path** - search for objects only in the specified path (folder).
    - **Including subfolders** - search for objects in the specified path (folder) and in all subfolders.
