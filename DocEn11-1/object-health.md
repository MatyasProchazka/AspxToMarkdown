# Object health
     
The health of an object indicates that the device is currently fully functional or partially or completely non-functional. The health of an object is determined based on the existence of [requests](../../alvao-service-desk/requests) linked to the object. Therefore, the [ALVAO Service Desk](../../alvao-service-desk) product is also necessary for its evaluation.
     
Only open requests that represent incidents or changes, i.e. requests in services with [processes that affect the health of an object](../../list-of-windows/alvao-webapp/administration/service-desk/process/create-process) affect the health of the object. The health is evaluated only on objects whose type is listed in the **WebApp - Administration - Service Desk - Services - Edit** - [Objects](../../list-of-windows/alvao-webapp/administration/service-desk/service/objects) - **Show on objects of type**.
      
Health can take on the following statuses:

| *Icon* | *Description* |
| --- | --- |
| ![](crit_incident.png) | The device is inoperable. The facility has at least one open critical incident, i.e. the SLA of the incident has a [quality index](../../list-of-windows/alvao-webapp/administration/service-desk/sla/create-sla) of 5 or higher. |
| ![](linked_incident.png) | The device may not be fully functional. Another device on which the health of that device depends has at least one open serious incident. The dependency on another device is due to the existence of a directional link between objects with the *WebApp - Administration - Asset Management - Link Types between Objects* option enabled - [New link type](../../list-of-windows/alvao-webapp/administration/asset-management/link-types/new) -*The health of the end object is affected by the health of the starting object.* |
| ![](incident.png) | The device may not be fully functional. The facility has at least one open minor incident, that is, the SLA of the incident has a quality index less than 5. |
| ![](change.png) | The device may not be fully functional. The facility has at least one open change. |
| ![](ok.png) | The object is functional. |

Individual statuses are evaluated in the order they are listed in the table, and the first status whose conditions are met is displayed as the health of the object. The calculation does not take into account the [permissions](../../alvao-service-desk/implementation/services/service-roles) of the user in the requests. Thus, the user sees health evaluated against all relevant requirements, including those that does not have permission to see.
      
Object health information is displayed in:
     
- WebApp - Objects - [Object](../../list-of-windows/alvao-webapp/objects/object)
    - [Diagram of links](../../list-of-windows/alvao-webapp/objects/object/links-diagram)
- WebApp - Request
    - [Request](../../list-of-windows/alvao-webapp/requests/request) - Object tab
    - [New request](../../list-of-windows/alvao-webapp/requests/new-request)
