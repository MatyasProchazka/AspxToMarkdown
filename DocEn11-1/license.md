# New license - license
   
This tab allows you to add information about the newly created license, which will be entered into [License registry](../../../../../../alvao-asset-management/software-management/licenses).
   
Options:
   
- **License Name** - enter the full name of the license so that you can uniquely identify the license later in the list. By default, the name is the same as the product name. If you are working with [License Pack](../new-license), you need to enter the license name manually.
- **Language** - select the license language if the license is tied to a specific language.
- **Count** - enter the number of licenses you own.
- **Licensing Model**- select the licensing method or CAL:
    - **per device** - assign license items to computers.
    - **per user** - allocate license items to users. The license then covers all of the user's computers (i.e., computers that the user has under in the [object tree](../../../../../../alvao-asset-management/implementation/tree-design)).
    - **per connection** - typically for server licenses, the number of active connections is limited.
    - **per processor** - typically server products are licensed by the number of processors.
    - **per core** - typically server products are licensed *per core*, i.e. by the number of compute cores in the processor.
- **License Mode** - select a license mode from the menu or enter your own.
- **Valid from** - entering the date of the beginning of the license validity.
- **Valid to** - enter the expiry date of the licence if the licence is time limited.
- **Upgrade/support to** - write the date when product support expires (and an upgrade is required).

> [!TIP]
> You can be notified by email when your license or support is about to expire. For more information, see [Maintenance Reports](../../../../../../alvao-asset-management/implementation/maintenance-reports).

- **License Type**- select the license type.
    - **Normal** - normal (boxed) license.
    - **Unlimited volume license** - license for unlimited installations, uses and users.
    - **Floating** - use of the license is protected by special software, hardware key or access rights. A license can be assigned to more entities than the number set in the number field.
    - **OEM** - OEM license when a new computer or device (component) is purchased.
    - **CAL** - A CAL (client access license), or a license for a product that has no installation on the computer. This license will not be reported as "surplus".
- **Hardlock** - enable if the license requires hardware key protection. The "Hardlock" flag can only be registered for a "floating" license.
- **License Package** - This option determines whether the license is included in the package. The option is set according to whether the **License Package** option was selected in the [New License - Product](../new-license) window.
- **Cover components without package installation** - disable if this license doesn’t cover the installations of parts of the package unless the package is installed. This option doesn’t affect packages on the Substitute products tab, where parts installations are always covered regardless of the installation of the package.
- **Assign automatically** - turn on if the system should automatically allocate and remove this license to all computers in the active inventory. This option cannot be enabled if the *License Model* is
  of type *per user*
  or *License Type* is of type *OEM license*.
    
If this option is active:
.    - The system allocates this license whenever there is any product installation that can be covered by this license and at the same time that installation is not covered by another license.
    - If the product is uninstalled (detected or manually), the system automatically releases the license again:
        - If any data is entered in the item (serial number, inventory number, cost center, etc.), the item will only cancel the computer.
        - The system automatically releases only items that have been automatically allocated. Manually allocated items are not automatically unallocated.
    - It is possible to manually allocate or move licenses (even those that were previously allocated automatically).

  If an item is manually allocated, the system will not automatically remove it, but it will remain permanently allocated.
    - Licenses are automatically assigned by organization and cost center:
        - The organization of the license and computer match, and the cost center of the license and computer match (both can be blank).
        - The license and computer organization match and the license cost center is empty (the license is purchased for the entire organization so the computer cost center can be any).
        - License is not assigned to any organization and the license and computer cost center match (both can be empty).
        - License is not assigned to any organization and the license cost center is empty (the license is purchased for the entire organization so the computer cost center can be any).

  Therefore, the system does not automatically assign a license to a computer with a different organization and cost center (but it is possible to manually assign a license from another cost center or another organization).
    - Automatic assignment/deassignment occurs:
        - After some time after saving the license with the "Automatically assign" option enabled.
        - Immediately after any evaluation of the SW detection of the computer (AM Collector, manual loading of the detection result into the AM Console).
        - Once a day (at night) using the AM Collector. All computers in the inventory that can be automatically assigned/unassigned some licenses are searched.
    - [\[Settings ...\]](../auto-assign-license-settings)
- **Allow multiple license assignment to a single object** - enable if it is possible to assign a license to the same object multiple times.
- **Activation Key** - if the license has only one activation key (multilicense), enter it in this field. Otherwise, enter activation keys in the field in the license entries. 

> [!CAUTION]
> This value will be stored in the database in unencrypted form! 

> [!NOTE]
> If you specify an activation key for a license, all newly created license entries will automatically have the activation key added according to the license's regulation.

- **Inventory number** - entering the inventory number under which this license will be recorded in the accounting system.
- [Certificate](../../../../tools/lists/documents) - select the certificate from the document register.
- **Request** - enter the number of the request related to the license (e.g., the purchase request to which the purchased license relates).
- **Organization** - select the organization for which the purchased license is intended. If you do not select any value, the license will be available for all organizations. This field only appears for users who have [Software License Security](../../../../../alvao-webapp/administration/asset-management/software-licenses-security).
  set permissions to change licenses from at least one organization.
- **Cost Center** - specify the [cost center](../../../license-and-install-overview/view) for which the purchased license is intended. If you do not enter any value, the license will be available for all cost centers.
- **Price** - specify the price at which the license was purchased. Enter the value in integer form.
- **Web download address** - enter the address where the software was downloaded from if it is an *internet license*.
- **Note** - enter a note about the purchased license.
