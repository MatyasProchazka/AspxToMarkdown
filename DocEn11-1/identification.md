# Computer Identification
  
On this page, you can select information that uniquely identifies computers on the network during HW and SW detections.

The automatic update of the evidence after detection stops if:

- any discrepancy is found in the identification data, or
- some key component already exists in the records on another computer.

This can reveal, for example, a replacement computer or component.

> [!TIP]
> If you are replacing key components of the computer, record the corresponding operations in the register as well. This will avoid later detection complications. 

   
Options:

- **Computer - Network Name (always)** - the computer is always identified by its network name, so this option cannot be turned off.
- **Computer - BIOS Serial Number** - turn this on if you want to identify computers by BIOS serial number as well. 

> [!NOTE]
> This attribute is usually only detected on branded computers (Dell, HP, ...) or virtual machines.

- It is also possible to identify computers by their components. The following options only appear if the component is part of the [default object kind template for computers](general):
    - **Hard drive - Serial number, Name, Capacity** - turn on if you want to identify computers by hard disk parameters as well.  

 The key attribute of hard drives is the **Serial Number**. If the serial number is not detected for a hard drive, the system monitors the **Name** and **Size** attributes for a match in detection and registration.
    - **Network Card - MAC Address** - Enable if you want to identify computers also by the MAC address of the network card.  

> [!CAUTION]
> Laptops can connect in multiple ways (LAN, WiFi, ...).  

 Energy-efficient computers sometimes disable unused network cards, which are therefore not detected at all.  

 Therefore, it is sufficient for the system if the **MAC address** of at least one of the network cards matches in the detection and logging.
    - **Motherboard - Serial Number, Manufacturer, Type** - enable if you want to identify computers also by motherboard parameters.  

 The key attribute of motherboards is **Serial Number**. If the serial number is not detected, the system monitors whether the **Manufacturer** and **Type** attributes match in detection and registration.

> [!NOTE]
> The serial number is only detected for some motherboards - usually branded computers (Dell, HP, ...).
