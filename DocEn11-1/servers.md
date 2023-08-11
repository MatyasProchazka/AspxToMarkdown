# Servers (deprecated)
 
On this page you can manage servers that have [ALVAO Asset Management Collector](../../../../alvao-asset-management/implementation/detection/collector).
  
Options:
 
- **Command Panel**
    - **New Server** - add [new server](servers/create-server) to the list.
    - **Edit** - edit the properties and settings of the server. The menu contains the same commands as in the [server preview](servers/detail) blocks.
    - **Delete** - delete the selected server.
    - **Allow** - resumes AM Collector activity on the selected server if the server has been disabled, see the *Disable* command.
    - **Disable** - stops the AM Collector from running on the selected server.
- **Server Table** - contains all servers and their selected attributes. You can [customize the table as needed](../../../../alvao-asset-management/working-with-tables).
- **Selected Server** - After selecting a server in the table, a [view](servers/detail) will appear on the right with information about the selected server. The *Edit* command is displayed in each block of the preview to modify the server settings.

> [!NOTE]
> Changing the settings of the running server will take effect within 5 minutes. If you want the settings change to take effect sooner, restart the Collector service on the server.
