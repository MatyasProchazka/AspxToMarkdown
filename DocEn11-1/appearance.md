# Custom appearance
     
You can customize the look and feel of ALVAO WebApp to your organization's needs in *WebApp - Administration - Settings - [WebApp](../../../list-of-windows/alvao-webapp/administration/settings/webapp)*.
     
You can make more advanced appearance changes, such as changing colors, font cuts and sizes, graphic element sizes, etc., by creating a custom Cascading Style Sheet (CSS) file as follows:
     
1. In the folder with the WebApp installed in the **Custom** subfolder, create a folder with the company name. In it, create a **Theme** subfolder. This folder will contain all the customizations that affect the appearance. It should have the same hierarchy as the *Content*folder in the WebApp installation folder:
.    - Content/
        - img/ - images folder
        - fonts/ - folder with fonts
        - .scss - cascading style files

> [!NOTE]
> The *Custom/&lt;company-name&gt;* folder is used for custom forms.

2. In the **Web.config** file, in the **appSettings** section, set the **CustomThemePath** to the path to the *Theme* folder.For example, when the appearance customizations are in the *&lt;ALVAO WebApp installation folder&gt;/Custom/Company1/Theme*,then set the **CustomThemePath** entry to *"~/Custom/Company1/Theme"*.
3. Enable access to this folder for non-logged-in users (styles are also applied on the login page). In the **Web.config** fileFind the line *"&lt;location path="Scripts"&gt;"*. Add after it:
            
    &lt;location path="Custom/&lt;company name&gt;/Theme"&gt;  

                     &lt;system.web&gt;  

                      &lt;authorization&gt;  

                      &lt;allow users="\*" /&gt;  

                      &lt;/authorization&gt;  

                     &lt;/system.web&gt;  

                    &lt;/location&gt;

All SCSS files in this folder will be loaded on each WebApp page. These files are loaded last, so the rules have more weight than the rules in the system SCSS files in the *Content* folder.   All other files in this folder take precedence over files in the *Content* folder, including the image in the *img* folder.
      
## Variables
     
You can use the following variables in SCSS files. Variable value setting syntax: : "&lt;variable name&gt;: &lt;value&gt;;".

| Variable | Description |
| --- | --- |
| $navbar-bg-color | Color of the top navigation bar |
| $navbar-hover-bg-color | Colour of the elements in the top navigation bar after mouseover |
| $search-bg-color | Color of the search box in the top navigation bar if not active |
| $navbar-search-focus-bg-color | Color of the top navigation bar when the search field is activated |
| $navigation-sd-bg-color | Left navigation bar colour |

> [!NOTE]
> The ALVAO WebApp uses its palette of 7 shades of base color, which are used as the default colors for each graphic element. The individual shades are stored in the variables *$primary-color-dark-3*, *$primary-color-dark-2*, *$primary-color-dark-1*, *$primary-color*,

  *$primary-color-light-1*, *$primary-color-light-2*, and *$primary-color-light-3* (from darkest to lightest), with the base color stored in the *$primary-color* variable. You can change the palette, but you will need to make additional adjustments for a consistent WebApp appearance.

## Example
     
To change the color of the top navigation bar to red, create a folder *Custom/&lt;company name&gt;/Theme* and create an empty **Custom.scss** file in it. In the file, write the rule:
     
$navbar-bg-color: red;
     
or
     
.navbar-default  

            {  

             background-color: red;  

            }
     
Save the file.
     
In the **Web.config** file, set **CustomThemePath** to *"~/Custom/&lt;company name&gt;/Theme"*.
      
## Off custom appearance
     
In case you want to use the standard ALVAO WebApp appearance again, in the **Web.config** file, set **CustomThemePath** to an empty value.
     
## Backup Custom Appearance
     
It is recommended to back up the custom theme settings either as part of backups of the entire application server or by backing up the *Custom/&lt;company&gt;/Theme* folder.
       
## Upgrade Alvao
     
When upgrading to a new version of Alvao, there may be changes to the ALVAO WebApp cascading styles. Therefore, after upgrading, we recommend that you check the appearance of the WebApp and modify your own appearance if necessary.
