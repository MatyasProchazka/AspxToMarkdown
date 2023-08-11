# REP print report templates
      
You can manage print report templates in *WebApp - Administration - Asset Management -*[Print report templates](../../../../list-of-windows/alvao-webapp/administration/asset-management/print-report-templates). Each template contains several files that define the content and appearance of the resulting print report.
     
The resulting print reports are generated from the templates as follows:
     
1. After the user selects the objects they want to print in the application's object tree, the application generates a working XML file containing details of the selected objects according to the settings in the REP file.
2. The working XML file then undergoes an XSL transformation resulting in an HTML document. This HTML document can use other files in the template, such as CSS files, PNGs, JPGs, etc.
3. The content of the HTML document is displayed to the user as a preview of the print report.
4. After the user approves the preview, the HTML document is converted to PDF format, in which it can be printed or saved to the document repository.

## Rep file
      
A REP file is a text file that defines an output print report.
     
The file contains several lines in the format:
     
Variable=Value
     
For example:
     
VERSION=XMLReport1

| Variable | Description |
| --- | --- |
| VERSION | Specifies the version of the print report format. This variable must be specified on the first line of the REP file and must have the value XMLReport1. |
| TYPE | The value of this variable specifies a special procedure for generating the XML file that is the data source for the print report.  <br>
                      <br>
                    <br><br>| Value | Description |<br>| --- | --- |<br>| Null | When the default value Null is specified, the XML file will contain only the object (including child objects) that is selected in the object tree when creating the print report. |<br>| Transfer Inner | Print report of type "transfer report internal". |<br>| Transfer Inner Summary | Print report of type "transfer protocol internal summary". It can only be used on an object of type *User*. |<br>| Transfer Outer | Print assembly of type "transfer protocol external". | |
| --- | --- |
| SEQUENCE | The name of the numeric sequence that will be used to generate the document number of the print report type "Transmission Report".
 For example: "Loans".  <br>
> [!NOTE]
> If the value is blank, the system series "handover protocols" will be used for internal handover protocols. No series is used for external transfer logs. |

| HTML | The name of the HTML file to be used as the default file for displaying the print report. The file name is specified relative to the REP file path. If the HTML file is stored in the same directory as the REP file, you only need to specify the file name. |
| FLAGS | The value can be an empty string (e.g. "FLAGS=") or a comma-separated list of items listed below, e.g. "FLAGS=children,ownprop,inheritedprop". Each list item allows writing some information to the XML file. The list of items is given in the following table:  <br>
                      <br>
                    <br><br>| Item | Description |<br>| --- | --- |<br>| notice | notes to objects (element &lt;noticelist&gt;),
 only records that have not been deleted (hidden) in the Journal. |<br>| history | history of objects (element &lt;historylist&gt;),
 only records that have not been deleted (hidden) in the Journal. |<br>| children | Child objects (element &lt;nodelist&gt;) |<br>| responsibility | New subtrees are generated under objects of type User. They contain objects that have the value of the user object in the property "Responsible for property". |<br>| ownprop | property (element &lt;prop&gt; in &lt;proplist&gt;) |<br>| inheritedprop | inherited properties (element &lt;prop&gt; in &lt;proplist&gt;) |<br>| owninfo | element &lt;own&gt;1&lt;/own&gt; for custom properties |<br>| inhritedinfo | element &lt;iherited&gt;1&lt;/inherited&gt; for inherited properties |<br>| specialinfo | element &lt;special&gt;1&lt;/special&gt; for special properties (properties for internal use in remote data collection, etc.) | |
| --- | --- |

Example of the contents of the Evidence Card.rep file:
     
VERSION=XMLReport1           
         TYPE=Null  
         HTML=Evidence Card.ht           
         FLAGS=children,ownprop,inheritedprop,notice
      
## XML file
      
This chapter describes the structure of the XML file that is used when creating a print report. The image of the object (including child objects)          over which the print report is being created (that is, the object that is selected in the object tree) is written to the file. Which elements are          included in the XML file and which are not depends on the setting of the FLAGS item in the REP file.
     
XML file format (DTD):

    <!ENTITY ONE "1">
    
    <!ELEMENT report (node*)>
    
    <!ELEMENT node (name, icon, proplist?, responsiblefor?, noticelist?, historylist?, nodelist?)>
    <!ELEMENT name (#PCDATA)>
    <!ELEMENT path (#PCDATA)>
    <!ELEMENT icon (#PCDATA)>
    <!ELEMENT proplist (prop*)>
    <!ELEMENT noticelist (notice*)>
    <!ELEMENT historylist (history*)>
    <!ELEMENT nodelist (node*)>
    
    <!ELEMENT prop (value, kind, own?, inherited?, special?)>
    <!ELEMENT value (#PCDATA)>
    <!ELEMENT kind (#PCDATA)>
    <!ELEMENT own (&ONE;)>
    <!ELEMENT inherited (&ONE;)>
    <!ELEMENT special (&ONE;)>
    
    <!ELEMENT notice (date, desc, user)>
    <!ELEMENT date (#PCDATA)>
    <!ELEMENT desc (#PCDATA)>
    <!ELEMENT user (#PCDATA)>
    
    <!ELEMENT history (date, desc, user)>

Element meanings:

| Element | Description |
| --- | --- |
| node | object |
| path | path to an object in the object tree |
| prop | property |
| notes | object note |
| history | history record |
| nodelist | list of child objects |

## HTML file
      
The REP file also contains the name of the HTML file of the print report, which, after replacing macros, is displayed in the preview before printing. This file is only used when printing from the AM Console.
      
The following macros can be used in an HTML file:

| Macro | Description |
| --- | --- |
| %HTMLPATH% | Absolute path to the HTML file on the hard drive.  <br>
                      <br>
                    For example, if the style.css file is stored in the same directory as the HTML file, the following construct can be used to retrieve it:  <br>
                      <br>
                    &lt;link rel="stylesheet" href="%HTMLPATH%\style.css"&gt; |
| %XMLPATH\_C% | Name with the path to the working XML file formatted for use in javascript. |

## Edit HTML for printing from ALVAO WebApp
      
All templates printed from ALVAO WebApp use uniform HTML, which is stored in the database. To modify it, you need to run the following SQL script to add the required HTML:

    update tProperty set sPropertyValue='<own HTML>' where sProperty='AssetManagement.PrintTemplateHtml'

In the html for the print report for the web, you must use variables written as [$&lt;name&gt;$], which are replaced by the files attached to the print report when printed.
   
If the variable used does not contain a period (e.g., "CSS" or "XSL"), the first file attached to the template with that extension (i.e., \*.css or \*.xsl) is used.   If the variable used contains a dot (e.g. "logo.png"), the file attached to the template with the given name (i.e. logo.png) is used.
   
The exception is the variable [$PrintTemplateName$], which is replaced by *Name* for the print report.
