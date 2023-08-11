# SQL query and database script
      
Data that cannot be retrieved from the database [by searching](../../alvao-asset-management/searching/looking-up-objects) or [queries](../../alvao-asset-management/searching/query) can be retrieved and possibly manipulated directly in the SQL database. To write an SQL query or script, you need at least a basic understanding of the structure of [Alvao database](../../alvao-asset-management/implementation/customization/database) and writing [SQL queries](../../alvao-asset-management/searching/database-sql/samples). Alternatively, contact ALVAO technical support.
      
You can find the commands you need in **AM Console - Tools** - [Database](../../list-of-windows/alvao-asset-management-console/tools/database).
      
## Creating SQL queries
      
1. When creating SQL queries, we recommend using [views](../../alvao-asset-management/implementation/customization/database#report_view_list) created for easier access to data in Asset Management. All views designed to access AM information are in the database schema "Query".
2. SQL queries only allow you to run SELECT queries.
3. Always enter custom column names in the form **.  View.[Column]**, for example **Node.[Serial Number]**. You can rename columns using an AS statement, for example **SELECT View.[Column]AS [View Column]**.
4. Do not use **SELECT \* FROM** in queries, but always list specific columns, otherwise the result display may be slowed down.
5. Views that contain object properties always contain the top 100 most used object properties. Updating these views (redefining them for the 100 most used properties) can be done in [ALVAO WebApp - Administration - Database Maintenance - Update data for reports](../../list-of-windows/alvao-webapp/administration/database-maintenance)
6. Before creating your own queries over views, we recommend that you take a look at the examples of using views described below.
