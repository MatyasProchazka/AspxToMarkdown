# New property
     
This form can be used to create a new property.
       
Options:
     
- **Property name** - enter the unique name of the property, (e.g. Size, Capacity, First Name, Surname etc.).
- **Data type** - select whether the property will be of type Text, Number, or Date. If you change the type after the fact, the property values are automatically converted to the new type. If changing from Text to Date or Number type, it is a good idea to check that the values have been converted correctly, see [Change property of type Text to another type](../../../../../alvao-asset-management/implementation/object-property-change-type).

> [!CAUTION]
> Can’t be changed in edit mode for system properties.

- **Inherit Property** - enable if the property is to be inherited, i.e. if an object has this property, then all its child objects also have this property.
- **Global across all objects** - turn on if the property and the values it takes on should be treated as global across all object types.  

            A typical example is *Inventory Number*, which is unique across all objects.  

> [!NOTE]
> This option affects:  

    - Evaluation of uniqueness check - if you do not turn it on, two objects of different types can have the same value for this property.
    - Content of the automatically generated list of property values - if you turn this option off, the list of values in the [Property](../../../../../list-of-windows/alvao-asset-management-console/tab-view/properties/property-edit) will only list values specified for objects of the same type, e.g. the Name property will list different values for printers and different values for monitors.
- **Unique** - turn on if the values of this property are to be unique.

> [!NOTE]
> All properties that are supposed to be unique are checked using Uniqueness Check. For example, different objects or devices can be distinguished by the values of these properties.  

                A typical example of a unique property is *Inventory Number*.  

                The uniqueness check is only performed in the active inventory, i.e. outside the *Recycle Bin, Assets, Object Templates, Object Views, and Property Categories*.
- **Delete value when copying objects** - turn on if you want the property value to always be filled consciously (not unconsciously when copying an object). An example is the serial number.

> [!NOTE]
> This option is automatically enabled if the **Unique**.

> [!CAUTION]
> Can’t be unchecked.

- **Order in list** - if applicable, specify the order in which to display the property being edited. Alternatively, you can sort the list of properties by these values - sort by the column in **Order in list**.
- **Icon** - button to select the icon for the property being edited.
