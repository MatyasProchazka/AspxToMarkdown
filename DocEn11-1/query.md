# Query
  
On this page, enter the SQL query.

> [!CAUTION]
> A poorly defined SQL query can irreversibly damage the Alvao database. Always create and test SQL queries on a testing copy of the production database.

Options:

- **Command panel**
    - **Save** - saves changes.
    - **Execute** - runs the SQL query and previews the results.
- **Query editor** - enter the SQL query.

You can use the following variables in the SQL query:

- @personId - ID  of the user ([tPerson](../../../../../alvao-asset-management/implementation/customization/database#U_dbo.tPerson).iPersonId) running the data query.
- @localeId - LCID ([tLocale](../../../../../alvao-asset-management/implementation/customization/database#U_dbo.tLocale).iLocaleId) of the preferred language of the user running the data query.
- @customId - the value of the *customId* query string parameter. You can use this variable in customizations, e.g., [IEntityTab](../../../../../modules/alvao-am-custom-apps/applications/i-entity-tab). For instance, the URL of the data query may look like this: *https://contoso.onalvao.com/Alvao/DataQuery/Result?id=1&customId=1*.

On the page [Data queries](../../../data-queries), the users can view all columns returned by the SQL query. If the column name ends with "TicketId", "NodeId", or "PersonId" (e,q. "MentorPersonId"), the values are displayed as links to the corresponding entity page. When an entire row is selected, the entity page for the first such column is displayed on the right.
     
As an example, use SQL queries in [SQL query examples](../../../../../alvao-asset-management/searching/database-sql/samples).
