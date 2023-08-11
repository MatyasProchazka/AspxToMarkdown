# New linked request
   
The form contains the same items as [New request](new-request).

> [!NOTE]
> When opening a form, for example using a custom command, you can select the type of link and service that will be pre-populated on the form by entering the following parameters in the url: 

- **relCompositeId** - this number represents the link type to be pre-populated on the form. The parameter value is obtained by adding the two parts. The upper 16 bits are used for the id of the link type from the [TicketRelationType](../../alvao-asset-management/implementation/customization/database#U_dbo.TicketRelationType) table, and the lower 16 bits contain the number 1 or 2, which determines which side of the request is in the link.    

    | Link Type | RelCompositedId |
    | --- | --- |
    | Related to | 65637 |
    | It is superior to | 131073 |
    | Precedes | 196609 |
    | Blocking | 262145 |
    | Is duplicated | 327681 |
    | It is subordinate to | 131074 |
    | Follows | 196610 |
    | Is blocked | 262146 |
    | Duplicates | 327682 |
- **sectionId** - the id of the service ([tHdSection](../../../alvao-asset-management/implementation/customization/database#U_dbo.tHdSection).iHdSectionId) to be pre-populated on the form.
