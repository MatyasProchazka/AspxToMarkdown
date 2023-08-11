# Links between objects
     
You can create links between objects in ALVAO Asset Management that describe various relationships between objects (configuration items).   For example, links can define which elements of the IT infrastructure are involved in the delivery of a particular IT service. You can then use the resulting graph to assess the impact (impact analysis) of incidents, problems and changes in the IT infrastructure.
     
For an overview of the links between an object and other objects, see the graphical diagram on the page **WebApp – Objects – Object –**[Link Diagram](../../list-of-windows/alvao-webapp/objects/object/links-diagram), or **AM Console – Object – Link Diagram**.
     
You can create and edit links directly in the [diagram](../../list-of-windows/alvao-webapp/objects/object/links-diagram) and also in the main **AM Console** window on the [Links](../../list-of-windows/alvao-asset-management-console/tab-view/links), or automated via the REST API included in the [ALVAO Asset Management Enterprise API](../../modules/alvao-am-enterprise-api) module.

> [!NOTE]
> When an object is moved to the *Recycle bin* or the *Discarded assets* folder all its links are automatically removed.

## Types of links
     
The link type specifies the nature of the relationship between two linked objects. The following system link types are available:

| Link Type | Description | Categories (system cannot be removed) |
| --- | --- | --- |
| Related to - Related to | General link - object A *is related to* object B. | system |
| Is used - Uses | For example, UPS "UPS1" *is used* by server "SERVER1". Looking from the other side: the server *is* using the UPS. Thus, the correct functionality of the server depends on the functionality of the UPS.
                      <br>
                    Use this type of link to define chains of dependencies between infrastructure elements going from the basic elements to complex end IT services. This type of links is recommended for analyzing the impact of outages and changes in IT infrastructure. | system |
| It is superior to - It is inferior to | Links of this type are determined by the object's position in the object tree and do not appear on the *Links* tab. | system |
| Hosted - Is hosted | For example, the physical server "SERVER1" *hosts* the virtual server "VM1". The virtual server "VM1" *is hosted* by the physical server "SERVER1". | ownloaded |.
| It is backed up - Backups | For example, the backup copy "Db1.bak" *backs up* the "Db1" database. Looking from the other side: Database "Db1" *is backed up* by backup copy "Db1.bak". | ownloaded |

If the above types are not enough, create your own link types in **WebApp - Administration - Asset Management** - [Object Link Types](../../list-of-windows/alvao-webapp/administration/asset-management/link-types), or **AM Console - Tools - Lists** - [Object Link Types](../../list-of-windows/alvao-webapp/administration/asset-management/link-types).
      
## User permissions
     
Only authorized users can work with Links according to the following table:

| Role | View the[links](../../list-of-windows/alvao-asset-management-console/tab-view/links)tab and[diagram of links](../../list-of-windows/alvao-webapp/objects/object/links-diagram) | Adding, editing and removing links | Manage link types |
| --- | --- | --- | --- |
| Asset Management administrators | Yes | Yes | Yes |
| Links managers | Yes | Yes | Yes |
| Links readers | Yes | No | No |
| Asset Management readers | No | No | No |
| Asset managers | No | No | No |
| Software licences managers | No | No | No |
| Software and hardware detections managers | No | No | No |
| Accountant | No | No | No |

> [!NOTE]
> The right to *View Links* and *Links Diagram* tabs means that the user can see the *Links* and *Links Diagram* tabs, respectively, of the selected object, and all its links (even links to objects to which has no rights) on it.
