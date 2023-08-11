# Approval steps
 
Use this window to manage the steps of the [approval scheme you are editing](../../../../../../alvao-service-desk/implementation/services/processes/request-approval).
  
Options:
 
- **Command Panel**
    - **New Step** - create a new [approval step](approval-scheme-item).
    - **Edit** - edit the selected step.
    - **Delete** - delete the selected step.
    - **Move up** - move the selected step up one row.
    - **Down** - move the selected step one row lower.
- **Steps table** - contains the steps of the schema.Approval starts with the first step. If the request is approved in the first step, it automatically moves to the next step, and so on. If the request is rejected in a step, the next step does not proceed and the entire schema is terminated with the result *rejected*. You can [customize the table as needed](../../../../../../alvao-asset-management/working-with-tables).
