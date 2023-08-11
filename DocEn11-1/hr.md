# Employee Management
      
The basic processes in Employee Management are:
      
- New employee joining
    - The aim of the process is to ensure that all working resources (e.g. desk, computer, access cards, ...) are prepared in time.
  for the new employee so that the new employee can work fully from day one. In addition, during the first few weeks after the new employee's arrival (i.e. during the adaptation period), ensure that the new employee is trained and that all legal obligations (occupational safety courses, health checks, etc.) are met.
- Employee separation
    - The aim of the process is to create all the documents necessary to formally terminate the employment relationship with the employee, revoke all their access rights to information systems and physical spaces (keys, access cards) and take over all the entrusted working resources from the employee (computer, mobile phone, ...).
- Changing employee data
    - The aim of the process is to update all records containing the employee's personal data in a timely manner, e.g. when the employee's bank account is changed for sending salaries, etc.

These processes usually require coordinated collaboration of many teams, especially HR, IT, Facilities Management, etc. At Alvao, a request or set of requests arises for each team to complete specific steps in the process, such as preparing the physical workplace, preparing the computer, conducting periodic assessment interviews with the employee during their onboarding, etc. Each request has an expected resolution date and is automatically directed to a specific implementation team.
      
## Process Settings

1. Select your version of Alvao at [https://www.alvao.com/download](https://www.alvao.com/en/download) and download the **AlvaoEmployeeManagementServices{Enu/...}.xml** file for your [Alvao system language](../../../alvao-asset-management/implementation/supported-languages) to your computer.
2. In **WebApp - Administration -**[Services](../../../list-of-windows/alvao-webapp/administration/service-desk/service) in the service tree, select the folder where you want to place the *Human Resources Department* service.
  If you do not select any service in the tree, the new service will be created directly at the root level of the tree.
3. Use the [Import](../../../alvao-service-desk/implementation/services/service-transfer) command to import the file from step 1.

> [!NOTE]
> Only entities that do not already exist in the database are imported from the file. Before the import, a list of possible collisions is displayed on the page.   If you still want to import entities from the file, in the appropriate *WebApp* - [Administration](../../../list-of-windows/alvao-webapp/administration) sections, rename the existing entities first.

4. The **Personnel Department** service will appear in the service tree and other services that are used in the processes will appear in its subtree. You can move these services to any other part of the service tree or remove them if you do not want to use them.
5. If you are using the [ALVAO Advanced Workflows](../../../modules/alvao-sd-advanced-workflows) module, in the [processes](../../../list-of-windows/alvao-webapp/administration/service-desk/process) **HR - Employee Onboarding, HR - Employee Offboarding, and HR - Employee Data Change** in the **New** status, check and modify, if necessary, the [automatic request creation](../../../list-of-windows/alvao-webapp/administration/service-desk/process/detail/status-request/automatic-request-creation).
6. In the new services, assign the appropriate permissions and SLAs to the user groups.
7. Test the processes by creating test requests.

> [!TIP]
> For more advanced process automation, use the [ALVAO Service Desk Custom Apps](../../../modules/alvao-sd-custom-apps) module.
