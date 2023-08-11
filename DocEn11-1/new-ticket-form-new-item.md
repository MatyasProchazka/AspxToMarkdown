# New item
     
This window is used to create a new custom request item and add it to the [New Request Form](new-ticket-items).
      
Options:
     
- **Item name** - enter the name of the item to be displayed on the form.
- **Item type**- select the data type of the item.
    - **Date** - only the date can be entered in the entry.
    - **Date and Time** - only the date and time can be entered in the entry.
    - **Number** - only a numeric value can be entered into the entry. The number can be decimal or only integer, see the *Decimal Number* option.
    - **Option** - user can select item values from the drop-down menu.
    - **Text** - any text can be entered into the item. See also the *Multi-line text* option.
    - **User** - a user of Alvao can be selected in the item.
- **Source group** - select the user group. Values of the field of type *user* will be limited to members of the group. This field is displayed only for the *Item type*"User".
- **Description** - enter a description of the item, instructions for the applicant to fill in the values, etc. The text entered will be displayed to users on the form.
- **Values**- a menu of values for an Option type item.
    - **Yes/No** - the item will be displayed on the form as a simple option (checkbox).
    - **Value list**- list of values in the drop-down menu. You can move the values in the list by grabbing the icon on the left ("up arrow and down arrow") with your mouse.
        - **New Value** - add a new value to the end of the list.
        - **Allow custom text entry** - enable this option if you want to allow the user to enter any text into the item in addition to the values in the list.
        - **Enable translation of value list** - enable this option if you want to export the values from the list of values for [translation into other languages](../../../../../../alvao-service-desk/implementation/multi-languages) and then display them to users in their preferred language.
- **Multi-line text** - turn on if you want a larger input field for *Text* type items in forms to display multi-line text. If disabled, only a single line input field is displayed and the text length is limited to 256 characters.
- **Decimal number** - turn on if you want to enter decimal numbers in the entry as well. Otherwise, only integers can be entered.
