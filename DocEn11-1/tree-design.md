# Tree structure design
      
Now you create an object tree. The tree is displayed in the left side of the [main window](../../list-of-windows/alvao-asset-management-console).
     
The tree should have the following basic structure:
     
- organization (Organization object)
    - organizational breakdown (Organizational Component, Building,... objects)
        - ...
            - employee (User object)
                - asset (Assembly, Copier, Phone,... objects)

At the root of the tree is the Organization object, which is further subdivided into smaller units according to the appropriate organizational breakdown. In the smallest organizational units (e.g. department, division, etc.) are located individual workers (User object) and under each worker is kept the property that has been entrusted to the worker for use (e.g. computers, mobile phone,...).
      
## Heritage
     
The arrangement of objects in a tree takes advantage of the inheritance of certain properties. For example, a sales department will be represented by a Department object, which will be described by a Department property with the value "Sales Department".

- Organization
    - Department="Sales Department" (Department object)
        - ...
            - User="Petr Pěnička" (User object)
                - asset

The Department property will be *inherited* to all child objects in the Business Department. This means that if we look at the properties of the Petr Pěnička object, for example, we will also find a Department property with the value "Business Department". However, this property is defined in the parent object Department and is only inherited into the Petr Pěnička object. Therefore, the value of the Department property that we see in the Petr Pěnička object depends on which department Petr Pěnička is located in the tree. This will make it easier for us to work in a situation when a worker moves to another department, because then we only need to move the corresponding object representing the worker to another place in the tree. The situation is the same when moving assets between workers, because the object that represents the asset inherits the name of the user (the User property) to whom the asset was assigned.

> [!NOTE]
> You can set whether or not a particular property will be inherited to child objects in the **Property** window that opens when you use the **Property** command in the property list on the **Properties** tab **Edit** from the local menu to the appropriate property.

## Organizational breakdown
     
In this chapter, we will describe the process of creating an organizational breakdown tree. If you can't see the object templates and bin in the tree on the left side of the [main window](../../list-of-windows/alvao-asset-management-console), you have disabled the display of hidden objects. Use the **Show - Hidden Objects** command to show them.
     
First, edit the object at the root of the tree to represent our organization/company.

1. The new database should already contain the **&lt;Organization&gt;** object you created. Select this object in the tree.
2. On the **Properties** tab on the top right, double-click the *Organization Name* property with the mouse and enter the actual name of the organization and save the value with the ENTER key. This property is set to form the name of the object in the tree and therefore the organization name will change in the object tree as well.
3. Similarly, enter the address of the organization in the format *Name;Street;Zip Code City* as the value of the *Address* property and the organization code (abbreviation) in the *Organization Code* property.
  .

We will further divide the organization into smaller units according to the breakdown that is common for you. If your organization has one headquarters and several branches in different cities, the breakdown might look like this:

- Organization
    - Prague Headquarters
    - Ostrava branch
    - Brno Branch

Here is the procedure for inserting the headquarters:

1. In the tree, right click on the organization object and select the command - New Object from the menu.
2. In the [New Object - Select the sample object - Object Templates](../../list-of-windows/alvao-asset-management-console/edit/new-object/object-template), select *&lt;Plant&gt;* in the Organizational Structure folder and confirm with OK.
3. The enterprise object type is inserted into the tree. Select it with the mouse.
4. On the **Properties** tab on the top right, select the *enterprise* property and edit its value to "Prague Headquarters" and confirm with ENTER. The property again determines the name in the tree, so the name of the object in the tree will change automatically.

Similarly, insert objects for the Ostrava and Brno branches into the tree. Each branch will probably have further subdivisions into individual departments, etc. We will insert the department into the tree similarly to the branch, only instead of the Plant object we will use the Department object.
     
To subdivide the organization, you can use the objects that are in the *Organizational Structure* folder when you add the object to the tree, i.e.:

- Building
- Floor
- Room
- Workplace
- Division
- Department
- Department
- Network
- Subnet
- Network branch
- Storage
- Disposed assets
- A plant
- Section
- Centre

The following properties are available for describing objects:

- Building
- Division
- Office
- Room
- Department
- Department
- Floor
- Workplace
- Section
- Centre
- Location
- Section
- Unit
- Plant

Objects do not have to be described by only one property, but you can use more than one. For example, if the entire sales department is located on the second floor, you can describe it with a Department object with the properties Department="business" and Floor="2".
      
## Organisation staff
     
Organization employees are represented in the tree by the *User* object and are inserted into the tree in a similar way to organizational objects. Just select the *&lt;User&gt;* object in the object menu in the - New Object command. Each user is described by default by the properties Office (office number), User (employee name), Personal number, etc.

