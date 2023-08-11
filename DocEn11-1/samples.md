# SQL query examples
      
## All computers in active records
     
The following query will find out the details of all computers.

    SELECT [Object name], [RAM size (GB)], [Total hard disk capacity (GB)], [CPU], [Operating system], [Graphic card], [IP addresses], [MAC addresses]
    FROM Query.ObjectEnu
    WHERE [Object of Computer type] = 'Yes'

## All computers in active records with AcrobatReader installed
      Here we join values from multiple views into one using the LEFT JOIN operator.     

    SELECT ObjectEnu.[Object name], Software.Product FROM Query.ObjectEnu
    LEFT JOIN Query.Software ON [Software].ComputerNodeId = ObjectEnu.[Object id]
    WHERE Software.Product = 'Adobe Acrobat Reader'

## All computers and their move history
      Query computer objects and some selected items of their history.     

    SELECT ObjectEnu.[Object name], ObjectLogEnu.[Record date (UTC)], ObjectLogEnu.[Title], ObjectLogEnu.[Message], ObjectLogEnu.[Record kind]
    FROM Query.ObjectEnu
    LEFT JOIN Query.ObjectLogEnu ON ObjectLogEnu.[Object id] = ObjectEnu.[Object id]
    WHERE ObjectEnu.[Object of Computer type] = 'Yes' AND ObjectLogEnu.[Title] = N'Move' AND ObjectLogEnu.[Record kind] = 'Object history'

## Disk drives and free space
     
Question about computer disk drives and free space status.

    SELECT o.[Object name], d.[Logical drive], d.[Capacity (GB)], d.[Total free space (GB)], d.[Free space (%)]
    FROM Query.DiskDriveEnu d
    LEFT JOIN [Query].[ObjectEnu] o ON d.[Object id]=o.[Object id]

## Users with transferred assets without a transfer protocol
     
This query displays users who have been transferred assets with a completed inventory number, but subsequently no handover protocol has been issued.

    SELECT
        usr.[Name] [User],
        usr.[Path in tree],
        dbo.fnLocalTime(moves.[Date of last move (UTC)], 'Central Europe Standard Time') [Date last moved],
        dbo.fnLocalTime(pp.[Last PP Date (UTC)], 'Central Europe Standard Time') [Date of last PP]
    FROM (
        SELECT
            usr.[Object id] [User Id],
            max(l.[Record date (UTC)]) [Date of last move (UTC)]
        FROM Query.ObjectLogEnu l
            INNER JOIN Query.ObjectEnu o ON o.[Object id]=l.[Object id] AND ISNULL(o.[Inventory number],'')!=''
            INNER JOIN Query.NodeParent np ON np.ChildNodeId=l.[Object id] 
            INNER JOIN Query.ObjectEnu usr ON usr.[Object id]=np.ParentNodeId AND usr.[Type]=N'User' 
        WHERE l.Title=N'Move' 
        GROUP BY usr.[Object id] 
      ) moves 
      INNER JOIN Query.ObjectEnu usr ON usr.[Object id]=moves.[User Id] 
      LEFT JOIN (
        SELECT
          l.[Object id],
          SNULL(max(l.[Record date (UTC)]),{d'1900-01-01'}) [Last PP Date (UTC)]
        FROM Query.ObjectLogEnu l
        WHERE l.[Record kind]=N'Document' AND l.Title=N'Transmission Log' 
        GROUP BY l.[Object id] 
      ) pp ON pp.[Object id] = moves.[User Id]
    WHERE moves.[Date of last move (UTC)]>DATEADD(DAY,1,pp.[Last PP Date (UTC)])

> [!NOTE]
> The transfer log only has a date in the log (and the time is always 00:00:00), so we need to add a day to it.

      
## Audit user permission changes
      Log of changes in permission settings in the object tree for the last month.

    SELECT * FROM Query.NodeRightLog
    WHERE DatePart(m, [TimeStamp]) = DatePart(m, DateAdd(m, -1, GETUTCDATE()))
        AND DatePart(yy, [TimeStamp]) = DatePart(yy, DateAdd(m, -1, GETUTCDATE()))

      Log of changes in group membership settings for last month.

    SELECT * FROM Query.RoleMembershipLog
    WHERE DatePart(m, [TimeStamp]) = DatePart(m, DateAdd(m, -1, GETUTCDATE()))
        AND DatePart(yy, [TimeStamp]) = DatePart(yy, DateAdd(m, -1, GETUTCDATE()))

      Log of user logins for the last month.

    SELECT * FROM Query.UserLogonLog
    WHERE DatePart(m, [TimeStamp]) = DatePart(m, DateAdd(m, -1, GETUTCDATE()))
        AND DatePart(yy, [TimeStamp]) = DatePart(yy, DateAdd(m, -1, GETUTCDATE()))

## Computers and their detected TPMs
      
The query displays a list of computers and their detected TPM chips.

    SELECT o.[Object id] NodeId, o.[Type],
        	o.[Object name] [Computer],
        	o.[Path in tree],
        	wo.IsActivated, wo.IsEnabled, wo.IsOwned, wo.Manufacturer, wo.ManufacturerVersion, wo.ManufacturerVersionFull20, wo.ManufacturerVersionInfo, wo.PhysicalPresenceVersionInfo, wo.SpecVersion
    FROM Query.ObjectEnu oLEFT JOIN vComputerDetectLast cdl ON cdl.lintComputerNodeId=o.[Object id] AND cdl.lintDetectKindId=1LEFT JOIN tblWbemObject wo ON wo.lintDetectId=cdl.lintDetectId AND wo.__CLASS='Win32_Tpm'
    WHERE o.[Object of Computer type]='Yes'

