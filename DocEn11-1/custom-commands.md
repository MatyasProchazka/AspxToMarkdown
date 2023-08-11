# Custom commands
      
The custom command can be used to perform custom operations or operations with external systems. A custom command can be run for [just one selected request](custom-commands/ticket-custom-commands) or [without link to a request](custom-commands/general-custom-commands). To display it to the user and run it, it is possible to define conditions that control, for example, the role of the logged-in user, the status of the request, or the value of its items.
      
Using the command can perform a sequence of actions within the ALVAO Service Desk, or open a URL in the user's default browser.

> [!CAUTION]
> Poorly defining a custom command can irreversibly damage the Alvao database, so always create and test commands on a copy of the database in a test environment.

> [!TIP]
> A prerequisite for creating a functional custom command is a good knowledge of [Alvao database](../../../alvao-asset-management/implementation/customization/database) and [Alvao.API](../../../alvao-asset-management/implementation/customization/alvao-api).

Tip: To display a custom command in the user's preferred language, create one command for each language. Then, in the display condition, check if the user's preferred language matches the language of the command.
