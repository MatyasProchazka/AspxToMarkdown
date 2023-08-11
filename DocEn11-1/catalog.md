# Service Catalogue
 
This section on the [New Service](create-service) form is used to set the appearance of the service catalog tile in the WebApp, keywords, order in the tree, and the default request template.
 
Options:

- **View in the Service Catalogue** - disabling this option will make the service invisible in the service catalog. The option only affects the display in the service catalog in the WebApp. The visibility of the service in other parts of the system is not affected by this option.  

> [!TIP]
> It is recommended to disable the *Show in service catalog* option for technical services or for services where it is undesirable for requesters to make requests directly to them, but at the same time it is necessary to ensure that requesters have an SLA assigned to these services (e.g. for [creating a new request on a failed reopen attempt](extended)).

> [!NOTE]
> The *Show in service catalog* option setting is overwritten in all child services. A disabled option has a higher weight (the service is not displayed), so the *Show in service catalog* option cannot be enabled on a service if this option is disabled on the parent service.

- **Tiles**
    - [Change icon](icons) - select a service icon from the icon library.

> [!TIP]
> To bulk change the icon of multiple services that use the same icon, display the *Icon* column in the service table that contains the icon name. Filter all services with the current icon by the icon name, select them, and change the icon with *Edit*.

    - **Tile Color** - select a tile color, see [recommended colors](../../../../../alvao-service-desk/implementation/services/tile-color). The chosen tile color should be contrasting to the service image and should reflect the type of service (e.g., red for incidents).
    - **Tile Type**- select how the service is displayed in the WebApp service catalog.
        - **Square** - the service icon is displayed on a colored square background. This mode is recommended for *white icons*.
 in the so-called "modern look" of Windows.
        - **Ribbon under icon** - the service icon is displayed on a white background and below the icon is a colored horizontal bar with the service name.  This mode is suitable for colored icons on a transparent or white background.
- **Tree order** - if you want to sort the services in the catalog alphabetically by their name, leave this field blank. Otherwise, enter the serial number of the service. The services are then displayed in ascending order according to the *Tree Order* value, services with no order are at the top. Services with the same value in the *Tree Order* field are sorted alphabetically by service name.
- **Keywords** - Enter keywords by which users can search for the service. Separate individual keywords or phrases with commas. Services are always searched for by their name, including the full path in the tree, so words contained in the name do not need to be re-entered as keywords. 

> [!TIP]
> Among the keywords, include the words by which your users actually search for the service. You can find search statistics in the [data-analysis](../../../../../alvao-service-desk/evaluation-of-system-operation/data-analysis) on the *Search* sheet.

- **Default request template** - select a default request template to populate the default field values of the [new request form](../../../requests/new-request).
