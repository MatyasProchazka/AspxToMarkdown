# Software Management Report
     
The [ALVAO SAM Assistant](../alvao-sam-assistant) module includes **Software Management Report** (Software Management Report csy.rdl, Software Management Report enu.rdl), which provides an operational overview of installed software and purchased licenses.  
         The report graphically shows the status of the entire inventory and lists information on only a few of the most important objects.  
         The graphs are used to get a general overview and to help decide which information needs to be looked at in more detail. The description of each chart (below) therefore refers to the relevant section of ALVAO Asset Management.

> [!NOTE]
> The report is in Czech and English only.

> [!TIP]
> Similar information can also be obtained in the analytical excel ***Asset Management Analysis.xlsm***, which is located in the installation directory of the installed ALVAO Asset Management Console.

## Installation
     For a description of how to install reports, see [Installing reports in Microsoft SQL Server Reporting Services](../../alvao-asset-management/implementation/maintenance-reports/installation).       
## Report graphs
     
### Checking License Enrollment and Allocation
     
The first four graphs show the legality of installed software and license usage, for more information see [License and Installation Overview](../../list-of-windows/alvao-asset-management-console/software/license-and-install-overview).  
> [!NOTE]
> The charts only show information about products that are not freeware.

     
- **Non/legal installations** - shows the overall ratio between installed software and purchased licenses. Unassigned licenses for the primary license product are also counted.
- **Installations with/without assigned license** - shows the ratio of installations with and without an assigned license. The three computers (and their users) with the highest number of installations without assigned licenses are listed.
- **License** - shows the proportion of purchased licenses that are unassigned licenses, and the three licenses with the highest number of unassigned licenses.
- **Allocated Licenses** - shows what portion of the allocated licenses are unnecessarily allocated.  

            The three computers (and their users) with the highest number of unnecessarily allocated licenses are listed.
- **Newly registered licenses (documents)** - highlights potential problems in [license registry](../../list-of-windows/alvao-asset-management-console/software/license-registry) and shows the volume of newly registered licenses over the last 6 months.
- **Expiring licenses in the next three months** -
Displays the top three expiring licenses and the number of licenses expiring in the next three months. You can find them all in the ALVAO Asset Management application, in [license registry](../../list-of-windows/alvao-asset-management-console/software/license-registry) by displaying the *Expiry by* column.

### Checking the technology part of the system

- **Computer detection software** - comparison [ways in which computers were detected](../../alvao-asset-management/implementation/detection/detection-way). More at [Detection](../../list-of-windows/alvao-asset-management-console) tab for the selected object. Displays information for the last 6 months.
- **Software Installation and Uninstallation** - A summary of detected and manually entered changes to installed software. For more information, see the [log tab](../../list-of-windows/alvao-asset-management-console/tab-view/diary) for the selected object.
- **Detection Age Histogram** - the age of the computer detections. The three computers with the oldest detections and possibly 3 never detected before. More on the [Detection tab](../../list-of-windows/alvao-asset-management-console/tab-view/detection) of the selected object.
- **Software Products** - information about [SW product library](../../alvao-asset-management/software-management/custom-swlib): how many products are unrecognized and when the library was last updated.
