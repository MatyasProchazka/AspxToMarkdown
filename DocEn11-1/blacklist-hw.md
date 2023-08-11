# Blacklist HW

        If it happens that nonsensical values are detected during the HW detection, it is possible to remove them during the detection processing. The table in the **tblWbemObjectProcess** database is used for this purpose. The table already contains some system values by default.
## Description of the table

        Table columns:
- **txtCASS**- the abbreviated part of the WMI class name of the detected object - usual values:
    - **DesktopMonitor** - monitor
    - **BaseBoard** - motherboard
    - **PhysicalMedia** - hard disk drive (HDD serial number)
    - **NetworkAdapter** - network card
- **txtPropName** - Name of the property in WMI - e.g. SerialNumber, Caption, etc.
- **txtPropValue** - A nonsense value that is detected, e.g. 000000, etc.
- **bolSetObjectAsVirtual** - If the value here is True, the object will be marked as "virtual" - the corresponding object will not be created in the object tree after detection, but will be visible in the HW detection details. It is useful e.g. for marking virtual CDROMs etc.
- **bolClearObjectProp** - if the value here is True, the detected (nonsense) value will be replaced with an empty value during processing.

> [!NOTE]
> In the **bolSetObjectAsVirtual** and **bolClearObjectProp** columns, only one value must always be **True** and the other must always be **False**.

## Supervisor: we bought a PC where the serial number of the motherboard has the same value

        The value in the motherboard serial number is the same for all computers: 00000000. After detection, a HW collision is reported (the detected components are in another PC).
        
### Procedure to fix the problem

1. Modify the **tblWbemObjectProcess** table, e.g. using Microsoft SQL Server Management Studio.
2. Insert a new row where:
    - **txtCLASS** - insert value: BaseBoard
    - **txtPropName** - insert value: SerialNumber
    - **txtPropValue** - insert value: 00000000
    - **bolSetObjectAsVirtual** - insert value: False
    - **bolClearObjectProp** - insert value: True
3. Save the change in the table.
4. Re-evaluate all HW detections of computers that had a collision during detection due to the same motherboard serial number (00000000).
