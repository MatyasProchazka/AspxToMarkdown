# Links between requests
      
Request links to other requests are shown on the [Request](../../list-of-windows/alvao-webapp/requests/request) page -  **Links** tab. You can also view the links directly in the [requests table](../../list-of-windows/alvao-webapp/requests/table-of-requests).
      
## Types of links

| Link type | Link meaning |
| --- | --- |
| Relates to  <br>

                    ![](related.png) | For example, two change requests are for the same device (CI). These requests are *related*.<br>
                    <br>This is a general type of link. There is no functionality tied to this link type. |
| It is parent over / It is child under  <br>

                    ![](superior_subordinated.png) | For example, a *supervised* task consists of sub *subordinate* tasks (decomposition).<br>
                    <br>A parent request cannot be closed while it has open child requests.<br>
                    <br>A notification is automatically sent to the solver of the parent request when each child request is resolved. |
| Precedes before / Follows after  <br>

                    ![](previous_following.png) | For example:<br>
                    <ol>
                        <li><em>Previous</em> tasks must be completed chronologically before <em>next</em> tasks.</li>
                        <li>The following <em>request</em> was created based on the <em>preceding</em> request.</li>
                    </ol>
                    <br>Used to document the solution sequence or origin of the request. |
| Blocking/Is Blocked  <br>

> [!NOTE]
> The application does not restrict the resolution or closure of a blocked request in any way.<br>

                    <br>A notification is automatically sent to the solver of the blocked request when each blocking request is resolved. |
| Is Duplicated / Duplicating  <br>

                    ![](duplicated_duplicate.png) | For example, two users have reported incidents regarding the same issue. The first incident will be Duplicated, the second will be Duplicate to it. |

## ITIL
      
For links between records of individual ITIL processes, we recommend using the following types of links:
      ![](itil.png)
For "simple" ITIL, we recommend recording all links as "related".
      
If you want to implement ITIL more consistently, we recommend using the following types of links:

| ITIL | Link type | Note |
| --- | --- | --- |
| Incident - similar Incident (parent - child) | Is Duplicated - Duplicates | The first incident is marked as "Is Duplicated". All other incidents related to the same fault duplicate the first incident. |
| Incident - Problem/Known Error | Related to | An incident may occur to an existing problem. A problem can arise from an existing incident. Therefore, it is not appropriate to use "Precedes Before - Follows After". |
| Incident - Service Request | Precedes Before - Follows After | Service Request is created based on an incident (SR handles the incident). |
| Incident - RFC (N:N) - RFC is triggered by an incident | Precedes before - Follows after | The RFC resolves the incident. |
| RFC - Incident (caused by) | Precedes Before - Follows After | Incident caused by a poorly implemented change. |
| Problem - RFC | Precedes before - Follows after | Problem is resolved via RFC. |

## Custom link types
      
The Alvao administrator can create custom link types in the database in the [TicketRelationType](../../alvao-asset-management/implementation/customization/database#U_dbo.TicketRelationType) table. Changes to system link types are not supported.

> [!TIP]
> When creating new link types, choose the start and end of the link so that the link is mostly created from the initial request. When creating a link, the end names of all types are offered first, then the start name.
