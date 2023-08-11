# Upgrade from ALVAO 11.0 – manual steps
      
## Custom Apps
      
When upgrading from ALVAO 11.0, you need to modify you existing custom extensions, see [ALVAO Asset Management Custom Apps](../modules/alvao-am-custom-apps) or [ALVAO Service Desk Custom Apps](../modules/alvao-sd-custom-apps). Modify the source files and scripts as described on this page. If you are upgrading from ALVAO 10.4 or earlier, first [convert the custom extensions to ALVAO 11.0](../../11.0/upgrade/customization_upgrade).
      
1. In all [Applications](../modules/alvao-am-custom-apps/applications) and [Custom Forms](../modules/alvao-sd-custom-apps/custom-form-template):
    - Instead of the namespace **System.Data.SqlClient** use *Microsoft.Data.SqlClient*. E.g.:  

                Replace the line using System.Data.SqlClient; with using Microsoft.Data.SqlClient;.
    - Delete all uses of namespaces **Alvao.ServiceDesk.ServiceDeskWebApp.Infrastructure.WebService** and **Alvao.Apps.WebService**.
2. Stored database procedure *spReadAllComunication* was renamed to *spReadAllCommunication*.
3. Log mode *Comunication* (logMode=Comunication) for the request URL was renamed to *Communication* (logMode=Communication).
4. Renamed value in enumerator Alvao.API.SD.Act.TicketLogMode from *Comunication* to *Communication*.
5. Change of word "licence" to "license":
    - Table dbo.PeriodicAlert, columns:
        - Licence name –> License name
        - Licence inventory number –> License inventory number
    - View *Query.SwInstallationEnu* column *Number of assigned licences* –> *Number of assigned licenses*
6. The custom apps interfaces [ICommand](../modules/alvao-sd-custom-apps/applications/custom-commands) and [IView](../modules/alvao-sd-custom-apps/applications/ticket-custom-tabs) were deprecated. Use [IEntityCommand](../modules/alvao-am-custom-apps/applications/i-entity-command) and [IEntityTab](../modules/alvao-am-custom-apps/applications/i-entity-tab)instead.
    1. Add definition of command entity (Entity.Request, Entity.Object)
    2. Change return types of the *Show* method to *EntityCommandShowResult/EntityTabShowResult* object.
    3. Change return types of the *Run* method to *CommandResult* object.
    4. Change the *SqlConnection* parameter uses to *AlvaoContext.GetConnectionScope()*.
