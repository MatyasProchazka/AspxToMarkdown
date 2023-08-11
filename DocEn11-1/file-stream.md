# Saving attachments outside the database
      
The attachments that usually take up the largest part of the entire database can be stored outside the database using filestream technology. The size of the attachments is then not counted in the size of the database itself.
     
Check this option if the queries often contain attachments, which then significantly increase the size of the database, and you want to use Alvao on Microsoft SQL Server Express, where the database size is limited.

> [!NOTE]
> Setting attachments to be stored outside the database does not affect Alvao performance.

## Deactivate the option to save attachments outside the database
     
1. **Enable filestream on MS SQL server**
    - **Enable filestream during MS SQL Server installation**
        1. Open the Database Engine Configuration page.
        2. On the FILESTREAM tab, enable the following options in turn:
            - Enable FILESTREAM for Transact-SQL access
            - Enable FILESTREAM for file I/O streaming access
            - Allow remove clients to have streaming access to FILESTREAM data
        3. Continue installation.
    - **Enabling filestream after MS SQL Server installation**
        1. Start SQL Server Configuration Manager.
        2. Right-click on the SQL Server Service instance you want to enable filestream.
        3. On the FILESTREAM tab, turn on all options one by one.
        4. Save by clicking OK.
        5. Launch SQL Server Management Studio
        6. Run the following SQL script over the target DB Alvao:
            - EXEC sp\_configure filestream\_access\_level, 2  

                        GO  

                        RECONFIGURE  

                        GO
2. **Adding a filestream to the database**
    1. Launch SQL Server Management Studio.
    2. Run the Alvao SQL script over the target DB:
        - ALTER DATABASE [**&lt;database\_name&gt;**]  

                    ADD FILEGROUP fstDocumentGroup contains filestream;  

                    go  

                    declare @db\_name varchar (MAX)  

                    declare @filestream\_loc varchar (MAX)  

                    SELECT @db\_name = physical\_name FROM sys.master\_files WHERE database\_id = DB\_ID(DB\_NAME())
 AND type\_desc = 'ROWS'  

                    set @db\_name =
 REVERSE(RIGHT(REVERSE(@db\_name),(LEN(@db\_name)-CHARINDEX('\',
 REVERSE(@db\_name),1))+1))  

                    set @filestream\_loc = @db\_name +
 'AlvaoFileStream'  

                    DECLARE @AddFileSql varchar(max);  

                    SET @AddFileSql = 'ALTER DATABASE [**&lt;database\_name&gt;**]  

                    ADD FILE  

                    ( NAME = ''fstDocument'',
 FILENAME = ' + QuoteName( @filestream\_loc, '''' ) + ')

                    TO FILEGROUP [fstDocumentGroup];  

                    ';  

                    EXEC (@AddFileSql);

> [!NOTE]
> The above script will create a folder to store the filestream in the database files folder.  

                    If you want to store the filestream in a custom defined folder, then enter the folder name including the absolute path into the @filestream\_loc variable:  

        - ALTER DATABASE [**&lt;database\_name&gt;**]  

                            ADD FILEGROUP fstDocumentGroup contains filestream;  

                            go  

                            declare @filestream\_loc varchar (MAX)  

                            set @filestream\_loc = 'C:\&lt;path&gt;\&lt;folder\_with\_filestream&gt;'  

                            DECLARE @AddFileSql varchar(max);  

                            SET @AddFileSql = 'ALTER DATABASE [**&lt;database\_name&gt;**]  

                            ADD FILE  

                            ( NAME = ''fstDocument'',
 FILENAME = ' + QuoteName( @filestream\_loc, '''' ) + ')

                            TO FILEGROUP [fstDocumentGroup];  

                            ';  

                            EXEC(@AddFileSql);

> [!CAUTION]
> The target folder must not exist at the time the script is run. It will be automatically created when the script is run.

3. **Adding filestream to tDocument table**
    1. Launch SQL Server Management Studio.
    2. Run the Alvao SQL script over the target DB:
        - ALTER TABLE dbo.tDocument SET (FILESTREAM\_ON =
 fstDocumentGroup)  

                    GO  

                    ALTER TABLE dbo.tDocument  

                    ADD TempColumn varbinary(max) FILESTREAM NULL  

                    GO  

                    DECLARE @curId INT  

                    DECLARE @db\_cursor CURSOR

                    SET @db\_cursor = CURSOR FOR  

                    SELECT iDocumentId FROM dbo.tDocument WHERE oDocument IS NOT NULL  

                    OPEN @db\_cursor

                    FETCH NEXT FROM @db\_cursor INTO @curId  

                    WHILE @@FETCH\_STATUS = 0  

                    BEGIN  

                    UPDATE dbo.tDocument SET TempColumn = oDocument WHERE iDocumentId = @curId  

                    UPDATE dbo.tDocument SET oDocument = NULL WHERE iDocumentId = @curId  

                    FETCH NEXT FROM @db\_cursor INTO @curId  

                    END  

                    CLOSE @db\_cursor  

                    DEALLOCATE @db\_cursor  

                    GO

                    ALTER TABLE dbo.tDocument DROP COLUMN oDocument  

                    GO  

                    EXEC sp\_rename 'dbo.tDocument.TempColumn',
 'oDocument', 'COLUMN'  

                    GO

## Disabling the option to save attachments outside the database

1. **Removing filestream from tDocument table**
    1. In SQL Server Management Studio, run the following script over the target DB Alvao:
        - ALTER TABLE dbo.tDocument ADD TempColumn varbinary(max)  

                    GO  

                    DECLARE @curId INT  

                    DECLARE @db\_cursor CURSOR

                    SET @db\_cursor = CURSOR FOR  

                    SELECT iDocumentId FROM dbo.tDocument WHERE oDocument IS NOT NULL  

                    OPEN @db\_cursor

                    FETCH NEXT FROM @db\_cursor INTO @curId  

                    WHILE @@FETCH\_STATUS = 0  

                    BEGIN  

                    UPDATE dbo.tDocument SET TempColumn = oDocument WHERE iDocumentId = @curId  

                    UPDATE dbo.tDocument SET oDocument = NULL WHERE iDocumentId = @curId  

                    FETCH NEXT FROM @db\_cursor INTO @curId  

                    END  

                    CLOSE @db\_cursor  

                    DEALLOCATE @db\_cursor  

                    GO  

                    ALTER TABLE dbo.tDocument DROP COLUMN oDocument  

                    GO  

                    EXEC sp\_rename 'dbo.tDocument.TempColumn',
 'oDocument', 'COLUMN'  

                    GO  

                    ALTER TABLE dbo.tDocument set (filestream\_on = "NULL")
2. **Removing the filestream from the database**
    1. In SQL Management Studio, run the script:
        - ALTER DATABASE [**&lt;database\_name&gt;**]
 REMOVE FILE fstDocument  

                    GO  

                    ALTER DATABASE [**&lt;database\_name&gt;**]
 REMOVE FILEGROUP fstDocumentGroup  

                    GO
3. **Disabling filestream on MS SQL Server**
    - **Disabling in SQL Configuration Manager**
        1. Launch SQL Server Management Studio.
        2. Run the Alvao SQL script over the target DB:
            - EXEC sp\_configure filestream\_access\_level, 0  

                        GO  

                        RECONFIGURE  

                        GO
        3. Launch SQL Server Configuration Manager.
        4. Right-click the SQL Server Service instance on which you want to disable the filestream.
        5. On the FILESTREAM tab, disable all options one by one.
        6. Save by clicking OK.
