# New server 
   
Use this form to set up a new server that has [Asset Management Collector](../../../../../alvao-asset-management/implementation/detection/collector) installed.
   
Features:
   
- **General**
    - **Hostname** - enter the network name of the server.
    - **Description** - enter a description of the server if applicable.
- **Detection**
    - **Detection Processing**
        - **Detect and evaluate (evaluation scheduling will not take effect)** - Select if Collector should evaluate the detected data immediately after performing the detection. Collector writes the changes to the object tree and to *Installation registry*.
        - **Detect and Schedule Evaluation** - Select if Collector should perform detections but not evaluate the detected data.Collector will only schedule the evaluation of the data.   

> [!NOTE]
> 

> [!TIP]
> - **Use the PING command to determine if a computer is switched on**

        - **Detection with the "Agent over TCP/IP" method** - select to enable the PING function to verify the presence of the computer on the network for detection by *Agent over TCP/IP*.
        - **Detection with the "without Agent" method** - select to activate verification of the computer's presence on the network using the PING function for *no Agent* detection.

> [!NOTE]
> - **Detect the computer again in**

        - **\_\_ minutes while the computer is switched off** - specify in minutes the earliest time Collector should retry to detect the computer off.
        - **\_\_ minutes in case of detection error** - specify in minutes the earliest time Collector should retry to detect the computer after the last detection attempt failed.
    - **Process in one block**- Collector processes requests in blocks. It processes at most the specified number of requests within each block and places a wait (wait state) at the end of the block.
        - **\_\_ computer detections** - Specify the maximum number of detections to be performed by Collector within a block.
        - **\_\_ detection evaluation operations** - enter the maximum number of scheduled evaluation operations that Collector should perform within a block.

> [!NOTE]
> - Collector, which performs evaluation operations, also handles the allocation and removal of software licenses that have the **Automatically allocate** option enabled.

            - Evaluation Operations creates Collectors with the **Detect and Schedule Evaluation** option enabled.
            - Evaluation Operations is also created to re-evaluate software detections when a new version of [Software Product Library](../../../../../alvao-asset-management/software-management/custom-swlib) is loaded.
    - **Waiting status between the processing of blocks**- enter the length of the wait time between blocks in minutes.
    - **Perform detections only on computers that match the filter**- specify a filter defining the computers to be detected by this Collector instance.   

  Ex: If you want the Collector instance to detect only computers that are located somewhere in the "ALVAO Branch" object, use the filter:   

            EXISTS (
            SELECT *
            FROM tblNodeParent NP 
            INNER JOIN tblNode N ON NP.lintParentNodeId=N.intNodeId
            WHERE NP.lintNodeId=D.lintComputerNodeId
             AND N.txtName=N'Office ALVAO'
            )

> [!NOTE]
> This is a condition in the SQL query to the database that selects the requests to perform the detection.  

  The alias D appears in the sample, which represents the tblDetect table.
    - **Only perform evaluation operations for computers matching the filter** - Specify a filter that defines the computers for which this Collector instance should perform evaluation operations. The filter has the same format as the filter for performing detections.

> [!NOTE]
> Computers that are placed in a tree structure under an object of type *Stock* are not detected in any case.

- **Scheduling**- setup scheduling of computer detections.
    - **Detection Schedule (network load)**.
 - Enable if detections are to occur only at a specific time interval.
        - **Detect computers daily only in the following interval** - specify from when to when detections should take place.  

> [!NOTE]
> The intervals are stored in UTC and do not respect the transition between daylight saving time and standard time. For example, if you enter an interval in summer, it will be offset by an hour in winter and will be displayed as such in the settings.

> [!NOTE]
> This setting does not apply to the *Autonomous Agent* detection method.

        - **Exceptions (the schedule does not apply to the following days)**
 - Select days on which detections will be performed throughout the day (will not be subject to the detection schedule).

