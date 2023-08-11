# ALVAO Outlook Add-in
     
**ALVAO Outlook Addin** is an add-in for Microsoft Outlook that allows you to work with requests in **ALVAO Service Desk** directly in the Microsoft Outlook environment.
      
## Overview of terms used

| Concept | Meaning |
| --- | --- |
| Target request | Request detail in ALVAO WebApp within [ALVAO Task Panel](../list-of-windows/ALVAO-Outlook-Addin/task-pane) regardless of the currently displayed tab (General, links, ...). |
| Adjustment schedule | In this mode, there is no [ALVAO Task Panel](../list-of-windows/ALVAO-Outlook-Addin/task-pane) is updated in any way by changing the selected item. |

## Requests display
     
1. In MS Outlook, select the item (email, event, meeting, task) that has a valid request tag in the subject from **ALVAO Service Desk**
            (e.g. T123ALVAO).
2. In [ALVAO Task Panel](../list-of-windows/ALVAO-Outlook-Addin/task-pane), the request log (*target request*) will be displayed.

Tips:

        The *target request* can be worked with directly in MS Outlook using the commands provided by the **ALVAO WebApp**.

        To work with the request in a separate window outside of Outlook, use the **View Request** command from the local menu above the message to open the request in the **ALVAO WebApp**.    

        Another option is to use the **Open in separate window** in the header of [ALVAO Task Panel](../list-of-windows/ALVAO-Outlook-Addin/task-pane).

## Creating a new request from a message
     
Use the following procedure to create requests in ALVAO Service Desk based on messages that are not yet related to any requests.

1. 1. In MS Outlook, select one or more messages from which you want to create requests in ALVAO Service Desk. One request will be created for each message.
2. On the **Home** tab, select the **New request from message** command, or select this command from the local menu above the selected message.
3. In the window [New request from message](../list-of-windows/alvao-outlook-addin/ticket-from-mail), select the requester, the service, edit the name of the request if necessary, and press the **OK** button.

Notes:

        The default requester of a newly created request is the sender of the message.  If the sender is not recognized, an unregistered user (Host) is selected. The request is created with the default SLA of the selected requester.  

        All initial prefixes RE: and FW: are removed from the message subject.  

        If only one request has been created and the ALVAO taskbar is not in edit mode, the taskbar will display the created request.  Otherwise, the contents of the taskbar will not change.  

        For each request, notifications are sent to the main solvers and Requesters of the request.

## Save a message to the log of an existing request
     
Use the following procedure to save selected messages that are not related to any request (i.e., do not have a request marker in the subject line) or are not saved in the request log (e.g., because they were not sent in a copy to the service address) to the log of an existing request.

1. In MS Outlook, select the message(s) you want to save to the log of an existing request.
2. If you do not have displayed [ALVAO Task Panel](../list-of-windows/ALVAO-Outlook-Addin/task-pane), display it using the **View Taskbar** on the **Home**.
3. In the ALVAO Taskbar, search (e.g. with the *Search Requests* command) for the target request in whose journal you want to save the messages.
4. On the **Home** tab, select the **Save to request log** command, or select this command from the local menu above the selected message.
5. A window will appear on the screen prompting you to confirm the action. Check the request number in the prompt and confirm the action with the **Yes** button.

Notes:

        The retrieved messages are saved in the request log with the time of sending, and therefore they may not be displayed immediately at the top of the log when sorted by **Date** column, they are placed chronologically after any more recent entries.  

        If the sender of the message is not recognized, the Host is listed as the sender (the sender's email address is displayed in the log).  

        If the retrieved message does not have a subject, the placeholder "(no subject)" is used. Quotation marks are not part of the string.

## Create a new Outlook item based on a request
     
For a request that is currently displayed in the ALVAO taskbar, you can create a new Outlook item, i.e., an email message, event, appointment, or task, with a command in the taskbar **New item from request**.           
         In the form to create the item, the subject line is automatically populated with the tag and name of the selected request.
      
## Finding the target request to process unrecognized items
     
If the selected item is without a valid request tag in the subject, users are  [ALVAO Task Panel](../list-of-windows/ALVAO-Outlook-Addin/task-pane)         request reports are available to the user, from which can quickly select a *target request*, which he can then use, for example, to save a message in the request log.

Notes:

        Using any of the links will go [ALVAO Task Panel](../list-of-windows/ALVAO-Outlook-Addin/task-pane)
        to *edit mode*.  

        Closed requests are also listed in the reports.

### Last communication with sender
     
The section lists up to 5 requests in which the sender (or meeting organizer or task author) last communicated, i.e. is the sender (or author) or recipient of at least one journal entry.
     
The list is sorted by date column **Person's last activity**.
     
To view all of a sender's communications, use the **View more** link at the end of the section.

Notes:

The section is not displayed if:

- no item is selected
- the email address of the sender (or meeting organizer or task creator) is not maintained in the **ALVAO Service Desk**.
- all items in the group of selected items do not have the same email address of the sender (or meeting organizer or task creator)
- user does not have permission to view requests

### Last viewed requests
     
No more than 5 recent *requests* are listed in the section. Target *requests* that are not listed in the **Last Sender Communications** section.
     
To view all requests, use the **Requests.**
     
## Setting up the ALVAO add-on
      
To set up the add-on, use the **File - ALVAO Add-in Settings**, which will display the [ALVAO Add-on Settings](../list-of-windows/ALVAO-Outlook-Addin/options).
