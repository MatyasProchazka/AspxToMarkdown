# IEntityTab
     
By implementing this interface, you can define custom tabs on the object or request page. A custom tab can view any web content displayable in an iframe tag.      For an example, see the [ShowRequesterAddress](../../../modules/alvao-am-custom-apps/applications/templates) application template.
     
In the [application](../applications) create a new script using the *IElementTab* template and name it appropriately according to the content of the tab. In the newly created script, set the following properties in the constructor of the class:
     
- Id - a unique tab identifier (string)
- Entity - the type of entity for which the tab will be displayed (Entity.Request or Entity.Object).

## Interface methods

| Method | Description |
| --- | --- |
| Show | Displays the custom tab. |

## Show
     
This method handles the display of the entity custom tab.

- Syntax: **EntityTabShowResult** Show(int **entityId**, int **personId**)
- Parameters:
    - **entityId** - the entity ID (tblNode.intNodeId or tHdTicket.iHdTicketId) for which the custom tab should be displayed.
    - **personId** - the ID of the user (tPerson.iPersonId) to whom the custom tab should be displayed.
- Return value: an instance of the class *EntityTabShowResult*with properties:
    - **Show** (bool) - true = the tab will be displayed; false = the tab will not be displayed.
    - **Name** (string) - a display name of the tab
    - **Url** (string) - an URL of a content of the tab.

> [!TIP]
> If the custom tab is to display a different page from the ALVAO WebApp, use the Alvao.API.Common.DbProperty.WebAppUrl property from the [Alvao.API](../../../alvao-asset-management/implementation/customization/alvao-api) interface to get the root URL.
