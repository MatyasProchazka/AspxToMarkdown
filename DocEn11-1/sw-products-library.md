# SW products library
       
On this page, specify settings for automatic updates of the software products library.
       
Options:
     
- **Auto update**
    - **Download from Internet**- turn on if Alvao should automatically download the latest software product library from the Internet.
        - **Library availability verification period (days)** - specify in days how often to check if a new library of sw products is available on the manufacturer's website.
    - **Load from backup** - this library update option is recommended to use if the Alvao Service application does not have access to the Internet. Then, periodically once a week, download the [https://www.alvao.com/downloads/swlib2.swl](https://www.alvao.com/downloads/swlib2.swl) file from the web and save it to a folder on the server disk.
        Specify the path to the folder to match the disk and folder structure from the view of the configured server.
    - **Do not update** - Alvao will not automatically update the library.
- **Evaluate existing detections based on new library automatically** - Enable if you want to automatically evaluate existing software detections against the new library of software products.
- **Send requests for changes in software products library over Internet** - turn on if you want Alvao to send change requests to the software product library.  

            Change requests include *requests to add a new product*
            or *requests with unrecognized software*.
- **Search for unrecognized software automatically**
            - Turn on if Alvao should search the entire database for unrecognized software once a week.  

            Unrecognized records are saved and if you send requests for changes to the sw product library (option above), they will be sent to ALVAO technical support specialists who will add the unrecognized software to the standard library.

> [!NOTE]
> The automatic search for unrecognized software will only be performed if the library in the database is less than one month old.

- **Disclaimer for sending information on unrecognized and new software**
    - **If you need any additional information, you can contact me by e-mail** - select if technical support staff can contact you if needed and fill in the email contact person.
    - **I do not wish to be contacted. I want to send data anonymously** - select if you want to send data anonymously. Our specialists will not be able to contact you, so if some unrecognized products cannot be identified by the records you have sent, the product will not be included in the standard library.
