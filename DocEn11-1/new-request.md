# New request
   
You can use this form to create a new request for a specific service.  The specific content and appearance of the form depends on the situation in which you are using it, the service you are making the request to, and your system settings. If you are making a request as a requester (e.g. from a service catalogue), you will see a simplified form. If you are creating a request as a member of a service's resolution team, all the items in the request are available on the form.

Options:
    
- **Command Panel**
    - **Attachment** - attach an attachment to the request description. This command has the same function as the *Add attachment* button.
  in the form.
    - **Copy Values** - fills the form with the corresponding values from the linked request. This command is only displayed if the form was opened with the [New linked request](../requests) command.
 The *Requester*, *Service* and *SLA* fields
  are not copied.
    - **Use template** - select the [request template](../../../alvao-service-desk/requests/ticket-templates) you want to use to fill out the form. Items for which no values are defined in the template will remain unchanged.
    - **Requester's requests** - displays a table with the existing requests of the applicant already filled in on the form.
- **New request (select link type)** - select which link type the new request should be linked to the request that is listed under the input field. This command only appears if the form was opened with the [New linked request](../requests) command, see [Request links](../../../alvao-service-desk/requests/relations).
- **Requester** - enter at least part of the requester's name and then select the requester from the drop-down menu.  

> [!TIP]
> If you [connect Alvao to the switchboard](../../../alvao-service-desk/requests/new-request-call-centre), the incoming call will automatically open this form on the main solver's screen and the corresponding requester will be automatically searched and filled in based on the caller's phone number.

- **Non-registered user** -  enable this option if the Requester of the request is not a registered Alvao user (i.e. not registered in *Administration* - [Users](../administration/users)).
- **Contact information**- if the applicant is an unregistered user, please fill in their contact details.
    - *Name and Surname*
    - *Mobile phone*
    - *E-mail, E-mail 2*
    - *Work phone*
    - *Organisation* - type part of the organisation name and select the organisation you are looking for in the drop down menu.
    - *Department*, *Position*, *Office*
    - *Other Contacts*
- **Service**- type the part of the service name you want to insert the new request into, then select the service you are looking for in the drop-down menu.
    - **...** - or select the service in the service tree.
- **Requested for another user** - enable this option if you want to create a request for another user, e.g. you are requesting equipment for your subordinate or colleague. Enter at least part of the name of the user for whom you are creating the request, and then select it from the drop-down menu. Only users who have an SLA to the service and are from the same organization as the Requester are offered.
- **Request Name** - enter a concise name for the request.
- **Description** - enter a detailed description of the request.
- **Attachments**- list the attachments to the request
    - **Add attachment** - select the file you want to attach as an attachment. You can also attach files by dragging and dropping them into the form.
- **Objects** - select the object to which the request relates from the drop-down menu. By default, the menu contains the assets entrusted to the requester. If you want to select a different object, enter part of its name or serial, inventory or registration number in the input line. You can also specify the type of object, e.g. by typing "monitor: dell" you can search for all objects of type *Monitor* whose name starts with the string *dell*.
    - **...** - search for the object and select it in the object tree.
- **SLA** - select [SLA](../../../alvao-service-desk/implementation/services/sla) from the drop-down menu. If the menu is empty, the requester has no SLA in the selected service and cannot submit requests for that service.
- **Impact** - select the impact of the request from the menu, e.g. [ITIL incident](../../../itil/incident-management).
- **Urgency** - select the urgency of the request from the menu, e.g. [ITIL incident](../../../itil/incident-management).
- **Priority** - if applicable, select an appropriate priority from the menu.  

  Priority can be determined automatically based on the selected *Impact*.
  and *Urgency*.
- **Related organisations** - if applicable, type the part of the name of the organisation to which the request is related and then select the organisation you are looking for from the drop-down menu.
- **Device Number** - if applicable, enter the number of the device to which the request relates.
- **Request Submission Method** - select from the drop-down which communication channel the request was submitted through. This field only appears if you are making a request on behalf of another requester.
- **Assign to me** - enable if you want to be the solver of the request.
- **Assign**- turn on if you want to assign the request to a specific solver, or solver group.
    - **Solver Group** - type part of the name of the solver group and then select the appropriate group from the drop-down menu. The field is only displayed if at least one group has the "Solution Group" option set on the service.
    - **Request queue without solver** - select this option if you want to return the request to the [main solvers](../../../alvao-service-desk/implementation/services/service-roles) of the service (if the request is assigned to the *Main* solver group) or to all solvers of another solver group (if the request is assigned to a solver group other than *Main*).
    - **Assign to solver** - select this option if you want to assign the request to a specific solver. Then type part of the solver's name and select the appropriate solver from the drop-down menu.
    - **Change the request status to** - select the status to which the request should change when assigned to the solver from the drop-down menu.
    - **Message for solver**
  - Alternatively, write a message to the solver that will be sent to them in the email notification when the request has been assigned for resolution. If you have changed the status of the request, the message is pre-populated with instructions for the solver according to the *Solve Progress*.
- **Cost Report** - if applicable, [report the work time](../../../alvao-service-desk/requests/work-time) spent creating the request.
