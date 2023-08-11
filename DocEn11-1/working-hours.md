# Intervals for operating hours

This window is used to manage the intervals of the edited [operating hours](../../../../../../alvao-service-desk/implementation/services/operating-hours). Each interval specifies the days of the week and the time of day when the service is operational. Operating hours typically consist of multiple such intervals, e.g., one for Monday-Friday 8:00-12:00 and another for Monday-Friday 13:00-17:00, etc.
 <p
Options:

- **Command Panel**
    - **New interval** - create [new interval](working-hour) of operating hours.
    - **Edit** - [edit](working-hour) the selected operating hours interval.
    - **Delete** - remove the selected operating hours interval.
- **Interval table** - contains the intervals of the edited operating time. You can [customize](../../../../../../alvao-asset-management/working-with-tables) the table as needed.

> [!TIP]
> 

> [!TIP]
> 

Tip:
A single runtime rule should have a runtime of no less than 1 hour. For shorter time rules, the value of the *Current Target (Remaining)* column in the [requests table](../../../../requests/table-of-requests) may not be calculated correctly.
