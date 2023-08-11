# ImportUtil
      
## Function description
     
This utility is used to import objects from CSV files into Asset Management. The utility uses *Object Templates* from AM during import.
     
## CSV file structure
     
The CSV file must have a semicolon as the value separator. The first line must contain the column names:

| **Column** | **Description** |
| --- | --- |
| **Class** or **Species** | The name of the type of the imported object. |
| **SwProfile** | The software profile of the computer object. The values specified in this column must match the names of existing software profiles. If the value is blank, the computer's software profile is set to "All software is enabled". |
| **NodeId** | The unique number of each object in the AM (can be displayed on the Child Objects tab, or in the Object Lists window). If the NodeId column is used in the **-keyfields** parameter
 and there is no value in the NodeId column, a new object is created. If an object with a specific NodeId does not exist in the database, a warning is issued and the object is not updated or a new object is created. |
| **&lt;property name&gt;** | The name of any object property in Asset Management (e.g., "Purchase Date"). |

> [!NOTE]
> We recommend using UTF-8 encoding.

## Command line syntax
      
**ImportUtil**         **-input** *name of input CSV file*         {**-conn** *connection string* |   **-server** *name of database server* **-db** *name of database*}   [**-class** *object type*]   [**-separator** *column separator used in CSV file*]   [**-keyfields** *identification column[,identification column ...]]*         [**-parentnodeid** *NodeId*]   [**-import**]   [**-force**]
      
## Parameters description

| **Parameter** | **Description** |
| --- | --- |
| **-class** | Using this parameter, you can specify the type of object in the input data (e.g. **-class** *Monitor*).  <br>
                    This parameter is mandatory if the source file does not contain a Type or Class column. If the input file contains the Type column and the **-class** *Class parameter is specified object kind*, only rows that have a matching entry in the Type column with *object kind* are included in the import. |
| **-conn                    -server                    -db** | These parameters are used to set the connection to the Alvao database. It is possible to use a connection string (e.g. **-conn** *Data source=.\sqlexpress;Initial Catalog=test;Integrated Security = True;TrustServerCertificate=True*), or simply specify a specific SQL server and DB (e.g. **-server** *.\sqlexpress* **-db**
                    *test*).  <br>
                    In case you use the **-server** parameters
 and **-db**, the database connection is made using Windows Integrated Authentication. If you specify all these parameters, only **-conn** is used
 parameter, **-server** and **-db**
                    will be ignored. |
| -**datetimeformat** | Date format in text strings (e.g. dd/MM/yyyy).
 If the parameter is not specified, the format is automatically detected during conversion. A detailed description of the possible formats can be found in [MSDN](https://msdn.microsoft.com/en-us/library/8kb3ddd4%28v=vs.110%29). |
| -**separator** | Using this parameter, you can specify the column separator used in the imported CSV file. E.g., -separator "," |
| **-force** | If used, the data is imported into the database even if there is an error in one of the entries. Without it, any error will cause no record to be imported. |
| **-import** | If used, the data is imported into the database, otherwise only the validity of the import is checked. |
| **-input** | Used for specifying the path and name of the input CSV file (e.g. *em D:\import\import.csv*) |
| **-keyfields** | Parameter used to identify and update existing objects. The specified columns together form a unique identifier (e.g. **-keyfields** Serial number, Model).
 If the identifier does not correspond to any item in the database, a new object is created in the **Read Objects** folder or in the folder specified by the **-parentnodetid** parameter.
 <br>
     <br><br>
     <br>Note:<br>
 NodeId), no other columns can be used in the parameter. See the description of the NodeId column for more information. |
| **-parentnodeid** | Create new objects as child objects under the object with ID: *NodeId*.
 <br>
     <br><br>
     <br>Note:<br>
 by displaying the system NodeId column, or in the database in the [tblNode](../implementation/customization/database#U_dbo.tblNode).intNodeId table. |
| **-scrapped** | If used, the assets in the scrapped asset are also searched for and updated on import. |

            Note:
        The following is a list of errors that are ignored when using the **-** **force** parameter and do not cause the entire import to fail.
Errors counted in the result as skipped records:

- Multiple objects with a key value occurring in columns selected by the -keyfields parameter. For more information on the -keyfields parameter, see above.
- Nonexistent template in the database for an object in the file. For more information, see the -class parameter above.
- Duplicate records in the input file.

Characters counted in the result as failed records:

- An error when creating an object according to an object template, including the template for the computer report that is used when creating an object with the Computer object kind.
- Error when updating an object in the database.

## Examples of use
      
**ImportUtil.exe** **-input** *import.csv***-server***.\sqlexpress***-db***AlvaoSample*     **-separator** ","
     
This command checks the validity of the *import.csv* file format in the current directory against the *AlvaoSample* database at *local SQL Server*.
     
**ImportUtil.exe** **-input** *import.csv***-server***.\sqlexpress***-db***AlvaoSample*         **-import**
     
This command imports data from the *import.csv* file into the *strong* database.  *AlvaoSample* on the *local SQL Server*. In **AM**         **Read Objects** folder, the corresponding new objects will be created.
     
**ImportUtil.exe** **-input** *. import.csv***-server***.\sqlexpress***-db***AlvaoSample* **-parentnodeid** *92*         **-import**
     
This command imports data from the *import.csv* file into the *strong* database.  *AlvaoSample* on the *local SQL Server*. In **AM**         the corresponding new objects are created under the object in the tree with the NodeId with the value *92*.
     
**ImportUtil.exe** **-input** *. update\_db.csv***-server***.\sqlexpress***-db***AlvaoSample* **-import** **-keyfields** *<q>registration mark</q>*
     
This command updates objects that have a *registration tag* entry that matches a value in the *update\_db.csv* file in the *em>strongrong database*.   *AlvaoSample* on the *local SQL Server*. In **AM**         properties of identified objects are updated, or non-existent objects are created in the **Read Objects** folder.
     
**ImportUtil.exe** **-input** *update\_db.csv***-server***.\sqlexpress***-db***AlvaoSample* **-import** **-keyfields** *NodeId*
     
The command updates the property values of objects according to the CSV file whose NodeId matches the values in the CSV file.

            Note:
        To test the functionality of the above commands, you can use the sample CSV files [import.csv](annexes/import.csv) and [update\_db.csv](annexes/update_db.csv).
