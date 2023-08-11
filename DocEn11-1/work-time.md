# Time reporting
      
Users who are members of the group [Time Reporting Persons](../implementation/users/groups) can record time worked in the request log when performing operations on a request. All users who have the right to see the request log can also see the time reported.
      
## Fields on forms
     
Time worked is reported in the following fields.
     
- **Work (h:m)** - enter the time you spent working on the request, in hours:minutes format.
- **Travel Time (h:m)** - enter the time spent on the trip (in hours:minutes format).
- **Distance (km)** - enter the number of kilometres travelled.
- **Invoice** - enable if you do not want the reported values to be displayed to the requester. [Solvers and managers](../implementation/services/service-roles) will see the values in strikethrough font.

## Display of reported time
     
The reported time is displayed in the request table as the sum of the reported time from all events. In the event list table and in the log, time is displayed for individual events. The *No Invoice* option can also be displayed as a column in the log, which can be turned on each time the time is reported.
     
When the Requester views the log, they see the reported time at the end of all events in the log. If the reported time on an event is marked as *No Billing*, then the requester sees this time as zero. If the solver or manager looks at the log, they see unbilled time, but it is crossed out.
     
The log can be exported to a Microsoft Excel spreadsheet. This file can then be used to invoice the customer for any time worked.
