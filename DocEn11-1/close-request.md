# Request Closure
     
After the request is resolved, the solver marks the request as closed by changing the status to *Closed*. This step is not necessary if the status is *Solved*.is set to automatically close the request, where resolving the request will also change the status to *Closed*.
     
The request cannot be closed in the following cases:
     
- Request does not have mandatory fields filled in for the *em>status*
            Closed.
- Solution progress does not allow transition from the current request status to the *Closed* status. For more information about workflow settings, see [Processes](../implementation/services/processes).
- The request has its own workflow.
