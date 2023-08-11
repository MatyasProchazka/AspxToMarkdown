# Approval schemes
 
This page is used to manage [approval schemes](../../../../alvao-service-desk/implementation/services/processes/request-approval).
  
Options:
 
- **Command Panel**
    - **New schema** - create [new schema](approval-scheme/create-approval-scheme).
    - **Create Copy** - create a copy of the selected schema.
    - **Edit** - edit the selected schema. The menu contains the same commands as the blocks in the [schema preview](approval-scheme/detail). Schemes that are currently being approved cannot be edited. To edit them, use the *Replace* command.
    - **Replace** - If you want to edit a schema that is locked for editing because it is currently being approved, use this command on that schema. The command creates a copy of the selected schema, replaces the selected schema with this copy in all processes, and then removes the selected schema, however, approvals in progress against it will run. You can modify the resulting schema copy until a new approval is started against it, or while the new approval is in progress. We recommend renaming the resulting copy of the scheme so that the name makes the version of the scheme clear, e.g. to indicate the effective date.
    - **Delete**- delete the selected schema. Schemas that are used in [processes](../../../../alvao-service-desk/implementation/services/processes) settings cannot be removed. If you remove the schema under which approvals are currently running, approvals under the schema will normally run out.
- **Approval Schema Table**- contains all approval schemas. [Customize](../../../../alvao-asset-management/working-with-tables) the table as needed.
- **Selected Approval Schema** - after selecting a schema in the table, the [preview](approval-scheme/detail) will appear on the right.
  with information about the selected scheme.  The *Edit* command is displayed in each block of the preview.
