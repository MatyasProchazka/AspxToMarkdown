# Full-Text Search
      
Alvao can quickly search information in the database using *Full-Text Search* (FTS) technology. If FTS is disabled, searches can be slow and the search function of the request logs is not available at all.

> [!NOTE]
> If the **Full-Text and Semantics Extractions for Search** component was installed on SQL Server at the time of the Alvao upgrade to the current version, FTS will be automatically enabled during the upgrade.

## Check to enable Full-Text Search
     
Check FTS installation and settings with SQL script:

    IF (1 != ISNULL(fulltextserviceproperty('IsFulltextInstalled'),0)) PRINT N'FTS is not installed.' ELSE 
    IF (1 != ISNULL((SELECT 1 FROM [dbo].[sysfulltextcatalogs] WHERE name = 'ftCatalogAlvao'),0)) 
    PRINT N'FTS is not enabled.' ELSE PRINT N'FTS is installed and enabled.'

If FTS is not installed, install the **Full-Text and Semantics Extractions for Search** component, which is an optional component of *SQL Database Engine*, into SQL Server. You can install this component during the initial installation of MS SQL Server, or you can [install](http://msdn.microsoft.com/en-us/library/cc281940) later with the SQL Server installer for any edition.

> [!NOTE]
> As of version 2012, SQL Server no longer considers the underscore ("\_") to be a word separator by default.  Because of this, as of this version, you cannot search for individual words that are separated by an underscore in the text, but you must enter the entire "phrase" including the underscores or the initial part of the phrase into the search engine.  If you are not comfortable with this behavior, you can [set SQL Server](https://docs.microsoft.com/en-us/previous-versions/sql/sql-server-2012/gg509108%28v=sql.110%29?redirectedfrom=MSDN) to use the same word separators as older versions.

## Full-Text Search

> [!CAUTION]
> It is recommended that the FTS be turned on at times outside of Alvao's normal operating hours. When FTS is turned on, SQL Server will begin creating indexes for searches, which may temporarily degrade SQL Server performance.

If FTS is not enabled in the Alvao database, run the following SQL script.To run it, you must be a member of the **sysadmin** group, **db\_owner**, or **db\_ddladmin**.

    DECLARE @languageLCID int;
    SELECT TOP 1 @languageLCID = lcid from syslanguages where langid = @@DEFAULT_LANGID;
    DECLARE @CreateFulltext nvarchar(MAX);
    SET @CreateFulltext = N'CREATE FULLTEXT CATALOG ftCatalogAlvao WITH ACCENT_SENSITIVITY = OFF AS DEFAULT; 
    CREATE FULLTEXT INDEX ON tHdTicket (FullTextSearch LANGUAGE '+CAST(@languageLCID AS nvarchar)+N', mHdTicketNotice LANGUAGE '+CAST(@languageLCID AS nvarchar)+N', sHdTicket LANGUAGE '+CAST(@languageLCID AS nvarchar)+N') KEY INDEX PK_tHdTicket_iHdTicketId WITH STOPLIST OFF; 
    CREATE FULLTEXT INDEX ON tAct (sAct LANGUAGE '+CAST(@languageLCID AS nvarchar)+N', mActNotice LANGUAGE '+CAST(@languageLCID AS nvarchar)+N', sActFrom  LANGUAGE ' 
    +CAST(@languageLCID AS nvarchar)+N', sActTo LANGUAGE '+CAST(@languageLCID AS nvarchar)+N', sActToEmail LANGUAGE '+CAST(@languageLCID AS nvarchar)+N', sActFromEmail LANGUAGE '
    +CAST(@languageLCID AS nvarchar)+N') KEY INDEX PK_tAct_iActId WITH STOPLIST OFF;
    CREATE FULLTEXT INDEX ON tDocument (sDocument LANGUAGE '+CAST(@languageLCID AS nvarchar)+N') KEY INDEX PK_tDocument_iDocumentId WITH STOPLIST OFF;
    CREATE FULLTEXT INDEX ON tArticle  (HtmlArticleBinary TYPE COLUMN HtmlArticleBinaryExt, sArticle, mArticleAnnotation, mArticle  LANGUAGE '+CAST(@languageLCID AS nvarchar)+N') KEY INDEX PK_tArticle_iArticleId;
    CREATE FULLTEXT INDEX ON tHdTicketApprovalItem (mHdTicketApprovalItemNotes LANGUAGE '+CAST(@languageLCID AS nvarchar)+N') KEY INDEX PK_tHdTicketApprovalItem WITH STOPLIST OFF;
    CREATE FULLTEXT INDEX ON HdSectionLoc (HdSectionKeywords LANGUAGE '+CAST(@languageLCID AS nvarchar)+N') KEY INDEX PK_HdSectionLoc_HdSectionLocId WITH STOPLIST OFF;';
    EXECUTE sp_executesql @CreateFulltext;

        Note
:

This script inflects the search for words according to the default language of the database. If you want to inflect words according to another language, replace the second line with a line such as:

    SET @languageLCID = 1029

Replace the number 1029 with the code of the national environment you want to use for word inflection.

        If you want to change the language afterwards, turn FTS off and on again.

## Off Full-Text Search
      
To disable the Full-Text Search catalog, run the following SQL script.You must be a member of the **sysadmin** group, **db\_owner**, or **db\_ddladmin**.

    DROP FULLTEXT INDEX ON tHdTicket;
    DROP FULLTEXT INDEX ON tAct;
    DROP FULLTEXT INDEX ON tDocument;
    IF EXISTS (SELECT * FROM sys.tables t INNER JOIN  sys.fulltext_indexes fi ON t.[object_id] = fi.[object_id] WHERE t.name= 'tArticle')
    DROP FULLTEXT INDEX ON tArticle;
    IF EXISTS (SELECT * FROM sys.tables t INNER JOIN  sys.fulltext_indexes fi ON t.[object_id] = fi.[object_id] WHERE t.name= 'tHdTicketApproval')
    DROP FULLTEXT INDEX ON tHdTicketApproval;
    IF EXISTS (SELECT * FROM sys.tables t INNER JOIN  sys.fulltext_indexes fi ON t.[object_id] = fi.[object_id] WHERE t.name= 'tHdTicketApprovalItem')
    DROP FULLTEXT INDEX ON tHdTicketApprovalItem;
    IF EXISTS (SELECT * FROM sys.tables t INNER JOIN  sys.fulltext_indexes fi ON t.[object_id] = fi.[object_id] WHERE t.name= 'HdSectionLoc')
    DROP FULLTEXT INDEX ON HdSectionLoc;
    DROP FULLTEXT CATALOG ftCatalogAlvao;
