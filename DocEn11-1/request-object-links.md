# Links between requests and objects
     
You can bind requests in [ALVAO Service Desk](../alvao-service-desk) to objects from [ALVAO Asset Management](../alvao-asset-management). For example, for a request representing an [incident](../itil/identity-management), you can bind objects representing the devices (CIs) involved in the incident. You can bind multiple objects to a single request, and vice versa.
     
You can view and edit the list of objects that are linked to a specific request in **WebApp - Requests** - [Request](../list-of-windows/alvao-webapp/requests/request) - **Objects** tab. Similarly, for a list of requests that are tied to a specific object, see **WebApp - Objects - Object** - [Related Requests](../list-of-windows/alvao-webapp/objects/object/related-tickets) tab.
     
So in **WebApp - User Menu - My Assets** - [Assets](../list-of-windows/alvao-webapp/search/persons/person/my-asset-object) you can directly create a new related request to the selected object.
     
In **AM Console**, requests linked to the selected object can be found in the [object log](../list-of-windows/alvao-asset-management-console/tab-view/diary). To edit the links, you can use the **New Request**, **Add to Request**, and **Related Requests** commands in the following places:
     
- [object-tree](../list-of-windows/alvao-asset-management-console/object-tree)
- Tab [Objects](../list-of-windows/alvao-asset-management-console/tab-view/objects)
- [Object Lists](../list-of-windows/alvao-asset-management-console/view/list-of-objects)
- [Objects found](../list-of-windows/alvao-asset-management-console/view/search-results)

> [!NOTE]
> If you don't see these functions in your application, ask your Alvao administrator to [enable the links between objects and requests](implementation/services/processes#request_object_links).
