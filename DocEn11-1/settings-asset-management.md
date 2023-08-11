# Installation Settings - Asset Management

- **Collector**
    - **Run under an account** - if you want to use [agentless detection](../../../alvao-asset-management/implementation/detection) HW/SW, enter the login credentials of the account under which the AM Collector service is to run. The specified account must have the *Administrators*role on the detected end stations.
        - **User Name (domain\login)**
        - **Password**
    - **Local System Account** - unless you will be using [agentless detection](../../../alvao-asset-management/implementation/detection),
 you can have the service run under a local system account.
- **Asset Management WebService**
    - **URL** - edit the service address if necessary. For example: http://app.company.com/AssetWebService/AssetWebService.asmx.
    - **Further settings**
        - **Virtual Folder Name (Asset Management WebService)** - option to set the virtual folder name for the Asset Management WebService. The default folder name is *AssetWebService*.
