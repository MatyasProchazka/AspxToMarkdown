# Edit REP print report templates
     
If you need to edit a REP format print report template, do the following:
     
1. Go to **WebApp - Administration - Asset Management** - [Print Report Templates](../../../../list-of-windows/alvao-webapp/administration/asset-management/print-report-templates).
2. Select the desired template and use the **Edit** command.
3. Download all the print report files to any folder on the disk.
4. Now, edit the template source files as needed.
5. After making any changes, go to the **WebApp** again and use the **Add Files** command in the template edit.
6. Select the changed files from the folder on disk and overwrite the existing template files with them.
7. Save your changes to the template.

## Adding a company logo to the header of print reports

1. Go to **WebApp - Administration - Asset Management**- [Print Report Templates](../../../../list-of-windows/alvao-webapp/administration/asset-management/print-report-templates).
2. For each template, replace the **logo.png** file with the company logo file. The image should be no more than 100 pixels high.

> [!NOTE]
> The logo is not visible on the screen when the print report is displayed. The logo is only displayed in the print page preview.

## Adding the text of the declaration to the handover protocol
     
In the handover protocol XSL file, search for the string "*Declaration Text*" and insert your own HTML text after the found note.
      
## Adjustment of the asset table in the handover protocol

1. Edit the XSL file of the handover protocol.
2. Find the header of the asset table - look for the text "Asset table - header".
  Change column headings, add new column headings if necessary, or remove some columns, e.g.:  

                &lt;td class="Frame&gt;  

                  &lt;b&gt;IMEI&lt;/b&gt;  

                &lt;/td&gt;
3. Find the rows with the table values - look for the text "Asset table - values".
  Modify the code to get the value in the appropriate column, e.g. change the name of the object property, add values for new columns, or remove values for deleted columns.  

            Example of one table cell:  

                &lt;td class="Frame&gt;  

                  &lt;xsl:valueof select="proplist/prop[kind='IMEI']/value"/&gt;  

                &lt;/td&gt;

            *IMEI* is the name of the object property whose value is displayed in the property table.  

            The values of the table columns must be listed in the same order as the column headings in the table header.

## Change margins, paper orientation and page numbering settings
     
Edit the following SQL script and set the values of the required attributes according to the table below:

    update tProperty set sPropertyValue='PageOrientation=Portrait;Margins=10,10,15,15;PageNumbering=0;'
    where sProperty='AssetManagement.TransferProtocol.PageSettings'

Meaning and possible values of each setting:

| Attribute name | Importance | Possible values |
| --- | --- | --- |
| PageOrientation | Page Orientation | <ul style="margin-bottom: 0px;">
                    <li>Portrait = portrait</li>
                    <li>Landscape = landscape</li>
                </ul> |
| Margins | Paper margins | A field of four integers separated by commas meaning:  <br>
                &lt;left&gt;,&lt;right&gt;,&lt;top&gt;,&lt;bottom&gt;
                  <br>
> [!NOTE]
> the number indicates the edge of the paper in millimetres. |

| PageNumbering | Page numbering | <ul style="margin-bottom: 0px;">
                    <li>0 = page numbering off (not displayed)</li>
                    <li>1 = pagination on (displayed at the foot of each page in the format &lt;page number/total number of pages&gt;)</li>
                </ul> |

Then run the script on the Alvao database (e.g. using *Microsoft SQL Server Management Studio*).
