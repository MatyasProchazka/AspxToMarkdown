# New SLA
 
Use this form to create a new [SLA](../../../../../alvao-service-desk/implementation/services/sla).
   
Options:

- **SLA name** - enter the name of the SLA, e.g. *. Gold*,
 *Silver* etc.
- **Description** - enter a verbal description of the SLA. This description is displayed to applicants.
- **Parameters**
    - **Operating hours** - select [operating hours](../../../../../alvao-service-desk/implementation/services/operating-hours).
    - **Time until first response** - enable if you want to set the time for the resolution team to respond to a newly submitted request.  
 A response is considered to be a reply to the requester via email (except for an automatic notification of the creation of a request) or a recording of any event (such as a phone call) that has the requester listed in the *To whom* field. If the request is established on behalf of the requester by the main solver based on a phone call or in-person meeting with the requester (see [New Request](../../../requests/new-request) - *Method of Request* item), the first response is satisfied by the mere establishment of the request.  

        - **hours from request submission (within operating hours)** - enter the number of hours.
    - **Time to resolve request** -  enable if you want to set the maximum time from request submission to resolution. The *Deadline*item is then automatically set in the request as soon as it is submitted, according to the value specified in the SLA.
        - **hours from request submission (within operating hours)** - enter the number of hours.
    - **Pause SLA while waiting for requester**
 - Enable if you do not want to count the time of any [waiting for a requester](../../../../../alvao-service-desk/requests/wait-for-response) until the request is resolved. The request resolution date specified by the SLA will automatically be pushed back while waiting for the requester. 

> [!TIP]
> We recommend checking requests with a suspended SLA periodically (e.g. 1x/day or week) and requesting the requester's cooperation after a certain period of waiting. In the window [Requests](../../../requests/table-of-requests) you can create a *Pending Requester* view with a filter of *Pending Requester* &gt; 0. 

> [!NOTE]
> The *waiting for requester* time is only added to the deadline if the resolution date is set according to the SLA. If the deadline is set manually, the *Waiting for Claimant* time is not added to the deadline.

> [!NOTE]
> In the window [Requests](../../../requests/table-of-requests), when sorted by the *Icons* column by default, requests with a currently suspended SLA are automatically pushed to the bottom of the table.

> [!CAUTION]
> The parameter change is also applied retroactively to any requests already created with the given SLA. If you want to apply the change only to newly created requests, first create a new SLA according to the new conditions, assign it to the Requesters in the selected services, and remove the old SLA from the Requesters. It is advisable to add an expiry date to the name of the removed SLAs, e.g. "Z2 - medium (valid until 14.4.2014)".

- **Other**
    - **Contract (number)** - enter the designation of the physical contract.
    - **Quality index** - enter if you want to rank SLAs by quality. Quality is determined by a number: the higher the number, the higher the quality.
    - **Notes** - enter additional internal notes if necessary.
    - Other custom filed may be placed here.
