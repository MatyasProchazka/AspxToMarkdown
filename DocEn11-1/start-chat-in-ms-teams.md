# Start chat in MS Teams
     
In the [Person](../../../list-of-windows/alvao-webapp/search/persons/person) page, which is accessible in many places in the application, users can use the button **Start chat** to start a chat in MS Teams with the displayed person. The button is enabled and visible by default for all users imported from Azure Active Directory. To hide this feature use this SQL script:  
        UPDATE tProperty SET bPropertyValue = 0 WHERE sProperty = 'WebApp.StartChatEnabled'  
        To re-enable and show the button run this SQL script:  
        UPDATE tProperty SET bPropertyValue = 1 WHERE sProperty = 'WebApp.StartChatEnabled'
