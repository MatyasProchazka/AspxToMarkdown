# Filter
     
Using a filter, you can display only rows in a table that meet a certain criterion. You can find the commands to work with the filter in the local table menu and also in the local header menu.
     
## Desktop applications
     
In the AM Console desktop application, the filter is controlled in a different way than in the web browser (ALVAO WebApp).   When the filter is enabled, the filter parameters are displayed in a row below the table header.
      ![Filter in table](filtering.png)     
Filter is turned on and off with the **Filter** command in the local menu in the table header.
      
### Filter by Selection
     
This command is useful when the table contains too many rows and we are only interested in a few. In that case, you can right-click on a specific cell and select **Filter by Selection** from the menu.   This will turn on a filter in the table that will show only the rows with the selected value.  If you want to filter by multiple values, first select the rows with those values in the table and then use *Filter by Selection* in that column.
     
For example, on the **Detection** tab in [main window](../../list-of-windows/alvao-asset-management-console), a long list of different detections can be displayed.  If we are only interested in software detections, i.e. rows that have a value of "software" in the *Species* column, we just need to find one row in the table with a software detection, right-click on the value in the *Species* column and select *Filter by Selection* from the menu.   This will turn on the filter in the table, which will only pass rows that have a value selected in the *Species* column.

> [!NOTE]
> The *Filter by Selection* command can only be placed in the *Table* submenu.

### Filter Out of Selection
     
This command is used similarly to the Filter by selection. The difference is that rows that have a value selected in the column are filtered out, and all others are passed through.  Also, you can use this command for multiple selected table rows at once.
      
## Advanced Filter
      
If the filter is enabled, you can manually change its settings in the row below the header. If you enter text in a column, only the rows whose value in that column contains the specified text will be displayed in the table. When comparing values, diacritics are ignored.  
         The asterisk represents any number of arbitrary characters, so if you enter, for example, "ar", the filter will only pass values that contain the substring "ar". Entering "\*ar\*" would have the same result, because the asterisk is added automatically at the beginning and end.  
         Another option is to enter a boolean expression into the filter, such as:
     
"\*ar\*" or "\*unk\*"
      Searched parts of the text must be enclosed in quotation marks. The following logical operators may be used in the expression:  
     
- and
- or
- not

      The keywords listed in the following table can only be used in column filters with Yes/No (boolean) values:  

| Keyword |
| --- |
| yes / yes |
| no / no |

For columns of type text, number and date and time it is possible to use mathematical operators *em> "&gt;"* (greater), *"&lt;"* (less), "&gt;=" (greater than or equal to), "&lt;=" (less than or equal to), *"!,Not,&lt;&gt;,!="* (negation, not, not equal to), *"=,=="* (equal to). The alphanumeric order of the texts is assumed when comparing them.
      
## Filter above columns of type "date and time"
     
If the column is of type "date and time", the following filter write options are supported:

- **@now** - displays entries from today's date and current time to the nearest hour.
- **@today** - displays entries from today's day only.
- **\*.M.YYYY** - displays data from month M and year YYYY
- **\*.\*.YYYY** - displays data from year YYYY
- **D.M.YYYY** - displays data from a specific day D.M.YYYY
- **D.M.YYYY H** - displays data from a specific day D.M.YYYY and hour H
- **D.M.YYYY H:M** - displays data from a specific day D.M.YYYY and hour H and minute M
- **operators:                    | Operator | Description | Example of use |    | --- | --- | --- |    | &lt;, &gt;, &lt;=, &gt;= | smaller, larger, less than or equal to, greater than or equal to | &gt;15.4.2013 |    | =, == | equals | =15.4.2013 |    | !=, &lt;&gt; | not equal | &lt;&gt;15.4.2013 |    | Not, ! | does not (same meaning as does not equal) | Not 15.4.2013 |    | and, or | logical product and logical sum | =15.4.2013 or =16.4.2014 |**

> [!NOTE]
> - Date formats **D.M.YYYY**, **D.M.YYY** can be written to the filter.

  M/D/YYYY
  and **YYYY-M-D**, the date separator can be followed by a space, the day and month digits can be written as single or double digits, the year must be written as a 4-digit number.
- If the **AND** or **OR** operator is used,
  some mathematical comparison operator (e.g. =) must also be specified.
- An integer representing the number of **hours** can be added/subtracted to the **@now** variable. The resulting time is calculated regardless of service hours, weekends and holidays. E.g. @now+10 means: in 10 hours.
- An integer can be added/subtracted to the **@today** variable to represent the number of **days**. The resulting date is calculated on a calendar basis, regardless of service hours, weekends and holidays. E.g. @today-1 means: yesterday.

### Examples

1. Today's data:  

            @today
2. Data for the last 30 days:  

            &gt;= (@today - 30)
3. Data from the following day:  

            = (@today + 1)
4. Data over the next 3 days:  

            (&gt; @today) AND (&lt;= (@today + 3))
5. Data from the next 5 hours from now:  

            (&gt; @now) AND (&lt;= (@now + 5))
6. Data as of 4/14/2017:  

            14.4.2017
7. Data as of 3pm on 10/24/2017:  

            15.10.24.2017
8. Data from the month of March 2017:  

            \* March 3, 2017
9. Data from 2016:  

            \*.\*.2016
10. Data from January to May 2018:  

            &gt;=1.1.2018 and &lt;1.6.2018
11. Data from October 5 and 6, 2017:  

            =5.10.2017 or =6.10.2017

## Variable @me
     
The @me variable represents the name of the currently logged in user. You can use it to filter out records related to the currently logged in user.
This variable is available in the ALVAO Service Desk:
- Requests - in the Applicant and solver columns
- Diary - in the From, To, Created by, Solver, Requester columns
- Request log table (bottom left) - in From, To, Created by columns
