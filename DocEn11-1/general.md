# General
 
This tab allows you to edit the basic license information written in [Licence registry](../../../../../../alvao-asset-management/software-management/licenses).

Options:

- **License Name** - enter the full name of the license. By default, the name is the same as the product name. If you are working with [License Package](../edit-license), you need to enter the license name manually.
- [Product](../../../products)
 - select the product name from the menu or use the **button ...**
 button to select it in the Products window. Use the **"pencil"** button to view/edit the product.
- **Language** - enter the language of the license.
- **Count** - enter the number of licenses you own.
- **Licensing Model**- select the licensing method or CAL:
    - **per device** - allocate license items to computers.
    - **per user** - allocating license items to users. The license then covers all of the user's computers (i.e., computers that the user has under in [object tree](../../../../../../alvao-asset-management/implementation/tree-design)).
    - **per connection** - typically for server licenses, the number of active connections is limited.
    - **per processor** - typically server products are licensed by the number of processors.
    - **per core** - typically server products are licensed *per core*, i.e. by the number of compute cores in the processor.
- **License Mode** - select a license mode from the menu or enter your own.
- **Valid from** - entering the date of the beginning of the license validity.
- **Valid to** - enter the expiry date of the licence if the licence is time limited.
- **Upgrade/Support Until** - write the date when the product support expires (and an upgrade is required).
- **Reminder** - write the date when the system should remind you of the upcoming expiration of, for example, a time-limited license or to renew the product. The reminder will appear in the reminder list and automatically alert at the specified time.
- **License type**- select the license type.
    - **Normal** - normal license or multilicense.
    - **Unlimited volume license** - license for unlimited installations, uses and users.
    - **Floating** - use of licenses is protected by special software, hardware key or access rights. A license can be assigned to more entities than the number set in the number field.
    - **OEM** - OEM license when a new computer or device (component) is purchased.
    - **CAL** - a CAL (client access license), or a license for a product that has no installation on the computer. This license will not be reported as "surplus".
- **Hardlock** - enable if the license requires hardware key protection. The "Hardlock" flag can only be registered for a floating license.
- **License Package** - enable if the license is part of a package.
- **Cover components without package installation** - disable if this license doesn’t cover the installations of parts of the package unless the package is installed. This option doesn’t affect packages on the Substitute products tab, where parts installations are always covered regardless of the installation of the package.
- **Assign automatically** - turn on if the system should automatically allocate and remove this license to all computers in the active inventory. This option cannot be enabled if the Licensing Model is set to *"per user"* or *"per kernel"* or if the *License Type* is of type *OEM license*.
    
If this option is active:
.    - The system allocates this license whenever there is any product installation that can be covered by this license and at the same time that installation is not covered by another license.
    - If the product is uninstalled (detected or manually), the system automatically releases the license again:
        - If any data is entered in the item (serial number, inventory number, cost center, etc.), the item will only cancel the computer.
        - The system automatically releases only items that have been automatically allocated. Manually allocated items are not automatically unallocated.
    - It is possible to manually allocate or move licenses (even those that were previously allocated automatically).
   
If an item is manually allocated, the system will not automatically remove it, but it will remain permanently allocated.
    - Licenses are automatically assigned according to cost center priority:
        - Cost center license and computer match (both can be blank).
        - License cost center is empty (the license is purchased for the entire organization and therefore the computer cost center can be any).

The system therefore does not automatically assign a license to a computer with a different cost center (but it is possible to do this manually).
    - Automatic assignment/deassignment occurs:
        - After some time after saving the license with the "Automatically assign" option enabled.
        - Immediately after any evaluation of the SW detection of the computer (AM Collector, manual loading of the detection result into the AM Console).
        - Once a day (at night) using the AM Collector. All computers in the inventory that can be assigned/unassigned some licenses are searched.
    - [\[Settings ...\]](../auto-assign-license-settings)
- **Allow multiple license assignment to a single object** - enable if it is possible to assign a license multiple times to the same object.
- **Activation Key** - Enter the license activation key. If you enter an activation key for a license, all newly created license entries will have the activation key automatically added according to the license's prescription. 

> [!CAUTION]
> This value will be stored in the database in unencrypted form!

- **Inventory number** - specify the inventory number under which this license will be recorded in the accounting system.
- [Certificate](../../../../tools/lists/documents) - to select a certificate from the document register.
- **Request** - enter the number of the request related to the license (e.g., the purchase request to which the purchased license relates).
- **Organization** - select the organization for which the purchased license is intended. If you do not select any value, the license will be available for all organizations. This field is only displayed to users who have the
  [Software License Security](../../../../../alvao-webapp/administration/asset-management/software-licenses-security).
  Set permissions to change licenses from at least one organization.
- **Cost Center** -  specify [cost center](../../../license-and-install-overview/view) for which the purchased license is intended. If you do not enter any value, the license will be available for all cost centers.
- **Price** - specify the price at which the license was purchased. Enter the value in integer form.
- **Download website URL** - enter the address where the software was downloaded from if it is an *internet license*.
- **License ID in external system** - enter the license identifier in the external system from which [automatically retrieves](../../../../../../alvao-asset-management/software-management/import-lic) the current information about the license.
- **Note** - enter a note about the license you purchased.
