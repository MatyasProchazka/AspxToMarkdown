# ALVAO Teams Add-in
     
ALVAO Teams Add-in is an add-in for Microsoft Teams that allows you to:
     
- create a new request in Alvao from a message,
- conveniently search for requests,
- insert links to requests in the messages you send,
- receive notifications from Alvao.

## Technical Requirements

- ALVAO Service Desk (provided as SaaS)
- User authentication using Azure Active Directory

## First launch of the add-on
     The first time you run the add-on, enter the address of your ALVAO REST API provided by your Alvao administrator.  
     Then log in using your Azure Active Directory account.    
## Creating a new request from a message

1. In **MS Teams Chat** hover over the message to display commands, click the three-dot button and select **More actions – Create request in Alvao**.
2. Fill in the form with additional information.
3. Submit the dialog and the request will be created in Alvao. A new card with details of the request will be inserted into the compose message area.

## Inserting a request link into a message

1. In **MS Teams**, type **@alvao** in the chat or team channel message, or select the *Alvao* app in the command bar under the message input field.
2. The add-on will automatically give you the 5 requests you last worked with in Alvao.
3. If you want to search for another request, type at least part of the request name, the request number, part of the service name, the Requester name, or the solver name in the input line. The add-on will offer you requests matching the text you entered.
4. Select the request you are looking for from the menu. This will insert a tile representing the request into the chat or channel message. If the recipient of the message clicks the *View Request* button at the bottom of the tile, they will see the page for that request in the Alvao WebApp.

> [!NOTE]
> You can also insert the request tile into the message text by pasting the url of the request page in the *Alvao WebApp*. The url will automatically change to a tile.

## Request search

1. In MS Teams, type **@alvao***in the search bar in the window header.*
2. Enter at least part of the request name, request number, or other information by which you are searching for the request in the input line of the add-in. The add-in will offer you requests matching the text you entered.
3. Click the request you are looking for in the menu. The request tile will appear below the input line. In the tile, press the **View request** button. This will display the request page in the web browser.

> [!TIP]
> You can click on the icon in the top right corner to copy the tile to your clipboard and then paste it into a chat message or team channel.
