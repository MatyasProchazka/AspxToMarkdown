# ALVAO Server - manual upgrade

This chapter describes the manual upgrade procedure for Alvao server applications used in non-typical installations and when upgrading from ALVAO 7.1 and earlier. For upgrading a typical ALVAO Server installation, we recommend using **ALVAO Server Setup**, see the standard [Upgrade from previous versions](../upgrade) procedure.

## Upgrade database

> [!CAUTION]
> 


Before you start upgrading the database, back up the database and the existing installation (following the [Upgrade from previous versions](../upgrade) procedure).

> [!NOTE]
> 

1. From the [ALVAO downloads](https://www.alvao.com/download/) page, download the **DatabaseDeploy.zip** file.
2. Extract the ZIP package to any folder on the disk.
3. Check that you have permissions on the target SQL Server to change the database schema.
4. Use the [DatabaseDeploy](../alvao-asset-management/implementation/installation/database-deploy) utility to upgrade the database to the new version.

> [!NOTE]
> When upgrading the database, the current activation key is verified over the Internet.

  
## Upgrade server applications

1. Install server application MSI packages for the new product version on the server. For a typical installation, these are the following packages.
    - AlvaoWebApp.msi
    - AlvaoRestApi.msi
    - AlvaoService.msi
    - AlvaoCustomAppsWebService.msi
    - ALVAO Asset Management
        - AlvaoAssetWebService.msi
        - Deprecated: AlvaoAssetCollector.msi - after upgrading, re-set the account under which the service runs to some account with Domain Admins permissions.
2. Check that all Alvao server services are running and start them if necessary.
3. Continue with the procedure [Upgrade from previous versions](../upgrade)
  after the ALVAO Server chapter.

Caution:
If you install **Asset Management** and **Service Desk**, run the **Alvao WebApp** installationonly once.
