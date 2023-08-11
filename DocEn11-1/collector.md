# Collector
     
Detection requests are handled by a separate Collector program that periodically scans the database and if it finds a new pending request, it tries to resolve it. If a computer cannot be detected, e.g. because it is currently powered off, the request is deferred and Collector will return to it later. It is possible to schedule and configure Collector to handle detection and evaluation requests so that it does not overload the SQL server or the computer network, e.g. during operating hours, but works at night when the SQL server and the network are underutilized.
     
Collector can be run as a system service (recommended) or as an interactive application. A shortcut for running Collector interactively is added to the Start menu when the AM Console is installed.
     
As a service, Collector is usually installed on a server, but you can also install it on a workstation this way. The advantage of installing a service is that Collector automatically starts when the computer is turned on and runs even when no interactive user is logged on.
     
Collector can also run on multiple computers on the network simultaneously. The individual Collector instances then share the specified discovery requests and handle them together.
     
Another feature of Collector is the ability to *Automatically update the software product library (SwLib)*.   The Collector, according to [settings](../../../list-of-windows/alvao-webapp/administration/asset-management/servers/create-server), checks the availability of a new library on the Internet, or loads the library from a set folder on the server disk.
     
Collector also allows you to search for new computers on the network using *Network Search*. This feature is used to search for new computers connected to the corporate network. Newly found computers are created in a special folder - Found Computers Folder in the Asset Tree. The network search configuration can be changed in the WebApp in **Management - Asset Management** **- Servers** using the **Edit** command in the **Network Search** section. It is possible to configure multiple Collectors to each scan only a specific part of the computer network, thereby speeding up periodic scanning of a large enterprise network. The scan period for each configured range can be individually changed. The set time determines after how long the Collector will rescan that part of the network.
     
Collector also includes the *Automatic loading of manual discovery files* feature. This automatically loads the manual detection files (\*.CXM) from a preset folder on the hard disk. The loaded detections are either moved to the "Processed" subfolder or deleted from the hard disk. This behavior can be selected in the **Read Files** setting.
     
Collector also sends requests with unrecognized software and requests to add a new product to the library (if this feature is enabled) and requires an internet connection to function properly.
      
### Settings
      
**ALVAO - Asset Management Collector**)   using the command Action -   [Settings](../../../list-of-windows/alvao-asset-management-collector/actions/hidd-optgeneralpp).
     
Further Collector settings are done in   **ALVAO WebApp** in **Management - Asset Management** -   [Servers](../../../list-of-windows/alvao-webapp/administration/asset-management/servers).
      
### Configuration file AMCollector.config
     
The configuration file stores all local configuration from [Collector settings](../../../list-of-windows/alvao-asset-management-collector/actions/hidd-optgeneralpp):
     
- Database connection string
- Start automatically after system boot
- Configure logging to *AlvaoCollector* event log

Collector can therefore be configured without restarting the service by editing this configuration file.
     
#### Configuration file elements

| Element | Description | Acceptable values | Default value |
| --- | --- | --- | --- |
| database\connectionTimeout | Timeout of connection to DB in [s]. | INT number | 300 |
| database\connectionStrings\add[@name="Collector"] | The DB connection string set through the Collector settings. | connection string | - |
| ui\autoStart | Automatically start the application after OS startup. | 0 = no,  <br>
                1 = yes | 0 |
| log[@active] | Enable/disable event logging. | 0 = off,  <br>
                1 = on | 0 |
| log\detailLevel | Level of logging detail. | 0 = status and errors,  <br>
                1 = normal,  <br>
                2 = detailed | 0 |
| log\writeProcessAliveHours | Logging period of the live status (heartbeat) of the detection and scanning process (in hours). | INT number | 12 |

### Interactive Collector launch
     
Collector is launched as an interactive application by **Start - ALVAO - Asset Management Collector**. A status icon         ![](collector_icon.png)         appears in the bottom right of the Windows Taskbar.Double-clicking on the status icon opens the Collector main window with a list of messages about the detections performed, including any error messages.

> [!TIP]
> When the Collector has handled all requests in the database, it goes into a quiescent state where it checks the database every 2 minutes to see if a new request has been made. You can skip the wait with the

        ![](go.jpg)
        button.

> [!TIP]
> When the Collector has finished scanning all of the network ranges that are configured for the machine, the "NetScan" function will go into an idle state until the next range scan is scheduled. You can skip the wait by clicking

        ![](GoNetScan.jpg).

In order for Collector to be able to detect data from computers running Windows 2000/XP/Vista/7 operating systems without using the Agent, it must be run on a user account with administrator privileges on the detected computers, i.e. the user running Collector must be the administrator of the detected computers. The second option is to run Collector under a different user by right-clicking on the -Collector command in the Start menu with the Shift key pressed, selecting -Run As from the local menu, and entering the login name and password of the appropriate user.

> [!NOTE]
> If you want to detect IBM AIX operating system hardware via SSH, you must have the login credentials of a user in the account list who has permission to run commands on the remote machine via SSH.
