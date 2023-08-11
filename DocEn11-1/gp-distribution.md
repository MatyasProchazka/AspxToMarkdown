# Distributing msi package via Group Policy
      
## Summary
      
Use this guide to create a rule in Group Policy that installs the selected .msi package on a computer/group of computers.
      
## Designed for products
      
- ALVAO Asset Management
- ALVAO Service Desk

## Starting Conditions
      
- Active Directory must be used on the network  
            - Windows Server 2000 and later  
            - Client stations must be running Windows 2000 and later  
            - save the installation packages to \&lt;server name&gt;\netlogon. Here, create a folder for these msi packages.
      
## Progress
     
Create a rule to install the ALVAO Asset Management Agent service.

1. Connect to the server.
2. Start Group Policy Management.
3. Create a new object (Group Policy Object), name it "ALVAO Asset Management Agent".
4. Right click on the object created and select Edit.
5. Select Computer Configuration - Policies - Software Settings -
  Software installation.
6. Right-click and select New - Package
  Package).
7. Select the AlvaoAssetAgent.msi package and confirm the selection.
8. Select Assigned and confirm.
9. The package is now created.
10. To add multiple msi packages in one GPO, repeat steps 6 through 9.
11. Close the Group Policy Management Editor.
12. Select the computers/group to which this GPO will apply.
13. Finished.

> [!NOTE]
> The AM Agent then updates itself automatically according to the installed version of the ALVAO Server.
