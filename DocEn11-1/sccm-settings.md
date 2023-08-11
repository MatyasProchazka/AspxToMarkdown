# MS SCCM settings
      
## Hardware Inventory
      
Some properties of some classes may affect the pairing of an imported SCCM scan and an existing computer in AM (depending on the settings in ALVAO WebApp - Administration - Asset Management - Settings - Computer Identification). It is important to at least keep track of these properties in SCCM as well (in the table these classes are marked with an asterisk). However, for completeness of information about the computers in AM, it is recommended to keep track of all the necessary classes and properties, which are listed below.
      
Set classes and their properties:
     
1. In SCCM, go to **Administration - Client Settings**.
2. Select the profile you are using and select **Properties** from the local menu.
3. Select the **Hardware Inventory** tab and click **Set Classes...**.
4. Select at least the following classes and their properties:

    | **Class Name (WMI class name)**  <br>
                            List of properties, ... |
    | --- |
    | 1394 Controller (Win32\_1394Controller) |
    | Caption, Description, Name, Manufacturer |
    | \*BaseBoard (Win32\_BaseBoard) |
    | Caption, Description, Name, Manufacturer, Product, Version, SerialNumber |
    | BitLocker (Win32\_EncryptableVolume) |
    | DeviceID, Drive Letter, Protection Status |
    | Bus (Win32\_Bus) |
    | Caption, Description, Name, DeviceID |
    | CDROM Drive (Win32\_CDROMDrive) |
    | Caption, Description, Name, Drive, Manufacturer |
    | \*Computer System (Win32\_ComputerSystem) |
    | Name, Manufacturer, Domain, Caption, Model, Description, SystemType, WakeUpType, UserName, DomainRole, TotalPhysicalMemory |
    | \*Disk Drives (Win32\_DiskDrive) |
    | Caption, Size, InterfaceType, MediaType, Description, Manufacturer, DeviceID, Index |
    | \*Disk Partitions (Win32\_DiskPartition) |
    | Caption, Size, Description, DiskIndex |
    | Floppy Controller (Win32\_FloppyController) |
    | Caption, Description, Name, Manufacturer |
    | IDE Controller (Win32\_IDEController) |
    | Caption, Description, Name, Manufacturer |
    | Installed Applications - (Win32Reg\_AddRemovePrograms) |
    | Product ID, Display Name, Install Date, Publisher, Version |
    | \*Installed Software - Asset Intelligence (SMS\_InstalledSoftware) |
    | PackageCode, ProductName, InstallDate, InstalledLocation, InstallSource, Language, ProductID, ProductVersion, Publisher, UninstallString, VersionMajor, VersionMinor |
    | Keyboard (Win32\_Keyboard) |
    | Caption, PNPDeviceID, Description, Name |
    | Logged On User (Win32\_LoggedOnUser) |
    | Antecedent, Depoendent |
    | \*Logical Disk (Win32\_LogicalDisk) |
    | Caption, FileSystem, VolumeSerialNumber, Size, FreeSpace, Compressed, Description, DriveType |
    | Logon Session (Win32\_LogonSession) |
    | Caption, Description, Name, LogonId, LogonType, StartTime |
    | Modem (Win32\_POTSModem) |
    | Caption, PNPDeviceID, Description, Name, DeviceType, AttachedTo |
    | \*Network Adapter (Win32\_NetworkAdapter) |
    | Caption, Name, MACAddress, AdapterType, DeviceID, Description, Manufacturer |
    | \*Network Adapter Configuration (Win32\_NetworkAdapterConfiguration) |
    | Caption, Description, IPAddress, IPSubnet, IPEnabled, DNSServerSearchOrder, DHCPEnabled, Index, ServiceName |
    | \*Operating System (Win32\_OperatingSystem) |
    | Caption, Description, CSDVersion, Version, Organization, RegisteredUser, InstallDate, Manufacturer, SystemDirectory, SerialNumber, OSLanguage |
    | Parallel Port (Win32\_ParallelPort) |
    | Caption, Description, Name |
    | \*PC BIOS (Win32\_BIOS) |
    | Caption, Description, Name, Manufacturer, SMBIOSBIOSVersion, Version, SerialNumber |
    | PCMCIA Controller (Win32\_PCMCIAController) |
    | Caption, Description, Name, Manufacturer |
    | \*Physical Media (Win32\_PhysicalMedia) |
    | Caption, Name, Description, SerialNumber, Tag |
    | \*Physical Memory (Win32\_PhysicalMemory) |
    | Caption, Description, Name, Version, Manufacturer, Capacity, DeviceLocator, SerialNumber, DataWidth, Speed, FormFactor, MemoryType, TypeDetail |
    | \*Physical Memory Array (Win32\_PhysicalMemoryArray) |
    | Caption, Description, Name, MaxCapacity, MemoryDevices |
    | \*PNP Device Driver (Win32\_PnpEntity) |
    | Caption, Description, Manufacturer, PNPDeviceID, Service |
    | Pointing Device (Win32\_PointingDevice) |
    | Caption, Description, Name, Manufacturer |
    | Printer Device (Win32\_Printer) |
    | Caption, Description, Name, PortName, PNPDeviceID |
    | \*Processor (SMS\_Processor) |
    | Caption, Description, Name, MaxClockSpeed, ProcessorId, Version, SocketDesignation, Manufacturer, NumberOfLogicalProcessors, NumberOfCores |
    | SCSI Controller (Win32\_SCSIController) |
    | Caption, Description, Name, Manufacturer |
    | Serial Ports (Win32\_SerialPort) |
    | Caption, Description, Name |
    | \*Sound Devices (Win32\_SoundDevice) |
    | Caption, Description, Name, Manufacturer |
    | System Enclosure (Win32\_SystemEnclosure) |
    | Caption, ChassisTypes, Description, Name |
    | Uninterruptible Power Supply (Win32\_UninterruptiblePowerSupply) |
    | Caption, Description, Name, UPSPort |
    | USB Controller (Win32\_USBController) |
    | Caption, Description, Name, Manufacturer, PNPDeviceID |
    | \*Video Controller (Win32\_VideoController) |
    | Caption, AdapterRAM, VideoModeDescription, CurrentRefreshRate, MaxRefreshRate, Monochrome, Description, PNPDeviceID |
    | Volume (Win32\_Volume) |
    | DeviceID, Capacity, Caption, Compressed, Description, DriveLetter, DriveType, FileSystem, FreeSpace, Name, SerialNumber |
    | \*WmiMonitorId (WmiMonitorId) |
    | Active, UserFriendlyNameLength, UserFriendlyName, ManufacturerName, InstanceName, SerialNumberID  <br>
