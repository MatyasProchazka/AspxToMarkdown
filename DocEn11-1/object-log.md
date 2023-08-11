# Object History
     
Changes made to the object tree can be automatically recorded in the object history. The history is visible in the [main window](../list-of-windows/alvao-asset-management-console) on the right on the **Journal** tab, or in the journal at the bottom of the window on the **Properties** and **Objects**. The **Diary** and **Properties** tabs display only the records related to the object that is currently selected in the tree. On the **Objects** tab  the journal displays entries related to all objects that are selected in the top part of the window on the **Objects** tab.
     
When a new object is created or an object is copied, an entry is made in the history of both the created object and the object in which the new object was created.
     
When moving object A to another location in the tree, a history entry is created for the following objects:
     
- in object A
- in its parent object (i.e. where it was removed from)
- in the object to which object A was moved

Some records contain information about the related object, e.g. when an object is moved to another location, the record "Moved to *name of the target object*". You can find the target object in the tree by right-clicking on the record and selecting **Mark in tree**. This will display the object in the tree in bold font.

> [!NOTE]
> History entries older than 3 months are automatically moved to the archive. Archived records do not appear in the object history. If you want to view the archive as well, enable the **Table - View Archive** option in the local menu, or press the button in the bottom right of the table.

## Working with Journal entries
     
Most Journal entries are created automatically.  
         Only authorized users are allowed to manually create, edit and delete individual journal entries, see the following table:

| Record type | Administrator | SW lic. | Reader | Asset Manager | Detection Report | Accountant | Linkage Lawyers | Bond Readers |
| --- | --- | --- | --- | --- | --- | --- | --- | --- |
| Document, invalidated document<sup>1</sup> | Add  <br>
                    Edit  <br>
                    Delete | Add  <br>
                    Edit  <br>
                    Delete |  | Add  <br>
                    Edit  <br>
                    Delete |  | Add  <br>
                    Edit |  |  |
| Installation registry | Edit | Edit |  |  |  |  |  |  |
| License registry |  |  |  |  |  |  |  |  |
| Object History | Remove |  |  | Delete |  |  |  |  |
| Fault (detection) | Remove |  |  | Remove |  |  |  |  |
| Information | Delete |  |  | Delete |  |  |  |  |
| Asset inventory | Remove |  |  | Delete |  |  |  |  |
| Note<sup>2</sup> | Add  <br>
                    Edit  <br>
                    Delete |  |  | Add  <br>
                    Edit  <br>
                    Delete |  |  |  |  |
| Request |  |  |  |  |  |  |  |  |
| Lending Library |  |  |  |  |  |  |  |  |
| Warning (detection) | Remove |  |  | Delete |  |  |  |  |
| SAM alert |  |  |  |  |  |  |  |  |
<tfoot>
            <tr>
                <td colspan="9"><sup>1</sup>Only the Document link is created and removed.<br>
                    <sup>2</sup>Only the author can edit the note, others can only view the text of the note and open its attachments.<br>
                    The note can be deleted by its author and by users with the <i>Asset Management administrators</i> role.</td>
            </tr>
        </tfoot>

> [!NOTE]
> No records can be permanently deleted, they can only be "hidden".

## Display deleted (hidden) Journal entries
      
To view deleted Journal entries, enable the option located on the **Journal** tab in the local **Table - Show deleted entries** menu.  
         The user can then also see in the journal the deleted entries that is the author of or had the right to delete (see table above).  
         Deleted entries are shown in grey.  
         You can view the "Deleted" and "Deleted" columns in the Journal. For deleted (hidden) records, this shows the name of the person who deleted the record and the date the record was deleted.

> [!NOTE]
> The "Show Deleted Items" option is also found in the local Diaries menu on the **Properties**, **Objects** and **Detections** tabs.

> [!NOTE]
> If an entry is deleted in one of the logs, the changes will be reflected in all other logs.

> [!NOTE]
> Administrators can recreate deleted entries using the Tools - Database -**Restore Deleted Entries**.
