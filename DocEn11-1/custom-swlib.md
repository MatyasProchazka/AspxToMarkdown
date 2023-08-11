# Custom software product library
     
A software product library is a set of rules by which the system analyzes software detections and recognizes which software products are installed on computers. You can upload the current library to the system from the Internet using the **Software - Software Product Library - Software Products Library command.Load Current Library**.

> [!TIP]
> If the system does not detect some programs and you see unrecognized records on the **Software** tab, select the unrecognized records and use the **Send SW to identify...** command from the local menu. A wizard will be displayed where you can enter advanced information for the unrecognized records, and once this wizard is complete, a request will be created and sent by Collector to our specialists. They will add the unrecognized products to the standard library. You will then be able to download the updated library from the Internet using the **Software - Software Product Library - Load Current Library** command. After downloading the new library, the records will be recognized.

> [!TIP]
> On the Software tab in [main window](../../list-of-windows/alvao-asset-management-console) of the AM Console, detected registry entries that have not been assigned to any product according to the software product library can also be displayed. If such entries are present on the tab, it means that there are products installed on the computers that could not be detected by the software product library rules.

## Adding a new product
      
You can add your own products and rules for recognizing them to the library, or you can request a new product to be added to the standard library of software products.
      
### Adding a new custom product
     
1. On the **Detection** tab on the top right of the
 [main window](../../list-of-windows/alvao-asset-management-console) of the AM Console, select the software detection that contains information about the programs you want to add to the library.
2. Right-click on the selected detection and select the command - Details from the menu.
3. A window will open on the screen [Software Detection Detail](../../list-of-windows/alvao-asset-management-console/tab-view/detection/detail/software), which displays information about files and registry entries from the detected computer.
4. In the list of files (at the top or middle of the window) or in the list of registry entries (if the window is switched to **View - Registry** mode), select the file or registry entry(s) by which you want to identify the product.
5. Right-click on the entry and select the command from the menu -
Suggest Key Rule.
6. The screen will open either a [New file-based recognition rule](../../list-of-windows/alvao-asset-management-console/tab-view/detection/detail/software/file-general) or [New rule for registry-based detection](../../list-of-windows/alvao-asset-management-console/tab-view/detection/detail/software/reg-general), depending on the view mode enabled. Both windows contain a list of identifiers that are preset according to the selected entry.
7. Click the tab [Other](../../list-of-windows/alvao-asset-management-console/tab-view/detection/detail/software/other).
8. Press the **...** button after the **Product** line. The window will open on the screen [New Product](../../list-of-windows/alvao-asset-management-console/software/products/product/general), in which you enter the name, version, publisher, and any other product information. Close the window by clicking **OK**.
9. Also close the rule definition window with the **OK** button.
10. The rule will be evaluated and the added product will appear in the list of found products on the bottom left.

> [!NOTE]
> One product can contain several key rules. If at least one file or registry entry is found on the computer's disk that matches a key rule, the system considers the product found.

### Creating checkbox rules
     
If the product contains additional executables or libraries, these files are shown in the list of unrecognized files at the top of the [Software Detection Detail](../../list-of-windows/alvao-asset-management-console/tab-view/detection/detail/software). If you don't want to see them in the list, create a "check off" rule for them as follows:

1. In the product list on the bottom left, select the actual product to which the files belong.
2. In the list of unrecognized files, select one file you want to exclude, right-click on it, and select the - command from the menu.
Suggest a deletion rule.
3. A window will open on the screen [A new file-based recognition rule](../../list-of-windows/alvao-asset-management-console/tab-view/detection/detail/software/file-general) that presets the recognition characters based on the selected file. You can modify the values if necessary. Then save the rule by clicking **OK**.
4. All files matching the created rule will disappear from the list of unrecognized files.
5. If you cannot cover all files with one rule, create additional check-off rules for the other product files one by one.

> [!CAUTION]
> You cannot create, edit, or delete rules for certified products from the software library.

> [!NOTE]
> Detections are evaluated first against key rules and then against check-off rules, so if a check-off rule overlaps with a key rule, the key rule takes precedence.

> [!NOTE]
> While the checkbox rules are assigned to specific products, this assignment is for informational purposes only. The checkbox rules do not affect what products the system finds on the computer.

### Request to add a new product to the standard library

1. From the main menu, use the **Software - Products (software)** command.
2. The window will appear [Products (software)](../../list-of-windows/alvao-asset-management-console/software/products) in which you press the **Add** button.
3. Fill in detailed information about the product you want to add to the standard library such as publisher, name, version and other details. Enable the **Add to Standard Software Product Library** and press **OK**.
4. The new product will appear in the product list and you can start using it immediately (creating licenses, etc.). At the same time, a request to add a new product is prepared and sent by Collector to our software product library specialists.
5. Once the new product is added to the library and the new library is in the system, the system will automatically replace the user's product with a new product from the standard library.

> [!NOTE]
> In order to submit a request to add a new product to the standard library, you must enable the **Submit requests for changes to the software product library over the Internet** option in the [server administration](../../list-of-windows/alvao-webapp/administration/asset-management/servers/create-server) of the Internet Connected Collector. This option can be found in the SW library settings section. Data is sent anonymously, or you can provide a contact email. This can make it easier for our specialists if they need further information about a new product.
