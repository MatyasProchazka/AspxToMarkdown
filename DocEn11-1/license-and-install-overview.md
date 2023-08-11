# License and Installation Overview
 
In this window you will find a comparison of purchased licenses and installed software.
 
Options:

- Main Menu
    - [View](license-and-install-overview/view)
    - [Table](license-and-install-overview/table)
    - [Actions](license-and-install-overview/actions)
    - [Tools](license-and-install-overview/tools)
- **Product Table** - the top table contains a list of products. When you select a product in it, a list of computers on which the product is installed or licensed appears at the bottom of the window.
- **Devices and Users Table**- The bottom table displays the devices and users on which the selected product in the top table is installed or assigned. Record types displayed:
    1. Installations of the selected product, covered or not covered by a license.
    2. Unnecessarily assigned licenses for the selected product.
    3. Installations of another product that are covered by the license of the selected product (the information in the "Installed product" column is then different).

## Product table columns

- **Icon** - icon ![](../tools/stocktaking/Exclamation.png)
  is displayed for products where there is a problem with the license, software profile, or product status.
- **Product** - the name of the product.
- **Operating System** - information on whether the product is an "operating system".
- **Publisher** - the publisher of the product.
- **Installations without assigned licenses** - number of installations of the product that are not covered by any license.
- **Risk** - a numerical value that can be used to estimate the risk associated with using unlicensed software - this value shows the number = product price x number of missing licenses. In order to display this value, the price of the product needs to be added to the monitored products. The price can be set in the product overview e.g. using **Software - Products (software)**
 and inserting the value with the price of the respective software.
- **Installations assigned without reason** - the number of licenses that are allocated but no product is installed that the license could cover.  

> [!NOTE]
> "OEM" and "CAL" licenses are not counted in the number of unnecessary licenses allocated.

- **Inconsistency** - the difference between the number of licenses purchased and the number of installations. A negative number in this column means that the specified number of licenses for the product is missing. Purchased licenses should be entered in [License registry](../../../alvao-asset-management/software-management/licenses).

> [!NOTE]
> Each product installation that does not have a license assigned draws just 1 license, even in the case of a kernel license. Therefore, in the case of installations with no kernel licenses assigned, this column will likely display a higher value than the actual number of free licenses.

- **Licenses in stock (per device)** - The number of available (free) licenses in stock for licenses per device. For multilicenses, "999999" is specified.
- **Licenses in stock (per user)** - the number of available (free) licenses in stock for licenses per user. For multilicenses, "999999" is specified.
- **Licenses in stock (per core)** - the number of available (free) licenses in stock for licenses per core.
- **Total Licenses (per device)** - the total number of licenses purchased per device.
- **Total Licenses (per user)** - the total number of licenses purchased per user.
- **Total licenses (per core)**- total number of licenses purchased per core
- **Unlimited/Floating** - (unlimited number of licenses) - a value of Yes means that we have an unlimited number of licenses available.
- **Installations** - the total number of times the product has been installed on computers on the network.
- **Special Installations** - This attribute indicates a software installation that we don't want to draw a license, e.g., placing the product on a file server, a test installation of the product in the acceptance procedure, etc.
- **Shared License** - the number of installations on laptops that are covered by a desktop license. Some products can be installed on both the desktop and laptop of a single user under a single license. This column indicates the number of installations on laptops.
- **Type** - Type of software. This figure is for reference only. The same products may be sold under different licenses.
- **Audit** - Should the product be displayed in this table? You can exclude a product from the evaluation by pressing the right mouse button on it and selecting the command from the menu -
  [Audit...](license-and-install-overview/audit), in which you select **No**.  

  Hidden products will be visible in this window once you enable the display of unaudited products with **Show -**.
  Unaudited Products.
- **Parameter1** - the user parameter of the product.
- **Parameter2** - user product parameter.
- **Product description** - note/description of the product.
- **Product Status** - contains the set product status.
- **Approved Version** - if the product status is set to "Approved" or "Approved - Scheduled for Decommissioning", this column contains the exact version of the approved product.
- **Product status updated by** - this indicates the person who last made a change to the product status.
- **Product status updated** - this indicates when the product status was last changed.
- **Will be excluded from operation** - if the product status is set to "Approved - scheduled to be decommissioned", this column indicates the date on which the product status will change to "Decommissioned".
- **Request** - if the product status is set to "Approving", the request number from the Service Desk where this approval is being resolved can be entered here.
- *Custom Product Items*

## Device and User Table Columns

