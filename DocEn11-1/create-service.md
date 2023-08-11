# New service
 
This form is used to create a new [services](../../../../../alvao-service-desk/implementation/services).
 
Options:
   
- **General**
    - **Service Name** - enter the service name. 

> [!TIP]
> - **E-mail** - enter the service email from which notifications will be sent to applicants and members of the research team. The email can be entered as *email address* (e.g. *support@alvao.com*) or

  name-service &lt;email-address&gt; (e.g. *Technical Support &lt;support@alvao.com&gt;*)*.* Separate multi-word names with a space, do not use commas, semicolons or other punctuation marks.

> [!NOTE]
> - **Phone** - enter the phone number of the main service provider.

    - **Description** - enter brief information about the service. The service description is displayed to applicants in the service catalog.
    - **Process** - select the process from the menu that will be used to process requests in the service. 

> [!NOTE]
> [Process](../../../../../alvao-service-desk/implementation/services/processes) defines, among other things, the [process of the solution](../process/detail/workflow) and the visible [request items](../process/detail/request-items)[.](../process/detail/workflow)
    - **Request tag prefix** - specify the prefix of the request tag. The request tag has the format &lt;prefix&gt;request-number&lt;prefix&gt;, e.g. T123ALVAO. The request tag is automatically included in the subject line of notifications and other messages and is used to associate the message with the correct request.
    - **Request Tag Suffix** - Enter the request tag suffix, see *Request Tag Suffix*.
    - **Preferred Language** - the language of the service in which notifications are sent to service principals.
    - **Time zone** - the time zone in which all dates and times in notifications sent to the service principals will be reported.
    - **Folder (requests cannot be entered into the service)** -
 Enable if you want to disable the creation of requests in this service. A folder can have child services that can be used to insert requests.
    - **Require solver License** - enable if you want to ensure that the service requires a solver license regardless of the SLA assignment to the *Host* user. If the service requires a license per solver, the license must cover all members of the solver team. Applicants then do not require any license. For more information, see [License Service Desk](../../../../../alvao-service-desk/implementation/users/sd-licenses).
    - **Service Shortcut** - If you only want to create a shortcut that points to another service, enable this option and select the target service. *Permissions* and *SLAs* are applied to the shortcut according to the target service.
    - **...**
 - or select the service from the service tree.

> [!NOTE]
> 

> [!NOTE]
> - [Service Catalog](catalog) - Setting the appearance of the tile in the service catalog in the WebApp, setting keywords, order in the tree, and default request templates.

 - [Objects](objects) - select the objects on which the service will appear in the service menu to create a new request.
 - [Message loading](loading-messages) - setup loading messages from the mailbox.
 - [Extended](extended) - setting the processing flow of the request.
 - [Notification](notification) - setting to send automatic notifications about the occurrence and progress of requests for the service being edited.
 - [Other](other) - manage custom service items
