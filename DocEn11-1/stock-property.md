# Stacking assets
     
## Preparation of stacking

1. Check the contents of the delivery, especially the types of equipment and quantities.
2. ***Optional:*** Attach an inventory or registration number (a barcode label from a pre-printed series) to each item. Write the assigned inventory number or registration number in pencil on the delivery note for each item.
3. If you are using a barcode scanner, take serial numbers from each item in turn.
If an item does not have a serial number, skip it.4. ***Optional:*** If you are immediately assigning an inventory or record number when you stack, use the scanner to take the serial number of item 1, then the inventory (or record) number of item 1, the serial number of item 2, the inventory (or record) number of item 2, and so on for all items in the shipment.

Recommendation:

            If the item does not have a serial or inventory (or registration) number, remove another code instead to maintain the sequence serial number - inventory/registration number - serial number -
 serial number - inventory/registration number - etc. Then edit the list of retrieved codes after loading them into the computer.

## Loading
     
In the AM Console for each item on the delivery note in turn:
.1. Create an object ([Adding an object to the tree](inserting-object-in-tree)) in the Warehouse folder ([Supplies Warehouse](material-warehouse)).
2. Fill in the properties for it:
    - **Name** (the computer does not have this property),**Manufacturer**, **Serial Number**.
If multiple units of the same device are to be stocked, do not fill in the serial number. To be entered later    - **Purchase Date**, **Supplier**, **Supplier**, **Supplier**,
 **Delivery note - number**
You can copy these properties from an already stocked asset**from the same delivery note**as follows:        1. Select one already stocked property in the tree.
        2. On the **Properties** tab, select the properties "Purchase date", Supplier, "Delivery note -
 Number" and press **Ctrl+C**.
        3. Select the asset currently being stocked in the tree and press **Ctrl+V**. Confirm the overwrite of existing properties.
    - **Warranty** (date until which the warranty is valid)
    - ***Optional:***Enter "Inventory Number" or "Registration Number". If you are using a barcode scanner, you can retrieve the inventory number from the scanner similar to the serial number. If multiple pieces of the same equipment are to be stocked, do not fill in the inventory (or registration) number. It will be entered later.
3. If you are stacking a computer and need to assign licenses directly, use the "Assign licenses" command from the local menu.
4. If multiple units of the same device are to be stacked, create additional objects as follows:
    - Copy the first object.
    - Enter the "Serial Number" and possibly also the "Inventory Number"
5. Deliver the delivery note to the accounting department.

Recommendation:

            If the inventory number is assigned retrospectively and the asset does not have a serial or registration number and it is not clear from the name of the asset what item on the delivery note it is, add the asset ID in pencil to the relevant items on the delivery note. This will make it easier to identify the delivery note items in the accounts department.
