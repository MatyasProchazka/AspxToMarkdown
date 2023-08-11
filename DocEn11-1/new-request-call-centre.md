# PBX
     
You can integrate the Service Desk with the PBX. When the phone rings, the main solver's computer will then automatically open the New Request form and, based on the caller's phone number, will automatically fill in the caller's details, including, for example, a table of the requests they have recently made. This automatically provides the principal investigator with all the necessary information to start the call.

> [!NOTE]
> For this functionality, you need to have application support for the PBX, which allows you to launch any configured application from the command line or open the URL in a web browser when a call comes in.

## Settings
     
**ALVAO WebApp** - if you wish to make new requests via the web application, set the PBX application to open the following URL on the main solver's computers when a call comes in:  
         &lt;server&gt;/Alvao/Ticket/New?phoneNumber=*&lt;caller's phone number*&gt;
      
This setting automatically opens the *New Request* form in the selected application with the Requester pre-populated by phone number when a call comes in. If no phone number is listed for any user, only that number and the Requester Host are filled in the form.

> [!TIP]
> The method of locating an applicant by the phone number provided by the PBX can be modified using a custom stored procedure in the database. Create a procedure in the database:  

        CREATE PROCEDURE [*&lt;custom schema&gt;*].[spPersonByPhoneNumber\_Custom] @caller nvarchar(255) AS  

            BEGIN  

            ...  

            END  

            GO  

        The procedure must return the requester id that is stored in the[tPerson.iPersonId](../../alvao-asset-management/implementation/customization/database).
