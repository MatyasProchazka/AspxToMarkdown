# Move object
     
You can easily move objects in the tree by drag & drop or using the windows clipboard (Ctrl+X         and Ctrl+V). If the tree is larger, dragging objects with the mouse or clipboard may be inconvenient. In that case, do the following:
     
1. In the tree, right-click the object you want to move.  

> [!NOTE]
> You can also select multiple objects at once by holding down the Ctrl or Shift keys.

2. From the local menu, select the command - **Move**.
3. A window will appear [Select the target object](../../list-of-windows/alvao-asset-management-console/object/choose-object), in which you select the object to which you want to move the first object and press the **OK** button.
4. You can display the [Date and Time](../../list-of-windows/alvao-asset-management-console/date-time) to enter the actual date and time of the move if you are backdating the move.
5. The object will be displayed in the new location. 

> [!TIP]
> When in the [Date and Time](../../list-of-windows/alvao-asset-management-console/date-time) to enter the date and time, if you enable the **Don't show this window next time and use the current date and time** option, the window will not open next time. You can enable it again with **Tools - Settings**, where on the **General** tab

 disable the **Create history records with current date and time** option.
6. After moving the object, you can print the [transfer protocol](../documents/transfer-protocols).

## Return last moved object
      
To return the last moved object to its original position, do the following:

1. Use the **Edit-Return Last Moved** main menu command (Ctrl+Z).
2. The object is returned to its original position in the object tree.
3. The history displays both back and forth moves.

> [!TIP]
> When moving back, the rights in the object tree are ignored. So even objects that were accidentally deleted (moved to the trash) can be returned.

> [!CAUTION]
> Permanently removed objects (deleted objects from the trash) cannot be moved back.

> [!NOTE]
> - History is kept only about the last move

- History is only kept while the active AM Console window is running
- History is deleted:
    - by permanently deleting an object
    - by switching to another database
