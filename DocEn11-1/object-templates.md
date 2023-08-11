# Object templates
      
Object templates are object definitions that are used to create objects in the asset tree (or [Object templates](object-models)).  A template specifies what properties, icon, etc. an object should have. You can edit templates, add and remove properties from existing templates, create new templates, or delete existing templates.
       
To edit the Object Templates, you need to select **Tools - Settings** from the main menu and on the **Display** tab turn on **Show hidden objects**. In the root of the tree, the Object Templates object appears, which contains templates for creating organizational structure and assets in the tree.

> [!CAUTION]
> We do not recommend making major changes to the templates, especially in   the computer template and the computer assembly. Some objects and properties are closely tied to the entire system, prepared queries, and print reports, so modifications could lead to their non-functionality. Creating new objects and adding properties to existing objects can be considered safe editing.

> [!CAUTION]
> It is possible that future system upgrades will load new versions of the templates into the databases. For this reason, it is a good idea to keep template modifications under control so that you are able to replicate them later. It is advisable to put the new objects in one common folder called *Custom Objects*, for example. When you upgrade, you can then simply move the entire folder to the new templates.

## Modify object template
     You can add and remove object properties and edit their attributes only in the template of the object type. Changes to the template are automatically reflected in all objects of that type in the entire inventory.If you have objects of a type in the inventory that do not have a template, it is advisable to create a template for them:
1. [Copy](../objects-and-properties/copying-object) one of the existing objects in the inventory to the clipboard (Ctrl+C).
2. Paste an object from the clipboard into the object templates in the appropriate subfolder (Ctrl+V).
3. Add/remove properties or set attributes - see the following sections.

## Adding and removing properties
     
To add a new property to the list, right-click anywhere in the list and select **New Property** from the menu. The screen will open a [Properties menu](../../list-of-windows/alvao-asset-management-console/tools/lists/properties-definition), in which locate the property you want to add to the object and double-click it. Then enter a value for the property.
     
Properties are removed again in the usual way. Right-click on the property you want to remove and select **Delete**.

> [!CAUTION]
> The add property operation is not recorded in the object history, unlike the remove and edit operations.

## Changing property attributes

1. Select a property and right-click on it.
2. Select **Edit** from the menu. The window will open[Property](../../list-of-windows/alvao-asset-management-console/tab-view/properties/property-edit) with details for the selected property.

> [!NOTE]
> You can also use the Alt+Enter keys to display the window.

3. Edit the attributes (property specifies the object name, inherit property) as needed and confirm the change with **OK**.

> [!NOTE]
> Attributes can only be changed by a user with the *Asset Management administrators* role.

## Mandatory features
     If you want some properties to be mandatory (i.e. they must have a value filled in),   enable mandatory properties in **AM Console - Tools - Lists - Property Definitions - Edit -**   [Value-check](../../list-of-windows/alvao-webapp/administration/asset-management/property-definitions/detail/value-check).
