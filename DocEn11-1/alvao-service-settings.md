# Alvao Service component settings
      
The settings are stored in the appsettings.json file in the installation folder.  
         To return the settings to the default state, re-create the file by copying and renaming the "AlvaoServiceSample.exe.config" file. You can use Notepad in Windows to edit it.
      
## Database connection
      
The connection to the database is defined in section:
     
"ConnectionString": {  

             "Db": "Data Source=localhost;Initial Catalog=Alvao; Max Pool Size=2000; Integrated Security=True; MultipleActiveResultSets=True"  

            },
      
Write the database connection string to the **ConnectionString** attribute. The format of the string is the same as in the WebApp settings, see [Database Connection](webapp-settings#database_connection).
      
## Sending emails
      
The Alvao Service component sends all email messages leaving the Alvao system. The SMTP server address for sending email messages in the database needs to be set in **WebApp - Administration - Settings**- [Messaging](../../../list-of-windows/alvao-webapp/administration/settings/messaging).
     
Emails are sent in batches, the default sending interval is 1 minute. If an email fails to send for any reason, it will remain stored and will be resent at the set interval (default value 10 minutes) until it is successfully sent or exceeds the number of send attempts (default value 432). Once the number of send attempts is reached, the email will remain in the database for possible diagnostics.
     
Sending settings are stored in the database (tProperty table):

| Variable | Default value | Meaning |
| --- | --- | --- |
| MailSendIntervalSeconds | 60 | Email sending interval - in seconds |
| MailSendMaxAttempts | 432 | Maximum number of attempts to send an email |
| MailSendRetryIntervalMinutes | 10 | Interval between attempts to resend emails that failed to send - in minutes |

The change in the interval of sending emails will be reflected only after Alvao Service is restarted.
      
## E-mailboxes
      
If you want to automatically load messages from a specific mailbox into a specific service desk service (see [Service Desk Services](../services/service-tree)),     in **WebApp - Manage - Services - Edit**         - [Loading messages](../../../list-of-windows/alvao-webapp/administration/service-desk/service/loading-messages) section, set up a connection to that mailbox.
      
## Incoming message rules
      
Alvao Service can perform actions based on defined rules. Rules for incoming messages are set in **WebApp - Administration - Service Desk -**[Rules for incoming messages](../../../list-of-windows/alvao-webapp/administration/service-desk/roles-messages).
      
## Automatic responses
     
If Alvao encounters a message that is evaluated as an automatic reply while retrieving messages, this message is not considered a full message and therefore the following operations are not performed:
     
- [Reopening of a request](../../requests/reopen-for-further-resolution) by the requester or creation of a new request after the reopening deadline has expired.
- Stop [waiting for a requester](../../requests/wait-for-response).
- Resetting the Waiting for email column.

Messages are considered an automatic reply when:

- contain the Auto-Submitted parameter in the header
 with the value auto-generated,
 auto-replied or auto-notified or
- contain one of the predefined strings in the subject line of the message.

### Settings
     
If you wish to change the default settings of the predefined strings that are included in the subject of auto-replies in your organization, edit and run the following SQL statement on the Alvao database:   
          update tProperty set sPropertyValue =
 N'Auto reply\*;Automatic reply\*;Out of office\*;Out of Office\*' where sProperty = 'AutoSubmittedEmails.Subjects'

> [!NOTE]
> The example shows the default settings. Individual subject templates are separated by semicolons, and the asterisk replaces any number of characters.

By default, autoresponse recognition is turned on. If you do not wish to use this functionality, run the following SQL statement on the Alvao database:   
          update tProperty set bPropertyValue = 0 where sProperty = 'AutoSubmittedEmails.Detect'
       
## Additional settings

| Variable | Value |
| --- | --- |
| SleepSeconds | The amount of time the Alvao Service waits if there are no new messages in the mailbox. The time is specified in seconds. |

## Event log
      
Event log can be set in the NLog section.
     
By default, warnings and errors are printed to the Windows Event Log.
     
However, you can freely change the target, logging level, printed messages, etc. according to the [NLog documentation](https://github.com/nlog/nlog/wiki).
      
## Sending Diagnostics
      
If an email fails to send, the Alvao Service component prints an error message to the event log containing information about the email that was sent and the text of          the error that occured. This message is printed when the log is set to *Warning* or higher. For a message informing about a general component failure (e.g. an invalid          database operation), setting the log to *Error* is sufficient.
     
If there are messages in the database that have reached the maximum number of attempts to send, a message is output once a day indicating the number of messages that could not be sent (Event Log Level 1 and higher):
     
"The mail queue currently contains X emails that could not have been sent."
     
The unsent emails can be found in the database (table  MailMessage), where, in addition to the message itself (packaged in .eml format), there is information about the number of attempts to send (SendAttempts), the last error message (LastErrorMsg) and the time of the last attempt to send (LastAttemptTime).
