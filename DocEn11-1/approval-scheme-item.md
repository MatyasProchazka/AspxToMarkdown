# Approval step
 
This window is used to create and edit the step of the [approval scheme](../../../../../../alvao-service-desk/implementation/services/processes/request-approval) being edited.
 
Options:
 
- **Approver**- select an approver for this approval step.
    - **Requester** - the approver will be the current requester of the request.

> [!NOTE]
> If the Requester of the request is a non-registered user (Guest), the approval step will be automatically approved. This also applies to the *The requester's direct manager* and *The requester's top manager* approvers.

> [!NOTE]
> If the Requester of a request changes during the approval process, the new Requester will be able to approve the request but will not receive an additional email notification of the start of the approval.  This also applies to the *The requester's direct manager* and the *The requester's top manager* approvers.

    - **The requester's direct manager** - the approver will be the direct supervisor of the user for whom the request was created, see [Requested for](../../../../../../list-of-windows/alvao-webapp/requests/table-of-requests). A request is usually created for the Requester of the request. If the supervisor is also the requester of the request, the step is automatically approved.
    - **The requester's top manager** -
  The approver will be the highest supervisor of the user for whom the request was created, i.e., the user who is above the user selected in the *Required for*field in the organizational hierarchy and has no supervisor. The request is usually created for the Requester of the request. If the highest supervisor is also the Requester of the request, the step is automatically approved.
    - **Group** - The approvers will be all members of the specified [user group](../../../../../../alvao-asset-management/implementation/users/groups). It is sufficient for any one of them to approve or reject a step.
        - **Only the requester or manager** - turn on if you want to select only the supervisor of the user for whom the request was created, or that user directly, as the approver among the members of the specified group. For example, if you select the *Division Directors* group and enable this option, only the director of the division to which the user for whom the request was created will approve the request. If the group contains multiple directors, the closest one (i.e., the one lowest in the organizational hierarchy) will be selected as the approver.
    - **Custom** - approvers are defined by the custom Alvao customer extension.
    - **Automatically approved by the requester** -
 If the option is enabled and the approver of the step is the current requester of the request, the step will be automatically approved. The option is only available for *Group* and *Custom* types.
- **Expires in (hours)** - if applicable, enter the time in hours (regardless of service hours, weekends and holidays) that approvers have to approve or deny the request. If the approver does not make a decision within that time, the approval will automatically terminate (expire) and no further steps in the approval scheme will be performed.
- **Custom form (URL)** - if applicable, enter the path to[custom form to approve/reject](../../../../../../modules/alvao-sd-custom-apps/custom-form-template) the request if you want to use it in this step.

> [!NOTE]
> If there is a situation where there is no approver for an approval step, e.g. the applicant has no supervisor or the selected approver group has no members, the approval step is skipped. If this is the only step in the approval scheme, then the approval is not started and the next status needs to be manually advanced. In the case of the last step of the scheme, approval is terminated with the result of the previous step.
