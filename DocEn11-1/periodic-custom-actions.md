# IPeriodicAction
     By implementing the IPeriodicAction interface in a [application script](../../../list-of-windows/alvao-webapp/administration/applications/app/scripts), you can define custom periodic actions.       
     Custom actions can be run at a regular time interval.       
     The system runs periodic custom actions every hour.       
       
      In the [application](../applications), create a new script using the *IPeriodicAction* template and name it appropriately according to the functionality that the action performs.       
     In the newly created script, set the value of the Name property (the name of the action itself) in the class constructor.      

> [!CAUTION]
> Poor definition of a custom action can irreversibly damage the Alvao database, so always create and test actions in a test environment, e.g. on a copy of the production database.

> [!TIP]
> A prerequisite for creating a working automated action is a good knowledge of [Alvao database](../../../alvao-asset-management/implementation/customization/database) and [Alvao.API](../../../alvao-asset-management/implementation/customization/alvao-api).

## Interface Methods

| Method | Description |
| --- | --- |
| OnPeriod | Periodic custom action. |

## OnPeriod
     In the method, define both the conditions for performing the operations and the operations themselves.     
- Syntax: **void** OnPeriod(SqlConnection **con**)
- Parameters:
    - **con** - SqlConnection to the database.
- Return value: **none**.

      For an example use case, see the [AutoCloseInactiveTickets](../../../modules/alvao-am-custom-apps/applications/templates) application template.
