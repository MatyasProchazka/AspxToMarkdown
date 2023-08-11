# Message template
 
This window allows you to define the content of the alerts sent about irregularities in the software installed on computers.
 
Options:

- **Subject**- specify the subject of the email.
    - **Insert Variable** - select from the menu the variable you want to insert into the subject text at the cursor position (see table below for more details)

.
- **Message body** - enter the text of the email.
    - **Insert Variable** - select from the menu the variable you want to insert into the message text at the cursor position (see table below for more information).

You can use the following variables in the subject or body of the message:

| Variable | Meaning |
| --- | --- |
| [$ComputerProductTable$] | Table with problem products, e.g.:
  <br><br>| **Computer** | **Software name** | **Alternative approved software** | **Software Responsible** |<br>| --- | --- | --- | --- |<br>| PC10 | WinZip 11 | 7-Zip, WinRar | Jan Novák, Petr Svoboda |<br>| PC11 | XnView |  | Petr Svoboda |<br><br>
  Column **Alternative Approved Software**
  will only be displayed if at least one product in the database is set up with alternative approved software - see [Setting up alternative approved SW](../../../../../alvao-asset-management/software-management/software-regular-auditing#alternative-approved-sw). |
| --- | --- |
| [$Alert1SentDate$] | Date on which the first alert was sent. |
| [$Alert2SentDate$] | Date when the second alert was or will be sent. |
| [$Alert3SentDate$] | Date on which the third alert was or will be sent. |
| [$MyAssetURL$] | Link to WebApp page - [My Assets](../../../search/persons/person). |
| [$DetectPeriod$] | Set (accelerated) detection period (number - number of days). |
| [$AlertNo$] | Alert serial number (integer). |
| [$ComputerSwManager$] | E-mail addresses of the people who are responsible for the SW on the computer. |
| [$ComputerSwManagersManager$] | E-mail addresses of the supervisor(s) who are responsible for the SW on the computer. |
