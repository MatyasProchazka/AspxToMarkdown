# Automatic actions based on request events
      
Automatic actions can be triggered in the following cases:
     
- Changing the value of a request item (custom/system)
- Creating a new request
- Creating a new event
- Edit event
- Delete event
- Read a new message from the service mailbox

> [!CAUTION]
> A poorly defined automated action can irreversibly damage the Alvao database, so always create and test on a copy of the database in the test environment.

> [!TIP]
> A prerequisite for creating a working automated action is a good knowledge of the [Alvao database](../../../alvao-asset-management/implementation/customization/database) and [Alvao.API](../../../alvao-asset-management/implementation/customization/alvao-api).