> [!NOTE]
> You can describe users with additional properties and you can also create completely new properties that the system does not offer by default, vi [User customization](customization).

## Majetek
     
Evidenced assets (computers, printers, phones, etc.) are also represented by objects in the tree. They are generally handled in the same way as organizational objects or employees.

> [!NOTE]
> An asset is any object that contains the property "Inventory Number" or "Registration Number". Property values can also be empty.

Each asset in an organisation is usually the responsibility of a specific person, e.g. a computer is the responsibility of the user to whom the computer has been assigned. In this case, the computer and other objects should be inserted in the tree as child objects of the respective employee:

- Václav Pěnička (user)
    - Nokia 6610 (mobile phone)
    - PC154 (computer set)

If an asset in the tree structure cannot be placed under a specific person (for example, a shared printer in the hallway), place it as a child object under an organizational structure component (for example, a department). Then, on the folder, specify the person responsible for the assets in this folder in the **Responsible for assets** property:

- IT Department (Department) - Property value "Responsible for assets" ="Michal Nový"
    - HP LaserJet Pro (printer)
    - Václav Pěnička (user) - Value of property "Responsible for assets" = "Václav Pěnička"
        - Nokia 6610 (mobile phone)
        - PC154 (computer set)

> [!NOTE]
> The value of the property "Responsible for property" is inherited by child objects. For an object of type "User", the value is automatically set to the given person. Therefore, the property under the user is still the responsibility of "Václav Pěnička".

> [!TIP]
> If you want to record the responsibility for assets that are not placed in the tree under specific users, we recommend adding the "Responsible for assets" property to the templates of the organizational structure objects and to the template of the object type "User".

No object contains this property by default.

If you need more than one person to be responsible for the assets in a room, for example, divide the assets into different folders and set different people on these folders in the "Responsible for assets" property. For example:

- Server room (Room) - value of property "Responsible for property" ="Michal Nový"
    - Servers, Václav Pěnička - value of property "Responsible for property" = "Václav Pěnička"
        - Dell PowerEdge 2950 (Computer/Server)
    - Network Elements, Petr Omáčka - value of property "Responsible for assets" = "Petr Omáčka"
        - HP 1810 (Switch)
    - PowerEdge 2420 (Rack)

> [!NOTE]
> You can also insert the "Responsible for asset" property directly into asset objects. However, to make it easier to move assets around, we recommend that you only inherit this property from Organizational Units and User type objects into asset objects.

Users can check their asset records at any time in the ALVAO WebApp - user menu - [My Directed Assets](../../list-of-windows/alvao-webapp/search/persons/person). The command is only displayed to users who are registered in the object tree and have the *User Name* property filled in. In *WebApp - Administration - [Users](../../list-of-windows/alvao-webapp/administration/users)* users do not need to be registered.  If ALVAO Service Desk is not activated, but only ALVAO Asset Management, the *My Trust Assets* page is the default.
     
Computers, monitors and some printers can be detected by the system on the network and added to the records, see [Hardware and software detection](detection). Other objects such as copiers, phones, electronic diaries, etc. need to be entered into the register like any other object, i.e. with the command - New Object. Standard types of devices and objects can then be found in the object templates in the folders.

- IT inventory
- Other inventory
- Supplies

## Read Organizational, Employee, and Computer Information from Active Directory
         
In addition to manually creating organizational structure objects and objects representing the organization's workers as described in the previous sections, you can automatically retrieve these objects from Microsoft Active Directory. The scope of the retrieved data can be user-defined.
         
The process of retrieving objects from Active Directory:

1. Select the object in the tree into which to load the organizational structure and select **Object - Load from Active Directory** from the menu.
If you want to load the organizational structure into the root of the tree, do not select any object.
2. In the [Retrieve Objects from Active Directory](../../list-of-windows/alvao-asset-management-console/object/retrieve-objects-ad), specify the **LDAP** path to the folder with the organizational breakdown in Active Directory, check the **Organizational breakdown** box,
  **User**, **Computer**, and press the **Read** button.

    **Example 1. LDAP paths**

    Path to the ALVAO folder of the ALVAO organizational structure on the ALVAO.CZ domain

    LDAP://server/ou=alvao,dc=alvao,dc=en

    Path to the IT folder in the ALVAO organizational structure on the ALVAO.CZ domain

    LDAP://server/ou=it,ou=alvao,dc=alvao,dc=en
3. The program creates new objects and adds them to the tree, which can take several minutes depending on the extent of the structure in AD.

> [!NOTE]
> When loading objects from Active Directory, the program will only load objects that are not disabled in AD.

> [!TIP]
> You can start loading information from Active Directory automatically see [ImportAD](users/authentication/ad/import-ad).
