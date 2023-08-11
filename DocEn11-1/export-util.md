# ExportUtil
      
## Function description
      
The application is used to export objects from the ALVAO Asset Management system to a standard CSV file. It exports only assets of the active inventory, i.e. excluding "discarded assets", "basket" and other system objects.
     
## Syntax command lines
      
**ExportUtil** **/csv** *"path and name of CSV file"* {**/con** *"connection string"*         |   **/server** *"database server name"* **/db** *"database name"*}  **/cols**"list of columns" [**/NotEmpty**         "column name"] [**/TemplateFolder** "folder name"]   [**/where** {[@class] | [@name] | [@path] | [&lt;object property name&gt;]}&lt;operator&gt;&lt;value&gt;]
      
## Detailed description of parameters

| **Parameter** | **Description** |
| --- | --- |
| **/csv** | The path and name of the CSV file where the object information will be saved. |
| **/con                    /server                    /db** | These parameters are used to set the connection to the Alvao database. It is possible to use a connection string (e.g. **/con** *"Data source=.\sqlexpress;Initial Catalog=test;Integrated Security = True;TrustServerCertificate=True"*), or simply specify a specific SQL server and DB (e.g. **/server** *".\sqlexpress"* **/db** *"test"*).  <br>
                    In case you use the **/server** parameters
  and **/db**, the database connection is made using Windows Integrated Authentication. If you specify all these parameters, only **/con** is used
  parameter, **/server** and **/db**
                    will be ignored. |
| **/cols** | Column definitions that will be exported to the output file. See below. |
| **/NotEmpty** | This parameter is for backwards compatibility and will be removed in future versions. We recommend using the **/where** parameter instead.
  It only exports objects where the value of a specific object property is not an empty value.  <br>
> [!NOTE]
> The property name can be written without diacritics. |

| **/TemplateFolder** | This parameter is for backwards compatibility and will be removed in future versions. We recommend using the **/where** parameter instead.
  It only exports certain types of objects lying in object templates under a certain folder. The parameter is the folder name.  <br>
> [!NOTE]
> The folder name can be written without diacritics. |

| **/where** | Used to filter exported objects by type, name, path in the tree, and property values. Follow the switch with the logical filter expression in quotes. All objects for which the expression is satisfied will be exported.  <br>
                    You can use the following variables in the expression:
                        <ul>
                            .
  <li>[@class] - object kind</li>
                            <li>[@name] - name of the object in the tree</li>
                            <li>[@path] - path in the tree, the "/" character is used as a level separator</li>
                            .
  <li>[&lt;object property name&gt;] - value of a certain object property, e.g. [Serial number].<br>
> [!NOTE]
> property names can be entered without diacritics.</li>

                        </ul>

                    Konstanty:
                        <ul>
                            <li>N'&lt;text constant&gt;' - text in unicode, e.g. N'Petr Novák'.</li>
                            <li>'&lt;text constant&gt;' - text in ASCII (without diacritics), e.g. 'Serial number'.</li>
                            <li>&lt;numeric constant&gt; - e.g. 12.</li>
                        </ul>

                    Operators:
                        <ul>
                            <li>= - equals, e.g., [@class]=N'Computer/server'</li>
                            <li>!=, &lt;&gt; - does not equal, e.g. [@class]&lt;&gt;N'Computer/server'</li>
                            <li>IN - value equals one of the specified values, e.g. [@class]IN (N'Computer/server', N'Computer/virtual')</li>
                            <li>LIKE - string comparison with the possibility of using simple regular expressions. E.g. object kind starting with 'Computer/': [@class] LIKE N'Computer/%')</li>
                            <li>NOT - negation of IN or LIKE operators, e.g. [@class] NOT LIKE N'Computer/%')</li>
                            <li>IS NULL - the value is NULL - e.g. the object does not have the property Serial number: [Serial number] IS NULL.</li>
                        </ul>
                    You can concatenate parts of an expression using AND and OR operators.  <br>

                      <br>
                    <br>
                        <br><br>
                        <br>Note:<br>

## Description of supported columns
     
Columns are set in the **/cols** parameter   are separated by a comma. We recommend enclosing the entire parameter value in quotes.

| **Column** | **Importance** | **Example value** |
| --- | --- | --- |
| **@id** | The unique identifier (INT number) of the object in the Asset Management database (NodeId). | 1245 |
| **@name** | The name of the object in the object tree. | HP LP2475w, LCD, 24" |
| **@class** | Object kind. | Monitor |
| **@path** | The path to the object in the object tree. | Organization/Brno/Petr Novák |
| **@adguid** | GUID identifier of the object from Active Directory (contains the value if the object was created or paired using an AD import). | {f50c0d0f-fede-4aaa-9509-7632e48251cc} |
| **[object property]** | Any object property. Properties must be written in square brackets.  <br>
> [!NOTE]
> The property name can be accented or unaccented. | SN1234 |


Example of parameter value: "@id,@name,@path,@class,[serial number],[inventory number],[name in network]"
     
## Scenarios
      
### Export objects that have a value in the property "Inventory number"

    ExportUtil.exe /csv "c:\data\objects.csv" /server server\sql2005 /db alvao /cols "@id,@name,@path,@class,[serial number],[inventory number],[name in siti]" /where "[inventory number]!=''"

### Export all objects where the object template is in the folder "IT assets" in object templates

    ExportUtil.exe /csv "c:\data\objects.csv" /server server\sql2005 /db alvao /cols "@id,@name,@path,@class,[serial number],[inventory number],[name in siti]" /where "[@class] IN (SELECT txtClass FROM vNodeClass WHERE txtPath LIKE N'Object Templates/Inventory IT%')"

### Export all mobile phones

    ExportUtil.exe /csv "c:\data\objects.csv" /server server\sql2005 /db alvao /cols "@id,@name,@path,@class,[serial number],[inventory number],[inventory number],[name in network]" /where "[@class]=N'Mobile phone'"

### Export all iPhone 7 mobile phones

    ExportUtil.exe /csv "c:\data\objects.csv" /server server\sql2005 /db alvao /cols "@id,@name,@path,@class,[serial number],[inventory number],[name in network]" /where "[@class]=N'Mobile phone' AND [Model]=N'iPhone 7'"

### Export of all mobile phones in Brno branch

    ExportUtil.exe /csv "c:\data\objects.csv" /server server\sql2005 /db alvao /cols "@id,@name,@path,@class,[serial number],[inventory number],[name in network]" /where "[@class]=N'Mobile phone' AND [@path] LIKE N'Organization/Brno/%'"
