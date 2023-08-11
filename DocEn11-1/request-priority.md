# Request priority
      
Request priorities are defined in the tColumnValue table.
     
You can change the priority names using the following SQL script, where you set the new priority name (@newValue) and the weight of the priority you are changing (@priority 1-5):

    DECLARE @newValue varchar(30) = N'lowest';
    DECLARE @priority int = 1;
    
    UPDATE tColumnValue
    SET mColumnValue = @newValue,ColumnValueShort = @newValue
    WHEREliColumnId = (SELECT iColumnId FROM tColumn WHERE sTable = 'tHdTicket' AND sColumn = 'Priority') AND nOrder = @priority

> [!NOTE]
> Edit and run the script for each priority that is changed.
