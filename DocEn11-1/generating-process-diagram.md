# GenerateProcessDiagram
      
## Function description
     
This application is used to generate a status diagram of a specified process in Microsoft Visio. This utility works only if Microsoft Visio is installed on the computer.
      
## Syntax command lines
      
**GenerateProcessDiagram.exe** {**/conn***"connection string"* | **/server** *"database server name"* **/db**         *"database name"*} { **/process** *&lt;process number&gt;* | **/processName** *"process name"*}
      
## Parameters

| Switch | Description | Mandatory |
| --- | --- | --- |
| /conn "string"  <br>
                    /server "server name"  <br>
                    /db "database name" | These parameters are used to set the connection to the Alvao database. You can use a connection string (e.g. **/conn** *"Data source=.\sqlexpress;Initial Catalog=test;Integrated Security=True;TrustServerCertificate=True"*),
  or simply specify a specific SQL server and DB (e.g. **/server** *".\sqlexpress"* **/db** *"test"*). | Yes |
| /process &lt;process&gt;number&gt;  <br>
                    /processName "process name" | These parameters identify the corresponding process. It is possible to use a process number (e.g. **/process** 1),
  or specify a process name (e.g. **/processName** *"General Request"*). | Yes |

## Examples of use
     
Display process status diagram by entering a simple SQL server login and process number:  
         GenerateProcessDiagram.exe /server ".\sqlexpress" /db "test" /process 1
