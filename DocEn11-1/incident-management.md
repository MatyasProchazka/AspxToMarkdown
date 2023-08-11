# Incident Management
     
The purpose of Incident Management is to respond to unplanned situations where services are not being provided at the agreed levels (e.g. Exchange server downtime or reduced availability) and restore Normal Service Operation as quickly as possible. Emphasis is placed on minimising the impact of service failure on the business of the company (Business Impact).
     
It follows from the above that incidents that cannot be resolved by 1st line support within internally agreed timeframes, e.g. using the Known Error Database and Knowledge Base, must be escalated to the technical teams without delay.
     
The Incident Records workflow can be defined by the service whose level has been reduced below an agreed threshold by the incident. However, from a practical point of view, we recommend not to present many statuses for generality and to use only the New - Resolved - Closed request statuses. Differences in the typical procedures leading to the resolution of an incident in different services can be reflected in the instructions to the solver or even in the workflow itself. This is subject to customer needs analysis.
      
## Default process pattern
     
This is the default process template, which can be further modified by the customer according to their needs.

 Status | Description | Instructions for the solver || **New** | Incident classification is in progress. | Check that this is an Incident. If not, use the "Move to another service" command to move the request to the correct service.
                      <br>
                    Determine the priority of the solution.
                      <br>
                    Then use the "Assign" command to assign the request to a specific solver. |
| **Solution** | Incident resolution is in progress. | Restore normal service operations as quickly as possible.
                      <br>
                    Finally, close the incident with the command "Close".
                      <br>
                    If it is a known problem, bind the Incident to it as "related". |
| **Closed** | The request has been closed. The request is closed. |  |
