# Maintenance reports
      
The ALVAO Asset Management product includes two reports suitable for alerting managers to specific upcoming events.           
         The **Objects with an upcoming date** report (Expiring objects csy.rdl, Expiring objects enu.rdl) allows you to set a notification for any date in the object property according to a defined advance (number of days into the future).           
         The **Licenses with an upcoming deadline** report (Expiring licenses csy.rdl, Expiring licenses enu.rdl) allows you to set a warning for the expiration or support date of a license.

> [!NOTE]
> Reports are in Czech and English only.

> [!TIP]
> You can also use [Periodic Alerts](../../periodic-alerts) instead of *Maintenance Reports* to notify you of upcoming license and device deadlines.

## Installation
     RDL files can be found at [www.alvao.com/download](https://www.alvao.com/download) under the Asset Management product in the MaintenanceReports.zip archive.  
     For a description of how to install the reports, see [Installing reports in Microsoft SQL Server Reporting Services](installation).      
## Objects with an upcoming deadline
      The report is suitable for alerting about upcoming events/scheduled maintenance in the asset records.  
     For required equipment, you need to record a property that contains some future date. This date may indicate, for example, the end of warranty, the date of the next inspection, the date of the next UPS battery replacement, etc.  
     A report is then generated based on this date and the specified advance date, which will contain all the objects that have this date in the specified advance date to give the technician enough time to react to the event.     
### Parameters
      
- **Organizational folder** - enter the path to the folder in the tree for which you want to generate the report. If you do not enter anything, the report will be generated for the entire record.
- **Object kind** - select one or more object types you want to display in the report from the menu.
- **Property** - from the menu, select the property in which the date of the scheduled date is stored.

> [!NOTE]
> Only the date type property can be selected.

- **Filter** - specify a custom condition to filter objects by values of any property in the form of a SQL condition.  

            Example: "([Manufacturer] = 'EPSON' OR [Manufacturer] LIKE 'Gigabyte%') AND [Vendor] LIKE 'Softcom%'".
- **Advance (days)** - specify how many days before the deadline the objects should be displayed in the report.

## Licence with an upcoming deadline
      The report is used to notify you about expiring licenses and expiring maintenance on licenses.  
     Licenses are selected based on the specified advance notice.     
### Parameters

- **Date** - select the date you are interested in in the report - "Valid until" or "Upgrade/support until".
- **Filter** - enter a custom condition to filter licenses by manufacturer in the form of a SQL condition.  

            Example: "[Manufacturer] LIKE 'Microsoft %' OR [Manufacturer] = 'ALVAO s.r.o.'".
- **Advance (days)** - specify how many days before the deadline the licenses should be displayed in the report.
