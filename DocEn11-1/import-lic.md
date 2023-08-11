# Import of licenses
      
## Function description
      
The ImportLic application is used to import licenses from a CSV file, including assignment to individual computers or users.  It can also be run in a mode to synchronize assigned licenses with an external system.
       
## Syntax command lines
      
**ImportLic.exe** **/input** *"path and name of CSV file"* {**/conn** *"connection string"* |   **/server** *"database server name"* **/db** *"database name"*} [**/import**] [**/mode** {ImportLicenses | UpdateItems}]   [**/force**] [**/headers**] [**/help**]
      
## Detailed description of parameters

| Parameter | Description |
| --- | --- |
| /input | The path and name of the CSV file from which the import is to be performed. |
| /conn  <br>
                    /server  <br>
                    /db | These parameters are used to set the connection to the Alvao database. A connection string can be used (e.g. **/conn** *"Data source=.\sqlexpress;Initial Catalog=test;Integrated Security = True;TrustServerCertificate=True"*),
                      <br>
                    or simply specify a specific SQL server and DB (e.g. **/server** *".\sqlexpress"* **/db** *"test"*).  <br>
                    In case you use the **/server** parameters and **/db**, the database connection is made using Windows Integrated Authentication. If you specify all of these parameters,
                      <br>
                    only **/conn** parameter will be used, **/server** and **/db**
                    will be ignored. |
| /import | Import Data. If you do not use this switch, only the syntax check of the data in the CSV file is performed. |
| /mode | Import mode:
                    <ul>
 <li>ImportLicenses - import new licenses. This is the default mode.</li>
                        <li>UpdateItems - import license items in a per-user licensing model, i.e. assigning or removing licenses to specific users.</li>
                    </ul>
                    Detailed description of the modes can be found below. |
| /force | Forces import of data even if there are errors in the data. |
| /headers | Use if the first line of the file contains column names. |

## ImportLicenses
     
Import new licenses, including documents, and assign the created licenses to computers or users.
     
### Description of all supported columns

> [!CAUTION]
> The order of the columns is fixed, it does not depend on the column name.  

        Therefore, the imported file must contain all columns, only the values in some of them can be empty.  

        This is also true if the *force* parameter is used.

> [!CAUTION]
> Dates must be entered in the correct format, e.g. "1.12.2014" or "2015-12-01".

#### License

| Name of column in CSV | Options | Check | Mandatory |
| --- | --- | --- | --- |
| Product | Exact product name from the ALVAO SWLIB software product library. | Yes | Yes |
| Language ID (LangId) | License language - can be either an empty value or the language code number (INT type) that is in the database:  <br>
                    (1029=CZE, 1051=SVK, 1033=ENG, 1031=GER, 1036=FRA, 1034=SPA, 1040=ITA, 1038=HUN, 1045=POL, 1049=RUS, 1060=SLO, 1053=SWE, 1055=TUR, 1050=CRO, 1041=JAP). | Yes | No |
| License name | Name of an existing license in the database, or an empty value (the license name will then be the same as the product name). | No | No |
| Number | Number of licenses purchased - INT number, must be entered. | Yes | Yes |
| License Type | One of the following values must be entered: *em> per device, per user, per connection, per processor or per core.* | Yes | Yes |
| License Mode | Any text can be entered, we recommend using one of the following values: *Rental*, *Assurance*, *Assurance*, *Select* or *Open*. | No | No |
| Activity from | Date from which the license is valid - the date must be entered in the correct format. | Yes | Yes |
| Valid until | Date until which the license is valid - can be a blank value or the correct date format. | Yes | No |
| Support to | Date until which the license is supported - can be a blank value or the correct date format. | Yes | No |
| License type | License Type - must be one of the following values.
 Float, *Multi, OEM* or CAL. | Yes | Yes |
| License Activation Key | License Activation Key - enter any text or an empty value. | No | No |
| License Inventory Number | License Inventory Number - enter any text or a blank value. | No | No |
| Certificate Number | Any text or empty value - if specified, the program searches for the certificate by this number in the DB.  <br>
                    If it finds it, it assigns the created license to the found certificate from the DB, otherwise it creates a document of type "Certificate" and assigns it to the currently created license. | No | No |
| Request | Request for license - enter any text or a blank value. | No | No |
| License Cost Center | License cost center - enter any text or a blank value. | No | No |
| Price | License price - must be any number of type INT, or an empty value. | Yes | No |
| Web address | If this is a product downloaded from the Internet, enter the URL link to download the product, or a blank value. | No | No |
| Bundle | If the product is part of a bundle package, enter "*1*",
 if not, enter "*0*". | Yes | Yes |
