# Import user portraits from SharePoint server
    
## Regular automatic import
   
Create a scheduled task on the server with a recurrence period of e.g. 1 time per day that runs the following command:
 
%ProgramFiles%\ALVAO\AlvaoService\utilities\ImportPortraitsSharepoint.exe /server &lt;sql\_server&gt; /db &lt;database\_alvao&gt; /portalUrl &lt;url&gt; /username &lt;login&gt; /password &lt;pass&gt;

> [!NOTE]
> 

## One-time import
  
For a one-time import of portraits, run a scheduled task created on the server or copy the *ImportPortraitsSharepoint* application from the application server to your computer and run it from the command line. The application is installed together with the ALVAO Service in the "%ProgramFiles%\ALVAO\AlvaoService\utilities" directory.
  
## Utility ImportPortraitsSharepoint
    
The ImportPortraitsSharepoint utility loads user portraits from SharePoint 2010, 2013 or SharePoint Online (Office 365) into Alvao.
   
The utility is part of the ALVAO Service installation and is installed in the same folder, usually in "%ProgramFiles%\ALVAO\AlvaoService\utilities".
  
### Command line parameters

| Parameter | Description | Mandatory | Example |
| --- | --- | --- | --- |
| /conn &lt;string&gt;  <br>/server &lt;server&gt;  <br>/db &lt;db&gt; | Setting the DB connection. | Yes | /conn "Integrated Security=True;Initial Catalog=ALVAO;Data Source=.\SQLEXPRESS;TrustServerCertificate=True" /server .\SQLEXPRESS /db ALVAO |
| /portalUrl &lt;url&gt; | SharePoint address. | Yes | /portalUrl https://firma.sharepoint.com |
| /office365 | Flag that this is Office 365. | No | /office365 |
| /username &lt;login&gt; | User name for logging into SharePoint. | No | /username jan.rychly@firma.cz |
| /password &lt;pass&gt; | Password to log into SharePoint. | No | /password password |
| /wait | Wait for a keystroke at the end of the import. | No | /wait |
| /progress | Display import progress. | No | /progress |

If no username is specified for SharePoint login, the current account is used (note: not supported in Office 365, or if SharePoint has forms authentication). If the SharePoint address contains "sharepoint.com" or "onmicrosoft.com", the office365 option is automatically enabled.

### User pairing
  
To convert users from SharePoint to Alvao users, use:

- E-mail - SharePoint attribute Email.
- User Name - SharePoint attribute Name (standard domain comparison).
- Name - SharePoint attribute Title.