- **Error Message** - displays the error of the assigned license, Software Profile, or product status. Icon ![](../tools/stocktaking/Exclamation.png)
  is displayed if the column displays any error message.
- **Record kind**- display the record type:
.    - ![](../tab-view/software/SwInstallation.GIF) **Installation** - the product is installed on the computer. The status of the license or software profile is displayed in the appropriate columns.
    - ![](../tab-view/software/SwLic.PNG) **License** - the license for the selected product is assigned to computers. It can be:
        - "CAL" license,
        - redundantly assigned license,
        - licenses covering installations of another product.

            For more information, see the "License Status", "License Type", and "Installed Product" columns.
    - ![](../tab-view/software/SwProfReq.GIF) **Required product** - the computer is missing an installation of a product that is defined as "required" in the software profile.
- **Object** - the name of the object in the tree on which the product is installed or licensed.
- **Path in tree** - display the path in the tree where the displayed object is located.
- **Above Object** - The parent object in the tree (e.g., User) under which the asset is located.
- **License Status** - Displays the license status for the selected product on the selected computer. Possible values.
- **Not needed** - the license for the product is not needed (it is a Freeware product).
- **Allocated** - the license for the product is allocated.
- **Missing** - a license for the product is not assigned but is needed (the product is commercial/shareware). This is an error condition.
- **Overflowing** - A license for the product is assigned to the computer, but the product is not installed on the computer (the computer is drawing a license unnecessarily). This is an error condition.
- **Special** - the installation is marked as special (shareware product, trial installation, etc.).
 The license in this case is guarded by the system administrator.
- **Shared** - a computer shares a license with another computer (e.g. a laptop shares a license with a desktop computer).

You can assign a license to a computer either in the license acquisition record in the License registry (see. [License registry](../../../alvao-asset-management/software-management/licenses)) on the **License Items** tab,   or by clicking on a computer in this list and selecting the command - Allocate a license to a computer... from the menu, which opens [Allocate license](license-and-install-overview/actions/allocate-license) window with free unallocated licenses or the command - Allocate license to computer automatically, which will automatically select the first free license. The command - Remove Computer License is used to remove the license.
      - **License from a product** - the name of the product whose license covers the product installation.
   - **License** - the name of the license that covers the product installation.
   - **License Type** - the type of license.
   - **License Model** - per device, per user, per connection, per processor.
   - **Number of assigned licences** - the number of licenses assigned to the object
   - **Activation Key** **(license)** - -
  activation key of the assigned license item.
   - **License Inventory Number** - the inventory number of the assigned license item.
   - **(License) cost center** - the cost center to which the license is assigned.
   - **Organisation (licence)** - the organisation to which the licence is assigned.
   - **License created by** - the person who created the license.
   - **The license has been created** - the date on which the license was created.
   - **License assigned/removed by** - the person who assigned the license (if assigned) or the person who last revoked the license (if not assigned).
   - **License assigned/removed** - the date the license was last assigned or revoked, if applicable.
   - **Note to license** - display the note listed for the license, shared license, or special installation -.
  depending on the license coverage of the product on the computer.
   - **Document** - the designation of the document for which the assigned license was purchased (the document is listed with the license purchase).
   - **Shares license with** - display the name of the object from which the license is shared - computer or user.
   - **Product** - display the selected product (may be useful if multiple products are selected at once in the top list).
   - **Installed Product** - the exact name of the installed product recognized by the SWLIB software product library.
   - **Special Installation** - a value of Yes indicates that this is a special installation of the product. You can change this value by pressing the right mouse button on the item and selecting - Special Installation from the menu.
   - **Installed** - the date the product was installed.
   - **Installed by** - the person who performed the installation.
   - **Detected Product** - the exact name of the installed product as detected from the system registry or an executable file.
   - **Detected Version** - the exact version value of the installed product detected by detection from the system registry or from an executable file.
   - **Detected ProductID** - the ProductID value of the installed product as detected by detection from the system registry or from an executable file.
   - **Activation Key (detected)** - display the detected activation key of the product.
   - **Software from (last software detection)** - the date when the software detection was last evaluated on the computer.
   - **Software Profile Status** - displays an indication of the status of the product installation against the software profile definition. Possible values.
- **Optional** - the product is defined in the profile as optional, or the **option is set for the computer. All software is enabled**. In this case, product installations are not tracked against the software profile.
  - **Mandatory** - the product is defined as mandatory in the profile.
  - **Disabled** - the product is defined as disabled in the profile. The product is installed, but is disabled - e.g. someone installed the product without admin approval, etc.  All products that are not enabled in the profile are disabled by default (unless all software on the computer is enabled). This is an error condition.
  - **Missing** - The product is defined as mandatory in the profile, but is not installed on the computer. This status is an error.
      
