# System Architecture

        ![System Architecture](architecture/img/sd-architecture.png)
      
1. **Database** - all data is stored in a common database. Azure SQL Database or MS SQL Server is used as the database system.
2. **ALVAO WebApp (WA, WebApp)** - is a web-based interface through which applicants, operators and solvers can interact with the system. The WebApp is implemented on the MS IIS/ASP.NET platform. Users can use any web client to access the WebApp, e.g. Microsoft Edge, Internet Explorer, Mozilla Firefox, Opera, etc. Similarly, users can use any e-mail client to receive information messages. It is also used for system administration.
3. **ALVAO Service** - a server component that provides automatic retrieval of requests and follow-up e-mail communication to the ALVAO Service Desk system. Messages are retrieved using IMAP or EWS (Exchange WebService) protocol. The system uses any SMTP Server to automatically send e-mail messages to both applicants and solvers. It also includes a utility for retrieving users from Active Directory.
4. **Custom Apps WebService** - a service used by the [ALVAO Service Desk Custom Apps](../../modules/alvao-sd-custom-apps) module.
5. **REST API Service** - REST API interface used by ALVAO Outlook Add-in, Teams Add-in and other applications. It can be also used by custom applications, see [ALVAO Service Desk Enterprise API](../../modules/alvao-sd-enterprise-api).
