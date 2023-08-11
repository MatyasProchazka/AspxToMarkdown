# Physical asset check
      
Physical asset check consists of scanning labels with a mobile barcode scanner or a mobile phone with an app installed.
      
## Printing barcode labels
     
1. Create a file in *Microsoft Excel* that will contain a column called *Barcode* and below it the values you want to print on the labels.
2. Register to [Orca Scan](https://orcascan.com) and create a new worksheet.
3. Remove all columns from it except the *Barcode* column.
4. Upload the created XLSX file using the **Import** command, or enter the data into the *Barcode* column manually.
5. In the table, select the values you want to print and open the *Barcode Labels* menu in the left bar.
6. Select the type of labels you want to print (e.g. barcode or QR) from the menu.
7. Use the *Print Labels* command to print or download the labels to your device (PDF file).

## Orca Scan mobile app inventory
      
You can use the paid [Orca Scan](https://orcascan.com/) app for mobile phones and some barcode scanners to take asset check using barcodes. Follow these steps:

1. [Take asset check](stocktaking), create a reader file and assign the required assets to it.
2. Use the **File - Export XLSX** command and select the property containing the barcode values. If an asset has a barcode value stored in another property (e.g. *Serial Number, Inventory Number*), then open the file in *Microsoft Excel* and copy the values from the corresponding cells in the *Barcode* column. You can delete the rows that do not have a value in the *Barcode* column from the workbook, as they will not be inventoried anyway.
3. Register for [Orca Scan](https://orcascan.com/) and install the app on your mobile phone or other device.
4. Create a new sheet in the web app and remove all columns except the *Barcode* column.
5. Upload the XLSX file using the **Import** command. All necessary columns will be automatically created and all data will be replaced with the data from the imported file.
6. If this is the first time you have imported the file, right-click in the **Date** column header and select **Edit column**. Set the **Data type** item to those of **Date Time (automatic)**. Similarly, for the **ObjectId** column, turn on the **Readonly** option.

> [!TIP]
> For the columns you want to see in the asset list in the mobile app, turn on the **Edit column** option in the **Show in mobile list** menu. The first column with this option is shown as the asset name, the others as other items. If you enable this option in the **Date** column, you will then be able to sort the assets in the mobile app from not found to already found. In the mobile app, use the filter button in the top bar and select the **Sort by** column from the **Sort by** menu.

> [!TIP]
> For columns that you don't want to edit when confirming a property (or creating a new one), turn on the **Edit column** option in the **Hidden** menu.

7. Open the *Orca Scan* mobile app and pair it with the web app.
8. In the mobile app, switch the sheet to newly created and the bookmark to *cloud*.
9. Use the **Scan** button in the mobile app to retrieve the barcodes of all inventoried devices one by one. After reading the barcode, always check the correctness of the values in the fields and change them if necessary.

> [!TIP]
> If you are doing asset check by room or user, you can group your records by these columns. In the mobile app, use the filter button in the top bar and select **Group by**

                select the appropriate column.
10. After completing the asset check, use the **Export** command in the *Orca Scan* web app to download the XLSX (Microsoft Excel) file to your computer.
11. Open the downloaded file in *Microsoft Excel*, enable editing in the top yellow bar under the command bar, and save the file.
12. In the *AM Console* in the [asset check](../../list-of-windows/alvao-asset-management-console/tools/stocktaking) window, use the **File - Import XLSX** command and select the downloaded file.
13. Then [process the results](stocktaking) of the asset check.
