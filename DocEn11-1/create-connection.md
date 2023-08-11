# New connection
 
Use this form to create a new connection to [MS SCCM](../../../../../../modules/alvao-microsoft-endpoint-manager-connector).
 
Features:

- **Connection Type**- Select the connection type.
    - **Administration Service**- Select if you want Collector to read data through the Administration Service.
        - **URL** - Enter the URL to the Administration Service. For example, https://cmg.cloudapp.net/CCM\_Proxy\_ServerAuth/12345678987654321/AdminService/.
        - **User Name** - enter the user's login name to connect to the Administration Service.
        - **Password** - enter the user's password.
        - **Application (Client) ID** - enter the GUID of the native client application registered in Azure to connect through the Cloud Management Gateway.
        - **OAuth 2.0 (v2) Token Endpoint** - to connect through the Cloud Management Gateway, enter the URL of the access point of the native client application to obtain the authorization token.
        - **URL identifier for the application ID** - to connect through the Cloud Management Gateway, enter the URL of the Azure-registered web application.

> [!NOTE]
> The Administration Service is only available in SCCM from version 1810 onwards.

    - **Database**- select if you want Collector to read data by directly connecting to the SCCM SQL database.
        - **Connection String** - enter the connection string to the MS SCCM database.  

 For example Data Source=localhost;Initial Catalog=CM-SITE;Integrated Security=SSPI;Provider=sqloledb.
