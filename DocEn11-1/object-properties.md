# Edit object properties
     
You can edit object properties on the **Properties** tab. in the [main window](../../list-of-windows/alvao-asset-management-console).
     
Only the administrator can add and remove properties to/from objects in [Object Templates](../implementation/object-templates).
     
## Edit property value
     
1. Select the property whose value you want to change and double-click it with the mouse, or press Enter or F2.

> [!NOTE]
> Some property values cannot be edited. For example, if the property value is set by detection or from AD, or if you do not have the right to change the property value.

2. The value property is switched to edit mode. Write the new value or select it from the drop-down list (dial).

> [!NOTE]
> Press Alt+Down or F4 to open the drop-down list.

3. Press Enter or Tab
            to save the change. Tab will immediately start editing the following property. Alternatively, you can use Shift+Tab to save the change and start editing the previous property. Clicking the mouse outside the input field will also save the change.

> [!NOTE]
> If you do not want to save the change, press Esc.

> [!TIP]
> When you enter a URL or disk path into the property, the value will be displayed as a link that you can click on with your mouse.

          
Supported link types:
.- Web URLs (e.g.: http://, ftp://, file://)
- Path to local disks (e.g.: C:\...)
- UNC path (\\server\...)

        If the disk path contains spaces, replace them with the string "*%20*" and write the path as a URL.  

        For example, the path:

        *D:\file with space.jpg*  

        write it like this:  

        *file:///D:/File%20with%20gap.jpg*

## Insert barcode into value

1. Select the property into which you want to insert the barcode value from the reader.
2. Right-click on the property and select **Insert Barcode**.
3. The CS1504 reader manager will open, where you select one barcode and confirm with **Select**. The value will be inserted into the currently selected property in the table and the entry in the Reader Manager will be marked as used.

> [!NOTE]
> Code cannot be inserted into some properties. For example, if the property value is set by detection or from AD, or if you do not have the right to change the property value.

## Additional property value generation according to the number series
     
A property can have an automatic number line set to generate property values automatically. Sometimes the value needs to be generated additionally.

1. Right-click on the property and select **Generate Value** from the local menu.
2. If a numeric series is defined for the property after the control query, a new value is generated according to the numeric series.