| Organisation | The name of the [organization](licenses) that owns the license. If you specify a blank value, the license can be assigned to computers or users from any organization. | Yes | No |
| Note | License Note - enter any text or a blank value. | No | No |

#### License Items
     This section does not need to be filled in for a license - in this case the license will be created without license items. 

| CSL column name | Options | Check | Mandatory |
| --- | --- | --- | --- |
| Computer | Network name of a specific computer in the DB - the computer must exist in the database. | Yes | No |
| Item Activation Key | License Item Activation Key - enter any text or a blank value. | No | No |
| Item cost centre | License Item Cost Center - enter any text or a blank value. | No | No |
| Inventory item number | License Item Inventory Number - enter any text or a blank value. | No | No |
| Item Request | License Item Request - enter any text or a blank value. | No | No |
| Item Note | License Item Note - enter any text or a blank value. | No | No |

#### Document
     Again, this section does not need to be filled in. In this case, no document is created for the newly created license. Documents are stored in the [document-folder](../../list-of-windows/alvao-webapp/administration/asset-management/document-folders/document-folder) with the smallest ID that is linked to the software license (usually the *All Documents* folder).  

| Name of column in CSV | Options | Check | Mandatory |
| --- | --- | --- | --- |
| Invoice number | Enter any text or a blank value. | No | No |
| Invoice number 2 | Enter any text or blank value. | No | No |
| Date of issue | Invoice issue date - the date must be entered in the correct format. | Yes | No |
| Path to attachment | Path to document attachment (searched in shared documents), or empty value. | No | No |
| Supplier | The name of the supplier in DB is searched, if found, the found record is assigned, otherwise a new supplier with this name is created. It can also be an empty value. | No | No |
| Document note | Enter any text or blank value. | No | No |

### Chefs
     
#### Sample CSV file

    Product;LangId;License Name;Number;License kind;License Mode;Valid From;Valid until;SupportUntil;License Type;Asset. license key;License inv. no.;Cert. number;Request;Cost. center;Price;Web. address;Bundle?;Organization;License note;Computer;Item activ. key.;Item cost center;Item inv. no.;Item rquest;Item note;Invoice no.;Invoice no. 2;Issue date;Attachement path;Supplier;Invoice note
    Microsoft Windows 2000 Professional;;Win2k;1;per device;Assurance;30.01.2007;15.12.2030;15.05.2008;float;AK-1234;IC-ALL-1234;Cert1;Pozad1;Strd1;1534;www.seznam.cz;0;Organizace;Poznamka k licenci1;PC1;AK-PC-1;StredPc1;IC-PC-1;REQ-ITM-1;Pozn PC1;CF-1234;CF-2-1234;15.08.2006;Faktury\f01.doc;DOD1;Pozn. doc. 1
    Microsoft Windows XP Professional;1029;WinXP;1;per device;Assurance;15.01.2007;15.08.2030;15.05.2008;normal;AK-1234;IC-ALL-1234;Cert1;Pozad1;Strd1;1534;;0;;Poznámka k licenci1;PC1;AK-PC-1;StredPc1;IC-PC-1;REQ-ITM-2;Pozn PC1;CF-1234;CF-2-1234;15.08.2006;Faktury\f01.doc;DOD1;Pozn. doc. 1
    Microsoft Windows 2000 Professional;1029;Win2k;1;per device;Assurance;15.01.2007;15.08.2030;15.05.2008;normal;AK-1234;IC-ALL-1234;Cert1;Pozad1;Strd1;1534;;0;;Poznámka k licenci1;PC2;AK-PC-2;StredPc2;IC-PC-2;REQ-ITM-3;Pozn PC2;CF-1234;CF-2-1234;15.08.2006;Faktury\f01.doc;DOD2;Pozn. doc. 2
    Microsoft Windows XP Professional;1033;;2;per device;Assurance;15.01.2008;;15.01.2010;multi;AK-888;IC-ALL-8888;Cert2;Pozad2;Strd1;2256;;0;;Poznámka k licenci2;PC1;AK-PC-1;StredPc1;IC-PC3;REQ-ITM-4;Pozn PC1;CF-8888;CF-2-1237;15.08.2008;Faktury\f02.doc;DOD1;Pozn. doc. 2
    Microsoft Windows XP Professional;1033;;2;per device;Assurance;15.01.2008;;15.01.2010;multi;AK-888;IC-ALL-8888;Cert2;Pozad2;Strd1;2256;;0;;Poznámka k licenci2;PC2;AK-PC-2;StredPc2;IC-PC2;REQ-ITM-4;Pozn PC2;CF-8888;CF-2-1237;15.08.2008;Faktury\f02.doc;DOD1;Pozn. doc. 2

#### CSV import with recommended structure
      
