# Audit changes to user permissions
      
The product includes three reports that are used to audit changes in user permissions.

| Report name | RDL file name | Description | Name of the database view |
| --- | --- | --- | --- |
| Object Tree - Permission Settings Log | Object Tree - Security Settings Log csy.rdl  <br>
                    Object Tree - Security Settings Log enu.rdl | Provides a list of permission changes in the object tree. | Query.NodeRightLog |
| Group Membership Settings Log | Roles Membership Log csy.rdl  <br>
                    Roles Membership Log enu.rdl | Provides a list of changes to user and group memberships in groups. | Query.RoleMembershipLog |
| User Login Log | User Logon Log csy.rdl  <br>
                    User Logon Log enu.rdl | Provides a list of individual user logins/logouts to/from the Asset Management Console. | Query.UserLogonLog |

> [!TIP]
> You can use the database view names in the AM Console - Tools - Database - [SQL Query](../../../list-of-windows/alvao-asset-management-console/tools/database/sql-query) window. Here you can view the same data as in the report without using Reporting Services.

> [!NOTE]
> Reports are in Czech and English only.

## Installation
     RDL files can be found on [www.alvao.com/download](https://www.alvao.com/download) under Asset Management in the SecurityAuditReports.zip archive.  
     For a description of how to install reports, see [Installing Reports in Microsoft SQL Server Reporting Services](../maintenance-reports/installation).      
## Object Tree - Permission Settings Log
     The report displays a list of changes to user permissions in the object tree for the selected time period.  
     In addition to the changes made, the report also lists the date and time the change was made and the name of the user who made the change.     
### Report parameters
     
- **From** - enter the date from which the records in the report should be displayed.
- **To** - enter the date until which the records should be displayed.
- **User** - select the users to be displayed in the report from the menu.
- **Group** - select the groups to be displayed in the report from the menu.
- **Edit** - from the menu, select the authors of the permission changes to be displayed in the report.

## Group Membership Settings
     The report displays a list of changes to user and group memberships for the selected time period.  
     In addition to the changes made, the report also lists the date and time the change was made and the name of the user who made the change.     

> [!NOTE]
> When a user or group is deleted, the membership change is not recorded. Only if a group that was a member of other groups is removed, the log records the removal of the group from those groups.

### Report parameters

- **From** - enter the date from which the records in the report should be displayed.
- **To** - enter the date until which the records should be displayed.
- **Member** - select from the menu the users and groups to be displayed in the report.
- **Group** - select the member groups to display in the report from the menu.
- **Edit** - select the authors of the membership changes to be displayed in the report from the menu.

## User Login Protocol
     The report displays a list of user logins and logouts to/from the AM Console within the selected time period.  
     For each record, the name of the computer on which the user logged into the application is also listed.     
### Report parameters

- **From** - enter the date from which logins should be displayed in the report.
- **To** - enter the date until which logins should be displayed in the report.
- **User** - select from the menu the users to be displayed in the report.
- **Applications** - select from the menu the applications to be displayed in the report.
- **Computer** - select the computers to be displayed in the report from the menu.
- **Administrators Only** - enable this option if only users who were members of the *Asset Management administrators* group at the time they logged into the AM Console should appear in the report.
