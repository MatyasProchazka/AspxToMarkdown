# Processes
     
Process defines the request lifecycle, i.e. a sequence of request states, such as "New", "Solution", "Resolved", etc.
     
Processes can be edited in **WebApp - Administration - Service Desk** - [Processes](../../../list-of-windows/alvao-webapp/administration/service-desk/process/detail).
     
You can assign a process to one or more [services](service-tree).
     
## Links between requests and objects
     
If you want to use [request object links](../../request-object-links) in a process, add [request items](../../../list-of-windows/alvao-webapp/administration/service-desk/process/detail/request-items) **Objects**.

> [!TIP]
> Add [Incident Management](../../../itil/incident-management), [properties](../../../alvao-asset-management/implementation/object-templates) **Incident Default Service** and **Incident Default SLA** to the object templates that can be linked to requests in the process. Then, when a new request is created from the object, the [New request](../../../list-of-windows/alvao-webapp/requests/new-request) form automatically sets the service and SLA corresponding to the values of these properties in the object.
