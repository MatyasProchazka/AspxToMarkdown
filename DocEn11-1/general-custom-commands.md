# IGeneralCommand
     By implementing the IGeneralCommand interface in a [application script](../../../../list-of-windows/alvao-webapp/administration/applications/app/scripts), you can define custom main menu commands.       
       
      By placing a command in the main menu, you can give users access to frequently used pages and operations that are not tied to a specific request in ALVAO Service Desk.       
     Commands are displayed in the main menu of ALVAO WebAp applications.     

> [!TIP]
> To replace the system command in the ALVAO WebApp main menu with a custom one, [hide the system command](../../../../alvao-service-desk/implementation/customization/links).

      In the [application](../../applications), create a new script using the *IGeneralCommand* template and name it appropriately according to the functionality of the custom command.       
     In the newly created script, set the id, name, position, and icon property values in the constructor of the command class:     
- id - command number (unique)
- name - the name of the command that will be displayed in applications
- position - the position at which the command will be displayed in applications
    - 1 = in main menu under system commands
    - 2 = in the main menu above the *More* menu
    - 3 = in the main menu in the *More* menu above the *Administration* system command
    - 4 = in the user menu above the *Settings* system command
- icon - the name of the command icon
    - Use the icon name from the [Microsoft Fabric](https://developer.microsoft.com/en-us/fabric#/styles/web/icons) library as the command icon name (the icon name will appear on the page when you hover over the selected icon). If you do not specify an icon, the *LightningBolt* icon is used.

> [!TIP]
> To store the properties and settings of the command, we recommend defining the *Settings* class in a separate script that you create from the *Class Library* template.

## Interface Methods

| Method | Description |
| --- | --- |
| Show | Show command in the main menu of the application. |
| Run | Run command. |

## Show
     This method checks the defined conditions for displaying the command.     

> [!TIP]
> By calling this method in the *Run* method, you can check before running the command that the conditions for displaying it have not changed between the time the command was displayed and the time it was run.

- Syntax: **bool** Show(SqlConnection **con**, int **personId**)
- Parameters:
    - **con** - SqlConnection to the database.
    - **personId** - User ID (tPerson.iPersonId) to which the command should be displayed.
- Return values:
    - **bool** - the true value of whether the command should be displayed to the user in the main menu of the application.

      For an example use case, see the [ProblemReporting](../../../../modules/alvao-am-custom-apps/applications/templates) application template.      
## Run
     This method runs the command itself.     

> [!TIP]
> If the custom command is to open a different page from the ALVAO WebApp, use the Alvao.API.Common.DbProperty.WebAppUrl property from the [Alvao.API](../../../../alvao-asset-management/implementation/customization/alvao-api) interface to get the root URL.

- Syntax: Tuple&lt;**bool**, **string**, **string**&gt; Run(SqlConnection **con**, int **personId**)
- Parameters:
    - **con** - SqlConnection to the database.
    - **personId** - The user ID (tPerson.iPersonId) that runs the command.
- Return values:
    - **bool** - the truth value of whether the command was executed.
    - **string** - text that can be displayed in the message to the user.
    - **string** - URL to open in the browser.

      For an example use case, see the [ProblemReporting](../../../../modules/alvao-am-custom-apps/applications/templates) application template.
