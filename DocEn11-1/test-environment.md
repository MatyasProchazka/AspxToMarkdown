# Test environment
      
The testing environment is used to:
     
- testing a new version of Alvao before upgrading the production environment;
- testing software extensions before deploying them to the production environment.

## Creating a test environment
     
It is recommended to create a test environment by copying the production environment.

1. On the Alvao production server ("live" application server), stop Alvao Service and Collector services and set their startup mode to *Handheld.*
2. Create a differently named clone of the Alvao server:
    - Create a clone of the server.
    - Disconnect the server from the network.
    - Log in without the network as a local admin.
    - Use the sysprep tool to delete the existing SID and generate a new SID.
    - Change the server name.
    - Connect the server to the network.
    - Connect the server to the domain.
3. On the production server, restart the services and set their startup mode to *Automatic.*
4. Create a copy of the live database (permissions included) or a new test database.
5. Create a test loaded email, e.g. *servicedesk-test@firma.cz*(optional).
6. Adjust the test machine settings:
    - In the *Web.config* files in *connectionStrings*, set the correct database connection:
        - WebApp
        - AM WS
    - Set the correct database connection also for [ALVAO Service (AS)](../alvao-service-desk/implementation/installation/alvao-service-settings)
                    - (typically C:\Program Files(x86)\ALVAO\AlvaoService\appsettings.json).
    - Open ALVAO Collector as an application (you must stop the ALVAO Collector service first) and set the connection to D to a new SQL server. **Action - Settings - General -                     Set up connection - Add another - ...**
        - If Collector then starts checking the SW library and processing a queue of requests to detect, you can exit.
    - If you want to use computer discovery in the test environment as well, start the Collector service.  
If you want to use test mailbox loading and sending emails from the test SD, start the Alvao Service service. Otherwise, disable the service.
        - Check the Event log (application events) to see if AS is generating any errors and if it is loading emails (best to test by sending an email to the loaded mailbox).
    - Settings in WebApp Management:
        - Path to test AM WS
        - Path to Test WebApp
        - Servers (Test Collector)
        - SMTP Server (sometimes stays the same)

> [!NOTE]
> In the SMTP Server settings (*WebApp - Administration - Settings - Messaging*), we recommend renaming the message sender address to include the word *test*.

        - Reading messages from service mailboxes - delete/reconfigure to test mailbox.  

> [!CAUTION]
> 


                                Omitting this point risks the test environment retrieving messages from the production mailbox.
        - E-mail services *TEST ServiceDesk servicedesk-test@firma.cz*
        - (bulk change service prefix to "TEST")
    - SQL DB
        - Delete all users email address (except test users):

                          **UPDATE tPerson SET sPersonEmail = NULL**
        - Delete the contents of the MailMessage table (otherwise some emails/notifications would be sent (a second time):  

                          **DELETE FROM MailMessage**
    - On the test machine, start the *Alvao Service* and possibly *Collector* services.
7. Test the functionality of all components.
