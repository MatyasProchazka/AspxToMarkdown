# Query Wizard - Step 2
 
In the second step of creating a [database query](../../../alvao-asset-management/searching/query), define the properties you want to monitor.  
 The content of the window changes depending on which object you select in the **Object List** - the parameters are set separately for each object.
 
Options:

- **Object List** - select the object whose properties are displayed in the **Property List** window.  

 Only the control object selected in step 1 is listed at the beginning. Use the **button. Add Object** button to add additional objects to the list whose properties should appear in the query result.
- **Property List** - turn on all properties of the selected object that you want to use in the query,  

 i.e. you want to display them in the query result or set some condition for them, e.g. "RAM size less than 64 MB".
- **Search direction** - select the search direction of the selected object relative to the control object.  
A object other than the control object must be selected. Typically, child objects are searched.
    - **Child Object** - select if you want to search downwards, i.e. among the child objects of the control object.
    - **Parent object** - select if you want to search upwards, i.e. between parent objects.
- **Level**- select the search depth of the selected object.
    - **Depth** - select if the searched object can be anywhere in the tree of child objects of the controlling object.
    - **Surface** - select if the searched object must be a direct child object of the control object, i.e. not a child object of a child object.
- **Quality**- select the search quality of the selected object.
    - **All** - select to search the entire subtree of the controlling object.
    - **Closest** - select to find only those objects that are at the closest level in the control object's subtree.
- **Non-empty objects only** - turn on if the control object should only be in the query result if the selected child/superordinate object exists.
- [Add object](../edit/new-object/object-template) - add another object to the **Object List**.
- **Delete Object** - remove the selected object.
