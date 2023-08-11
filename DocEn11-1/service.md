# Services
 
On this page you can manage [services](../../../../alvao-service-desk/implementation/services) to which requesters enter their requests.
   
Options:
   
- **Command Panel**
    - **New Service** - create [new service](service/create-service).
    - **Table/Tree** - switch the service view mode.
    - **Display deleted/Hide deleted** - show or hide services that are marked as deleted, see the *Delete* command. These commands are only available in a tree (see *Show as tree*).
    - **Edit** - modify properties and user permissions for the selected service. The menu contains the same commands as in the [preview](service/detail) blocks of the service.
    - **Delete** - mark the selected service as deleted in the database (it cannot be permanently removed from the database, only marked with the *Delete* flag). Services marked in this way are not normally displayed in the application, but you can view them with the *View Deleted* command;
    - **Copy** - copies the selected service, possibly including all sub-services. After this command, use the *Paste* command. You can also invoke the *Copy* command using the keyboard shortcut
 Ctrl+C.
    - **Paste** - Paste a copy of the service specified by the last use of *Copy* into the selected service in the tree. You can also invoke the *Paste* command using the keyboard shortcut
 Ctrl+V. All service settings are copied except those in the [Message Reading](service/detail/edit) block.

> [!TIP]
> You can also copy services in the tree with the mouse using the drag & drop method with the key pressed.

 Ctrl.
    - **Restore Deleted** - restores selected services that are marked as deleted, see *Remove*.
    - **Overwrite permissions**- override all permissions set on the selected services with the permissions of [a specific service](service/multi-edit/authorization). This command is only available for 2 or more selected services in the table. You can override the permissions of a single service with the [Edit - Permissions](service/detail/authorization) - *Override* command.
    - **Remove permissions** - remove all permissions set on the selected service. This command is only available for 2 or more selected services in the table. You can remove permissions from one service by using the [Edit - Permissions](service/detail/authorization) - *Remove* command.
    - **Overwrite SLA** - Override all SLAs set on the selected services by setting the SLA of [a specific service](service/multi-edit/sla). The command is only available for 2 or more selected services in the table. You can override the SLA settings of a single service with the [Edit - SLA](service/detail/sla) - *Override* command.
    - **Remove SLA** - remove all SLAs set on the selected services. This command is only available for 2 or more selected services in the table. You can remove the SLA settings of one service with the [Edit - SLA](service/detail/sla) - *Remove* command.
    - **Export** - export the selected service including child services and related settings (process, custom fields, etc.) to a file, see [Service transfer](../../../../alvao-service-desk/implementation/services/service-transfer). If you do not select any services, all services in the service tree are exported.
    - **Import** - Import services from a file. The services contained in the file are created as child services under the currently selected service. If you do not select any services, the new services are imported into the root of the service tree.
- **Service tree**- services displayed in the tree (see *Show as tree*).

> [!TIP]
> You can move services in the tree with the mouse using the drag & drop method.

- **Services table** - services displayed in the table (see *Show as table*). You can [customize](../../../../alvao-asset-management/working-with-tables) the table as needed.

> [!TIP]
> You can select multiple services in the table and [edit them in bulk](service/multi-edit). You can select services in the table by clicking in the first column "pipe" or by selecting rows with Ctrl or Shift.

- **Selected service** - after selecting a service in the tree or table, [preview](service/detail) will appear on the right
  with information about the selected service.  The *Edit* command is displayed in each preview block to modify the service settings.

## How to design a service structure

- Applicants select the service sequentially from the root to the leaves of the tree. It is recommended to build the tree, if possible, so that on the path from the root to the leaves, requesters are able to intuitively select the correct service to insert their request.
- For the service tree breakdown you can use auxiliary services with enabled option [Folder](service/create-service). New requests cannot be added to folders.
- For frequently used services, you can create a [service placeholder](service/create-service) in a more accessible location in the service catalog.

## Links on the main page
   
Services in the *Links on the main page* folder appear as tiles on the main page below the search box. If you want to display a link to a form to submit a request to a specific service on the main page, create a shortcut for that service in the *Links on Main Page* folder in the catalog. The link will only appear on the main page for users who have an SLA assigned to that service. If you want to display a link to any other page in the ALVAO WebApp or elsewhere, create a service and enter the url of the page in the *[New Ticket Submission Form](service/detail/new-ticket-items) - Custom Form URL* field and assign any SLA in that service to the users to whom the link should be displayed.    
A maximum of 8 links will be displayed on the main page. The links are displayed in the same order as the services in the catalog.
