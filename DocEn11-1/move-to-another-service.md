# Move to another service
 
Use this form to [move](../../../../alvao-service-desk/requests/move-to-another-service) a selected request or even several requests at once to another service.
 
Options:
 
- **Please select a service to move the request to**- enter at least part of the service name and then select the service from the drop-down menu.
    - **...** -
 or search for the service and select it in the service tree.
- **Assign to solver**
    - **Do not change the solver if possible (solver name)** -
 Select this option if you want to leave the request to its current solver or solver group. If the current solver is not a solver or a special solver for the target service, the request will automatically be returned to the main solver.
    - **Assign**- select to assign the request to another solver or solver group.
        - **Solver Group** - enter at least part of the name of the solver group and then select the solver group from the drop-down menu. The field is displayed only if the service contains at least one solution group.
        - **Request queued without solver** - select this option if you want to return the request to the [to the main solvers](../../../alvao-service-desk/implementation/services/service-roles) of the service (if the request is assigned to the *Main* solver group) or to all solvers of another solver group (if the request is assigned to a solver group other than *Main*).
        - **Assign to solver** - select this option if you want to assign the request to a specific solver. Then type at least part of the solver's name and select that solver from the drop-down menu.
    - **Comment** - if applicable, write a message to the new solver of the request or the main solvers of the new service. Your comment will be sent to them in an email notification.
- **Cost Report** - if applicable, [report the work time](../../../../alvao-service-desk/requests/work-time) spent resolving the request.

> [!NOTE]
> If the target service has the same process as the original service, the status of the request does not change after the move and the request solving process continues. If the target service uses a different process, the request moves to the initial status of the solving process and any pending approval is cancelled. A new approval may be automatically triggered when the transition to the initial status occurs.  Mandatory fields for the initial status in the target service are ignored when the request is moved. The main solver of the target service SHOULD classify the request and add the mandatory items after the move.

> [!NOTE]
> You can move a request to another service if you are the current solver or a member of the solving team of that service.  

 If you are not the main resolver or resolver in the target service, it is necessary to have the Requester reporter permission.  

 In order to change the solver of a request, you must also be a member of the resolution team of the target service.  

 You can only move a request to services in which the Requester of the request has some SLAs.
