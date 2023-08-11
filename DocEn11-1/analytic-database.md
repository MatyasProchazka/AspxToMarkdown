# Analytical database
      
Because performing data analyses and creating reports over a production database in normal operation can slow down application response, we recommend creating these analyses and reports over a separate *analytic database*.
     
On SQL Server, create an analytic database (e.g., named ALVAO\_ANALYSIS) from the current backup of the production database and lock it against writes (read-only) to improve performance. It is recommended to update the analytical database daily from the last daily backup of the production database, e.g. with a scheduled job. The scheduled task can run, for example, a cmd script that you create using the [script template](renew_analysis.zip) and modify the disk file paths and server and database names in the script.
     
In **WebApp - Administration - Settings -**[Data Analysis](../../list-of-windows/alvao-webapp/administration/settings/analysis-db) then set up the connection to the analysis database.

> [!CAUTION]
> The analytics database is for analysis and reports only. Do not work with it directly in Alvao applications!
