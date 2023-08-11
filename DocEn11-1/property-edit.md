# Property

- **Property name** - display the name of the property.
- **Value**- enter the value of the property.
    - In the list that is attached to this input line, you can select a value from the list of default values for this property.
    - It is also possible to enter a value from the barcode reader manager using the button with the barcode symbol next to the *Value* field.
- **This property specifies the name of the object**- when this box is checked, the name of the object that contains this property will be automatically created according to the value of this property. The name of an object can consist of up to 8 properties -  the values of the properties are ordered in the defined order. If you change the value of the property that defines the object name, the object name in the tree will also change.
    - **Order in object name** - A number that determines the order of the value of this property in the object name. When the order is changed, the order of the other properties is automatically adjusted.
- [Inherit property](../../../../alvao-asset-management/implementation/tree-design#inheritance) - if you enable this option, the property will be inherited to all child objects i.e. it will be visible on the *Properties* tab in the [main window](../../../alvao-asset-management-console) in all child objects.

> [!NOTE]
> - This dialog can only be displayed in the [object template](../../../../alvao-asset-management/implementation/object-templates). Only property values can be changed outside of the object template.

- The values of some properties cannot be changed. If the object has the *automatically update on detection* option enabled in the tree,
 the values of the detected properties cannot be changed (there is a risk of overwriting the values on the next detection). Also, if the object is loaded from **Active Directory** it is not possible to change the values of properties loaded from AD (there is a risk of overwriting the values on the next import). Information about the impossibility to change the value in such cases is also displayed in the message under the *Value*.
- The list of values is dynamically constructed from the property values of the given property only from objects of the corresponding type. If the property is set as unique, the list is populated with the values of the property across all objects in the database.