> [!TIP]
> By scheduling detections, it is possible to limit the load on the network, e.g. during operating hours when the full capacity of the network needs to be used.

    - **Schedule for evaluations and automatic detection loading (SQL Server load)**- Enable if the evaluation of detections is to be performed only at a specific time interval.
        - **Evaluate detections daily only in the following interval**- specify from when to when the evaluation should take place.  

> [!NOTE]
> See note for the detection schedule above.

        - **Exceptions (the schedule does not apply to the following days)**
 - Select the days on which the evaluation will run all day (will not be subject to the evaluation schedule).

> [!TIP]
> By scheduling the evaluation of detections, it is possible to limit the load on the SQL server, for example, during operating hours when employees access the database on this SQL server. Especially the evaluation of software detection is a demanding operation that can put a lot of load on the SQL server.

> [!CAUTION]
> This setting also affects the automatic detection loading feature.

- **Loading files**- Settings for manual computer detections.
    - **Automatic loading of manual detection files (\*.CXM)**- Enable if you want the server to load manual detection files from a specific folder.
        - **Automatically load CXM files from folder** - specify the path to the folder that Collector will monitor and load new detections into the database from. 

> [!CAUTION]
> The specified path is a folder on the configured machine, but the **...** button browses folders on the local machine. Set the path to match the structure of the disks and folders as seen from the configured server.

        - **If the loading process succeeded**
            - **Move the CXM file to the subfolder "Processed"**
 - select if the CXM file should be moved to the "Processed" folder after the detection is loaded.
            - **Delete CXM file** - select if the CXM file should be deleted after the detection is loaded.
        - **If loading failed**
            - **Move the CXM file to the subfolder "Failed"**
 - select if the CXM file that failed to load should be moved to the "Failed" folder.
            - **Delete CXM file** - select if the CXM file that failed to load should be deleted.

> [!NOTE]
> For automatically loaded detections, objects of type *Assembly* (computer) in the "Computers from loaded detections" folder at the root of the object tree. For a computer that already exists in the tree, the existing detection is only updated.

- **Sw Product Library** - setup updates to [Software Product Libraries](../../../../../alvao-asset-management/software-management/custom-swlib).
    - **Automatic Update**
        - **Download from the web**- turn on if Collector should automatically download the latest software product library from the web.
            - **Library availability verification period (days)** - specify in days how often to check if a new library of sw products is available on the manufacturer's website.
        - **Load from the backup** - this library update option is recommended to use if Collector does not have access to the Internet. Then, periodically once a week, download the [https://www.alvao.com/downloads/swlib2.swl](https://www.alvao.com/downloads/swlib2.swl) file from the web and save it to a folder on the server disk.
            Specify the path to the folder to match the disk and folder structure from the view of the configured server.
        - **Do not update** - Collector will not automatically update the library.
        - **Automatically evaluate existing detections against the new library** - Enable if you want to automatically evaluate existing software detections against the new library of software products.
    - **Send software product library change requests over the Internet** - turn on if you want Collector to send change requests to the software product library.  

 Change requests include *requests to add a new product*
 or *requests with unrecognized software*.
    - **Automatically search for unrecognized software**
 - Turn on if Collector should search the entire database for unrecognized software once a week.  

 Unrecognized records are saved and if you send requests for changes to the sw product library (option above), they will be sent to ALVAO technical support specialists who will add the unrecognized software to the standard library. 

> [!NOTE]
> Each stage (finding records and sending requests) can be performed by a different Collector.

> [!NOTE]
> The automatic search for unrecognized software will only be performed if the library in the database is less than one month old.

    - **Disclaimer for sending information on unrecognized and new software**
        - **If you need any additional information, you can contact me at e-mail** - select if technical support staff can contact you if needed and fill in the email contact person.
        - **I do not wish to be contacted. I want to send data anonymously** - select if you want to send data anonymously. Our specialists will not be able to contact you, so if some unrecognized products cannot be identified by the records you have sent, the product will not be included in the standard library.
