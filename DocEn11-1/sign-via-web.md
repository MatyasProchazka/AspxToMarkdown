# Web signing
      
In this method of signing the handover protocol, the recipient confirms the acceptance of the property by pressing a button in the application. It is not necessary to print the handover protocol on paper and the recipient can confirm it with any device with a web browser (PC, mobile phone, tablet, ...) without any special technical equipment.
      
## Settings
     
After issuing a new transfer protocol, the application automatically notifies the recipient by e-mail of the need to sign it. In **WebApp - Administration - Asset Management - Settings -**[Signing documents via the web](../../list-of-windows/alvao-webapp/administration/asset-management/settings/electronic-handover-forms) first set the message text and other notification parameters.
      
## Publishing the handover protocol
     
1. When [building a transfer protocol](../../alvao-asset-management/documents/transfer-protocols), select the **Transfer Protocol Internal Summary** protocol template.  

> [!NOTE]
> Returns of individual assets via the *Difference Transfer Protocol* cannot be confirmed electronically, so we recommend using the *Transfer Protocol Summary*. By signing the protocol, the user always confirms the complete list of assets and thus has a better overview of the current status of the entrusted assets.

2. On the [form](../../list-of-windows/alvao-webapp/objects/object/print), select **Method of Signing** *Through the Web*.
3. After pressing **OK**, you will see a [preview](../../list-of-windows/alvao-webapp/objects/object/print/preview) of the print report where you can review the handover protocol.
4. Send the report using the **Send** command. An email will be sent to the recipient with a link to the ALVAO WebApp where they can view and sign the handover protocol.

> [!NOTE]
> The recipient's email address comes from *ALVAO WebApp - Administration - Users* and not from the object tree. The pairing of users between *Administration* and objects is based on GUID, personal number, username, and email (in that order).

## Signing the protocol via the web
     
The employee to whom the property is being handed over will receive an email with a message that the property has been handed over to them and their signature is required.  
         In the text of the email is a link to the user's documents page on the ALVAO WebApp.
     
To sign the handover protocol:

1. Go to the **My Documents** page.
2. Open the requested document and review it.
3. Click **Sign** next to the document.
4. You will then be asked if you agree with the content of the document.
5. Select **Confirm** to sign the handover protocol and record the date, the person who signed it and the name of the computer from which the signature was made.

> [!NOTE]
> When signing the log, you can also force a login password to make the signing more provable. This behavior can be set in *ALVAO WebApp - Administration - Asset Management - Settings -*

  [Signing documents via the web](../../list-of-windows/alvao-webapp/administration/asset-management/settings/electronic-handover-forms) by selecting *Require login password when signing*.

## Signature control
     
To check the signing status of a document, use the following procedure:

1. In the **AM Console**, select **Tools - Lists - Documents** from the main menu.
2. In the list that appears, view the **Signature Method, Signed, Signed by and Signed from Computer** columns.
3. Search (e.g. using a filter) for the desired document, the signing method has **Web signing**.
4. A document is signed if the **Signed** and **Signed by** columns contain the date and the person who signed it. The **Signed from computer** column then contains the name of the computer from which the document was signed.

## Changing the signing method
     
If the report has been signed in a different way (e.g. you have printed the handover protocol afterwards and the recipient has signed it manually) and you wish to change the signing method, please proceed as follows:

1. In the **AM Console**, select **Tools - Lists - Documents** from the main menu.
2. Select the desired handover protocol from the list and select **Edit**.
3. Set *Signature Method* to the desired value.
