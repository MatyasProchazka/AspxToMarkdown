# Detection 
     
Setting up detections in [ALVAO Asset Management](../../../../../alvao-asset-management).
     
Options:
     
- **Keep only one valid detection per machine** - enable if you do not want to create new software and hardware computer discovery requests.  

            The most recent (youngest) existing records are used, similar to calling [Detect again](../../../../../alvao-asset-management/implementation/detection).

> [!TIP]
> Enabling this option will ensure that detections are not accumulated for each computer.  

      This will ensure that you have just one current detection for hardware and software.
- **Agents verification code** - Enter the code used to authenticate standalone Agents when communicating with the Web Service. You must enter the same code when installing Agents.
- **In the records, automatically create new computers with an installed autonomous Agent** - turn on if you want the Autonomous Agent to automatically create new computers that are not in the inventory.
- **Scheduling** - After enabling automatic detection, you can set the daily interval of automatic loading and choose exception days when it won't run.
- **Loading files** **- Automatic loading of detection files (\*.CXM)**- after enabling, additional options will appear.
    - **Load CXM files automatically from**- Select the storage from which the file will be loaded:
        - **Folder**- Choose this option for loading data from a disk folder.
            - **Path** - Enter the path to the folder.
            - **If the loading process suceeded/failed** - You can choose what happens with the data file after the process is finished in each of cases. (The file can be deleted or moved to the specified folder.)
        - **Microsoft Azure storage**
            - **Connection string** - enter a valid MS Azure storage connection string following the example: DefaultEndpointsProtocol=https;AccountName=alvao;AccountKey=\*\*\*;EndpointSuffix=core.windows.net
