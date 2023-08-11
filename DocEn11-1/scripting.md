# Custom script
     
The *Config* folder can contain a file *EpCustomScript.js* with a custom script in JavaScript. The *Config* folder can be found in the folder where the ALVAO Asset Management Console is installed (by default *C:\Program Files\ALVAO\Asset Management Console\Config*), if it is not there, create it and put the script in it. After restarting the AM Console, the script will activate itself.
     
Handlers can be defined in the script that are automatically called from the AM Console when performing various operations.
     
**Example 1. Example of EpCustomScript.js**

    function OnNodeMoving(nNodeId,nDestNodeId,nUserId) {
      return true;
    }
    
    function OnNodeRemoving(nNodeId,nUserId) {
      MessageBox("Object cannot be removed",0x30);
      return false;
    }

The script in the example contains the OnNodeMoving function and   OnNodeRemoving. The OnNodeMoving function is used to enable moving an object in the tree. The function is called before the move is performed and the return value true indicates that the move is enabled. The OnNodeRemoving function is called before removing an object from the tree, and its return value enables removal. So in the example above, moving an object is always enabled and removing it is always disabled. In addition, when you try to delete an object, a window with the message "Object cannot be deleted" is displayed.
      
## Service functions

| Functions | Event |
| --- | --- |
| OnNodeCopying | A copy of the object will be created. This function is also called when a new object is created by a template. |
| OnNodeCopied | The object has been copied or a new object has been created according to the template. |
| OnNodeMoving | The object will be moved in the tree. |
| OnNodeMoved | The object has been moved. |
| OnNodeRemoving | The object will be moved to the Recycle Bin. |
| OnNodeRemoved | The object has been moved to the Trash. |
| OnPropertyModificationEnabled | Enable/disable command - Modify (property). |
| OnPropertyModifying | The value of the property will be changed. |
| OnPropertyModified | The value of the property has been changed. |

## OnNodeCopying
     
This function is called before copying an object in the tree, i.e. also in case of creating a new object according to the template.
     
- **Syntax** - bool OnNodeCopying(nNodeId, nDestNodeId, nUserId)
- **Parameters**
    - **nNodeId** - the value of the attribute (in the database) tblNode.intNodeId of the object that is copied, i.e. the sample object.
    - **nDestNodeId** - value of the tblNode.intNodeId attribute of the object into which the copy will be inserted as a child object. A value of 0 means that the copy will be created at the root of the tree.
    - **nUserId** - the value of the tblUser.intUserId attribute that specifies the currently logged in user.
- **return value** - if the function returns <tt>true</tt>, the object will be copied. If the function returns false, the copy will not be performed. In this case, it is useful to display an error message using the method MessageBox.
- **Examples**
            
    **Example 2. Example - Disable copying objects for selected user**

    The following example of the OnNodeCopying function prohibits a user with ID 15 from copying objects. The user ID depends on the specific database and must first be found in the tblUser table - attribute intUserId.

        function OnNodeCopying(nNodeId,nDestNodeId,nUserId) {
            if ( nUserId == 15 ) {
                MessageBox("The object is forbidden to copy.",0x30);
                return false; 
            }
            return true;
        }

    **Example 3. Example - calling a stored procedure on SQL server**

    In the following example, the stored procedure <tt>spOnNodeCopying</tt> on the SQL server is used to evaluate the event. Object copying is enabled if the stored procedure returns a non-zero value.

        function OnNodeCopying(nNodeId,nDestNodeId,nUserId) {
            var Con=new ActiveXObject("ADODB.Connection");
            Con.Open(ConnectionString);
            var Cmd=new ActiveXObject("ADODB.Command");
            Cmd.ActiveConnection=Con; 
            Cmd.CommandText="spOnNodeCopying";
            Cmd.CommandType=4; 
            Cmd.Parameters.Refresh();
            Cmd.Parameters.Item("@nNodeId").Value=nNodeId; 
            Cmd.Parameters.Item("@nDestNodeId").Value=nDestNodeId; 
            Cmd.Parameters.Item("@nUserId").Value=nUserId; 
            var Rs=Cmd.Execute();
            if ( Rs.Fields.Item(0)==1 )
                return true; 
            MessageBox("Object cannot be copied.",0x30);
            return false;
        }

    The stored procedure is defined as follows:

        CREATE PROCEDURE [dbo].[OnNodeCopying]
            @nNodeId int, @nDestNodeId int, @nUserId int
        AS
        BEGIN 
            SET NOCOUNT ON; 
            SELECT 1
        END

