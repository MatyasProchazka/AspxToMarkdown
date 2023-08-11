# IObjectMoveAutoAction
     By implementing the IObjectMoveAutoAction interface in an [application script](../../../list-of-windows/alvao-webapp/administration/applications/app/scripts), you can define custom actions that are automatically performed when an object is moved to another location in the object tree, including removing the object to the Trash.

> [!NOTE]
> The interface methods are also called in the Alvao.API.AM.Object.Move and Alvao.API.AM.Object.Delete methods.

        When automatically removing computer components to the Recycle Bin based on hw detection, the methods are not called.

> [!CAUTION]
> If you want to use only some of the methods of the implemented interface in the automatic action, leave an exception in the body of the other methods from the interface: throw new NotImplementedException();.

## Interface Methods

| Method | Description |
| --- | --- |
| OnObjectMoving | The object will be moved in the tree. |
| OnObjectMoved | The object has been moved. |

## OnObjectMoving
     This method is called before moving an object in the tree to another location, e.g. within the *Move* statement.      
- Syntax: Tuple&lt;**bool**, **string**&gt; OnObjectMoving(SqlConnection **con**, int **objectId**, int **newParentObjectId**, int **personId**)
- Parameters:
    - **con** - SqlConnection to the database.
    - **objectId** - ID of the object (tblNode.intNodeId) to be moved.
    - **newParentObjectId** - ID of the object (tblNode.intNodeId) to which the object is to be moved. A value of 0 means that the object will be moved to the root of the tree.
    - **personId** - the ID of the user (tPerson.iPersonId) who invoked the action.
- Return values:
    - **bool** - if the method returns true, the object is moved to a new position in the database. If the method returns false, the operation will not be performed and the upcoming object move will be canceled.
    - **string** - the message that will be displayed to the user if the return value is false.

      For an example use case, see [CheckObjectMandatoryProperties](../../../modules/alvao-am-custom-apps/applications/templates).  
      
## OnObjectMoved
This method is called after moving an object in the tree.
- Syntax: **void** OnObjectMoved(SqlConnection **con**, int **objectId**, int **oldParentObjectId**, int **personId**)
- Parameters:
    - **con** - SqlConnection to the database.
    - **objectId** - ID of the object (tblNode.intNodeId) to be moved.
    - **oldParentObjectId** - the ID of the object (tblNode.intNodeId) that was the father (parent object) of the object with objectId before it was moved. A value of 0 means that the object was moved from the root of the tree.
    - **personId** - the user ID (tPerson.iPersonId) that triggered the action.
- Return value: **none**.

     For an example usage, see the [SetComputerDetectionProfile](../../../modules/alvao-am-custom-apps/applications/templates) application template.
