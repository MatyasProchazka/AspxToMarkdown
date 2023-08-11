# New periodic alert
   
Use this form to create a new [periodic alert](detail).

> [!CAUTION]
> A poorly defined SQL query can irreversibly damage the Alvao database. Always create and test SQL queries on a testing copy of the production database.

Options:

- **Name** - enter the name of the alert.
- **Description** - enter a description of the alert.
- **SQL script** - insert the script for evaluating the alert.  For more information about script creation and examples, see [Periodic Alerts](../../../../alvao-asset-management/implementation/periodic-alerts)
- **Run above the analytical database** - enable if you want alerts to be evaluated on [analytic database](../../../../alvao-asset-management/implementation/analytic-database).
  Using the analytic database has the advantage that more computationally intensive queries do not slow down the production database and can therefore run for up to 10 minutes, whereas the limit for queries to the production database is set to 30 seconds.  The option is only active if the use of the analytical database is enabled.
- **The data table to be attached as a CSV file** - enable if you want to attach a data table to an email also as a CSV file.
- **Scheduling**
    - **Start** - enter the date and time when the alert will start sending. If repeated, the alert will always be sent at the specified time.
    - **Sending period** - select the period at which alerts will be evaluated and sent.
