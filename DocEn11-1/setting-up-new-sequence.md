# Setting a new number series for generating the property value
     
1. From the main menu, use **Tools - Lists -Numeric Sequences**, which will open the [Numeric sequences](../../list-of-windows/alvao-asset-management-console/tools/lists/numeric-sequences).
2. Press the **New** button.
3. The window will open on the screen [New numeric sequence](../../list-of-windows/alvao-asset-management-console/tools/lists/numeric-sequences/numeric-sequence) with numeric sequence settings.
4. Enter the name of the new sequence (e.g. "Computer names"), the prefix, the number and the sequence extension (e.g. PC, 1, ALVAO).
5. Select the property whose value you want the series to generate (e.g., "Name in network").

> [!NOTE]
> Properties that have the "selection only" option enabled are not displayed in the menu - an automatic dial cannot be defined for them

6. Select the object type, (e.g. "Computer") and press the **&lt;&lt;Add** button next to the list. The object type will be added to the list.

> [!NOTE]
> If the list of object types is empty, the value will be generated for the property for all object types.

7. Confirm the changes using the **OK** button. If the row setting conflicts with another row, a warning message is displayed and the row cannot be saved.

> [!NOTE]
> A row defined for specific object types takes precedence over a row that is defined for all object types. The two series do not collide. This rule also applies to the computer type.

Numeric ranks generate values for selected object properties immediately when a new object is created in the tree (New Object, Copy Object command). The generated property value can be manually changed later. Uniqueness may or may not be enabled on the property definition.
