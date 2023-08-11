# Custom workflow
      
This type of modification requires a good knowledge of the ALVAO Service Desk database. You set up the URL workflow in the service administration (**WebApp - Administration - Service Desk - Services - New Request Form**). The URL is always used when the request page is displayed. The URL may contain special symbols.

| Symbol | Description |
| --- | --- |
| ~ | Represents the address of the WebApp |
| {0} | Represents the request number (without prefix and suffix) |

For example: "*~/Custom/HdTicketNew\_NewEmployee?iHdTicketId={0}*"
