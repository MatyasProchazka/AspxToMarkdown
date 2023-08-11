# Hardware detection vs. Tree

- **Differences List** - the list shows the differences between the data taken by the detection and the data in the [object tree](../../../object-tree).
- **Write changes to the tree** - make updates to the computer objects in the tree according to the detection data. The update is performed only on objects that have automatic update enabled.  
    **Update objects in the tree according to the following rules:**

    | Condition | Action |
    | --- | --- |
    | A device is detected that does not have a corresponding object in the computer's object tree | Create a new object in the computer tree based on a device in detection |
    | There is an object in the computer object tree that does not have a matching device in the detection | Moving an object from the computer tree to the Trash object |
    | There is an object in the computer object tree that has a matching device in the detection but differs in some properties | Update the properties of an object in the computer tree according to the device in the detection |
- **Find a matching computer**- If any of the entries are in the list of differences:
    - Evidence was not updated according to the detection because some detected components are already in another computer in the inventory. It is possible that the computer has been renamed in the network. Use the *Find matching computer* and *Compare with inventory* commands on the **Detection** tab.
    - Evidence has not been updated according to hardware detection because the underlying computer components have changed. It is possible that the computer has been renamed on the network. Use the *Find Matching Computer* and *Compare with Evidence* commands on the **Detection** tab.

    Use this feature to find the computers to which these detected components correctly belong.

    You set the computer identification components in [Asset Management Administration](../../../../../alvao-asset-management/software-management).

> [!NOTE]
> - you replace any of the computer's essential components and the action is not recorded in the log

    - you rename computers on the network and do not record the action in the log
    - some of the computer's identifying information is not unique. In this case, the component cannot be used as an identifier and must be removed from the list of identifiers.
    - for the motherboard serial number, ignore the values "MB-1234567890" and "00000000"
- **Automatic Update**
    - Enable - enable automatic update on the selected object in the changelist.
    - Disable -  disable automatic update on the selected object in the changelist.
