# Install applications
  
On this page you can download the latest versions of the Windows (MSI) application installation packages.
 
After downloading the installation package, run. In order to install the package on your computer, you must have the *Administrator* role on your computer.
 
If you already have an older version of the application installed on your computer, the installation package will update the existing installation to the new version.

> [!NOTE]
> If the organization does not use *ALVAO Asset Management Agent* for HW/SW computer discovery (e.g., uses [ALVAO Microsoft Endpoint Manager Connector](../../../modules/alvao-microsoft-endpoint-manager-connector)

  or [agentless detection](../../../alvao-asset-management/implementation/detection)),
  Alvao Administrator can hide the link to the Agent package. The link can be hidden with an SQL script:   
`update tProperty set bPropertyValue = 0 where sProperty = 'WebApp.Settings.InstallApplications.ShowAmAgentLink'`.
