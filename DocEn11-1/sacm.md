# Service Asset and Configuration Management
      
The object tree in ALVAO Asset Management can be structured in different ways.
     
- Organizationally
    - E.g. Company -&gt; Division -&gt; Department -&gt; Center
- Locally
    - E.g. Company -&gt; City -&gt; Building -&gt; Floor -&gt; Room

Both approaches have their advantages and disadvantages. The correct choice of tree structure is mainly influenced by the following factors:
1. Tree clarity
    - The solution team should quickly deduce what the object is and what the context is from its position in the tree
    - This will often also show them what the impact is (whether it is just a local printer or a shared one)
2. Rights within the tree
    - Organizational breakdown allows setting data visibility permissions on the WebApp for managers by Department, Division, etc.
    - Local segmentation helps the solution team in cases where managed devices are spread across multiple sites and different technicians need to be given different rights across those sites.
3. Inheritance within the tree
    - A properly designed tree makes filling in information easier
    - Information such as department numbers, employee names, then do not need to be filled in and this information is propagated within the tree automatically

Practice shows that the two approaches can be blended according to needs. The entire tree can start from the Organizational breakdown and then seamlessly transition to the Local breakdown as needed. Changing the organization tree in the future is possible and does not mean that you have to re-enter the information.
         ![](sacm/object_tree.png)      
## Life Cycle
     
The life cycle of each object (CI) is historically recorded in each object's log. It can be recorded in two ways:

1. Position in the tree (recommended)
2. The "Status" property

### Lifecycle management using tree positioning
     System folders are ready in the system immediately after installation: warehouse, discarded assets, recycle bin. These folders can be further extended with additional folders as required: assets to be scrapped, Complaints (this can be further subdivided by supplier), Installation, etc. The position in the tree then simply shows where the object is currently located, which also represents its status. The user can then change the status by simple drag&drop operations within the tree.  
       
     Example of using position in the tree:  
       
     ![](sacm/object_tree_lifecycle.png)      
### Manage the lifecycle using the "State" property
     The "State" property is manually modified during the object lifecycle (more administratively intensive). However, this method can be well used for objects representing important servers or key applications over which consistent Release Management is performed.
Example of using the "Status" property:  
         ![](sacm/status_lifecycle.png)
      
## Inventory
     
See ALVAO Asset Management -         [Asset Inventory](../modules/alvao-inventory-audits/stocktaking).
      
## Example of an internal directive
An internal directive on this issue should include the following information:
1. Computers and other IT equipment entrusted to users for use are recorded in the ALVAO Asset Management system.
2. Each user can view a list of the devices registered with them at https://server/asset.
3. If an employee finds a discrepancy in the records, will immediately report it to the Service Desk.
