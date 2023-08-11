# Distributing msi package via SCCM
      
## Summary
      
This guide is for creating a rule to distribute *.msi* package via SCCM and then convert it to the desired .*mst* format.
      
## Designed for products
      
- ALVAO Outlook Addin
- Asset Management Agent

## Starting Conditions
      
- Microsoft Software Center Configuration Manager  
         - to transform *.msi* package to *.mst* you need to have Orca software installed
       
## Progress

1. Connect to the **server** on which you have **SCCM** installed.
2. Start **Microsoft Endpoint Configuration Manager**.
3. Software Library - Application Management - Applications - Create Application.
4. Use the **Browse** button to select the installation file (*\*.msi*) you want to specify for deployment and continue with the wizard. 

                ![Create Application Wizard](app_wizard.png)
5. On the **General Information** tab, in the **Installation program** field, enter the following string:

    - For **OA**:  msiexec /i "AlvaoOutlookAddIn.msi" /qn TRANSFORMS="AlvaoOutlookAddIn.mst"
    - For **AM Agent**:  msiexec /i "AlvaoAssetAgent.msi" /qn TRANSFORMS="AlvaoAssetAgent.mst"

            Set **Install behavior** to **Install for user**.

### Deploy applications

1. Right click on the created application - **Deploy**.
2. Select the collection to which you want to apply the deploy.
3. On the **Content** tab, select **Distribution point**.
4. Set the **Deployment Settings**-**Purpose** tab to **Required**.
5. On the **User Experience** tab, select **Software Installation**.

### How to transform .msi package to .mst package for Asset Management Agent, Outlook Addin
     
If you are distributing ALVAO Asset Management Agent or ALVAO Outlook Addin on a client device, you need to modify the installation msi packages using **Orca** software and create a *\*.mst package*. If you do not modify the installation files, the AM Agent and Outlook Addin will not work properly. If necessary, each user must then set up the applications manually.

1. Select the installation package to which you want to create the transformation.
2. From the local menu, use the **Edit with Orca** command.
3. Use the **Transform - New Transform** command from the main menu.
4. Select **Property** in the table view on the left side.
5. Use the **Add Row**local menu command in the property overview, or use the Ctrl+R keyboard shortcut.
    - For **OA** see [ALVAO Outlook Add-in - Installation](../../../modules/alvao-outlook-addin/installation).
    - For **AM Agent** - specify **APIUrl** as the property name (*Property*) and set the property value (*Value*) to the current *REST API* address. (for example, http://localhost/restapi/restapi.asmx).

                Then insert another line (Ctrl+R) and insert the name of the property (*Property*) **AUTH\_CODE** and add the value of the property (*Value*) with the appropriate code.

> [!CAUTION]
> Caution:

it is required that the property name be capitalized.

6. Use the command from the main menu **Transform - Generate Transform**.
7. A dialog will appear to save the file.
8. Select the directory where the source installation package is located.
9. Switch the file filter to **All files (\*.\*)**.
10. Select the installation package.
11. Switch the filter back to **Windows installer transform (\*.mst)**.
12. Press the **Save** button.
13. Close the Orca editor window.
