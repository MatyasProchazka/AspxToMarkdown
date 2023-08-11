# Connection string examples
      
This page provides examples of .NET connection strings for connecting to the Alvao database for various authentication methods, etc. Connection strings can be used to configure connections in:
      
- ALVAO WebApp
- ALVAO Asset Web Service
- ALVAO Service
- ...

| Authentication method | Connection type | Example connection string |
| --- | --- | --- |
| Windows integrated | SQL server | Data Source=SERVER1;Initial Catalog=ALVAO;Integrated Security=True;TrustServerCertificate=True |
| SQL Server user/password | SQL server | Data Source=SERVER1;Initial Catalog=ALVAO;User ID=user1234;Password=secret1234;TrustServerCertificate=True |
| Azure AD | Azure SQL | Data Source=company.database.windows.net;Initial Catalog=ALVAO;Authentication=Active Directory Integrated;TrustServerCertificate=True |
| Azure AD user/password | Azure SQL | Data Source=company.database.windows.net;Initial Catalog=ALVAO;Authentication=Active Directory Password;User ID=user1234;Password=secret1234;TrustServerCertificate=True |
