# New custom field
     
Use this form to create a new [custom field](../../../../alvao-service-desk/implementation/custom-items).
      
Options:
      
- **Custom field name** - enter the name of the custom field under which the field will be displayed in the application to users. The custom field name must not match any other field of the entity (custom or system) or any other column of the [reporting views](../../../../alvao-asset-management/implementation/customization/database#report_view_list).
- **Order** - specify the order in which the field should appear in the forms. Fields are displayed in ascending order based on the *Order* value. If two fields have the same *Order* value, their relative order will be random.
- **Type** - select the type of custom field from the menu.

    | Type | Meaning | Forms display |
    | --- | --- | --- |
    | bit | logical value yes/no | checkbox option |
    | date | date | date text field with calendar selection |
    | datetime | date and time | date and time text fields with calendar selection |
    | float | decimal number | text field |
    | int | integer | text field |
    | nvarchar | string | text field |
    | user | a user of Alvao; In the database, this type is represented as type int containing the ID of a user (see [tPerson](../../../../alvao-asset-management/implementation/customization/database#U_dbo.tPerson).iPersonId). | text field with user selection |

    The following fields are only displayed for type *nvarchar*:

    - **Multi-line text** - turn on if you want forms to display a larger input field for entering multi-line text. If disabled, only single line input fields are displayed.

> [!NOTE]
> This option cannot be combined with a list of values.

    - **Length** - specify the maximum length of text in characters that can be written to the entry.
    - **Maximum Length** - turn on if you want to store long text in the field.

    This field is displayed only for type *user*.

    - **Source group** - select the user group. Values of the field of type *user* will be limited to members of the group.
- **Description** - enter a description of the field that will be displayed in forms to help users fill in the field.
- **Table** - select the entity for which you want to create a custom field:

    | Value in the menu (name of the table in the database) | Entity |
    | --- | --- |
    | tHdTicketCust | Request |
    | tPersonCust | Person |
    | tAccoutCust | Organization |
    | tHdSectionCust | Service |
    | tSlaCust | SLA |
    | LicHistCust | Licence |
    | ProductCust | Products |
    | TicketStateCust | Ticket Status |
- **Column**- enter the name of the column in the database where the value of this custom field will be stored. The name must be unique and must not contain spaces or special characters. It is recommended to name columns in English and to follow the recommendations for [naming identifiers in the database](https://docs.microsoft.com/en-us/sql/relational-databases/databases/database-identifiers).
- **Use value list** - the custom field will appear as a text box with a drop-down menu on forms. After enabling this option, populate the list of values with *Edit* - [List of values](detail/list-of-values).  

            The list can only be used for *nvarchar* and *int* types. A value that is not listed in the list of values can also be written to a custom field of type *nvarchar*. The values of custom fields of type *int* are limited only to the values listed in the list of values, no other value can be written to them, and when modifying a value in the list of values, the value of the custom field is automatically changed.
- **Enable translation of value list** - enable this option if you want the values from the value list to be exported for [translation into other languages](../../../../alvao-service-desk/implementation/multi-languages) and then displayed to users in their preferred language.
