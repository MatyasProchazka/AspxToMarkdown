# SAM - notification
 
Setting user notifications within [Software Asset Management](../../../../../itil/sam) of irregularities related to the sw products they have installed on their computers. An alert is sent if there is no license assigned to the installation on the computer or the installation is not otherwise covered (e.g., shared license, special installation).
 
Options:

- **Messages**-
 Setting the content of alerts, selecting recipients, and defining the conditions under which alerts are sent.
    - **First Alert**- turn on if you wish to send the first alert via email.
        - **Alert:**
            - **Person responsible for the SW on the PC**
 - Enable if you want to send the first alert to the person responsible for the software on the PC, see property [Software Responsible](../../../../../alvao-asset-management/software-management/software-regular-auditing).
            - **Direct manager of the person responsible for the software on the PC** - enable if you want to send the first notification to the direct supervisor of the person responsible for the software on the PC.
            - **Group Members** - the first notification is sent to all members of the selected [user group](../../users/detail/membership).
        - [Edit message template](sam-alerting-message-template) - edit the template of the sent messages.
        - **Detection period after first notification (days)**
 - Enter the number of days after the first alert is sent that the software of the computer should be repeatedly detected until it is corrected. This time should be shorter than the time until the second alert is sent.
    - **Second alert**- turn on if you wish to receive a second alert by email.
        - **If not corrected until (days)** -
 enter the number of days. If after this number of days a remedy is not agreed, a second notification will be sent.
        - **Alert:**
            - **Person responsible for the SW on the PC**
 - enable if you want to send the second alert to the person responsible for the SW on the PC.
            - **Direct manager of the person responsible for the SW on the PC** - turn on if you want to send the second alert to the direct manager of the person responsible for the SW on the PC.
            - **Group Members** - the second notification is sent to all members of the selected [user group](../../users/detail/membership).
        - [Edit message template](sam-alerting-message-template)- edit the template of the sent messages.
    - **Third notification**- turn on if you want to receive a third notification by email.
        - **If not corrected until (days)** -
 enter the number of days. If after this number of days from the second alert no remedy is agreed, a third alert will be sent.
        - **Alert:**
            - **The person responsible for the SW on the PC**
 - enable if you want to send the third alert to the person responsible for the SW on the PC.
            - **Direct smanager of the person responsible for the SW on the PC** - turn on if you want to send the third alert to the direct manager of the person responsible for the SW on the PC.
            - **Group Members** - the third notification is sent to all members of the selected [user group](../../users/detail/membership).
        - [Edit message template](sam-alerting-message-template) - edit the template of the sent messages.

> [!NOTE]
> The user's direct manager is listed in the [field.

  Supervisor](../../users/detail) in the user settings in the ALVAO WebApp - Administration. 

> [!NOTE]
> The generated e-mail messages will be sent to all recipients at once (the "To" field will list the addresses of all recipients).

- **Other**
    - **Report send time** - enter the time at which the alert should be sent (in hh:mm format).

> [!NOTE]
> The send time is stored in UTC and does not respect the transition between daylight saving time and standard time. For example, if you enter the time in summer, it will be one hour offset in winter and will be displayed as such in the settings.

    - **Repeat last notice automatically after (the number of days from last notification)**
 - turn on if you want to send alerts repeatedly and specify the period of sending (in days).
    - **Alert only on computers whose SW detection is no older than (days)** - turn on if you want to send only alerts for computers with current SW detection, and specify the maximum allowable detection age in days.
