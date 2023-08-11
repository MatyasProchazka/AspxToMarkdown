# Service Catalog Management
      
The service catalogue is a single place to manage all services provided by service departments across the organisation (IT department, HR department, building management, fleet management, ...). The aim of managing the service catalogue is to ensure that the service catalogue reflects the actual situation in the organisation and that services are available to those users (requesters) who have [the right to use the services](../alvao-asset-management/implementation/users/permissions), at agreed levels ([SLA](../alvao-service-desk/implementation/services/sla)).
     
The development of the service catalogue should take place in the form of a workshop with the participation not only of members of the solution teams (inside view), but especially of key users of the services and business representatives (outside view). A well-designed service catalogue is intuitive for both requesters and researchers, reducing the need to [move between services](../alvao-service-desk/requests/move-to-another-service).
     
The Service Catalog manager is typically the CIO of the company (who is typically also the Service Level manager).
      
## Structure
      The service catalogue should be structured logically, and services can be grouped by subject matter (e.g. by departmental agendas). This creates a hierarchical service catalogue or, if you prefer, a service tree. Based on the experience gained from our customers' implementations, we recommend structuring the service catalogue as follows:     
- substantive grouping
e.g. Applications - Office applications - MS Office, Computers and end devices - Laptops and tablets

- at the last level of the defined ITIL process workflow (typically Incident Management, Request Fulfilment, Change Management, Problem Management)
e.g. Request (Request), Incident (Incident), Change (Change)
       
## How the ALVAO Service Desk looks like
     
### Sample of service structure

- Changes to company standards
- Administration
- Information Technology
    - I need help
    - Telephony
    - Computers, laptops and tablets
    - Printing services
        - Hassle of using
        - Printer request
    - Programs and applications
    - Enterprise Information System
        - Help with use
        - Report an error or malfunction
            - Troubleshooting
        - Setting up and changing access
        - Suggestions for improvement
    - Email
    - Shared files and folders
    - Remote network access
    - Support services
        - Access Management
        - Applications
            - Desktop applications
            - ERP system
            - Exchange
                - Incidents
                - Problems
        - Change Management
        - Infrastructure
        - IT projects
        - Problem Management
        - Software Asset Management
    - Compliments, complaints and ideas
- Building Management
- Fleet Management
- Buying to order
- Machinery maintenance
- Development
- Personnel Department
- Legal Services
- Finance
- Marketing
- Security
- Quality
- Management

### User WebApp
     ![Service Catalog in ALVAO WebApp](service-catalog-management/SDWA - Catalog EN.PNG)        
With a well-designed service catalog, there is little fluctuation in requests because the intuitive catalog, supported by appropriate icons and descriptions, correctly guides the requester to the last level with a specific workflow. If for some reason the requester is unsure where to place a request, they can create it at any level - operators and solvers will move it to the correct service as part of the requester communication and diagnostics.

> [!NOTE]
> Services that have a [are not displayed in the service catalog.service settings](../list-of-windows/alvao-webapp/administration/service-desk/service/create-service)

        the "Show in service catalog" option is disabled.

## Example of an internal directive
     
An internal directive on this issue should include the following information:
     
### IT Service Catalogue

1. A list of services provided by the company's internal IT staff.
2. Each list should be a separate document (stored e.g. on SharePoint)
3. You can then reference these catalog sheets from the Service Desk forms (description field)

| Service ID | S001 |
| --- | --- |
| Service name | **Computers and accessories** |
| Description of service | **Supply and service of computer and accessories**<br><ul>
                            <li>computer</li>
                            <li>desktop</li>
                            <li>or laptop + docking station + bag</li>
                        </ul>
                        
 - monitor<br>
                        - mouse<br>
                        - keyboard<br>
                        - headset with microphone<br>
                        - necessary connection cables<br>

 <br>**Connection to internal corporate network**         <br>      Connecting a computer to the internal corporate network Computers are connected to the internal network:  <br>      a) by cable        <br>      b) wirelessly (wifi)<br>

                        <br>**Web Access**                               <br>                             Providing access to the web from the internal company wall Computers are connected to the Internet via the internal company network. The connection is set up automatically. There is no need to set it up manually. Access from the internal network to web servers on the Internet is not restricted. |
|  | Business - Laptop<br>
                    <br>Design - desktop station<br>
                    <br>Administrative - desktop PC |
|  | Petr Novák (shop)  <br>                         František Doskočil (construction)  <br>                         Marie Okurková (administration) |
|  |  |

| Service ID | S002 |
| Service name | **Standard SW** |
| Description of service | Installation and support of standard software that comes with the computer. |
| Options | Application | Key User | Basic Software || Recommended for new computers |  |<br>| --- | --- | |
| --- | --- |
| Windows 7 Enterprise (English, x64) | Petr Novák | Yes |
| Microsoft Office 2010 Professional Plus (Czech, x64) | Petr Novák | Yes |
| Microsoft Lync | Petr Novák | Yes |
| Adobe Acrobat Reader | Petr Novák | Yes |
| 7Zip | Petr Novák | Yes |
| Microsoft Office Project 2010 Professional (Czech, x64) | František Doskočil | No |
| Microsoft Office Visio 2010 Professional (Czech, x64) | František Doskočil | No |
| Old supported applications: |  |
| --- | --- |
| Microsoft Vista Enterprise (Czech, x64/x32) | Petr Novák |  |
| Microsoft Office 2007 Enterprise (Czech. x64/x32) | Petr Novák |  |
| Microsoft Office Project 2007 Professional (English, x32) | František Doskočil |  |

             |  | Petr Novák (shop)  <br>              František Doskočil (construction)  <br>              Marie Okurková (administration) |
         |  |  |

| Service ID | S003 |
| --- | --- |
| Service name | **Electronic mail** |
| Description of service | Management of electronic mailboxes.<br>
                    <br>Each employee has their own electronic mailbox. The standard address format is                         <name.prijmeni>
                        @firma.cz.</name.prijmeni><br>
                    <br>The size of the mailbox is limited to 500 MB, see the recommended settings for automatic archiving. The contents of the mailbox are duplicated on two hard drives in case of disk failure. In case of server destruction or theft, data is backed up 2x/year. |
| Options | No variants of this service are offered. For any non-standard needs, please submit a request under Standard Request Resolution and the department will address it |
|  | Petr Novák |
|  |  |

| Service ID | S004 |
| Service name | **Shared Files and Folders** |
| Description of service | Management of shared drives, their backup and archiving.  <br>
                    Troubleshoot problems with shared drives and data on them, assign and change access rights
   <br>
                      <br>
                    Shared disks are<br><br> Disk | Description || S: | Backup disk in the ZR.
                                  <br>
                                The size of the disk is 20 GB.  <br>
                                  <br>
                                The contents are backed up every night after the work day. The backup resists destruction or theft of the server. The last 5 backups are archived. |<br>| T: | Working disk in ZR.
                                  <br>
                                The disk size is 200 GB.  <br>
                                  <br>
                                The contents are stored duplicated on two hard disks in case of disk failure. Data is backed up 2x/year in case of server destruction or theft. |<br>| In: | Working drive in Brno.
                                  <br>
                                The size of the disk is 200 GB.  <br>
                                  <br>
                                Content is stored duplicated on two hard drives in case of disk failure. In case of server destruction or theft, data is backed up 2x/year. The V:\Backup folder is backed up every night after the working day. The backup resists destruction or theft of the server.  The last 5 backups are archived. The size of this folder is limited to 1GB. | |
| --- | --- |
| Variants | Access controlled based on job title (management, finance department, administrative staff, ...) |
|  | Petr Novák |
|  |  |
