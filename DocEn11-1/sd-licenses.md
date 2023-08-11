# ALVAO Service Desk license
     
## License types
     
Each ALVAO Service Desk user draws a per-user or per-solver license, or draws no license. The total draw of these licenses is displayed in the  **Administration** - [License](../../../list-of-windows/alvao-webapp/administration/licenses)and is calculated in accordance with the [license agreement](../../license).
      
A user draws a **user license** if all of the following conditions are met:
     
- The user does not draw a solver license.
- The user is a member of a resolution team or a requester of a service in which the Host user **does not** have an SLA (i.e., the service does not serve anonymous requesters).

The user draws a **solver licence** if at least one of the following conditions is met:

- The user is a member of a research team (i.e., solver, manager, or special solver) of a service in which the user is a Guest **has** an SLA (i.e. an anonymous requester can create a request in the service).
- The user is a member of a service team for which the [Require solver license](../../../list-of-windows/alvao-webapp/administration/service-desk/service/create-service) option is enabled.

## License exceeding
     
If the license is exceeded, a warning will automatically appear in *Administration - Settings -*[Settings check](../../../list-of-windows/alvao-webapp/administration/settings/settings-check). In that case, increase the license by entering [a new activation key](../../../list-of-windows/alvao-webapp/administration/licenses/activation), or adjust the permission settings in the services (see below).  Then, on the [Settings check](../../../list-of-windows/alvao-webapp/administration/settings/settings-check) page, verify that the license is already in order. The page displays the last detected license usage information, which is normally automatically updated 1x/day. However, when the license is overdrawn, it is updated every time the *Settings Check* page is viewed.  Updates can take up to 15 minutes.
       
## Ensuring that only licenses per user are drawn
     
If you have only per-user licenses and the application reports an overrun of solvers, you need to change the service settings to require only per-user licenses. Follow these steps:

- In **Administration - Service Desk -**[Services](../../../list-of-windows/alvao-webapp/administration/service-desk/service), toggle the view with **Show as table**. Then view the **License Draws** column.
- Filter for services that have a **Solver** value in this column.
- For all of these services, ensure that the Host user (who is part of the "Everyone" group) does not have an SLA on this service. Instead of the "Everyone" group, we recommend using other groups, such as the "Registered Users" group, which contains all users except the Host user.

> [!NOTE]
> If the Host user must have an SLA in the service, the service will need a solver license.

## Ensuring that only investigator licenses are drawn
     
If you only have a solver license and the application reports an overage of users, you need to change the service settings to require only solver licenses. Follow these steps:

- In **Administration - Service Desk -**[Services](../../../list-of-windows/alvao-webapp/administration/service-desk/service), toggle the view with **Show as table**. Then view the **License Draws** column.
- Filter out the services that have a value of **per user** in this column.
- Select these services and use the **Edit** command to enable the [Require license per solver](../../../list-of-windows/alvao-webapp/administration/service-desk/service/create-service) option on them.

## Checking user license usage for a combined license
     
If you are using a combined user and solver license and need to find out which users are using which license, do the following:

- In **Administration -**[Users](../../../list-of-windows/alvao-webapp/administration/users) in the users table, display the **License Drawing** column, which shows the type of license the user is drawing.
- If a user is drawing a license that they shouldn't be (e.g., the user is drawing a solver license but should have a user license), select the user and use the **Edit -**[Rights](../../../list-of-windows/alvao-webapp/administration/users/detail/user-rights) command.
- In the permissions, view the **License Draws**column.
 If a service draws a solver license, the user must be assigned a solver license.
    - To ensure that the service draws a per-requester license, on the service, remove the user's Host SLA and disable the [Require a per-requester license](../../../list-of-windows/alvao-webapp/administration/service-desk/service/create-service) option.
    - To ensure that the service draws a solver license, enable the *Require solver license* option.

## Checking the use of licences by services
     
If the number of licenses being used has unexpectedly increased and you need to find out how many licenses and what kind of licenses each service requires, then:

- In **Administration - Service Desk -**[Services](../../../list-of-windows/alvao-webapp/administration/service-desk/service). Toggle the view with **Show as table**.
- Next, view the **License Draws** and **License Draws (Number)** columns.
- Check the license counts and see if any services are drawing an unexpected number of licenses or the wrong license type.
