# IObjectPropertyAutoAction
     By implementing the IObjectPropertyAutoAction interface in a [application script](../../../list-of-windows/alvao-webapp/administration/applications/app/scripts), you can define custom actions that are automatically performed when the user manually modifies the value of an object property.     

> [!NOTE]
> Interface methods are also called in both variants of the Alvao.API.AM.ObjectProperty.Update method.

        The *AM Console* command - [Properties](../../../list-of-windows/alvao-asset-management-console/tab-view/properties) tab - *Generate Value* does not call the *OnObjectPropertyModifying* method.
It only calls the *OnObjectPropertyModified* method.

> [!CAUTION]
> If you want to use only some of the methods of the implemented interface in the automatic action, leave an exception in the body of the other methods from the interface: throw new NotImplementedException();.

## Interface Methods

| Method | Description |
| --- | --- |
| OnObjectPropertyModifying | The value of the property will be changed. |
| OnObjectPropertyModified | The value of the property has been changed. |

## OnObjectPropertyModifying
     This method is called before saving the modified property value to the database, e.g. within the *Modify (property)* statement.      
- Syntax: Tuple&lt;**bool**, **string**&gt; OnObjectPropertyModifying(SqlConnection **con**, int **propertyId**, int **personId**, string **newValue**)
- Parameters:
    - **con** - SqlConnection to the database.
    - **propertyId** - ID of the property (tblProperty.intPropertyId) that is being modified.
    - **personId** - the ID of the user (tPerson.iPersonId) who invoked the action.
    - **newValue** - new value of the property.
- Return values:
    - **bool** - if the method returns true, the new value is written to the database. If the method returns false, the operation is not performed and the upcoming property value change is canceled.
    - **string** - the message that is displayed to the user if the return value is false.

      For an example, see the [CheckPhoneNumberFormat](../../../modules/alvao-am-custom-apps/applications/templates) application template.  
      
## OnObjectPropertyModified
     This method is called after writing a new property value to the database, e.g. by the *Modify (property)*statement.
- Syntax: **void** OnPropertyModified(SqlConnection **con**, int **propertyId**, int **personId**)
- Parameters:
    - **con** - SqlConnection to the database.
    - **propertyId** - ID of the property (tblProperty.intPropertyId) that has been changed.
    - **personId** - the ID of the user (tPerson.iPersonId) who invoked the action.
- Return value: **none**.

      For an example use case, see the [CopyNewPropertyValueToAnotherProperty](../../../modules/alvao-am-custom-apps/applications/templates) application template.
