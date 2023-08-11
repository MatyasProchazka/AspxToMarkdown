# Custom functions for service selection
     
When creating a request and possibly moving the request to another service, the service to which the request will be created/moved is selected.
     
It applies to the following forms:

- [New request](../../list-of-windows/alvao-webapp/requests/new-request)
- [Move to another service](../../list-of-windows/alvao-webapp/requests/request/move-to-another-service)

## System Behaviour
     
The *Service* field displays the localized service name including the path in the tree.
      
When you expand the list, the box shows the 20 services in which the main solver last created requests. Searching the list displays all services in which the current requester has an SLA, regardless of other logged-in user roles.
      
Deleted services, folders, and proxies that have the same name and default request template as the service being represented are not offered.
      
The text entered in the field is searched for in the service name, including the path in the tree, and in keywords.
      
Values are sorted by path in the tree.
       
## Custom functions
     
If you wish to change the way you search and sort values in the service field, add the *spHdSectionForRequesterSearch\_Custom* procedure to the database.
      
If the *spHdSectionForRequesterSearch\_Custom* procedure is defined in the database, the *spHdSectionForRequesterSearch* procedure is used instead of the default *spHdSectionForRequesterSearch* procedure.
      
The *spHdSectionForRequesterSearch\_Custom* procedure has the same inputs and outputs as the existing *spHdSectionForRequesterSearch* procedure.
