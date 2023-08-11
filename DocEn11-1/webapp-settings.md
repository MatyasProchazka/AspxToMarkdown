# WebApp Settings
      
The WebApp (web interface for the requester) settings are stored in the **Web.config** file. The file is in XML format. You can use Notepad from Windows to edit it. Values must be entered in accordance with the XML format, i.e. for example the character "&lt;" (smaller) is replaced by "&lt;",  instead of "&gt;" it is "&gt;" etc.  
         To avoid accidentally overwriting settings when upgrading the WebApp, the Web.config file is not included in the installation. The first time you install it, create it by copying the SampleWeb.config file.
      
## AppSettings section
      
In the &lt;configuration&gt;&lt;appSettings&gt; section, each configuration variable is written as an XML tag &lt;add&gt;. The key attribute specifies the name of the variable, the value attribute contains the value.  
         In the following table you will find a list of variables with their value descriptions.

| Variable | Value |
| --- | --- |
| AppName | Name of the web application, e.g. "ALVAO Service Desk".
 This value is displayed in the header of each page. |
| Kb | If a value of 0 is specified, the web application will not display the [knowledge base](../../knowledge-base). A value of 1 will enable its display. |
| CustomThemePath | Path to the folder with the files for customizing the look. |

## Setting automatic logout when the user is inactive
     
A user will be automatically logged out after a specified period of time if they have not taken any action during that time.
     
Disable automatic logout on inactivity (inactivity time is set in minutes from 1 - 525 600):
     UPDATE tProperty SET iPropertyValue = 30 WHERE sProperty ='WebApp.AutoLogoutMinutes'      
Turn off automatic logout when inactive:
     UPDATE tProperty SET iPropertyValue = 0 WHERE sProperty ='WebApp.AutoLogoutMinutes'      
For proper functionality it is also necessary to check the settings of the web.config file: in the section &lt;system.web&gt; &lt;authentication&gt; &lt;forms&gt; the slidingExpiration parameter. This parameter must not be filled in or must be set to true.

> [!CAUTION]
> This setting only works for form logins.

## Setting prohibited attachment types
     
To set disabled attachment types, use this SQL script:  
         UPDATE tProperty SET sPropertyValue = 'bat, cmd, exe' WHERE sProperty = 'WebApp.AttachmentBlacklist'
     
After applying this script, attachments with *bat, cmd* and *exe* extensions will be disabled. The list of individual file extensions can be freely changed
     
To restore the default state in which no attachment types are disabled, run this script:  
         UPDATE tProperty SET sPropertyValue = NULL WHERE sProperty = 'WebApp.AttachmentBlacklist'
       
## Setting the maximum attachment size
     
The maximum attachment size is defined in the &lt;configuration&gt;&lt;system.web&gt;&lt;httpRuntime&gt; section in the "maxRequestLength" variable in kilobytes [KB].
     
In case of using IIS7 and higher, you need to modify the maximum attachment size also in the &lt;configuration&gt;&lt;system.webServer&gt;&lt;security&gt;&lt;requestFiltering&gt;&lt;requestLimits&gt; in the "maxAllowedContentLength" variable in bytes [B].
     
## Enhancing protection against password guessing attacks
     
We recommend improving protection against password guessing attacks [by enabling reCAPTCHA](../../../alvao-asset-management/implementation/recaptcha).
