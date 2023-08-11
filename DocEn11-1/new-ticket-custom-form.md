# Custom request form from AM Console
      
If you want to use the [New request](../../../alvao-service-desk/request-object-links) command over the bulk object selection in AM Console to use a custom form from SD, use the following settings.
     
1. Create a custom form according to the [procedure in the SD book](../../../modules/alvao-sd-custom-apps/custom-form-template).
    - Use a custom model when implementing a custom form.
    - The form must support displaying the page using the HTTP GET method.
    - Expect a list of selected objects in the *Objects* parameter, which contains the comma-separated IDs of all selected objects in the AM Console.  

                    Ex: *Objects=54,134,1987,658*
2. Set the path to your custom form by running an SQL query over your Alvao database:  

            exec dbo.spUpdateInsertProperty 'AM.NewTicketFromObjects.CustomFormUrl', '~/Custom/&lt;function name&gt;/&lt;form name without .cshtml extension&gt;', NULL, NULL  

            Set the correct path to the custom form in the query.

## Disable the use of custom form
     
To disable the use of custom forms, run the following SQL query over your Alvao database:  
         delete tProperty where sProperty = 'AM.NewTicketFromObjects.CustomFormUrl'
