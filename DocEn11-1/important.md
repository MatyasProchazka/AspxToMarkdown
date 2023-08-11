# Important notices
     
# ALVAO 11.1
      
This page provides warnings about changes in the new version of the product that may cause problems when upgrading from the previous version or when running the new version. Please read this information carefully before upgrading to the new version.
     
It is also recommended that you read the list of subsequently identified issues in the released versions and their solutions, see [Known issues](../known-issues).
      
## Core features
     
- Connections to the Alvao database are encrypted by default now. Ensure you have properly 
            [installed a trusted certificate](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/enable-encrypted-connections-to-the-database-engine?view=sql-server-ver16) on your server. 
            If you don't want to use encrypted connections, add the "TrustServerCertificate=True" parameter to your connection strings.
- The **ALVAO MailboxReader** server component has been renamed to *Alvao Service*. (T116318ALVAO)
    - [ImportAD](../alvao-asset-management/implementation/users/authentication/ad/import-ad), 
                    [ImportPortraitsFiles](../alvao-service-desk/implementation/users/import-portraits-files), 
                    [ImportPortraitsSharepoint](../alvao-service-desk/implementation/users/import-portraits-sharepoint), 
                    [ImportUsersCsv](../alvao-asset-management/implementation/users/authentication/alvao/import-users-csv)
                    – after the upgrade, check the settings of existing scheduled tasks executing these utilities.
                    These utilities are newly installed into the "%ProgramFiles%\ALVAO\AlvaoService\utilities" folder.
- Security logs - the security log records are no longer stored in the [ALVAO Audit](http://localhost:44375/en/11.0/alvao-asset-management/implementation/audit-log) Windows Event Log but in two separate new logs: *AlvaoUserLogin*and *AlvaoSecurityChanges*. For more information see the [Settings change log](../alvao-asset-management/implementation/audit-log). (T130085ALVAO)
- [Disabled user accounts](../alvao-service-desk/implementation/users/inactive-accounts) don’t receive any request e-mail notifications and any e-mail alerts (on SLA deadlines, News, SAM issues, etc.) anymore. (T35075ALVAO)
- People with [disabled user accounts](../alvao-service-desk/implementation/users/inactive-accounts) can’t be searched and don’t show on the [My team](../list-of-windows/alvao-webapp/my-team) page anymore. (T46819ALVAO)

## ALVAO Asset Management

- AM Console – direct connection to the Alvao database is no longer supported. Use connection through *Web service* instead. (T124285ALVAO)
- The core **ALVAO Collector** functions are performed by the new *Alvao Service*. The *AM Collector* is not installed by default anymore. The detection methods “without Agent” and “agent over TCP/IP” are deprecated and will be removed in the next version of ALVAO products. To use these methods, manually install the *AM Collector*and enable the detection settings in *Administration – Asset Management*– [Servers (deprecated)](../list-of-windows/alvao-webapp/administration/asset-management/servers). In a SaaS environment, only detections with agents are supported. (T128616ALVAO)
- Hardware detection does not create nor update computer components (except monitors). (T128269ALVAO)
- The system object kind **Loaded objects** has been renamed to *Imported objects*. (T128357ALVAO)
- The system property definition **Total hard disk capacity (GB)** has been renamed to *Total storage capacity (GB)*. (T128357ALVAO)
- The WinPrefetchView utility has been removed from the AM Agent installer. This is because the utility was causing false reports from some antivirus software. 
            If you monitor software usage on your computers using Alvao, you need to ensure that when you upgrade Agents to a new version, the WinPrefetchView utility 
            is also distributed to the Agent installation folder. For more information see [Software usage](../alvao-asset-management/software-management/usage). (T135975ALVAO)
- AM Console - 
            [ExportUtil](../alvao-asset-management/import-export-data/export-util), 
            [ImportAD](../alvao-asset-management/implementation/users/authentication/ad/import-ad), 
            [ImportPortraitsFiles](../alvao-service-desk/implementation/users/import-portraits-files), 
            [GenerateNodeRelationshipDiagram](../modules/alvao-configuration-management/visio)
            - Utilities have been moved to the ImportUtilities folder. (T138988ALVAO)

## ALVAO Service Desk

- Administration – Service Desk – Services – SLA – the option to **deny users access**to an 
            [SLA](../alvao-service-desk/implementation/services/sla) has been removed. 
            All records denying an SLA access in service settings will be ignored after the upgrade. 
            Before upgrading, check the use of the retired option with the 
            [SQL script](Denied_SLAs_T116209ALVAO.sql). (T116209ALVAO)
- Administration – Processes – Process – [Request items](../list-of-windows/alvao-webapp/administration/service-desk/process/detail/request-items) – Add – the option [On the New Request Form (for main solvers), place the item into the Other Items section](../list-of-windows/alvao-webapp/administration/service-desk/process/detail/request-item) was removed. All items that are not explicitly placed on a [New Request Form](../list-of-windows/alvao-webapp/administration/service-desk/service/detail/new-ticket-items) are shown in the Other items section. (T101472ALVAO)

## ALVAO Outlook Add-in

- Variable name used for bulk installation using the *Active Directory Group Policy*has changed, see [Installation](../modules/alvao-outlook-addin/installation). (T124394ALVAO)
- In case you [manually upgrade](../upgrade/upgrade-server-manual) from the previous versions, don’t upgrade **ALVAO REST API** (AlvaoRestApi.msi) but first uninstall the old version and then [install](../alvao-asset-management/implementation/installation/installation-server-manual#restapi) the new version for the correct setup of the new *AlvaoRestApiWinAuth* application in IIS. (T124399ALVAO).
- Settings – the field *Service Desk Web Service URL* is replaced by the field *Alvao domain name (or REST API url)*. The current SD WS URL is automatically transformed into a REST API url. In case of any problems please check *ALVAO Outlook Add-in* - [Installation](../modules/alvao-outlook-addin/installation). (T130399ALVAO)
