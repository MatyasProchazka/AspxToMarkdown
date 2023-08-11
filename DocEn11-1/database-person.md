# Custom functions to select person
     
The *Person* input field is used in forms to specify a person, such as an applicant, investigator, note author, etc. The field allows you to search and select a person from a menu. The field is used in the following form commands.
     
- New Request
- Submit (also in bulk)
- Edit request (also in bulk)
- Move to another service (also in bulk)
- New Note (also in bulk)
- New Event
- Approve
- My Team - New/Edit

## System Behaviour
     
In ALVAO WebApp, the *Person* field displays values in two rows. The first line displays the **user name**. The second line displays **department; office; personal number; organization; work phone; mobile number**.
     
The text entered in the field is searched in all columns displayed. It is possible to enter part of the values from several items. The values must be separated by a space and in the same order as they appear in the whisper. Prompted items are sorted by user name.
      
## Custom functions
     
If you wish to change the way you search, sort and display values in the person field, add the **spPersonSearch\_Custom2** procedure to the database.  
         If the *spPersonSearch\_Custom2* procedure is defined in the database, it will always be used for the person menu instead of the default *spPersonSearch* procedure.  
         The *spPersonSearch\_Custom2* procedure has the same inputs and outputs as the existing [spPersonSearch](../../alvao-asset-management/implementation/customization/database#P-dbo.spPersonSearch) procedure.
