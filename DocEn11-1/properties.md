# Properties
    
This page contains [properties](../../../../alvao-asset-management/objects-and-properties) describing the selected object.
    
Options:
   
- **Command Panel**
    - **Edit Value** - edit the value of the selected property.You can also change the value of the property directly in the table by double-clicking on it.
- **Property table** - contains the properties of the selected object. You can [customize the table as needed](../../../../alvao-asset-management/working-with-tables).  

  Table columns: 

.    | Column | Description |
    | --- | --- |
    | Status | Icon meaning:   <br>
  ![Inherited property](zdedena_vlastnost.JPG) Inherited property - a property is inherited to this object from a parent object whose name is specified in the *Object* column.  <br>
  ![Read-only](nactena_vlastnost.JPG) Read-only - the value of the property is retrieved from Active Directory or hw detection and therefore cannot be manually changed.  <br>
  ![Alert](upozorneni.JPG) Alert - there is something wrong with the property. Mouse over the icon and a more detailed description of the error will appear in the bubble. |
    | Property | Property name, see [Property Definitions](../../../../list-of-windows/alvao-asset-management-console/tools/lists/properties-definition). |
    | Value | Property value; Double-click on the value to change the value (if you have sufficient permissions to do so and the property value is not locked). |
    | Object | The name of the parent object from which the property is inherited. |
    | Inherit | The value *Yes* indicates that this property is inherited to child objects. |
    | Category | See [Property categories](../../../../alvao-asset-management/implementation/property-categories) for the names of the property categories in which this property is included. |
    | Object name (order) | If this property specifies the [object name](../../../../alvao-asset-management/objects-and-properties/object-title), the numeric value in this column represents the order of the part of the object name that this property specifies.  For example, a value of 1 means that the property value specifies the beginning of the object name. |
    | Order | The rows in the property table are usually ordered by this column. You can change the value, see [Property Definitions](../../../alvao-asset-management-console/tools/lists/properties-definition). |
