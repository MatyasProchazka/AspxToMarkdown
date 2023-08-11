# Draw links in MS Visio
     
In addition to drawing [links diagram](../../list-of-windows/alvao-webapp/objects/object/links-diagram) directly in WebApp, you can also draw links diagram in MS Visio:
     
1. In the **ALVAO Asset Management Console**, in the object tree, select the object whose links you want to visualize.
2. From the main menu, select **Object - Draw links in MS Visio**.
3. A new MS Visio document with the drawn links will be displayed.  

            The generated document contains the entire dependency tree of the selected object.

## Utility GenerateNodeRelationshipDiagram
     
Use this utility to start drawing a link diagram from the command line.
      
#### Functions
     
Generates object dependency diagram in MS Visio (relative to the object that is given by ID number).  
         This utility works only if MS Visio is installed.
      
#### Syntax command lines
      
**GenerateNodeRelationshipDiagram.exe /conn** *"connection string"* **/nodeId** &lt;object id&gt;[**/mode** &lt;mode&gt;]
      
##### Parameter structure

| Switch | Description | Mandatory |
| --- | --- | --- |
| /conn &lt;string&gt; | Setting up a connection to DB. | Yes |
| /nodeId &lt;objectId&gt; | ID of the initial object from which the links will start rendering (intNodeId).  <br>
> [!NOTE]
> You can find out the object ID e.g. in the AM Console on the Child Objects tab by displaying the "NodeId" column. | Yes |

| /mode &lt;mode&gt; | Rendering mode:<ul>
                        <li>ImpactDiagram (default) - impact diagram; Renders the initial object (see nodeId) and all objects that use this object or that use this object (link type uses - is used) recursively.   It also plots objects that are directly related to the initial object (link type related to, direct links only).</li>
                        <li>ContextDiagram - renders the initial object (see nodeId) and all objects that are directly related to it (all link types, including parent-child link in the object tree). It then displays all the links between these objects.</li>
                    </ul> | No |
