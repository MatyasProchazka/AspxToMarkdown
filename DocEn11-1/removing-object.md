# Removing an object
     
1. In the tree, right-click the object you want to delete.
2. From the menu, select the command - Delete (or use the DEL key).
3. After confirming the control query, a window may appear on the screen [Date and Time](../../list-of-windows/alvao-asset-management-console/date-time) to enter the actual date and time of the deletion if you are writing the change to the database after the fact.
4. Then the object disappears from the tree.

> [!TIP]
> When in the [Date and Time](../../list-of-windows/alvao-asset-management-console/date-time) to enter the date and time, if you enable the **Don't show this window next time and use the current date and time** option, the window will not open next time. You can enable it again by using **Tools - Settings**, where on the **General** tab, turn off the **MoreCreate history records with current date and time**.

> [!CAUTION]
> If are enabled [Rights in the object tree](object-access-rights), objects for which the user does not have the rights to delete all child objects cannot be deleted.

The object has not been completely deleted from the database, but has only been moved to the Trash. The Recycle Bin is not normally visible in the object tree. You can enable its display with the **View - Hidden Objects** (only a user with the *Asset Management administrators* role can do this).
     
You can move an object removed from the Recycle Bin back into the tree.
     
You can irreversibly remove the contents of the Recycle Bin from the database by right-clicking on the Recycle Bin object in the tree and selecting the command from the menu - Empty Recycle Bin.
     
Only a user with administrative rights can empty the Recycle Bin.
