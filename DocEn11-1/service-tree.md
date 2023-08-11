# Service tree
     
You can manage your service tree in the **ALVAO WebApp**         using the **Administration - Service Desk - Services** command, which displays in the main window [service tree](../../../list-of-windows/alvao-webapp/administration/service-desk/service/detail).
      
## Receiving requests by e-mail
      
If you want to automatically retrieve the contents of a specific mailbox to a specific Service Desk service, then you must set up a connection to that mailbox for the service. The connection is set up on the selected service under [Loading messages](../../../list-of-windows/alvao-webapp/administration/service-desk/service/loading-messages).
      
After receiving a new request, the system sends an automated response to the requester that reads something like this:
     
*Hello,                        We have received your request under the number &lt;request mark&gt;.            We will contact you no later than &lt;response date&gt;.            The request will be resolved no later than &lt;deadline&gt;.            ...            For further information, please reply to this email.            Thank you for using our services.            &lt;Service name&gt;*
      
The request number is also included in the subject line of the auto-reply. If the requester responds to this message with another message, this new message will not be considered a new request, but rather additional information and will be inserted into the log of the existing request.
     
The system searches the subject of the message to see if there is an existing request identification somewhere. By default, the request identification has the format T&lt;number&gt;ALVAO. You can change the tagging method in the Service Desk settings on the [tab.
 General](../../../list-of-windows/alvao-webapp/administration/service-desk/service/create-service). This setting must be made before the Service Desk goes live, as changing the settings will not affect the IDs of existing requests.
