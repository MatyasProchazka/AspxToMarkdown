# Views
     
You can save different table settings, such as column widths and order, how to sort values and filter settings as views.
     
To create a personal view, use the **Create a copy of a view** command found in the local menu on the table header. A bookmarks bar will appear above the table, with the new view as a new bookmark. The new view is a copy of the currently selected view. After you enter a name for the new view, you can edit the table settings. You can then switch between views by simply clicking on the appropriate tab above the table. If the table contains only one view, the view tab bar is not displayed.
     
The tab bar displays pinned views. A new view is pinned by default. Using the **Unpin** command from the local menu will move its bookmark from the bookmark strip to the drop-down menu, which is accessible with the **...** command. You can view a maximum of one unpinned view in the bookmarks bar. You can then pin the unpinned view, either by using the **Pin** command from the local menu, or by moving its bookmark to a different position.
     
To remove a view, simply right-click on the tab of the view you want to remove and select **Delete** from the local menu.
     
Views can also be renamed again using the local menu above the bookmarks - right-click on the tab of the view you want to rename and select **Rename** from the local menu. A box will appear in which you can change the name of the view.
     
Views that have had their settings modified are displayed with the **\*** at the end of the name, e.g. **All\***. If you want to keep the changes to the settings until the next time you open the window, save them with **Save view settings**         from the local menu above the view tab or table header. If you do not save the settings before closing the table window, the next time you view the table, the original settings will be used. You can also restore unsaved view settings to their last saved state using the **Restore View Settings** command.

> [!NOTE]
> Also save the newly created views, otherwise they won't show up the next time you load the table. Deleting views does not need to be saved. 

The order of views can be changed by grabbing the view tab with the mouse and dragging it to the appropriate location. If you drag a view with the mouse outside the bookmarks bar and drag it again to the bookmarks bar at a different location, the view you dragged and the view you hovered over will swap order. In the Alvao WebApp, use the **Move** command to change the order of the views, available from the local menu. Enter a numeric value to move the view tab to the appropriate position.
      ![Views above table](views.PNG)      
## Shared Views
     
If several users are using one or more identically set views, each user does not have to set these views, but it is enough for one user to create and set the views and then provide them to the others as **shared views**. The user who created the shared views is the **owner** of those views, and can only edit those views and determine who can use them.
      
### Shared View
     
1. In the menu of any view, display the **Shared Views** drop-down menu and select the view you wish to view.
2. The view will be displayed in the bookmarks bar and behaves just like an unpinned view. If you wish to pin it, select **Pin** from the view menu.
The pinned shared view is no longer displayed in the shared view menu.

> [!TIP]
> If the owner of a shared view changes the view, the changes will be reflected to all users who use the view. If you do not want to accept these changes, use the **Create a copy of the view** command to create a personal copy of the shared view.

> [!NOTE]
> In the shared views menu, the owner of the view is listed after the title of the view.

### Sharing the View

1. Show the view you want to share.
2. Select **Share** from the view menu.
3. Select one or more users or groups to share the view with.
4. Confirm your selection with **OK**.

All selected users, including members of the selected groups, will then see the view in their shared view menu from which they can use the view. The user who shared the view is the owner of the view and only they can edit the shared view.

> [!NOTE]
> Sharing views is only possible with a group in which you are a member and which contains other users.

> [!NOTE]
> Users who are just requesters cannot share views.

### Changing the Shared View
      
A shared view can only be edited by its owner by editing the view in the normal way and saving the changes using the **Save View Settings** command. The changes made will be reflected for all users who use the shared view.
     
If you are not the owner of the shared view, or if you want to create a new personal view from the shared view, create a copy of the selected view using the **Create a copy of the view** command and save it using the **Save view settings** command, if necessary.

> [!NOTE]
> The **Save View Settings** command for a shared view is only available to its owner and administrator.

### Setting up sharing and changing the owner

1. If you wish to change the users or groups with whom the view is shared, or the owner of the view, select **Share Settings** from the menu.
2. Make the desired changes and confirm with **OK**.

> [!CAUTION]
> If you pass ownership of the view to another user, you will no longer be able to edit the view.

> [!NOTE]
> Only the owner and administrator can change the share and owner.

### Cancel sharing

1. If you wish to cancel sharing with all users, use the **Share Settings** command in the shared view menu.
2. In the sharing settings dialog, remove all people and groups to whom you are sharing the view and confirm with **OK**.
3. The shared view will become your own (or the view of the last owner of the shared view) and will disappear from the shared view menu for other users. If a user had a view pinned, the view will remain but will be converted to their own.