## Query to SQL
      Here we will show how you can convert a [query](../../../alvao-asset-management/searching/query) written in the internal query language into SQL.  
     Original query:

    SELECT AS "User"=[User].@Node,[Computer].[Computer Type],[Computer].@Node,[Monitor].@Node COUNT 
    WHERE @Class='User' 
    WITH 
        SELECT AS [Computer] WHERE @Class='Computer' AND ([Computer Type] = "desktop"),
        SELECT AS [Monitor] WHERE @Class='Monitor' 
    ENDWITH

     This query will show us the users' objects, their desktop type computers and monitors. It will also show us the total number of monitors under all users (regardless of computer type). When converting to SQL, we will proceed by first finding all the undeleted User type objects and their sub-objects of the Computer type.     

    SELECT [User].[Object name] AS [User NodeName], Node.[Object name] AS [Computer Name] FROM [Query].[ObjectEnu] [User]
    LEFT JOIN [Query].NodeParent ON [User].[Object id] = NodeParent.ParentNodeId
    LEFT JOIN [Query].[ObjectEnu] [Node] ON NodeParent.ChildNodeId = Node.[Object id]
    WHERE [User].[Object kind] = N'User' AND (Node.[Object kind] = N'Computer/Desktop' OR Node.[Object kind] = N'Monitor')

> [!NOTE]
> Unlike the original query in the query language, the resulting SQL query does not contain the total number of monitors. This value needs to be found in a separate query.

## Conversion of standard EPQ queries
     The following SQL queries display the same data as the standard EPQ files.     
### Inventory by room
     Objects with the inventory number property, grouped by the Room property and sorted by network name and class.     

    SELECT 
        [Object name],
        [Object kind],
        [Inventory number],
        [Room],
        [User],
        [Network branch name] 
    FROM Query.ObjectEnu 
    WHERE [Inventory number] IS NOT NULL

> [!NOTE]
> Then sort the query result in the table by the "Room" column.

     
### Inventory by user
     Objects with the inventory number property, grouped by the User property.     

    SELECT 
        [Object name],
        [Object kind],
        [Inventory number],
        [Room],
        [User],
        [Network branch name] 
    FROM Query.ObjectEnu 
    WHERE [Inventory number] IS NOT NULL

> [!NOTE]
> Then sort the query result in the table by the column "User".

      
### Uninstalled software by software
     Installed software, grouped by computer.     

    SELECT c.[Object name] AS [Computer], Product AS [Application],
    Installed, LicenseInventoryNumber AS [Computer inventory number],
    u.[Object name] AS [User], LicenseInvoiceNumber AS [License document number],
    LicenceName AS [LicenseName] FROM Query.Software
    LEFT JOIN Query.ObjectEnu c ON c.[Object id] = Software.ComputerNodeId 
    LEFT JOIN Query.ObjectEnu u ON u.[Object id] = Software.[User]
    WHERE Product like N'ALVAO%'

### Operating systems
     Installed OS, grouped by computer.     

    SELECT Computer.NodeName AS [Computer], Product AS [OS], Installed AS [Installation Date],
    Computer.[Inventory number] AS [Inventory Number], [Computer].UserNodeId AS [User], LicenseInvoiceNumber AS [Document], [LicenceName] AS [Assigned license], LicenseActivationKey AS [OS - serial number] 
    FROM Query.Software 
    LEFT JOIN Query.Computer ON Computer.NodeId = Software.ComputerNodeId WHERE Category = 1

### Computers
     Computers, their sub-objects and properties.     

    SELECT [Object name], [Network branch name], [User], [Purchase date], [Inventory number], [Serial number],
    [Warranty expiration], [Total hard disk capacity (GB)] AS [HDD], CPU, [Operating system] 
    FROM Query.ObjectEnu
    WHERE [Object of Computer type] = 'Yes'

### Changes by date
     List of events in the log from the specified parameters. Grouping by objects.     

    SELECT [Object name], [Object kind], [Record date (UTC)], [Title], [Message]
    FROM [Query].[ObjectLogEnu]
    LEFT JOIN [Query].[ObjectEnu] ON [ObjectEnu].[Object id] = [ObjectLogEnu].[Object id]

### Object Moves by Date
     List of movement events in the log. Grouping by date.     

    SELECT [Object name], [Object kind], [Record date (UTC)], [Title], [Message]
    FROM [Query].[ObjectLogEnu]
    LEFT JOIN [Query].[ObjectEnu] ON [ObjectEnu].[Object id] = [ObjectLogEnu].[Object id]
    WHERE ObjectLogEnu.[Title] = N'Move' AND ObjectLogEnu.[Record kind] = 'Object history'

### Equipment by date of purchase
     List of objects by date of purchase.     

    SELECT [Object name], CONVERT(datetime, [Purchase date]) AS [Date], [Room], [User]
    FROM Query.ObjectEnu

### Equipment under warranty
     List of objects according to their warranty (property).      

    SELECT [Object name], CONVERT(datetime, [Purchase date]) AS [Date], [Room], [User], [Warranty expiration]
    FROM Query.ObjectEnu