## OnNodeCopied
     
This function is called after copying an object or after creating a new object according to the template.

- **Syntax** - void OnNodeCopied(nNodeId, nNewNodeId, nUserId)
- **Parameters**
    - **nNodeId** - the value of the attribute (in the database) tblNode.intNodeId of the object that was copied, i.e. the sample object.
    - **nNewNodeId** - value of the tblNode.intNodeId attribute of the new object that was created by copying.
    - **nUserId** - the value of the tblUser.intUserId attribute specifying the currently logged in user.
- **return value** - none
- **Examples** - see OnNodeCopying

## OnNodeMoving

This function is called before moving an object in the tree to another location.

- **Syntax** - bool OnNodeMoving(nNodeId, nDestNodeId, nUserId)
- **Parameters**
    - **nNodeId** - the value of the attribute (in the database) tblNode.intNodeId of the object to be moved.
    - **nDestNodeId** - the value of the tblNode.intNodeId attribute of the object to which the object is to be moved.  A value of 0 means that the object will be moved to the root of the tree.
    - **nUserId** - the value of the tblUser.intUserId attribute that specifies the currently logged in user.
- **return value** - if the function returns true, the object will be moved. If the function returns false, the move will not be performed. In this case, it is useful to display an error message using the method MessageBox.
- **Examples** - see OnNodeCopying

## OnNodeMoved

This function is called after moving an object in the tree.

- **Syntax** - void OnNodeMoved(nNodeId, nSrcParentNodeId, nUserId)
- **Parameters**
    - **nNodeId** - the value of the attribute (in the database) tblNode.intNodeId of the object that was moved.
    - **nSrcParentNodeId** - the value of the tblNode.intNodeId attribute of the object that was the father (parent object) of the nNodeId object before it was moved.
    - **nUserId** - the value of the tblUser.intUserId attribute that identifies the currently logged in user.
- **return value** - none
- **Examples** - see OnNodeCopying

## OnNodeRemoving

This function is called before removing an object, i.e. moving it to the Recycle Bin.

- **Syntax** - bool OnNodeRemoving(nNodeId, bMoveToBin, nUserId)
- **Parameters**
    - **nNodeId** - value of the attribute (in the database) tblNode.intNodeId of the object to be removed or moved to the Recycle Bin.
    - **bMoveToBin** - if the object is to be moved to the Recycle Bin, this parameter has the value true.
    - **nUserId** - the value of the tblUser.intUserId attribute specifying the currently logged in user.
- **return value** - if the function returns true, the object will be removed or moved to the Recycle Bin. If the function returns false, the operation is not performed. In this case, it is advisable to display an error message using the method MessageBox.
- **Examples** - see OnNodeCopying

## OnNodeRemoved

This function is called after an object is removed, i.e. after it is moved to the Recycle Bin.

- **Syntax** - void OnNodeRemoved(nNodeId, bMoveToBin, nUserId)
- **Parameters**
    - **nNodeId** - value of the attribute (in the database) tblNode.intNodeId of the object that was removed or moved to the Recycle Bin.
    - **bMoveToBin** - if the object is moved to the Recycle Bin, this parameter has the value true.
    - **nUserId** - the value of the tblUser.intUserId attribute specifying the currently logged in user.
- **return value** - none
- **Examples** - see OnNodeCopying

## OnPropertyModificationEnabled

Enables or disables the -Modify command to modify a property.

