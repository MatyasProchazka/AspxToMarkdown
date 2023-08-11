# Import license assignments from Microsoft 365
     
Alvao supports the periodic import of license assignments from Microsoft 365 (M365).          The import is done using a PowerShell script that generates a CSV file which is then imported into Alvao using the [ImportLic](../import-lic) utility.

> [!NOTE]
> License import matches licenses from M365 to existing software licenses in Alvao based on a unique license ID.

## Configuration
     
1. Create a new (or use an existing) application in MS Azure Active Directory.
2. The application must have the following permissions on Graph API:
    - *User.Read.All*
    - *Organization.Read.All*
3. Edit PowerShell script *Export\_M365\_licences\_to\_CSV.ps1*(located in the AM Console installation folder) and enter your Azure AD identifiers into the variables at the beginning of the script:
    - *$tenantId*
    - *$clientId*
    - *$clientSecret*
4. Optionally, change the path and name of the generated output CSV file (*$csvOutput* variable).

## Initial import

1. In AM Console – License registry, first create the licenses whose assignment you want to periodically import from M365. For example, 
            *Microsoft Office 365 Enterprise E3*. The *License model* field should be per user.

> [!NOTE]
> It is not important to fill in the exact number of licenses and license items as they will be imported from M365 later.

2. Run the PowerShell script *Export\_M365\_licences\_to\_CSV.ps1* manually and wait for the CSV file to be created.

> [!NOTE]
> The PS script uses the *Microsoft.Graph* module, which installs itself if necessary. If necessary, 

                onfirm the prompt to install this module and its dependencies.
3. Open the generated CSV file (e.g. in *Notepad*) and map all unique M365 license identifiers (*Uid* column in the CSV) to existing licenses in Alvao. 
            Enter these UIDs into the *License ID in the external system* field of the appropriate licenses.

> [!NOTE]
> A map of Microsoft product names and their UIDs exists in the Microsoft 

                [documentation](https://learn.microsoft.com/en-us/azure/active-directory/enterprise-users/licensing-service-plan-reference).
4. Run the [ImportLic](../import-lic)utility in UpdateItems mode. The licenses in Alvao that you have mapped using the UID to licenses from M365 will be automatically updated:
    - *Count* field
    - All license items

> [!NOTE]
> If necessary, the [ImportLic](../import-lic) utility will create new users in the Imported objects folder.

## Setting up a periodic import

1. Once the licenses in Alvao are paired with M365 licenses through the UID, you may repeatably run the PS script and the 
            [ImportLic](../import-lic) to update the license assignment in Alvao. We recommend scheduling a task on a server to do this automatically.
