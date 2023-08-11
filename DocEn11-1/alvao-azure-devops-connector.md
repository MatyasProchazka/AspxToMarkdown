# ALVAO Azure DevOps Connector
      
This module connects ALVAO Service Desk and Azure DevOps.          For example, a user submits a request to ALVAO Service Desk to modify the ERP system.          After the request is approved and a detailed specification of the modification is developed, or immediately after the request is created,          a work item is automatically created in Azure DevOps to implement the modification.          After the modification is executed and the work item in Azure DevOps goes to defined status,          the original request in Alvao goes to a defined status, e.g. "Synchronization to DevOps".
      
## Technical requirements
     
- Azure DevOps
- ALVAO Service Desk
- ALVAO Service Desk Custom Apps module
- ALVAO Service Desk Enterprise API module

## Module activation
     
The module must be activated with an activation key, which you can obtain from your Alvao system supplier. In **WebApp - Administration -** [License](../list-of-windows/alvao-webapp/administration/licenses), select **Insert Activation Key** and enter the activation key.
      
## Installation

1. In the **WebApp - Administration - Service Desk -** [Services](../list-of-windows/alvao-webapp/administration/service-desk/service) tree, select the folder where you want to import the sample service to connect to Azure DevOps, and use the **Import** command to load the **AzureDevOpsConnectorService**&lt;Enu/Csy&gt;**.xml** file, which is included in the **AlvaoAzureDevOpsConnector.zip** installation package.
2. In **WebApp - Administration -** [Applications](../list-of-windows/alvao-webapp/administration/applications), use the **Import** command to load the **AzureDevOpsConnectorApp.xml** file.

## Azure DevOps Personal Access Token

1. In Azure DevOps, create a [Personal Access Token](https://docs.microsoft.com/en-us/azure/devops/organizations/accounts/use-personal-access-tokens-to-authenticate?view=azure-devops&tabs=preview-page) (PAT) with **Work Items - Read & Write** permissions.
2. In **WebApp - Administration -** [Applications](../list-of-windows/alvao-webapp/administration/applications), select the **ALVAO Azure DevOps Connector** application and insert the created PAT into the **Settings.cs** script at the location indicated by the appropriate comments.

> [!NOTE]
> Alternatively, you can use multiple access tokens, e.g. if you need to integrate Azure DevOps from different organizations into Alvao.

## Setting up Azure DevOps

1. In **Azure DevOps** in a given project, use **Project Settings - Service hooks - Create subscription**.
2. Select **Web Hooks** as the service type and press **Next**.
3. Under **Trigger on this type of event**, select **Work item updated**.
4. In **Field**, select the State option. Press the **Next** button.
5. In the **URL** entry, enter the URL of the AlvaoRestApi application, followed by the path "/Connectors/DevOpsCallback", e.g.: [https://contoso.alvao.com/AlvaoWebApi/Connectors/DevOpsCallback](https://contoso.alvao.com/AlvaoWebApi/Connectors/DevOpsCallback)
6. Select **None** under **Messages to send**.
7. In Detailed **messages** to send, also select **None** and press **Finish**.

## Setting up a service in Alvao

1. In **WebApp - Administration - Service Desk** - [Services](../list-of-windows/alvao-webapp/administration/service-desk/service), select the service you want to connect to Azure DevOps and use **Edit - Properties**.
2. In the [Other](../list-of-windows/alvao-webapp/administration/service-desk/service/other) section, specify the value of the **External Application - Connector Settings** custom field. The following settings are written in JSON notation:
    1. **ConnectorType** - enter the text **AzureDevOps**.
    2. **URL** - enter the URL of the Azure DevOps project in the form [https://dev.azure.com/{organization}/{project}](https://dev.azure.com/{organization}/{project})   
 
                Example: [https://dev.azure.com/Alvao/Alvaoproject](https://dev.azure.com/Alvao/Alvaoproject)
    3. **AccessToken** - enter the Personal Access Token (PAT) number that you first saved in the *Settings.cs* script.  

                Example: 0
    4. **AttributeMap** - specify the mapping of the request items, see below for the format of the settings.
    5. **BeginState**- specify the name of the request status in Alvao in which the request will be transferred to Azure DevOps.  

                Example: Synchronization to DevOps
    6. **EndState**- specify the name of the request status to which the request should transition when the corresponding work item is closed in Azure DevOps.  

                Example: Return from DevOps
    7. **WorkItemEndState** – specify the name of the state in Azure DevOps in which should the request change its state in Alvao.  

                Example: Closed

    Example of the entire setup:

    {  
             "ConnectorType": "AzureDevOps",  
             "URL": "https://dev.azure.com/Alvao/Alvaoproject",  
             "AccessToken": "0",  
             "AttributeMap":"{"System.Title":"[$TicketTitle$]",  
             "System.Description":"[$LatestImportantMessage$]",  
             "System.WorkItemType": "Task"},  
             "BeginState": "Synchronization to DevOps",  
             "EndState": "Return from DevOps",  
             "WorkItemEndState": "Closed"  
             }

## Attribute Map
     
The attribute map for setting up **AttributeMap** is written in JSON format as a list of properties, where the property name is the name of the [item in Azure DevOps](https://docs.microsoft.com/en-us/azure/devops/boards/work-items/guidance/work-item-field?view=azure-devops).   and the value is a string constant. You can use variables in the values, see below. e.g.:
     
{"System.Title":"[$TicketTitle$]", "System.Description":"[$LatestImportantMessage$]",  
         "System.WorkItemType": "Task"}
     
Each item in Azure DevOps is assigned a value that is written as static text containing variables. You can use the same variables as in the status change notification template to the requester, see [Message template](../list-of-windows/alvao-webapp/administration/service-desk/service/message-template).
