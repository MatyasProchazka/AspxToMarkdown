# New computer
 
In this window you can create new computers in the Asset Management database. You can automatically create computers that are detected on the network, or manually add a computer.

- **Search for new computers on the network** - select to search the network and create computers that are newly discovered on the network.
- **Create computer manually**- select if you want to create a new computer in the database.
    - **Object kind** - select from the [object kind](../../../alvao-asset-management/implementation/node-class) of the computer type. 

> [!NOTE]
> In order to select a computer object kind, a template must exist for that type. Therefore, only types with an existing template are displayed in the menu.  

 You can change the default object kind in **ALVAO WebApp** - **Management** - **Message**
 Asset Management - **Settings** -
 [General](../../alvao-webapp/administration/asset-management/settings/general).
    - **Hostname** - Enter a unique name for the computer on your network.  

> [!NOTE]
> If a numeric range is active for the selected computer type, the name will be automatically generated according to the computer type and the order of its creation in Asset Management.  

 Therefore, you cannot manually enter a name.
    - **Detect computer details over the network using saved settings** - enable if you want to automatically schedule detections for a new computer (according to [global detection settings](../../alvao-webapp/administration/asset-management/settings/detection) set in administration).
