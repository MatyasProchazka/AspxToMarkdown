# ALVAO WebApp Traffic Analysis
      
## Turn off traffic analysis for ALVAO WebApp
     
1. Create a Google account (if you have a Google account, skip this step).
2. Sign in at [https://analytics.google.com/analytics/web/#/provision](https://analytics.google.com/analytics/web/#/provision) with your Google account.
3. Click **Start measuring**.
4. Fill out the form to create a new Google Analytics account.
    - **Create an account**
        1. Enter a Google Analytics account name (for example, your company name) and set up account information sharing.
    - **Setting up the service**
        1. Enter the name of the page where you have your ALVAO WebApp. For example, your\_company\_name\_WebApp.
        2. Select the correct *Time Zone* and *Currency*.
    - **Information about your company**
        1. Fill in your company information.
5. After accepting the terms and conditions and creating an account in the **Admin** section, select *Web* from the **Data Streams** menu.
6. Enter the URL to the site where you have the ALVAO WebApp. You can copy the URL from **WebApp – Administration – Settings – WebApp – WebApp (URL)** and enter the name of the stream and click **Create stream**.
7. From the newly opened **Web stream details** window, enter the **Measurement ID** value into the database using the following command:

            <font face="Consolas" size="2" color="#0000ff">INSERT INTO</font> <font face="Consolas" size="2" color="#008080">tProperty</font> <font face="Consolas" size="2" color="#808080">(</font><font face="Consolas" size="2" color="#008080">sProperty</font><font face="Consolas" size="2" color="#808080">,</font> <font face="Consolas" size="2" color="#00808080">sPropertyValue</font><font face="Consolas" size="2" color="#808080">)</font> <font face="Consolas" size="2" color="#0000ff">VALUES</font> <font face="Consolas" size="2" color="#808080">(</font><font face="Consolas" size="2" color="#FF0000">&#39;WebApp.GA.TrackingID&#39;</font><font face="Consolas" size="2" color="#808080">,</font>
            <font face="Consolas" size="2" color="#FF0000">&#39;UA-XXXXXX-Y&#39;</font><font face="Consolas" size="2" color="#80808080">);</font>

            where the **Measurement ID** value will be inserted in place of UA-XXXXXX-Y and the quotation marks will be retained.
8. First statistics should be available after about 24 hours. You can view the statistics by logging into your Google Analytics account by clicking on the **tab**
            Reports.

## Changing traffic analysis scripts

1. Sign in at: [https://analytics.google.com/analytics/web/provision/#/provision](https://analytics.google.com/analytics/web/provision/#/provision)with your Google account.
2. After logging in under **Admin**, select the appropriate website from the **Data Streams** menu.
3. After opening the **Web stream details** window, in the **Tagging instructions** section, select **Add new on-page tag – Global site tag (gtag.js) Use this if you're using a website builder or CMS-hosted site** to display the code for traffic analysis.
4. Copy and paste the code shown into this SQL script:  

            <font face="Consolas" size="2" color="#ff00ff">UPDATE</font> <font face="Consolas" size="2" color="#008080">tProperty</font>

            <font face="Consolas" size="2" color="#0000ff">SET</font><font face="Consolas" size="2" color="#008080">sPropertyValue</font> <font face="Consolas" size="2" color="#808080">=</font> <font face="Consolas" size="2" color="#FF0000">&#39;your_adjusted_code_for_measuring_visit_analysis&#39;</font>

            <font face="Consolas" size="2" color="#0000ff">WHERE</font> <font face="Consolas" size="2" color="#008080">sProperty</font> <font face="Consolas" size="2" color="#808080">=</font> <font face="Consolas" size="2" color="#FF0000">&#39;WebApp.GA.TrackingCode&#39;</font><font face="Consolas" size="2" color="#808080">;</font>
5. In the **embedded code**, replace all apostrophes with quotation marks.
6. Replace all occurrences of **Measurement ID** with "{0}".
7. Run the SQL script.

## Changing Measurement ID for traffic analysis
     
Change the **Measurement ID** in the database by running the following command in the database:           
          <font face="Consolas" size="2" color="#ff00ff">UPDATE</font> <font face="Consolas" size="2" color="#008080">tProperty</font>           
         <font face="Consolas" size="2" color="#0000ff">SET</font><font face="Consolas" size="2" color="#008080">
sPropertyValue</font> <font face="Consolas" size="2" color="#808080">=</font> <font face="Consolas" size="2" color="#FF0000">&#39;UA-XXXX-Y&#39;</font>           
         <font face="Consolas" size="2" color="#0000ff">WHERE</font> <font face="Consolas" size="2" color="#008080">sProperty</font> <font face="Consolas" size="2" color="#808080">=</font> <font face="Consolas" size="2" color="#FF0000">
&#39;WebApp.GA.TrackingID&#39;</font><font face="Consolas" size="2" color="#808080">;</font>           
         where 'UA-XXXX-Y' is the new **Measurement ID**.
      
## Turn off search tracking

1. Sign in at [https://analytics.google.com/analytics/web/provision/#/provision](https://analytics.google.com/analytics/web/provision/#/provision) with your Google account.
2. After logging in under **Admin**, select the appropriate website from the **Data Streams** menu.
3. After opening the **Web stream details** window, in the **Enhanced Measurement** section, select the gear icon.
4. After opening a new window, in the **Site search – Show advanced settings** section, in the **Search Term Query Parameter** field, leave the value "search", delete the rest.
5. Save the settings using the **Save** button.
6. Search statistics can be found in the sidebar on the left under **Reports – Engagement – Events**.
