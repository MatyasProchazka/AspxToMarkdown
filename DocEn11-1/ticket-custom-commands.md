# ICommand

> [!CAUTION]
> This interface is deprecated. Instead of this interface use the [IEntityCommand](../../../alvao-am-custom-apps/applications/i-entity-command) interface.

By implementing the ICommand interface in the [application script](../../../../list-of-windows/alvao-webapp/administration/applications/app/scripts), you can define custom request commands.       
   
      In the [application](../../applications), create a new script using the *ICommand* template and name it appropriately according to the functionality of the custom command.       
     In the newly created script, set the id, name, position, and icon property values in the constructor of the command class:
     
- id - command number (unique)
- name - the name of the command that will be displayed in applications
- position - the position at which the command will be displayed in applications
    - 1 = at the first position of the main request menu
    - 2 = at the last position of the main request menu
    - 3 = at the first position of the nested menu in the main request menu
    - 4 = the last position of the nested offer in the main offer of the request
- icon - the name of the command icon
    - Use the icon name from the [Microsoft Fabric](https://developer.microsoft.com/en-us/fabric#/styles/web/icons) library as the command icon name (the icon name will appear on the page when you hover over the selected icon). If you do not specify an icon, the *LightningBolt* icon is used.

> [!TIP]
> To store the properties and settings of the command, we recommend defining the *Settings* class in a separate script that you create from the *Class Library* template.

## Interface Methods

| Method | Description |
| --- | --- |
| Show | Display the command in the request menu. |
| Run | Run command. |

## Show
     This method checks the defined conditions for displaying the command.     

> [!TIP]
> By calling this method in the *Run* method, you can check if the conditions for displaying the query have changed between the time the query was displayed and the time the query was run.

- Syntax: **bool** Show(SqlConnection **con**, int **ticketId**, int **personId**)
- Parameters:
    - **con** - SqlConnection to the database.
    - **ticketId** - The request ID (tHdTicket.iHdTicketId) for which the command will be displayed.
    - **personId** - the ID of the user (tPerson.iPersonId) to whom the command should be displayed.
- Return values:
    - **bool** - the truth value of whether the command should be displayed to the user on the specified request.

      You can find an example use case in the [CostsCalculation](../../../../modules/alvao-am-custom-apps/applications/templates) application template.      
## Run
     This method runs the command itself.     

> [!TIP]
> If the custom command is to open a different page from the ALVAO WebApp, use the Alvao.API.Common.DbProperty.WebAppUrl property from the [Alvao.API](../../../../alvao-asset-management/implementation/customization/alvao-api) interface to get the root URL.

- Syntax: Tuple&lt;**bool**, **string**, **string**&gt; Run(SqlConnection **con**, int **ticketId**, int **personId**)
- Parameters:
    - **con** - SqlConnection to the database.
    - **ticketId** - The request ID (tHdTicket.iHdTicketId) over which the command is run.
    - **personId** - The user ID (tPerson.iPersonId) that is running the command.
- Return values:
    - **bool** - the truth value of whether the command was executed.
    - **string** - text that can be displayed in the message to the user.
    - **string** - URL to open in the browser.

      You can find an example use case in the [CostsCalculation](../../../../modules/alvao-am-custom-apps/applications/templates) application template.
