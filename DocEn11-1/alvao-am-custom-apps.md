# ALVAO Asset Management Custom Apps
     
This module allows you to create custom software extensions on top of the ALVAO Asset Management product.
      
## Technical requirements
     
- ALVAO Asset Management

## Module activation
      
The module must be activated with an activation key, which you can obtain from your Alvao system supplier. In the **ALVAO WebApp - Administration - Licenses**, select the **Insert Activation Key** command and enter the activation key.
      
## Module installation
     
After activating the module on the server, run [ALVAO Server Setup](../alvao-asset-management/implementation/installation), which will install the necessary components.
      
### Manual installation
     
Install *ALVAO Custom Apps WebService* on the server:

1. Make sure the machine where you want to run ALVAO Custom Apps WebService has an IIS intranet server installed with a version that meets the [technical requirements](../alvao-asset-management/implementation/requirements).
2. We recommend creating a custom application pool on IIS [ALVAO AppPool .NET 4.0](../alvao-asset-management/implementation/installation/own-iis-apppool) This step is not strictly necessary to run the application, but it significantly affects the loading speed of the WebApp.
3. Before installation, make sure you have ASP .NET v4.7.2 or higher installed.
4. (Optional) Before installation, setting up the Windows Integrated Authentication is strongly recommended:
    1. In IIS Manager, click on the application **AlvaoWebApp** and then click **Authentication**.
    2. Make sure **Windows Authentication** is enabled (and all others are disabled).

> [!CAUTION]
> Authentication must also be enabled on the website where the application is installed.

    3. Open the **web.config** file located in the ALVAO WebApp folder in a text editor.
    4. Make sure that in the **configuration/system.web** attribute is **authentication mode** is set to Windows.
    5. In the IIS root, set **Feature delegation**
            (Feature Delegation) - enable read or write in the following authentication modes: Anonymous
            and Windows.

> [!CAUTION]
> This authentication method cannot be used to authenticate users who are not imported from Active Directory.

> [!CAUTION]
> For this authentication method to work properly, you need to have [Alvao server address on the intranet](../../../alvao-service-desk/implementation/installation/webservice-settings).

    
5. Log in as administrator and run the AlvaoCustomAppsWebService.msi installation package. If you have a problem with UAC, run the installation from the command line using msiexec -i AlvaoCustomAppsWebService.msi.
6. When installing, select the **ALVAO AppPool .NET 4.0** application pool. If you did not create this AppPool in step 2, select .NET v4.5.
7. The installer creates a folder on disk (&lt;InetPub&gt;\wwwroot\AlvaoCustomAppsWebService) and also a virtual directory in IIS (AlvaoCustomAppsWebService).
8. After installation, you must configure the *web.config* file in the **ALVAO Custom Apps WebService** folder (open the file in Notepad).
9. In the line:  

            &lt;connectionStrings&gt;  

                  &lt;add name="Db" connectionString="Data Source=localhost;Initial Catalog=Alvao;Integrated Security=True;Current Language=Czech;TrustServerCertificate=True"  providerName="Microsoft.Data.SqlClient" /&gt;  

                &lt;/connectionStrings&gt;  

            set the connection to the database. The connection string has the same format as in the *web.config* file in the ALVAO WebApp settings.
10. In the database, set the application pool identity with the **public, db\_datareader, db\_datawriter, db\_ddladmin, db\_executor** permissions.
11. In **ALVAO WebApp - Administration - Settings -**[Web services](../list-of-windows/alvao-webapp/administration/settings/web-services)**- Custom Apps WebService (URL)** enter the path to the *ALVAO Custom Apps WebService* folder. For example: http://server/AlvaoCustomAppsWebService.

> [!NOTE]
> ALVAO Custom Apps WebService has *Windows authentication* set up.