The profile settings for the computer can be set in the object tree by invoking the command - Edit.... Then the profile can be set up on the **Page**.   Object - Software Profile (this tab is only visible for objects of type "computer" and "computer assembly"). Profile settings can also be made in bulk on the **Objects - Software tab.  Computers** by invoking the **Change Software Profile...** command from the context menu.
      - **Any properties** of the object in the tree (computer or user) on which the product is installed or licensed. The columns are named by the property name with a "(object)" suffix.
      
Columns for module [ALVAO SAM Assistant](../../../modules/alvao-sam-assistant):

- **Alerts sent** - total number of alerts sent.
- **Last Alert** - the date on which the last alert was sent.
- **Next scheduled alert** - the date on which the next alert will be sent.

In the bottom table, you can also view any computer property value (even inherited), custom license entries, and custom product entries.
  
You can print the table contents using the **Table - Print** from the local menu, or you can further process the table in Microsoft Excel with **Table - Analyze in MS Excel Table**.
 
## Use scenarios

- SAM manager controls the legality of software use in the organization. It looks for software installations that are not covered by licenses and resolves them.
- SAM manager checks for unnecessary purchases of software licenses. Locates unnecessarily allocated licenses and stock licenses.
- Checks whether the detected product activation key matches the activation key of the allocated license item.
- Exports summary of selected products (installations on computers) to MS Excel

### Checking for missing licenses

1. In the AM Console, use the **Software - Overview of Licenses and Installations**.
2. Select the **View** from the top and bottom lists.
 Missing Licenses.
3. The top list shows the number of installations that are not covered by any license in the Installations with no licenses assigned column.  
For each product:
.    1. Select the product in the list with the mouse. In the list below, click the mouse button to select the product and click on it to display the list of computers that are missing licenses.
    2. Select these computers in the bottom list and assign a license to them using the "Assign license" or "Assign license automatically" commands.

#### Prioritisation by risk of sanction
    
First, address licenses for products that pose the greatest risk of penalty to the organization in the event of a software audit.
  
Recommended course of action:

1. In the AM Console, use the Software - Products command.
2. Find the major products used in your organization in the list and use the Edit command to add the indicative price of 1 license (Product - Price tab). Significant products are those that are installed on a large number of computers or have a high license price.
3. In the top list, display the Risk column. This column displays the total cost of potentially missing licenses for the product.

#### Orientation control without license allocation
   If you do not want to assign licenses to specific computers, you can check licenses only by the Inconsistency column, which must be zero or a positive number.    
### Finding unnecessarily assigned licenses

1. In the AM Console, use the Software command - "Overview of licenses and installations".
2. Select the **View** from the top and bottom lists.
 Unnecessarily assigned licenses.
3. Select one product from the list. The bottom list displays the computers on which the license is allocated but the product is not installed. You can remove the license from the computer by using the "Remove Computer License" command from the local menu.

> [!CAUTION]
> An item with a shared license in the bottom list is displayed without an icon to warn of an unassigned license. Also, in the case of a special installation, it is assumed that the system administrator is guarding such a license.

   
### Check if the detected product activation key matches the activation key of the assigned license

1. From the main menu, use **Software - License and Installation Overview**.
2. The **License and Installation Overview** window will appear.
3. Select a specific product - the bottom table will display the product installation.
4. Check that the values in the **columns match Activation Key (detected)** and **Activation Key (license)**.

### Export overview of selected products (installation on computers) to MS Excel

1. Select multiple products in the top list.
2. The bottom list shows the computers on which the selected products are installed (or have a surplus license). The **Product** column displays the product name.
3. In the bottom table from the local menu, use the **Table - Analyze in MS Excel spreadsheet**.
4. MS Excel will be displayed with a summary of the selected products.  

> [!NOTE]
> The current table view will be transferred to MS Excel -

 order and visibility of columns.

### Updating installation records
If the list below shows computers from which the product has recently been uninstalled, you can take a current software detection on those computers as follows:
1. Select the desired software from the top list.
2. In the bottom list, select the computers that should no longer have the software.
3. From the local menu, select **Detect...**.
4. A window will open to create a request for new detection, where you can set the desired detection method and, if necessary, enable the **Detect and evaluate immediately** to ensure that you see the changes in your records as soon as possible. 

> [!NOTE]
> If you select the "autonomous agent" detection method, detection will be performed depending on the current interval of the agent contacting the web service.
