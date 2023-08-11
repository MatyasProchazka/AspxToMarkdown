# IEntityCommand
     
By implementing this interface, you can define custom commands for an object or a request. For an example, see the [CostsCalculation](templates) application template.
     
In the [application](../applications), create a new script using the *IEntityCommand* template and name it appropriately according to the functionality of the custom command.       
         In the newly created script, set the following properties in the constructor of the class:
     
- Id - a unique command identifier (string)
- Entity - the type of entity for which the command will be displayed (Entity.Request or Entity.Object).

## Interface methods

| Method | Description |
| --- | --- |
| Show | Display the command in the command menus. |
| Run | Run the command. |

## Show
This method controls display of the command in command menus.
- Syntax: **EntityCommandShowResult** Show(int **entityId**, int **personId**)
- Parameters:
    - **entityId** - the entity ID (tblNode.intNodeId or tHdTicket.iHdTicketId) for which the command should be displayed.
    - **personId** - the ID of the user (tPerson.iPersonId) to whom the command should be displayed.
- Return values: an instance of the class **EntityCommandShowResult**with properties:
    - **Name** (string) - a display name of the command
    - **Show** (bool) - true = the command will be displayed, false = the command will not be displayed.
    - **Position**(int) - the position in UI at which the command will be displayed:
        - 1 = first position of the entity main menu
        - 2 = last position of the entity main menu
        - 3 = first position of the nested menu in the entity main menu
        - 4 = last position of the nested menu in the entity main menu
    - **Icon** (string) - a command icon name; See [Fluent UI Icons](https://developer.microsoft.com/en-us/fabric#/styles/web/icons) - *Available icons* at the bottom of the page - hover over the icons to view icon names. If you do not specify any icon the *LightningBolt* icon will be used.

> [!TIP]
> By calling this method in the *Run* method, you can check if the conditions for displaying the command haven't changed between the time of displaying the command and running it.

## Run
     
This method implements the command itself.

- Syntax: Tuple&lt;**bool**, **string**, **string**&gt; Run(SqlConnection **con**, int **ticketId**, int **personId**)
- Parameters:
    - **entityId** - the entity ID (tblNode.intNodeId or tHdTicket.iHdTicketId) for which the command was run.
    - **personId** - the user ID (tPerson.iPersonId) who ran the command.
- Return values:
            an instance of the **CommandResult**class containing roperties:
    - **MessageType**(MessageType) - specify whether a message should be displayed to the user as a result of the command execution:
        - *None* – no message will be displayed
        - *Info* - an information message will be displayed
        - *Warning* - a warning message will be displayed
        - *Error* - an error message will be displayed
    - **MessageText** (string) - specify a text of the message that will be displayed to the user.
    - **NavigateToUrl** (string) - optionally specify an URL to navigate to after the command execution.

> [!TIP]
> If the custom command is to open another ALVAO WebApp page, use the Alvao.API.Common.DbProperty.WebAppUrl property from the [Alvao.API](../../../alvao-asset-management/implementation/customization/alvao-api) to get the root URL of the WebApp.