CSV contains a header with column names. The data in the file will be checked before importing. If the data is incorrect, the import will not be performed.  
         Import command line:
     ImportLic.exe /input "c:\data\licence.csv" /server server\sql2008 /db alvao /import /headers      
#### Import multiple license items to one license
     
You do this by copying the row with the data in the "License" section, changing only the "License Items" section. Example CSV import of one license with 3 items:

    Product;LangId;License Name;Number;License kind;License Mode;Valid From;Valid until;SupportUntil;License Type;Asset. license key;License inv. no.;Cert. number;Request;Cost. center;Price;Web. address;Bundle?;Organization;License note;Computer;Item activ. key.;Item cost center;Item inv. no.;Item rquest;Item note
    Microsoft Windows XP Professional;1033;;3;per device;Assurance;15.01.2008;;15.01.2010;multi;AK-888;IC-ALL-8888;Cert2;Pozad2;Strd1;2256;;0;;Poznámka k licenci2;PC1;AK-PC-1;StredPc1;IC-1;REQ-ITM-4;Pozn. 1
    Microsoft Windows XP Professional;1033;;3;per device;Assurance;15.01.2008;;15.01.2010;multi;AK-888;IC-ALL-8888;Cert2;Pozad2;Strd1;2256;;0;;Poznámka k licenci2;PC2;AK-PC-2;StredPc2;IC-2;REQ-ITM-4;Pozn. 2
    Microsoft Windows XP Professional;1033;;3;per device;Assurance;15.01.2008;;15.01.2010;multi;AK-888;IC-ALL-8888;Cert2;Pozad2;Strd1;2256;;0;;Poznámka k licenci2;PC3;;StredPc2;IC-3;REQ-ITM-4;Pozn. 3

> [!NOTE]
> The CSV contains 2 license entries that will be assigned to PC1 and PC2 and the last entry will not be assigned to any computer.

#### We don't have complete data
      
For the time being, we want to upload incomplete data, which will be corrected as soon as there is supporting information.  
         We are only uploading values to a few columns that we have defined in the header. The file will not be checked and we will force the import of even incomplete and incorrect data.  
         Import command line:
      ImportLic.exe /input "c:\data\licence.csv" /server server\sql2008 /db alvao /force /headers      
## UpdateItems mode
     
Synchronize assigned licenses to users with an external system (e.g. M365).
     
The input CSV contains a list of licenses and the users to be assigned those licenses.
      
### Setting and checking input data
     
In the external system, set the export to a CSV file to exactly match the description of the columns below.
     
Before starting the import into Alvao, make sure that:
     
1. All the licenses you want to synchronize,
    1. have been set to [*License ID on the external system*](../../list-of-windows/alvao-asset-management-console/software/license-registry/edit/edit-license/general), which is used to match the license to the external resource (records for non-existent Ids are skipped),
    2. have a *per-user* licensing model set, and
    3. have *automatic allocation* disabled.
2. The *User* object template contains the *E-mail* property. This property matches users in CSV with users in Alvao.
3. All users listed in the CSV exist in AM as objects in the tree, and their email address is unique within the active record.
    1. Non-existing users are automatically created in the *Read Objects* folder.
    2. When multiple users with the same email are found, the license is assigned to the one with the lower *Id*.
4. The input CSV contains all users to whom the license is assigned. Others will have their license automatically revoked.

### Description of all supported columns

> [!CAUTION]
> The order of the columns is fixed, it does not depend on the column name.  

        Therefore, the imported file must contain all columns, only the values in some of them can be empty.  

        This is also true if the *force* parameter is used.

| Name of column in CSV | Options | Check | Mandatory |
| --- | --- | --- | --- |
| UId | License ID in the external system. See AM Console - License registry -
 [Edit license](../../list-of-windows/alvao-asset-management-console/software/license-registry/edit/edit-license/general). | No | Yes |
| LicCount | Total number of licenses purchased. | Yes | No |
| UserEmail | User e-mail | Yes | Yes |
| UserName | UserName | No | No |

### Sample CSV file

    UId;LicCount;UserEmail;UserName
    Alvao:POWER_BI_PRO;10;mirek.vesely@alvao.com;Mirek Veselý | ALVAO
    Alvao:POWER_BI_PRO;10;david.ostry@alvao.com;David Ostrý | ALVAO
    Alvao:FLOW_FREE;;david.ostry@alvao.com;

 - Download the code [here](licosoby.csv)
       
### Import CSV with recommended structure
     
CSV contains a header with column names. The data in the file will be checked before the import. If the data is incorrect, the import will not be performed.  
         Import command line:

    ImportLic.exe /input "c:\data\licenceItems.csv" /server server\sql /db alvao /import /mode UpdateItems /headers
