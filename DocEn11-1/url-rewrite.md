# Redirect from HTTP to HTTPS using IIS URL Rewrite
     
In case of problems with HTTP and HTTPS redirection, set up automatic redirection in IIS server using URL Rewrite.
     
## How to redirect from HTTP to HTTPS
     
1. Make sure you have IIS intranet server installed.
2. Download the **URL Rewrite** module and install it, see link below.
3. Ensure that port 80 is configured on the page you want to redirect to.
4. After installing the **URL Rewrite** module, its icon will appear in the page overview window in IIS Manager. If it does not appear, try restarting IIS.
5. Select the page, open **URL Rewrite**, select the **Add Rule(s)** action in the right pane. In the **Add Rule(s)** window
 select the *Blank rule* option and confirm.
6. In the open form, set the following:
    - Enter a name.
    - Match URL:
        - Select **Requested URL** from the **Requested URL** menu matches the **Pattern**.
        - Select **Using** from the **Wildcards** menu.
        - Enter "\*" in the text box and check the *Ignore case*.
    - Conditions:
        - From the **Logical grouping** menu, select *Match Any*.
        - Select **Add**. In the window that opens, in the *Strong> Condition input*
                    Type *{HTTPS}*, select *Matches the Pattern*,
 enter *off* in the last field and confirm.
    - Action:
        - Select *Redirect* from the selection.
        - In the text box, type *"https://{HTTP\_HOST}{REQUEST\_URI}"*.
        - Do not enable/disable the *Append query string.*
        - Select *Permanent (301) from the **Redirect  type** menu.*
7. In the actions on the right side, confirm the rule by clicking on *Apply*.
8. The rule is added and can be turned off/on using *enable*,
 *disable*.

> [!NOTE]
> Adding a rule using **URL rewrite** will be reflected in the web.config file as follows:  

            &lt;rewrite&gt;

               &lt;rules&gt;  

                   &lt;rule name="Redirect to http" enabled="true" patternSyntax="Wildcard" stopProcessing="true" &gt;

                     &lt;match url="\*" negate="false"/&gt;  

                     &lt;conditions logicalGrouping="MatchAny"&gt;

                           &lt;add input="{HTTPS}" pattern="off"/&gt;  

                      &lt;/conditions&gt;  

                    &lt;action type="Redirect" url="https://{HTTP\_HOST}{REQUEST\_URI}" redirectType="Permanent" /&gt;  

                  &lt;/rule&gt;  

               &lt;/rules&gt;  

            &lt;/rewrite&gt;  

> [!CAUTION]
> This modification interferes with IIS settings. This is not a modification to the Alvao configuration.

### Links
     
For more information, please visit Microsoft's website - [https://blogs.technet.microsoft.com/dawiese/2016/06/07/redirect-from-http-to-https-using-the-iis-url-rewrite-module/](https://blogs.technet.microsoft.com/dawiese/2016/06/07/redirect-from-http-to-https-using-the-iis-url-rewrite-module)