- **Syntax** - bool OnPropertyModificationEnabled(nPropertyId)
- **Parameters**
    - **nPropertyId** - Attribute value (in the database) of the tblProperty.intPropertyId property to be modified.
- **Return Value** - If the function returns true, the -Edit menu command will be active. Otherwise it will be inactive (greyed out).
- **Examples** - see OnNodeCopying

## OnPropertyModifying

This function is called within the -Modify command before saving the modified property to the database.

- **Syntax** - bool OnPropertyModifying(nPropertyId, strNewValue)
- **Parameters**
    - **nPropertyId** - attribute value (in the database) of the tblProperty.intPropertyId property that is being modified.
    - **strNewValue** - new value of the property.
- **NewValue** - if the function returns true, the new value is written to the database. If the function returns false, the operation is not performed. In this case, it is advisable to display an error message using the method MessageBox.
- **Examples** - see OnNodeCopying

## OnPropertyModified

This function is called after writing a new property value to the database within the -Modify command.

- **Syntax** - void OnPropertyModified(nPropertyId)
- **Parameters**
    - **nPropertyId** - the attribute value (in the database) of the tblProperty.intPropertyId property that has been modified.
- **Return value** - none
- **Examples** - see OnNodeCopying

## MessageBox

Function displays a text message box.

- **Syntax** - int MessageBox(Text,Type)
- **Parameters**
    - **Text** - message text.
    - **Type**- parameter can contain a combination of the following bit values.
        - **Buttons**

            | Value | Symbol | Description |
            | --- | --- | --- |
            | 0 | MB\_OK | OK |
            | 1 | MB\_OKCANCEL | OK, Cancel |
            | 2 | MB\_ABORTRETRYIGNORE | Cancel, Reset, Ignore |
            | 3 | MB\_YESNOCANCEL | Yes, No, Cancel |
            | 4 | MB\_YESNO | Yes, No |
            | 5 | MB\_RETRYCANCEL | Return, Cancel |
        - **Icons**

            | Value | Symbol | Description |
            | --- | --- | --- |
            | 0x10 | MB\_ICONERROR | error (red) |
            | 0x20 | MB\_ICONQUESTION | questionnaire |
            | 0x30 | MB\_ICONEXCLAMATION | exclamation mark (yellow) |
            | 0x40 | MB\_ICONINFORMATION | information |
        - **Default Button** - the value from the following table determines which button in the order from the left will be set as the default.

            | Value | Symbol |
            | --- | --- |
            | 0 | MB\_DEFBUTTON1 |
            | 0x100 | MB\_DEFBUTTON2 |
            | 0x200 | MB\_DEFBUTTON3 |
            | 0x300 | MB\_DEFBUTTON4 |
- **Return Value**

    | Value | Symbol | Description |
    | --- | --- | --- |
    | 1 | IDOK | OK |
    | 2 | IDCANCEL | Storno |
    | 3 | IDABORT | Cancel |
    | 4 | IDRETRY | Reset |
    | 5 | IDIGNORE | Ignore |
    | 6 | IDYES | Yes |
    | 7 | IDNO | No |
- **Examples**

    **Example 4. Using MessageBox**

    The following example will display a window with the question "Do you want to continue?" and Yes and No buttons, with the No button active.

        if ( MessageBox("Do you want to continue?",4+0x20+0x100) == 6 )
          // continue ...

## ConnectionString

The ConnectionString variable contains the connection string for the currently open database. The variable is read-only.

> [!NOTE]
> The connection string conforms to ADO technology rules.

**Example 5. Using the ConnectionString variable**

In the following example, a connection is made to the Con variable to a database that is currently open in the AM Console.

    var Con=new ActiveXObject("ADODB.Connection");
    Con.Open(ConnectionString); 

## UserId

The UserId variable contains the identifier of the user who is currently logged into the AM Console. The variable is read-only.

The identifier corresponds to the value of the intUserId attribute in the tblUser table in the database.
