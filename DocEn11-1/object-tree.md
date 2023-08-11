# Object tree
     
Each tree item represents one [object](../../alvao-asset-management/objects-and-properties) in Asset Management.  
         For more on the logic behind creating an object tree, see [Tree Structure Design](../../alvao-asset-management/implementation/tree-design).
      
Local menu options in **Object Tree**:
     
- [New object](edit/new-object)
            - create a new object as a child of the object selected in the tree.
- [New computer](edit/new-computer)
            - create a new object of type computer as a child object selected in the tree.
- [New request](../alvao-webapp/requests/new-request) - create a new request in [ALVAO Service Desk](../../alvao-service-desk) related to the selected objects.
- [Add to request](add-objects-to-ticket)
            - Add selected objects to the [Objects item](../alvao-webapp/requests/table-of-requests) of an existing request in [ALVAO Service Desk](../../alvao-service-desk).
- **Related Requests** - view requests in [ALVAO Service Desk](../../alvao-service-desk) that are related to the selected object.
- **Remove** - remove the selected object (which can then be inserted elsewhere).
- **Copy** - copy the selected object.
- **Paste** - paste an object from the clipboard as a child object of the selected object.
- **Delete** - delete the selected object.
- [Move](object/choose-object) - move the selected object.
- [Change quantity](change-quantity)
            - allows you to change the *Quantity* property of objects that have this property.
- **Print** - displays information about the selected object in the print preview. Select the one that suits you best from the offered [templates](../alvao-webapp/administration/asset-management/print-report-templates). For some, you will need [Specify query parameters](file/query-parameters).  

            If you select a report for the **Transfer Protocol**, the appropriate window will open to fill in the necessary handover information:
    - [Internal handover protocol](../alvao-webapp/objects/object/print)
    - [External handover protocol](../alvao-webapp/objects/object/print)
- [Edit](edit/object)
            - edit the data of the selected object.
- [Administrator Tools](admin-tools)
            - commands for object administration available only to the administrator.

Local menu options in the **Object Tree** if the selected object is a **computer**:

- [Detect](edit/detection)
            - Detect the selected computer (can be detected using the saved settings for the computer, or edit the settings once).
- [Detection settings](edit/detection/detection-setup) - edit the detection settings for the selected computer.
- **Ping** - determine if a computer at a given IP address responds.
- [Rename computer](computer-name)
            - rename the network name to the selected computer in the tree.
- [Hardware](tab-view/detection/detail/hardware) - view the hardware detection details of the selected computer.
- **Software**
    - [Assign licenses](assign-licenses)
                - bulk assign a license to a given computer.
    - [Installation registry](software/installation-registry) - view the installation registry for a given computer.
    - [License registry](software/license-registry) - view the license registry for a given computer.
    - [Details](tab-view/detection/detail/software) - view details of the software detection for the selected computer.

Local menu options in **Object Tree** if the selected object is a **user**:

- **Software**
    - [Assign licenses](assign-licenses)
                    - bulk assignment of a license to a given user.
    - [License registry](software/license-registry) - view the license registry for a given computer.
