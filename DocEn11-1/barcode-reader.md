# Barcode Reader Manager

In this window you can work with the codes read from the barcode scanner.   
  
To scan codes, select the **Symbol CS1504** or **Opticon OPN-2001** reader.The codes read in the AM Console can then be selected and entered as a property value (e.g., as a serial number), bulk create objects from the selected codes, set the time, and delete the contents of the reader.
 
- **Codes inside the reader** - display the list of barcodes read from the reader.
- **Options:**
    - **Load Codes** - retrieve codes from the reader.
    - **Set Time** - set the correct time inside the reader.
    - **Clear Reader** - clear all codes inside the reader.
    - [Create objects](barcode-reader/object-prototype) - setup bulk import of objects from selected barcodes. This option is only active if a node is selected in the tree and the manager is opened from the button bar or menu.  
 Objects will be created in the tree under the currently selected node.
    - **Status "used"** - set the *used* status (icon with green check mark) to the selected codes.
    - **Status "deleted"** - setting the status *deleted* (icon with red cross symbol) to selected codes . These codes are only erased virtually in the program memory, not inside the reader. (The **button is used to erase the reader. Clear Reader**).
    - **Search** - searches for the selected code in the properties of all objects in the entire database and displays the search result.
    - **Select** - if the window is opened using the barcode icon in the *Edit Property* window, one currently selected code can be transferred to the value of this property. The selected code will also be set to the *used* status.
- **Show "deleted"** - the list of loaded codes will also display codes that have been previously deleted.
- **Show "used"** - in the list of loaded codes it will also display codes that have been previously used.

> [!CAUTION]
> The contents of the code table and the code statuses (deleted, used) are stored only in the program memory and everything in this window is irretrievably lost when the AM Console exits.
