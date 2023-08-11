# Basic Troubleshooting
     
This page provides basic tools and procedures for diagnosing problems with ALVAO products. The output of the relevant procedures can be sent along with the problem report to ALVAO technical support. Sending the diagnostic outputs will greatly speed up and facilitate troubleshooting.
      
## Web communication recording
     
A progress is made if an operation with the ALVAO WebApp is slow. Turn on communication recording just before invoking a slow function and stop it when the action is complete.
     
Execute the progress in Internet Explorer. The procedure is shown for Internet Explorer 10, but the procedure is almost the same in other versions.
      
1. Prepare the page in the WebApp so that the next click results in a slow response.
2. Use the Tools - Developer Tools menu (F12).
3. Go to the network tab.
4. Press the Start Capture button.
5. Take an action on the web page that takes a long time.
6. Press the Stop Capture button.
7. Use the Export captured traffic function.

The exported communication log file usually has the extension `.har`. These files can be viewed, for example, in online [HTTP Archive Viewer](http://www.softwareishard.com/har/viewer/)         or [Google HAR Analyzer](https://toolbox.googleapps.com/apps/har_analyzer/).

> [!CAUTION]
> The exported record file may contain sensitive information. Do not leave it on publicly accessible storage.
