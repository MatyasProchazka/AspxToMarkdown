# Waiting for requester
      
For each request, the system can track the amount of time that the resolution team has waited for a response from the requester in resolving the request. The waiting time is reported through entries in the request log.
      
### Example:

| Time | Journal entry | Claimant waiting time | Comment |
| --- | --- | --- | --- |
| 9:25 | E-mail from requester to service desk - request submission | - | The Requester has assigned a request. |
| 9:30 | E-mail from service desk to applicant - request for additional information | **Closed** | The main solver found that the specification of the request was incomplete and therefore sent a message to the requester requesting completion of the information. The solution team cannot address the request until the requester responds. Therefore, the time until the response is received should be reported as "waiting for the requester". Therefore, the lead solver, when sending a message in the [Message](../../list-of-windows/alvao-webapp/requests/request/message) form
 enabled the *Wait for reply*
                option. |
| 9:40 | Telephone call from requester | **Closed** | The applicant telephones the main solver and together they clarify the missing information. Since the applicant does not know all the information needed, the applicant and the main solver agree to find out the missing information and email it to the applicant. The principal investigator enters a record of the phone call into the request log and turns on the *Waiting for Requester*
                option,
 because it is still waiting for a response. |
| 9:50 | Note | - | The main solver realizes that learned important information during the phone call that did not write down. He enters a note in the request log and leaves the *Waiting for Requester* option inactive. This does not change the waiting status from the previous log entry. |
| 10:30 | E-mail from requester | **Off** | The applicant sends an email with the necessary information. The message is automatically loaded into the log with the *Wait for reply* option turned off. |

The time between 9:30 and 10:30 a.m. will be counted toward the "wait time for the applicant" and will be listed in the **column** in the requests table.   Waiting time for applicant (hours) the value 1 will appear.
      
In the [requests table](../../list-of-windows/alvao-webapp/requests/table-of-requests), you can track the wait time for requesters in the following columns:
     
- Requester wait time (hours)
- Claimant Wait Time (hours)
- Open time (hours)

In the request log, the following columns are related to waiting for a requester:

| Column | Comment |
| --- | --- |
| Claimant waiting time (hours) | For records that end the wait (i.e., the **Waiting for applicant** is set to off), this column indicates the amount of time in hours that this record has been waiting. For other records the column is empty. |
| Claimant Wait | | Value | Meaning |<br>| --- | --- |<br>| Yes | Start of wait |<br>| No | End of wait |<br>| - | The record does not affect the status of the wait (e.g. work notes of the research team). |<br><br>
                    The value in this column corresponds to the value of the **switch Waiting for requester** in the window for editing journal entries with the **Edit** command. |
| --- | --- |

> [!NOTE]
> The wait time and the open time of a request are calculated in the [operating hours](../implementation/services/operating-hours) that corresponds to the request, i.e. the operating hours that are set for the [SLA](../implementation/services/sla) within which the request is resolved. 

> [!NOTE]
> The time the requester waited may not be counted towards the time it took to resolve the request. The request resolution deadline defined by the corresponding [SLA](../implementation/services/sla) is delayed by the waiting time. This can be configured on the Administration - Service Desk -  settings page of a specific **SLA** - Edit - [Properties](../../list-of-windows/alvao-webapp/administration/service-desk/sla/create-sla) - option **Suspend SLA while waiting for Requester**.
