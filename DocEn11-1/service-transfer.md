# Service Transfer
     
You can transfer services, including their settings, from one instance of Alvao to another instance by exporting the settings of the selected services to a file in one instance and then importing that file into the other instance. In this way, you can, for example, transfer new services that you have created and tested in a test environment to a production environment.
     
Importing the file into the target instance creates new services, processes, etc. If the same named services, process, etc. already exist in the target instance as in the imported file, these elements are not updated in the target instance.

> [!CAUTION]
> Only new services that do not already exist in the target environment can be ported, but existing services cannot be updated.

### Export of services
     
1. In a **resource instance** (e.g., in a test environment) in **ALVAO WebApp – Administration –**[Services](../../../list-of-windows/alvao-webapp/administration/service-desk/service), select the service you want to transfer. If you do not select any service, all services in the tree will be transferred.
2. Use the **Export** command to specify whether you want to save the service to the file with or without any child services.
3. Name the file and confirm the export.

### Import services

1. In a **target instance** (e.g. in a production environment) in **ALVAO WebApp – Administration –**[Services](../../../list-of-windows/alvao-webapp/administration/service-desk/service) in the tree or in the service table, select one service to which  you want to import services from the file. Use the **Import** command. If you do not select a service, the new services are imported into the root of the service tree.
2. Select the file with the saved settings from the disk, see *Exporting services*, and confirm the file selection with OK.
3. In the displayed dialog, check the overview of the settings to be imported and confirm the import.
> [!NOTE]
> The report of the imported settings is thus saved in the Windows *ALVAO Audit* log.

5. Finish the set up according to the instructions in the report.

### File contents
     
The file contains following information:

- Service (including sub services)
    - Service settings (name, order in tree, key words, form settings, etc.)
    - Icon
    - Service catalog display settings
    - Form for submitting a new request, possibly including a default request template
    - Setting up a service representative
    - Notifications (including own notifications)
    - Custom fields of services and their values
- Processes of exported services
    - General settings of the process
    - Request items set in process
    - Solution progress
        - Request states
            - General state set (name, description, instructions for solvers, etc.)
            - Set announcements for the applicant (including a custom template)
            - Required items for transition to request state
            - Set approval
                - Target requirement states
                - Report template for approvers
                - Approval scheme name for automatically triggered approvals
            - Rules for [automatic request creation](../../../list-of-windows/alvao-webapp/administration/service-desk/process/detail/status-request/automatic-request-creation) (see module [ALVAO Advanced Workflows](../../../modules/alvao-sd-advanced-workflows))
  including the corresponding request templates, but only for the services contained in the exported file.
- Custom request items used in exported processes and services
- Custom fields for request states
- Exported service icons

The listed entities are exported including text translations into other languages.
     
The file does not contain:

- Users
- User groups
- SLA
- Access to services
- Assigned SLAs to service requesters
- Approval schemata
- Operating hours
- Requests templates in addition to the exceptions listed
