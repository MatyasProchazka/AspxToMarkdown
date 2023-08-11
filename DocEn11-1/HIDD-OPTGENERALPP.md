# Settings - General
 
Options:

- **Databases**
    - [Set up connection](../../alvao-asset-management-console/file/db-manager)- database connection for Collector.
    - **Database connection timeout (s)** -
 specify the timeout for working with the database in seconds. The default value is 300s.
- **Start**
    - **Start as application after user logon** - enabling this option will register Collector to start automatically when the user logs on to the computer.
- **Protocol**
    - **Log events** -
 Enable if you want to generate a log of Collector activity.  The log is stored in the *AlvaoCollector* event log.
    - **Detail**- select the detail of the generated log:
        - **Status and Errors** - only the regular "liveness" report of the detection and scanning threads is written to the log, as well as any errors.  This level is sufficient for normal system operation.
        - **Medium** - in addition, data on detections made, etc. is logged.
        - **Detailed** - detailed information about the Collector operation is written.

> [!CAUTION]
> If you set the log file detail to the **Detailed** level, the Collector will generate a large amount of data in the LOG file and the detection rate will be very slow. Therefore, setting it to the **Detailed** level is only recommended for troubleshooting and is not recommended for normal operation.

    - **Record the liveness (heartbeat) status of the detection and scanning process with a period (hours)** - specify the interval in hours after which the "liveness" status of the detection and scanning threads will be logged. These messages are used to check the correct functionality of these threads and are always written to the log, for whatever detail is set.
