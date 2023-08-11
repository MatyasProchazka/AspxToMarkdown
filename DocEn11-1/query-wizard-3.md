# Query Wizard - Step 3
 
In the third step of creating a [database query](../../../alvao-asset-management/searching/query), define what you want to monitor for the object properties selected in [step 2](query-wizard-2).  
 The items in the list (object properties) represent the columns of the print report that will be the result of the query. The order of the items determines the order of the columns in the result. The content of the window changes depending on which property in the table you select - parameters are set separately for each property.
 
Options:

- [Edit](set-column) -
 edit the header of the selected column.
- **Up** - move the selected column one row higher in the table.
- **Down** - move the selected column one row lower in the table.

> [!NOTE]
> The up and down buttons contain only an arrow and are not located at the bottom right corner of the table.

- **Include only rows where**- alternatively, specify a condition that the values should satisfy: select an operator and enter a value to compare. e.g. for RAM size you can specify the condition "&lt;64".
    - **And**, **OR** -
 or select a concatenation operator and specify a second condition that the values should satisfy. Select **A** if both conditions must be met at the same time, and **A**
 OR if it is sufficient if at least one condition is met.
- **Include in print report** - turn on if you want the selected column to be displayed in the resulting print report.
- **Property Type**
    - **Do not distinguish** - select if the property can be custom or inherited.
    - **Own** - select if only custom properties are to be used.
    - **Inherited** - select to use only inherited properties.
- **Aggregation Functions**- enable those functions whose result you want to be displayed in the footer of the resulting print system.
    - **Count** - display the number of property items.
    - **Sum** - display the sum of property values.
    - **Average** - display the average value of properties.
    - **Minimum** - display the minimum value of properties.
    - **Maximum** - display the maximum value of properties.