> [!NOTE]
> The class is located in the namespace "root\wmi" |

    | \*WmiMonitorBasicDisplayParams (WmiMonitorBasicDisplayParams) |
    | Active, InstanceName, MaxHorizontalImageSize, MaxVerticalImageSize  <br>
> [!NOTE]
> The class is located in the namespace "root\wmi" |


If one of the listed classes does not appear in the list, you probably do not have it added in the **Default Client Settings** profile. To add a new class to the list, use the following procedure:

1. In **Client Settings**, select the **Default Client Settings** profile and again go to **Properties**- **Hardware Inventory** - **Set Classes...**.
2. Select **Add...** followed by **Connect...**
3. Enter the **computer name** and **WMI namespace** where you want to search for the classes.

> [!NOTE]
> All of the above classes can be found in the namespace "root\cimv2" unless otherwise noted for the class.

4. Turn on the **Recursive** option and select **Connect**.
5. After a moment, a list of classes found in the namespace will be displayed, where you can search for the desired class, turn it on, and select **OK**.
6. Now you can edit the profile you are using and turn on the added class and its properties.

## Software Inventory
      
To keep track of software on SCCM computers, you need to set up exe file tracking on users' disks.
      
Make this setting in:

1. In SCCM, go to **Administration - Client Settings**.
2. Select the settings in use and select **Properties** from the local menu.
3. Select the **Software Inventory** tab and click **Set Types**.
4. If you don't already have **\*.exe** in the list, add it. Select the location to be searched, and whether to search subfolders as well. Optionally, you can set to monitor compressed files, and files in the **Windows** folder.
