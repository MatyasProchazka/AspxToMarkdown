# Permission to see request
     
Each user sees only those requests in the application that they are authorized to see based on their [service roles](../../alvao-service-desk/implementation/services/service-roles) and possibly other settings. By modifying the view [vHdTicketPersonRead-Custom](../../alvao-asset-management/implementation/customization/database#V_dbo.vHdTicketPersonRead_Custom)         in the database, you can grant users permission to see additional requests beyond their roles in the services.

> [!CAUTION]
> View customization requires a good knowledge of SQL and [Alvao Database](../../alvao-asset-management/implementation/customization/database).

  Unprofessional view customization can lead to application slowdown or even data corruption.
