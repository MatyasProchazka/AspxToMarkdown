# Request Fulfilment
     
Request Fulfilment deals with frequently recurring requests made to the Service Desk that are low enough risk that they do not need to go through the more formalised ITIL Change Management process. Typical requests that Request Fulfilment deals with include a request to change a password, a request to install standard software on a specific workstation, or a request for a consultation.
      
## Approval
     
Urgent requests, however minimal the risk to the organisation's business (request for standard HW, installation of approved software, etc.), must be approved, e.g. for financial reasons.
     
Approvals can be done in two ways in Alvao Service Desk: by emailing the approver and a more formal option - the Let me approve function. Using the approval agenda, we can predefine different [approval schemes](../alvao-service-desk/implementation/services/processes/request-approval) for different services. The approval schema is activated at the beginning of the process, and until the request is approved, it is not started and the solution team does not see it in the "Requests to be resolved". Of course, at any time during the resolution of a request, approval can be triggered on any approval schema if new circumstances are discovered.
     
## Default Process Pattern
     
This is the default process template, which can be further modified by the customer according to their needs.

| Status | Description | Instructions for solvers |
| --- | --- | --- |
| Approval | Request approval is in progress. | Check that this is a "Service Request". If not, use the "Move to another service" command to move the request to the correct service.                           <br>                         Check that the request has been approved. If it has been rejected, close it with the "Close" command.                           <br>                         Determine the priority of the solution.                           <br>                         Then use the "Assign" command to assign the request to a specific solver. |
| Realization | Request execution is in progress. | Execute the request.                           <br>                         Record all changes in the configuration database.                           <br>                         Finally, close the request with the command "Close". |
| Closed | The request has been closed. The request is closed. |  |
