# Impact and urgency
       
If they are in or on the [process](processes) of the [new ticket form](../../../list-of-windows/alvao-webapp/administration/service-desk/service/detail/new-ticket-items), the *Date* or *Emergency* items are enabled, the *Priority* of the request is automatically set according to the values of these items, see the priority table:

| Fall | High | Medium | Low |
| --- | --- | --- | --- |
| Emergency |
| --- |
| High | critical | high | medium |
| Medium | high | medium | low |
| Low | medium | low | planning |

The priority can still be [changed](../../../list-of-windows/alvao-webapp/requests/request/edit) manually to any value.

> [!NOTE]
> Priority item values:

| Icon | Czech | English |
| --- | --- | --- |
|  | critical | critical |
|  | high | high |
|  | medium | medium |
|  | low | low |
|  | scheduling | planning |

In addition, if SLAs with a quality index of 1 to 5 are available in the service, changing Impact and Urgency will also change the SLA to an SLA with a quality index according to the following table:

| Fall | High | Medium | Low |
| --- | --- | --- | --- |
| Emergency |
| --- |
| High | 5 | 4 | 3 |
| Medium | 4 | 3 | 2 |
| Low | 3 | 2 | 1 |

Even if the SLA is set by the Impact and Urgency values, it can be changed to a different value.

> [!NOTE]
> If there is no SLA with a calculated quality index for the selected applicant, the next higher one will be selected. If neither exists, the SLA with the highest quality index for the applicant will be selected.  

        If there are multiple SLAs with the same quality index, it is not defined which one will be selected.
