# Regular license purity check
      
The license manager checks the status of licenses periodically (e.g., 1x/month) as follows:
     
1. In the **ALVAO Asset Management Console**, select **Software - Overview of Licenses and Installations**.
2. In the [License and Installation Overview](../../list-of-windows/alvao-asset-management-console/software/license-and-install-overview) window, step through the products for which an exclamation point is displayed. Select each product and look at the error message for the entries with an exclamation mark in the list below.
3. If you are missing a license on a computer and have a free license available, you can assign it using the "Assign License..." command,
  "Allocate license automatically" from the local menu.  >

> [!NOTE]
> Unaudited products can be displayed by enabling the **Show - Unaudited Products** in the main menu of the window.

## Setting up alternative approved SW

1. In the AM Console, use the **Software -  Products (software)...**.
2. A list of all products will be displayed. Select the products and from the local menu use the **Set Alternate Approved Software...** command.
3. The **Set Alternate Approved Software** window appears, in which you enter a list of alternate products that users can use instead of the disabled products.
4. Finally, press the **OK** button.

> [!NOTE]
> - The set value is for informational purposes only.

- Alternative software can also be set in bulk. If you select multiple products with different values, the **Alternative approved software** is blank when the edit window is displayed.

## Setting the person who is responsible for the software on a specific PC (if not managed by the IT department)

1. In the AM Console, go to the computer template in the tree and edit the value of the "Responsible for software" property:
    1. If most of the computers are managed by the IT department - set the value to "Software Administrator on computers" (default setting).
    2. If most computers are managed by users - set the value to "[PC User]".
2. Select the computer template and use the "Object - Unify Objects" command, this will add the "Responsible for Software" property to all computers in the inventory and set them to the appropriate value.

     Optional: If most of the PCs are managed by the IT department but some of the PCs are managed by the user, locate these PCs and adjust the value of the "Responsible for software" property to "[PC user]".    

> [!NOTE]
> - You can type the name of any other user group into the value of the "Responsible for software" property.

- The system automatically delegates responsibility to the system group "Computer Software Administrator" in the following case:
    - If a computer does not have the "Software Responsible" property.
    - If no computer is placed under any user in the tree and the value of the "Responsible for software" property is "[PC user]".
    - If the value of the "Responsible for software" property does not match any group name, nor "[PC User]".

## Example of an internal directive
      
### Computers and other IT equipment

1. Computers and other IT equipment entrusted to users are registered in the ALVAO Asset Management system.
2. Each user can view the list of devices registered with them on https://server/asset.

### Software

1. The IT user must not use the software in a way that is not in accordance with the license terms for that type of software (e.g. installing illegal software, copying, redistributing or modifying the software).
2. Each computer has its own **software administrator**,
 who is responsible for the legality of the software on the computer. If the user of the computer (i.e. the user to whom the computer is entrusted for use) has software installation rights enabled, the software administrator on the computer is the user of the computer. Otherwise, the software administrator is the designated internal IT staff member.
3. Software licenses are registered in the internal ALVAO Asset Management system. The registration of licenses is handled by internal IT.
4. Software installed on company computers is automatically inventoried at least once a year.
5. If during the inventory the IT department detects a serious violation of the license conditions of a software, it immediately calls on the software administrator of the computer in question to take corrective action. Once the problem has been corrected, the computer administrator can check the result of the last inventory at [https://server/asset](https://server/asset). The software inventory on the computer is automatically performed every 24 hours after the problem is detected. After 1 month, an automatic health check is performed. If the problem with the product is still not corrected, a call is resent to the computer's software administrator. This second prompt is also copied to the software administrator's direct supervisor. It is also logged in the internal Service Desk as a task to be resolved.
