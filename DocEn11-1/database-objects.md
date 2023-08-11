# Custom object selection functions
     
The *Objects* field is used to add [objects](../../alvao-asset-management/objects-and-properties) from ALVAO Asset Management to the **Objects** tab on the ../../list-of-windows/alvao-webapp/requests/requestpage. This is an input field with a drop-down menu.
      
## System Behaviour
     
In the input field, the icon of the selected object and its name are displayed.
     
If the user does not enter any text in the input field, the drop-down menu offers the objects that are entrusted to the current requester for use (located below it in the object tree) and the assets for which [is responsible for](../../alvao-asset-management/implementation/tree-design). If the user enters part of the object name, path in the tree, inventory, serial or registration number in the input field, the menu will display objects matching the entered text. The user can also specify the type of object, e.g., if the user enters "monitor: dell", it searches for all objects of type *Monitor*, whose name starts with the string *dell*.
     
Only objects that the user has the right to see in the object tree are displayed in the menu. Computer components and objects of type *Assembly* are not displayed.  The offered objects are sorted by path in the tree, then by object kind and object name.
      
## Custom functions
     
If you want to change the system behavior of the array, e.g. search objects by values of other properties, create a new function **ftDeviceSearch-Custom2** in the database that will return the contents of the drop-down menu according to the specified parameters. The function must have the same parameters and the same output format as the system function [dbo.ftDeviceSearch](../../alvao-asset-management/implementation/customization/database#TF-dbo.ftDeviceSearch).
