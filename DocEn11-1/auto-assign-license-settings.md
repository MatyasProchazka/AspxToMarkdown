# Setting Automatic License Allocation
 In this dialog, you can set a filter to narrow the set of computers to which the license will be assigned.   
 The filter is set using SQL syntax conditions and must have the following format:  
 
[@ObjectKind] | [@ObjectName] | [@ObjectPath] | [&lt;object property name&gt;]&lt;operator&gt;&lt;value&gt;
  
[@ObjectKind] - object kind  
 [@ObjectName] - Name of the object in the tree  
 [@ObjectPath] - Path in the tree (entered as: object1/object2/...)  
 [&lt;object property name&gt;] - Name of any object property (even inherited)
   &lt;operator&gt; - The following SQL operators can be used:
- = - equals
- !=,&lt;&gt; - does not equal
- IN - determines whether the specified value is in the subquery/list
- LIKE - string comparison with the possibility of using simple regular expressions
- NOT - operator negation - concatenation with another operator (IN, LIKE)
- IS NULL - the value is NULL - e.g. the object does not have a specific property

 &lt;value&gt; - N'string', where the prefix N specifies that the string is in Unicode encoding 

> [!NOTE]
> Comparing values can be case sensitive.   

Conditions can be combined using AND and OR operators.
Filter examples:
- **[@ObjectKind] = N'Computer/Server'**License assignment only to computers of type "Computer/Server".
- **[@ObjectPath] LIKE N'Organization/Brno%'**  License assignment only in a specific part of the tree, according to the path in the tree.
- **[Branch] IN (N'Praha',N'Brno')**Add only to computers that are in specific branches.
- **ISNULL([Branch],'') != N'Ostrava'**Add to all computers that are not in the Ostrava branch. Note:
- **[Branch] IS NULL**Only allocate to computers that are not on any branch.
- **[Location] NOT IN (N'IT Warehouse',N'Central Warehouse') AND [Software Responsible]=N'PC software managers'**Example of a filter composed of multiple conditions - computers that are not in specific warehouses AND the software on the computer is the responsibility of the "PC software managers" group.
- **[Location] NOT LIKE N'Stock%'**All computers where the value of the "Location" property does not begin with the word "Warehouse".
