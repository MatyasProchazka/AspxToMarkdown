# Databases
 
This menu contains commands for working with [Alvao database](../../../alvao-asset-management/implementation/customization/database).
 
Options:
  
- **Restore deleted items** - first in [Diary](../tab-view/diary), use the local menu command - **Table - Show deleted items**.
  Then select the entries you want to restore and use this command.
- [SQL query...](database/sql-query) - run the specified SQL query (SELECT) and display its result in a [table](database/sql-query), where you can further [work with it](../../../alvao-asset-management/working-with-tables). This command can only be used by members of the [Asset Management administrators](../../../alvao-asset-management/implementation/users/groups) or *SQL Query Administrators* group.
- **Run SQL script** - select the SQL script file you want to run from the disk. After executing it, the application will only display information about whether the script ran without errors or with errors.  This command can only be used by members of the [Administrators](../../../alvao-asset-management/implementation/users/groups) group.

> [!CAUTION]
> Never run SQL scripts that you are not completely sure of their content. Running an incorrect SQL script can lead to database corruption and data loss. Before running an SQL script on a production database, we recommend that you test it in a test environment first.

> [!CAUTION]
> If you are working with diacritics, the SQL script must be in **UNICODE**, otherwise the diacritics will not be processed correctly and the script will not run correctly.
