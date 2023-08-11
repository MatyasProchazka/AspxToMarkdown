# Solution progress
   
This window is used to define the request statuses that each request will go through during its lifetime.
   
Options:
   
- **Commands Panel**
    - [New Status](status-request) - create a new request status.
    - **Show diagram** - switch the display mode to status diagram, see the window workspace.
    - **Show List** - switch the display mode to a list of statuses, see the window workspace.
- **List of statuses** - the left side of the window contains an ordered list of statuses that the request progresses through during normal resolution. The right part contains a list of exceptional statuses that the request usually does not reach in an ideal process. You can [edit](status-request) and possibly remove individual statuses using the buttons at the right edge of the list. You can drag & drop the statuses in and between the two lists.

> [!TIP]
> Sort the statuses in the left list as they should follow each other.

- **status Diagram** - a graphical representation of each request status and possible transitions between them. This display mode is useful for checking the allowed transitions between statuses and the overall form of the solution procedure (process). You can edit individual statuses by using the buttons displayed on the right above each status that you hover over.  

> [!NOTE]
> Each time you switch to this view mode, the statuses are automatically positioned in the diagram. Manual changes to the status placement are not saved.

> [!TIP]
> Have the process status diagram drawn in MS Visio using the [GenerateProcessDiagram](../../../../../../alvao-service-desk/implementation/services/processes/generating-process-diagram) utility.

> [!NOTE]
> Note:

You cannot delete end status approvals. 


> [!NOTE]
> The system statuses *New*, *Solved* and *Closed* cannot be deleted, modified or moved. The exceptions to this rule are the *New* status, which can be renamed, and the *Solved* status, which can be moved.
