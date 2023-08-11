# Checking
     
This section of the [New Request Status](../status-request) form is used to set the behavior of the request status within the process.
     
Options:
     
- **Approval status** - select this option if you want the status you are editing to be approved. Enabling this option will display the *Approval*tab on the request page.
    - **Approval Run**- select how the approval will be run and how it will proceed.
        - **Manually** - the approval can be triggered manually by a member of the service's solution team with the *Let approve* command.
        - **Automatically**- approval is triggered automatically when the request transitions to the edited status. 
            - **Approve by schema** - select the appropriate [approval scheme](../../../../../../../alvao-service-desk/implementation/services/processes/request-approval) from the menu.
            - **Approve by person**- select a specific person to be the approver.
                - **Expires in (hours)** - specify how many hours from the time the approval is started, this approval will end with the result *Expired* if the approver has neither approved nor rejected the request by that time. A value of 0 represents an unlimited time limit.
    - **Message template for approvers**
        - **Edit** - opens the [window](approval-message-template) to edit the message template for the approver.
- **From this status are allowed transitions**
    - **To all statuses** - select this option if the request in the edited status can transition to any other status.
    - **Only to permitted statuses**- select this option if you want to limit the set of statuses that a request in the edited status can go to.
        - **Permitted statuses**- list the statuses that the request can go to.
            - **Edit** - open the *Permitted statuses* window to enable the option for the statuses you want to allow the transition to.
    - **Automatically to statuses according to approval result**- if you select this option for the approval status, the request will automatically go to one of the defined end statuses after the approval is complete (by the schema or by the selected person). In this mode, the solver cannot add additional approvers to an approval in progress.
        - **End statuses** - for individual approval results (*Approved*, *Rejected*, *Cancelled*, *Expired*)
 select from the menu the status to which the request should automatically transition if the approval in the edited status ends with the given result.

> [!TIP]
> You can also select the edited status as the ending approval status. In this case, the request status will not change after the approval is complete. 

> [!TIP]
> Select the *Closed* status as the ending approval status only for approvals running between the separate *Solved* and *Closed* statuses.

> [!NOTE]
> If you select *Resolved* as the ending approval status, the request will be resolved when the approval is complete, including sending a notification to the requester and possibly automatically transitioning to the *Closed* status.

- **Switch to this status automatically following the first assignment to solver** - a request in the *New* status will automatically transition to this status when passed to the solver.
- **Assign request to a solver group during transition to this status** - select the resolution group to which the request should be automatically forwarded.  This setting is part of the [ALVAO Advanced Workflows](../../../../../../../modules/alvao-sd-advanced-workflows) module.
- **Send notification to requester when moving to this status** - when moving to this status, a notification of the status change is automatically sent to the requester via email. You can edit the notification text via the **edit notification template** link.

> [!NOTE]
> For the system statuses *New*, *Solved*, *Closed* and *Reopened*, this option is inactive.

- **Delay for reverse resolution (hours in business hours)** - specify the maximum delay in hours with which a request can be retroactively written to be resolved, see *Request -*[Resolve](../../../../../requests/request/resolve) - *Resolve retroactively to*.
  A value of 0 means that resolve backwards cannot be written to requests.
 The time limit is calculated in the operating hours according to the SLA. This field is only available for the *Resolved* status.
- **Change automatically to Closed status** - When the request is resolved, the request will go directly to the *Closed* status. This option is only available for the *Resolved* status. It is recommended to disable this option only if there are still some steps to be taken after the request is resolved, such as internal evaluation in the solution team, release of temporarily used resources, etc.
- **Show the “Transfer To Another Service” command** command *Move to another service* - the request solver in this status will see the *Move to another service* command in the command bar at the first position. If the request does not have a solver, the command is displayed in the first position to the main solvers of the service. At the same time, the *Receive for Resolution* and *Forward* commands will move from the command bar to the "..." drop-down menu.
- **Show the Assign command** - the solver of the request in this status will see the *Forward* command first in the command bar. If the request does not have a solver, the command is displayed in the first position to the main solvers of the service.
- **Pause SLA** - The time the request spends in this status will not count towards the time to first response or the time to resolution. The first response and resolution dates set by SLA will automatically be delayed by the time spent in this status.
- Tip:
                Since the application displays the name of the status as the cause of the pause in requests with a paused SLA, name the paused SLA statuses so that the name describes the cause of the pause, e.g., Approving, Waiting for Solution Acceptance, etc. Do not use generic names such as New.

- **Automatic request creation** - a list of rules that automatically create new linked (e.g., child) requests when a request transitions to this status. This setting is part of the [ALVAO Advanced Workflows](../../../../../../../modules/alvao-sd-advanced-workflows)module.
    - [Edit](automatic-request-creation) - edit template list
