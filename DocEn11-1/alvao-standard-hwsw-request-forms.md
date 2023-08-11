# ALVAO Standard HW/SW Request Forms
     This module supports the process of requesting pre-approved hardware and software.     
## Technical Requirements
     
- ALVAO Asset Management
- ALVAO Service Desk

## Installation
     
In the application **ALVAO WebApp - Administration - Licenses** select **Insert Activation Key** and enter the activation key that you obtain from your Alvao system vendor.
     
On the server where the **ALVAO WebApp** is installed,run the installation package **AlvaoStandardHWSWRequestForms.msi**         and follow the instructions in the wizard.

> [!NOTE]
> The module is only in Czech and is not localized to other languages.

## Create a custom HW request form
     
Copy the Custom/Templates/StandardHwSwRequestForm/StandardHwSwRequestForm\_Hw\_NewTicket.cshtml file to the Custom/&lt;function\_name&gt; folder and the Custom/Templates/StandardHwSwRequestForm/Code/StandardHwSwRequestForm\_Hw\_NewTicket.cs file to the Custom/&lt;function\_name&gt;/Code/ folder. You can rename the files, but name both files (.cshtml and .cs) the same.

1. In the namespace name at the beginning of the .cs file, replace the trailing "Templates.StandardHwSwRequestForm" with the name of the functionality, i.e. Alvao.ServiceDesk.ServiceDeskWebApp.Custom.&lt;functionality\_name&gt;.
2. If you have renamed the .cs file, change the class name (at the beginning of the file by the keyword class) to &lt;filename&gt;Controller.

> [!CAUTION]
> The file names of all forms used must be unique. If you use multiple different forms, you need to ensure that the name of the StandardHwSwRequestForm\_Hw\_NewTicketController class is unique.

### Devices offered

1. HW Request (type *HW Request - Catalog*)
    1. Notebooks (type *HW request - category*)
        1. Standard Laptop (type *HW Request - Item*)
    2. Desktop computers (type *HW request - category*)
        1. Standard PC (type *HW request - item*)
    3. Monitors (type *HW request - category*)
2. Standard Monitor (type *HW Request - Item*)

> [!TIP]
> If you want to record additional properties in the item objects for catalog management purposes, but they should not be displayed to users in the form, in the *HW Request - Catalog* object in the *Hidden Properties* property, provide a comma-separated list of these properties, e.g. "Last updated (date), Url in supplier's e-shop".

Categories and items are displayed on the form in alphabetical order by object name. If you want to display objects in a different order, use the *Order* property.

> [!TIP]
> > [!NOTE]

> ### Device images

      
### Edit HW Request Form

1. **folderName** - enter the name of the folder including the path in the tree that contains each category of devices offered, e.g. **"HW request"**.
2. **categoryObjectKind** - specify the type of objects that represent the categories, e.g. **"HW Request - Category"**. Sub-objects of these categories will appear on the form as offered devices. Objects that do not have a **categoryObjectKind** will not be displayed on the form as category objects (and their subobjects will not be displayed).

> [!CAUTION]
> The user can request any child of the object specified by the **folderName** and **categoryObjectKind** variables (i.e., even an object that they would not have access to in the Asset Managment tree).

3. **categories**
        - specify the category names (e.g. "Monitors, Laptops") to be displayed on the form. If the variable is empty, all categories are displayed.

> [!TIP]
> The display of objects and their properties can be edited in the .cshtml file. For more information on editing forms, see [Custom form for submitting a new request](../modules/alvao-sd-custom-apps/custom-form-template).

## Create your own SW request form
     
Follow the same steps as creating a custom HW request form, but use the Custom/Templates/StandardHwSwRequestForm/Code/StandardHwSwRequestForm\_Sw\_NewTicket.cshtml and Custom/Templates/StandardHwSwRequestForm/Code/StandardHwSwRequestForm\_Sw\_NewTicket.cs files.
     
The form displays software products that are in approved state, for more see [product status](../alvao-asset-management/software-management/product-state).
     
It is not possible to set the display of images for individual products in this form.

> [!TIP]
> For more information on editing forms, see [Custom form for submitting a new request](../modules/alvao-sd-custom-apps/custom-form-template).

## Service Settings
     
In **ALVAO WebApp - Administration - Service Desk - Services**, create a service (for example, **IT/Request for New HW**),that will use the form, or use an existing one. Use one service for each form. Set up the form for this service.

1. In **ALVAO WebApp - Administration - Service Desk - Services**, in the service tree, select the service (IT/New HW Request) and use the **Edit - New Request Form** command.
2. Change the **Form design** section to **Custom Form (URL)** and set the value to the address used by the request form, for example ~/Custom/&lt;feature\_name&gt;/&lt;form\_name&gt;.

> [!NOTE]
> If the address begins with http or https, it is used as is. Otherwise, the path to the root of the **ALVAO WebApp** is automatically added to the beginning.

Set the service process. You can use an existing process or create a new one.

> [!CAUTION]
> The status entered by creating a request must not have any mandatory items.
