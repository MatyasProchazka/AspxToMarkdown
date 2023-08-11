# Agent
      
## Installation

> [!TIP]
> Before you start installing the Agent, study the [chapters Selecting a detection path](detection-way), which will tell you more about using the Agent.

Installation can only be performed by a user with computer administrator privileges.
     
1. On the stations on which you want to install the Agent, run the *AlvaoAssetAgent.msi*.
2. The installation wizard will open on the screen. On the page [Settings](../../../list-of-windows/alvao-asset-management-agent-setup/settings), enter the installation parameters. Follow the instructions in the wizard.

If the installation went correctly, there is a folder *C:\Program Files\ALVAO\Asset Management Agent* on the disk where the Agent executables are stored. A system service named *ALVAO Asset Management Agent X.X.X* must exist on the system.
      
### Installation parameters

- **WSURL** - address of the ALVAO Asset Management web service, e.g. http://server/assetwebservice/assetwebservice.asmx.
- **AUTHCODE** - agent authentication code.
- **USETCP** - enables agent connection via TCP/IP - possible parameter values are yes or no.
- **PORT** - the number of the TCP/IP port on which the Agent is listening (port 760 by default). If you are connecting via TCP/IP.

Example parameter settings in a silent installation - the agent authentication code is 1234 and the agent will use TCP/IP failover and the port on which the agent listens is 760:           
         msiexec /i AlvaoAssetAgent.msi /quiet **WSURL**=*"https://app.company.com/assetwebservice/assetwebservice.asmx"* **AUTHCODE**=*"1234"* **USETCP**=*"yes"* **PORT**=*"760"*

> [!CAUTION]
> For successful installation, it is essential to run the script with administrator rights

> [!TIP]
> You can also change the Agent settings additionally by running the Agent as an application (usually *C:\Program Files (x86)\ALVAO\Asset Management Agent\Agent.exe*) and using the **Settings** option.

> [!NOTE]
> If you have any problems with the installed Agent, the log file that the Agent generates when it runs might help to solve them. Log generation is disabled by default. You can turn it on by running AMAgent.exe from the application directory. On the first page, select **Settings** and on the next page, check the **Generate log file** option. Set the log detail to Detailed. The service log will then be stored in the *agsvc.log* file.

> [!CAUTION]
> If you set the log file detail to **Detailed**, the agent will generate a large amount of data to the log file and the detection rate will be very slowed down. Setting it to **Detailed** is therefore only recommended for troubleshooting and is not recommended for use in normal operation at all.

> [!NOTE]
> If you want to use the Agent on Windows 95/98/ME operating systems, you need to install Agent version 5.0!!! - for more information, please refer to the manual for version 5.0 (ep.chm), which can be found in the installed Computer Records 5.0 application.  

        Also on Windows 2000 you must use Agent 5.10 and lower.  

        For Windows XP you must use Agent 10.0.

### Installation via GPO
     
If you are installing Agent via GPO on a 32-bit OS and want to set up communication with AM WebService or via TCP/IP protocol, use the following [ADMX 32b file](AMAgent.admx) and [ADML 32b file](AMAgent.adml). Place the ADML file in the localization files folder (for an EN Windows server, the *en-US* folder).
     
If you are installing Agent via GPO on a 64-bit OS and want to set up communication with AM WebService or via TCP/IP protocol use the following [ADMX 64b file](AMAgent_64b.admx) and [ADML 64b file](AMAgent_64b.adml). Place the ADML file in the localization files folder (for an EN Windows server, the *en-US* folder).
      
### Automatic update
     
ALVAO Agent automatically updates itself when it detects a newer version when communicating with AM WebService. The agent detects the new version when it starts or restarts and then once a day.

> [!NOTE]
> When diagnosing potential auto-update problems in Agent, turn on [detailed log](../../../list-of-windows/alvao-asset-management-agent/settings/general).When updating, the Agent will first download a new installation package to the Update subfolder of the folder where the Agent is installed (usually C:\Program Files (x86)\ALVAO\Asset Management Agent).In the same folder after installation you will find the installation log *AMAgent\_MSI\_upgrade.log*.

## Setting up an autonomous agent
     
