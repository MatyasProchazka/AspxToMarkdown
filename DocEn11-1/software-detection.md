# Software Detection
     
Software detections include information about files on computer disks and Windows system registry entries. The software product library is then used to create a list of installed products based on the detected data.
     
A prerequisite for a correct evaluation of software detections is an up-to-date software product library. The library is regularly updated by the AM Collector, see **WebApp - Administration - Asset Management - Servers** - [New server](../../list-of-windows/alvao-webapp/administration/asset-management/servers/create-server) - **Soft Product Library**. You can also update the library manually in **AM Console - Software - Software Products Library** - [Read the current library](../../list-of-windows/alvao-asset-management-console/software/sw-products-library/load-library-1).
     
For the system to be able to perform software detection, all the computers you want to detect must be registered in the tree. It is sufficient that an object of type *computer* exists in the tree. You do not need to perform hardware detection.For more information on how to add computers to the registry, see [Inserting Computers into Evidence](../implementation/insert-computers).
     
The process of performing detections is described in the chapter [Hardware and Software Detection](../implementation/detection).
     
After Collector performs a detection and loads it into the database, it automatically evaluates it against the software product library and updates the Installation Log.

> [!NOTE]
> When the library is loaded into the database, the application identifies itself to the Alvao service with the data contained in the activation key.

> [!TIP]
> If the system does not detect some programs and the **Software** tab you see unrecognized records, select the unrecognized records and use the **Send SW to identify...** command from the local menu. A wizard will be displayed where you can enter advanced information for the unrecognized records, and once this wizard is complete, a request will be created and sent by Collector to our specialists. They will add the unrecognized products to the standard library. You will then be able to download the updated library from the Internet using the command **Software - Software Products Library - Load current library**. After downloading the new library and re-evaluating the relevant detections, the records will be recognized.

> [!NOTE]
> You can also extend the software product library in a custom way, see [Custom software product library](custom-swlib).

> [!NOTE]
> The computer installation log is automatically updated by software detection only if this option is enabled in [detection settings](../implementation/detection#detection-options) for the computer.

> [!TIP]
> A quick overview of the software that is installed on a particular computer or in an organizational folder can be seen on the **Software** tab

in the [main window](../../list-of-windows/alvao-asset-management-console) of the AM Console.

## Installation registry
     
In the installation registry, records are kept for each computer about which program (software product) was installed on which computer when and by whom, or when it was uninstalled. Similarly, records of activation, configuration, etc. may also be recorded. When software is detected on a regular basis, the Installation Log automatically creates records of program installations or uninstallations so that the current status of the Installation Log matches the detected status.
     
Open the Installation Log either from the main menu using the **Software - Installation Log**, or by right-clicking in the tree on any computer and selecting **Software - Installation Records**.
     
In either case, the screen will display a [Installation Log](../../list-of-windows/alvao-asset-management-console/software/installation-registry) with a list of Installation Log entries. Use the buttons at the right edge of the window to edit the list.
       
### Manual Updates Installation Records
     
When a new software detection is retrieved, the Installation Log is automatically updated to match the detected state. If you want to update the Installation Log manually, you can disable the automatic update in the Detection Settings (see [Detection Settings](../implementation/detection#detection-options)) by turning off the **Software Detection** option - **Software Detection**         Update installation records.
     
After acquiring software detection, you update the Installation Log as follows:
     
1. Under the **Detection** tab in the top right [AM Console main window](../../list-of-windows/alvao-asset-management-console), select the appropriate software detection, right-click on it, and select **Software -Compare with installation status**.
2. A window will open on the screen [Installation Evidence vs. Software Detection](../../list-of-windows/alvao-asset-management-console/tab-view/detection/compare/compare-install-vs-detection) with a summary of the differences found between the selected software detection and the Installation Evidence status.
3. In the window, select the changes you want to make to the Installation Log and press the **Create Missing Entries** button.

Another option is to manually write entries to the Installation Log directly in the [Installation Log](../../list-of-windows/alvao-asset-management-console/software/installation-registry).
       
### Installation protocol
     
Installation registry performs the function of the so-called *installation protocol* according to Government Resolution No.624/01, which applies to ministries and other public administration bodies in the Czech Republic. In order to comply with this resolution, it is recommended to leave the automatic update of the Installation Register enabled according to software detections. The employee who is responsible for software installations in the organization should authorize the automatically created records of installations by entering as the person who performed the installation or uninstallation.
     
On the **Software** tab, which displays an overview of the software products on a particular computer, you can display the **Authorized Installation** column. If the column is *Yes*, the installation has been authorized (approved) by a specific person.  
         The **Installed** column can also be displayed to show the date of the installation and the worker who performed it. If the license was assigned automatically, this information is not filled in.
     
A license can be approved in two ways:

- License assignment - if the license is assigned by a person (not automatically),
this person is also the one who performed and approved the installation.
- Manual authorization - on the **Software** tab, selected products (even in bulk) can be approved for installation using the **Software** command.
Edit from the local menu.

> [!NOTE]
> A license is not required to legally use some products (e.g. *freeware*). However, if the ordinance is to be fulfilled, then if such a product is detected, it still needs to be manually authorized by the appropriate personnel, even though no license is assigned to the product.
