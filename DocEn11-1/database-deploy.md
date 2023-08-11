# DatabaseDeploy
      
The DatabaseDeploy utility is used to create a new database or to update an existing database to the latest version.

> [!NOTE]
> You can also run the utility in a batch of commands. If the database creation/upgrade is successful, the return code returns 0, if it fails, it returns 1.

## Syntax command lines
     
DatabaseDeploy.exe **/conn** *&lt;connection string&gt;* **/langid** *&lt;language id&gt;*
       
## Detailed description of parameters

| Parameter | Description |
| --- | --- |
| /conn &lt;chain&gt; | The connection string to the database.  <br>
> [!NOTE]
> the database name is also set in the connection string. |

| /langid &lt;language id&gt; | ID of the database language. Supported values:  <br>
                <ul>
                    <li>1029 - Czech</li>
                    <li>1051 - Slovak</li>
                    <li>1033 - English</li>
                    <li>1031 - German</li>
                    <li>1045 - Polish</li>
                </ul>
> [!NOTE]
> this parameter is only applied when creating a new database. |


> [!NOTE]
> - You can also set command line parameters in the DatabaseDeploy.exe.config file. The command line parameters take precedence over the settings in the configuration file.

- The utility expects the Alvao database definition file *AlvaoDatabase.dacpac* to exist in the same folder.

## Example of use

1. Create a new Czech database named "ALVAO" on a local computer with SQL Server with instance name "sqlexpress" using integrated Windows authentication:  

            **DatabaseDeploy.exe /conn** "Data Source=.\sqlexpress;Initial Catalog=ALVAO;Integrated Security=True;TrustServerCertificate=True" **/langid** 1029
2. Upgrade database named "ALVAO" to SQL server on server "SERVER1" using SQL username and password:  

            **DatabaseDeploy.exe /conn** "Data Source=SERVER1,1433;Initial Catalog=ALVAO;User ID=user1234;Password=secret1234;TrustServerCertificate=True"

> [!NOTE]
> For more connection string examples, see [Connection String Examples](connection-string-samples).