In the basic configuration, the agent contacts the Asset Management WebService every 2 hours to determine if it should perform a computer discovery. If the Agent fails to send a discovery, it tries again after 15 minutes. These values can be changed by creating values in the registry of the computer on which the Agent is installed:

| Value name | Type | Default value |
| --- | --- | --- |
| ScheduleUpdateIntervalMinutes | REG\_DWORD | 120 |
| DetectionUploadRetryIntervalMinutes | REG\_DWORD | 15 |

- 32 bit OS:

        SOFTWARE\ALC\ALVAO Asset Management\Agent
- 64 bit OS

        SOFTWARE\Wow6432Node\ALC\ALVAO Asset Management\Agent

## Web Service Settings
     
Web service stores received detections in directory or Microsoft Azure blob storage configured in the          [Administration – Asset Management – Settings – Detection – Loading files](../../../list-of-windows/alvao-webapp/administration/asset-management/settings/detection).
          
## Finding the reason why the Agent does not communicate with WS
     
Exception text or error code from the Agent will help in diagnosis. This can be found as follows:

1. Run in the Agent directory installation file *AMAgent.exe*.
2. A window will appear where you select the **Settings** option.
and press the *Next* button.
3. On the *General* tab
 Enable the **Write log to file** option and select *Status and errors* for the detail.
4. Confirm the setting change with *OK*.
5. Restart the Agent service.  The Agent immediately tries to connect to the web service.
6. In the Agent installation directory, locate the *agsvc.log*
            and open it, for example, in notepad.
7. Look for the line in the log:

        [CheckDetectSchedule] calling WS end with error: ...

    Either the exception text or the error code follows.                   
                   
                 Exception returned by webservice -  e.g. authentication error, computer not in DB, etc.                   
                   
                 The error code may indicate a problem with secure communication. In this case there should be a numeric error code. Details of the error can then be found on the                  [Microsoft learn site](https://learn.microsoft.com/en-us/windows/win32/debug/system-error-codes#system-error-codes).                   
                 If the error is in the communication then it will usually be a 12xxx code, which can be found on                  [this page](https://learn.microsoft.com/en-us/windows/win32/wininet/wininet-errors).

## Command line
     
Agent allows you to run from the command line with the specified parameters. In this chapter you will find a detailed description of all command line parameters.
     
Parameters:

- **/dd** - instant detection of the device on the computer where the Agent is running. (works only together with the **/df** parameter)
- **/dsw** - instant software detection on the computer where the Agent is running. With this switch, full detection is performed, including files on all hard drives without exceptions. (works only together with the **/df** parameter)
- **/dssw** - instantly detect software on the computer where the Agent is running. With this switch, normal software detection is performed. (works only together with the **/df** parameter)
- **/df** - performs selected types of detection (parameter **/dd**,**/dsw**,
  **/dssw**) and saves the resulting detection files to the directory from where the Agent is running or to the folder specified after the **/f**.
- **/f *[path]*** - the path to the shared folder, or the path where the selected detections are saved (parameter **/df**).
Specifies the path to the shared folder where the detection requests are stored. If this parameter is not specified, the path specified in the Agent settings (the **Settings** option after starting the Agent from the - menu) is used.
Start). If neither this parameter nor the path is specified in the Agent settings, the *server installation path is used.\Share*.
- **/l *[file]*** - the agent will generate a log to the file specified after the parameter.
- **/v *[number]*** -
logging detail will be set to the specified level (only works with the **/l** parameter).
  *Levels: 0 = Status and errors, 1 = Normal, 2 = Full*.
- **/s** - the agent will start covertly, i.e. no information window will be displayed on the screen.
- **/h** - a help window for command line parameters will be displayed.

> [!TIP]
> If you want to do a full software detection and skip some disks or paths, you need to run the agent without the command line and set the software detection parameters correctly in the wizard.

**Example 7. Agent - Device and Software Discovery Example**
     
We want to run the Agent so that it immediately performs device detection and normal software detection and saves the detection files to the D:\Detection folder

    AMAgent /dd /dssw /df /f D:\Detection

> [!NOTE]
> If you use the Agent to create detection files, the file names will be automatically created by the computer name and by adding the suffix *\_SW* for software detection and *\_HW* for device detection.

For example: for a computer named *STANDAPC*, the Agent will create the files *STANDAPC\_SW.cxm* and *STANDAPC\_HW.cxm*.
