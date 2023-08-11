# Sum of values
     
In this Window you can view the result of the function [Sum](../../../alvao-asset-management/objects-and-properties/functions) and allows you to update property values.
     
Options:
     
- **Yes** - update the property values of objects in the selected subtree according to the property values in their subobjects.
- **No** - not updating property values.

### Example of property update.
     
We have selected **Use Function** on the server room and aggregated via the **Price** property.

- Server room
    - Server 1
        - Raid box - Price = 19 000 CZK
        - Raid array - Price = 17 000 CZK
        - Raid array - Price = 21 000 CZK
        - Monitor - Price = 5 000 CZK
        - Tape drive - Price = 10 000 CZK
    - Server 2
        - Raid box - Price = 20 000 CZK
        - Raid array - Price = 20 000 Kč
        - Raid box - Price = 20 000 CZK
        - Raid box - Price = 20 000 CZK
        - Monitor - Price = 3 000 CZK
        - Tape drive - Price = 12 000 CZK
    - Server 3 - Price = 18 000 Kč
        - Raid array - Price = 22 000 Kč
        - Monitor - Price = 2 000 Kč

Each server and server room has a price property. Only server 3 has this property filled in, but its value is not current.  
         The sum function performed a sum of all objects with the price property and printed that the sum of the assets in the server room is 191 thousand crowns. If we update the values, it assigns values to the price property as follows:  
         Server 1 - 72 000 CZK  
         Server 2 - 95 000 CZK  
         Server 3 - 24 000 CZK  
         Server room - 191 000 CZK
