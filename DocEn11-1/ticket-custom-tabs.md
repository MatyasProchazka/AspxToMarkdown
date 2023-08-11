# IView

> [!CAUTION]
> This interface is deprecated. Instead of this interface use the [IEntityTab](../../alvao-am-custom-apps/applications/i-entity-tab) interface.

By implementing the IView interface (custom tabs), you can use it to display custom content in the request detail.       
     This can be a custom page in the ALVAO WebApp or, for example, an external parameterized link.

> [!CAUTION]
> A poorly defined custom bookmark can irreversibly damage the Alvao database, so always create and test on a copy of the database in a test environment.

> [!CAUTION]
> Pages that have disabled iframe display cannot be displayed in bookmarks.

> [!TIP]
> A prerequisite for creating a functional bookmark is a good knowledge of [Alvao database](../../../alvao-asset-management/implementation/customization/database) and [Alvao.API](../../../alvao-asset-management/implementation/customization/alvao-api).

> [!TIP]
> If the custom tab is to display a different page from the ALVAO WebApp, use the Alvao.API.Common.DbProperty.WebAppUrl property from the [Alvao.API](../../../alvao-asset-management/implementation/customization/alvao-api) interface to get the root URL.

      In the [application](../applications) create a new script according to the *IView* template and name it appropriately according to the content that the tab displays.In the newly created script, set the values of the id and name properties in the constructor of the command class:
- id - bookmark number (unique)
- name - the name of the bookmark that will be displayed in applications

> [!TIP]
> To store the properties and settings of the tab, we recommend defining the *Settings* class in a separate script that you create from the *Class Library* template.

## Interface Methods

| Method | Description |
| --- | --- |
| Show | Display the custom request tab. |

## Show
This method handles the display of the request's own page.
- Syntax: **string** Show(SqlConnection **con**, SqlTransaction **trans**, int **ticketId**, int **personId**)
- Parameters:
    - **con** - SqlConnection to the database.
    - **trans** - SqlTransaction of the database transaction in progress.
    - **ticketId** - The request ID (tHdTicket.iHdTicketId) for which the custom page will be displayed.
    - **personId** - the user ID (tPerson.iPersonId) for which the custom tab is to be displayed.
- Return value:
    - **string** - a text string containing the URL to display on the custom bookmark. If the URL is empty, the bookmark is not displayed to the user.

      For an example use case, see the [ShowRequesterAddress](../../../modules/alvao-am-custom-apps/applications/templates) application template.
