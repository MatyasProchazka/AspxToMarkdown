# New numeric sequence
 
In this Window you can define a new [number sequence](../../../../../alvao-asset-management/documents/sequences). The last two options only appear if you have selected a series for the Property.
 
Options:

- **Use this sequence** - turn on if you want to use the series to automatically generate values.
- **Sequence Type** - select from the menu whether the series generates values (selected below) [properties of objects](../../../../../alvao-asset-management/objects-and-properties#rep), or document numbers of forwarding reports (i.e. [Press reports](../../../../../alvao-asset-management/implementation/customization/reports)).
- **Sequence name** - enter the name of the numeric series.
- **Prefix** - enter the text prefix that will appear before the auto number.
- **Next Number** - enter the number from which the automatic numbering of the series will start. The number entered in the field will be respected in the specified format (even with zeros at the beginning) - e.g. it is possible to generate the numbers: *IC0001ALVAO*, *IC0002ALVAO*, ... In case of "overflow" of a number, the length is increased by one character. This will break the original formatting - for example, *IC999ALVAO* will be followed by *IC1000ALVAO*.
- **Extension** - enter the text suffix that will appear after the auto number.
- **Use this series to generate property values:**
 - select the Property (of type Text) from the menu for which this series will generate values.
- **For object kinds** - You can insert one or more object types into the list. The queue will then generate values for the selected property only for the selected object types. If the list is empty, the value of the selected property will be generated for all object types.   
Add values to this list by selecting the object type in the right search menu and pressing the **&lt;&lt;Add** button. If the selected object type is not already in the list, it will be added to the list. Adding **&lt;all&gt;**
 removes all object types from the list (the empty list is applied to all object types). You can also use the **button to remove Remove** - removes the selected object type from the list.
