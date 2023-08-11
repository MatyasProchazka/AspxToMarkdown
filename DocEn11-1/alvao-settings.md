# Alvao Settings
      
Detection by the MS SCCM method is performed by the ALVAO Collector service, which, depending on the settings, connects to SCCM either via [Administration Service](https://docs.microsoft.com/en-us/mem/configmgr/develop/adminservice/overview) or by connecting directly to the SCCM database on SQL Server.
      
## Connecting via Administration Service
     
The Administration Service is a component of SCCM that implements a web-based REST API that provides computer data to authorized users over HTTPS.
     
It can be run either only within the corporate network or also over the Internet. In either case, Collector authenticates with a user name and password, which must exist in SCCM and have permission to read data from the HW and SW inventory.

- Within the corporate network, kerberos authentication takes place between the Collector and the Administration Service.
- When connected over the Internet, Collector connects to SCCM through the *Cloud Management Gateway* service.
  Therefore, the specified user must also exist in Azure Active Directory, where the application that Collector uses to obtain an Access Token to connect to the Administration Service must also be registered. 

> [!CAUTION]
> To connect Collector to the Administration Service, you must use an account that is synchronized from your AD to AAD using *Password hash* synchronization. Accounts synchronized via *Pass-through Authentication* or *ADFS* are not supported.

To install and set up the Administration Service, see [How to set up the administration service in Configuration Manager](https://docs.microsoft.com/en-us/mem/configmgr/develop/adminservice/set-up).
      
## Database connection
     
Collector uses the connection string and reads the computer data directly from the SCCM database.

You need to ensure that the account under which the service runs has the right to read data from the SCCM database. So, for example, the db\_datareader role is sufficient.
          
## Setting the Collector connection to SCCM

1. In the **ALVAO WebApp** select **Management - Asset Management - Settings**.
2. Go to the **MS SCCM Connector** page and add one or more connections to SCCM.
