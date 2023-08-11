# New script
     
Use this form to create a new script in the application.
      
Options:
     
- **Template** - select a suitable script template:

    | Template Name | Description | Included inCustom Appsmodules |
    | --- | --- | --- |
    | Empty | Empty script | Asset Management, Service Desk |
    | Class Library | A library of helper classes that can be used in other scripts. Defined classes cannot be used in another library. | Asset Management, Service Desk |
    | [IEntityCommand](../../../../../../modules/alvao-am-custom-apps/applications/i-entity-command) | Custom entity command | Asset Management, Service Desk |
    | [IGeneralCommand](../../../../../../modules/alvao-sd-custom-apps/applications/custom-commands/general-custom-commands) | Custom command in the main menu | Asset Management, Service Desk |
    | [ITicketAutoAction](../../../../../../modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events) | Auto action on request event | Service Desk |
    | [IActAutoAction](../../../../../../modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events) | Auto action on an event in a request log entry | Service Desk |
    | [ITicketApprovalAutoAction](../../../../../../modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events) | Automatic request approval action | Service Desk |
    | [IMailMessageAutoAction](../../../../../../modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events) | Automatic action on message retrieval | Service Desk |
    | [IObjectPropertyAutoAction](../../../../../../modules/alvao-am-custom-apps/applications/object-custom-actions-by-property-change) | Automatic action when changing the value of an object property | Asset Management |
    | [IObjectMoveAutoAction](../../../../../../modules/alvao-am-custom-apps/applications/object-custom-actions-by-object-move) | Auto action when moving an object | Asset Management |
    | [IPeriodicAction](../../../../../../modules/alvao-sd-custom-apps/applications/periodic-custom-actions) | Periodic Action | Asset Management, Service Desk |
    | [IEntityTab](../../../../../../modules/alvao-am-custom-apps/applications/i-entity-tab) | Custom tab on entity page | Asset Management, Service Desk |

    Each script represents a particular UI element or other type of program extension that is an implementation of a particular interface in C#. The templates are named the same as the interface.
- **Name** - enter a name for the script. We recommend naming scripts with the name of the class they implement. For example, the *Open document* custom command class that implements the *IEntityCommand* interface could be named *OpenDocumentCommand* and the script name would be the same. By selecting the template, the appropriate ending will be automatically filled in the script name.
