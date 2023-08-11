# Change property of type Text to another type
      
## Change property of Text type to Date type
      
To change the property type, do the following:
     
1. Open the [Property Definitions](../../list-of-windows/alvao-webapp/administration/asset-management/property-definitions/detail), select a specific property and change its data type. Property values that are specified in one of the supported formats are automatically converted to the date type. Because the system is not guaranteed to automatically convert all property values in the entire record, a backup (copy) of the original property is automatically created with the name "&lt;property name&gt; (old)"
(e.g. "Date of manufacture (old)"), which will retain the original values.

> [!NOTE]
> The supported format for automatic conversion is "dd.mm.yyyy" (e.g. 15.10.2015, 3.1.2015). If you have most of the property values entered in a different format, we recommend following up to step 5 in this guide. 

        
2. Check that the system was able to convert all the values by following this procedure:
    1. Select the entire organization in the object tree.
    2. On the Child Objects tab, view the **"&lt;property name&gt;"** column (property type Date) and **"&lt;property name&gt; (old)"**. From the local menu, use the "Show in object lists" command.
    3. Once the "Object Lists" window appears, confirm the view name with the "Enter" key and set the filters in the columns as follows:
        1. "&lt;property name&gt;"=""
        2. "&lt;property name&gt; (old)"=not ""
        3. "Path in tree" - remove the filter (then the objects from the whole inventory will be displayed)
3. If no rows are displayed after setting the filter, all values have been converted correctly so continue with step 7.
4. If the system failed to convert a small number of values, manually add the values. It is recommended to sort the values on the Child Objects tab according to the **"&lt;property name&gt; (old)"** column and use the "Edit" command from the local menu to set the values of the object properties in the **"&lt;property name&gt;"** column. This way you can set the same property value for multiple objects at once.
5. If the system failed to convert a large number of values, follow the following instructions for bulk conversion:
    1. Show only the "NodeId" columns in the table in the Object Lists window,"Type" and "&lt;property name&gt; (old)".
    2. Select Table -&gt; Save As from the local menu and save the table as a "\*.CSV" file.
    3. Open the file in Microsoft Excel and, if necessary, edit the original property values (i.e., the values in the "... (old)" column, e.g., "Date of manufacture (old)") so that they are all in the uniform format supported by the ImportUtil utility , see the **-datetimeformat** parameter of the [ImportUtil](../import-export-data/import-util). Then rename the column with the original values to the name of the target property (i.e., remove the "(old)" suffix).
    4. Using [ImportUtil](../import-export-data/import-util)
                    and the **-datetimeformat** and **-keyfields "NodeId"** parameters.
  update the property values in the registry. If the data import fails for some objects, manually edit the data format for the objects in the CSV file.
6. Continue with step 2 again.
7. After the conversion of property values is complete, remove the "&lt;property name&gt; (old)" property for all templates and perform the unification according to the templates:
    1. Open the **Tools - Database - SQL Query** window.
    2. Create a new query (**File - New**).
    3. Enter the following SQL query:

            SELECT DISTINCT
                n.intNodeId,
                n.txtClass [Object Type],
                n.txtPath+N'/'+n.txtName [Path and name of the object in the tree]
            FROM vNodeClass n
                JOIN tblNodeParent np on np.lintNodeId=n.intNodeId 
                JOIN tblNode t on t.intNodeId=np.lintParentNodeId and t.lintClassId=3
                JOIN vPropertyKind pk ON n.intNodeId=pk.lintNodeId AND pk.txtKind=N'<propertyName> (old)'
    4. In the query, replace the string '&lt;property name&gt; (old)' with the name of your old property.
    5. Follow the path in the tree to find all found object templates and remove the old property from them.
    6. Make the objects unified according to the templates you are editing.
    7. Use "Lists - Property Definitions" to remove the property definition.
    8. If even then the property definition cannot be removed, it is probably applied to objects that do not have a template. You can find these using the query:

            SELECT
                n.intNodeId,
                n.txtClass [Object Type],
                n.txtPath+N'/'+n.txtName [Path and name of the object in the tree]
            FROM vNodeClass n
                JOIN vPropertyKind pk ON pk.lintNodeId=n.intNodeId and pk.txtKind=N'<propertyName> (old)'

          You can run the query again from the Tools - Database - SQL Query window. Do not forget to change the property name in the query. Delete all properties found in this way and remove the property definition again.

## Changing the property of the Text type to the Number type
       
To change the property type, do the following:

1. Change the data type of the Text property to Number. The supported format for conversion is a decimal number with a comma or period as the decimal separator. A space character can be used as a line separator. Negative numbers or numbers in abbreviated format can also be converted. For example: "12 543.50", "980.56", "-1530", "1,3e-2".
2. After conversion, check and import any unconverted properties as described when changing the Text type to Date type. 

> [!NOTE]
> There is no need to use the **-datetimeformat** switch when using ImportUtil.

Caveat: Date data type properties cannot be changed to Number (or vice versa). Date types also cannot be changed for system items.
