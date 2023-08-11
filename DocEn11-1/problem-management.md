# Problem Management
     
Problem Management deals with the investigation and systemic correction of the root causes of incidents. The Problem Manager is typically the Infrastructure Team Leader (2nd and 3rd line support).
     
## Default Process Pattern
     
This is a default process template that can be further customized by the customer.

| status | Description | Instructions for solvers |
| --- | --- | --- |
| **New** | Problem classification is in progress. | Check that this is a Problem. If not, use the "Move to another service" command to move the request to the correct service.
                      <br>
                    Determine the priority of the solution.
                      <br>
                    Then use the "Assign" command to assign the request to a specific solver to diagnose the problem. |
| **Diagnostics** | The problem is being diagnosed. | Find out the cause of the problem. Analyze related Incidents.
                      <br>
                    Suggest necessary measures and alternative solutions and record these. Alternatively, establish a related change request.
                      <br>
                    Finally, change the status of the record to "Known Error" |.
| **Known error** | The problem has a described cause and an alternative solution. | Connect other emerging Incidents to the problem.
                      <br>
                    After the problem is resolved, close the log with the command "Close". |
| **Closed** | The request has been closed. The request is closed. |  |
