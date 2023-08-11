# Software usage
     
AM Agent also collects information about the software usage on a given computer when detecting software. This information is useful for optimizing software license purchases and renewals.
      
## Configuration
      
The AM Agent uses the [WinPrefetchView](https://www.nirsoft.net/utils/win_prefetch_view.html) utility to monitor the usage of the software. However, it is not part of the agent installer, but has to be distributed manually.
      
1. Install the agent on the stations.
2. Download the [WinPrefetchView](https://www.nirsoft.net/utils/win_prefetch_view.html) utility and unzip it to the agent installation folder.
3. Make sure the *Prefetcher* function is enabled on the station (see below).

### Switching on the Prefetcher feature
     
AM Agent draws software usage information from the *Prefetcher* operating system feature.In *Windows 10/11*, this feature is enabled by default. In *Windows Server*, however, it is disabled by default. For example, you can turn it on with the following PowerShell script:

    reg add "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management\PrefetchParameters" /v EnablePrefetcher /t REG_DWORD /d 3 /f reg add "HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion\Prefetcher" /v MaxPrefetchFiles /t REG_DWORD /d 8192 /f Enable-MMAgent -OperationAPI net start sysmain

## Reporting the data
     
Software usage data is stored in a database and can be analyzed using the [Query.ExecutedSoftwareEnu](../implementation/customization/database#V_Query.ExecutedSoftwareEnu) view.         You can use the [Data queries](../../list-of-windows/alvao-webapp/administration/data-queries) to display the data.
     
For example, you can find out the usage of MS Word on all computers by SQL query:

    SELECT [Computer], [User], [Last run], [Run count]
    FROM Query.ExecutedSoftwareEnu
    WHERE [Filename]='winword.exe'
    ORDER BY [Last run]

         The computer on which MS Word has been unused for the longest time and is therefore adept for license release will be listed first.          
To get a list of all recorded executables, query:

    SELECT [Filename]
    FROM Query.ExecutedSoftwareEnu
    GROUP BY [Filename]
    ORDER BY [Filename]
