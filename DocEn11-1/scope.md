# Scope
 
Use this tab to specify the range in which computers will be detected.
 
Options:

- **Detect Hardware**- turn on if you want to detect computer hardware.
    - **Update objects in tree** -
 turn on to automatically write detected hardware objects to the object tree.
- **Detect Software**- turn on if you want to detect computer software.
    - **Normal (registry, services, and selected files)** - select if you are happy to detect SW by normal detection. 

> [!NOTE]
> *Normal* detection detects data from the Windows system registry and data about files that are launched from the **Start** menu or the Desktop. This option is faster and in practice is usually fully satisfactory.

    - **Full (registry and all files on local hard drives)** - select if you want to detect SW with full detection. 

> [!CAUTION]
> With *Full* detection, data from the Windows system registry and data about all executable files on the computers' hard drives are collected, which can be time consuming.

    - **Include Files** - Specify a mask for the names of folders and files to be searched during detection.   
For example, if you only want to search for files with *exe* and *dll*, specify the mask *"\*.exe;\*.dll"*.
   
The default search is for files with the extensions *exe*, *com*, *dll*, *ocx*, *drv* and *scr*.
    - **Omit Files** - Specify a mask for the folder and file names to be omitted during detection.   
For example, to skip the *System Volume Information* folder, enter *"\*\System Volume Information\\*"*.   

 If the include and omit file masks conflict with each other, the omit mask takes precedence.
    - **Update installation log** -
 Enable to automatically write the information about the found software to the Installation Log.
- **Options:**
    - **Use different detection methods** -
 Check this box if you want to detect hardware and software in different ways.
    - **Reset all computers** -
 Check this box if you want to reset the detection settings for all computers in the inventory. All individual detection settings for computers will be removed and these settings will be used for new detections in the future.
- **Automatic Detection Scheduling**
    - **Hardware and Software Detection Period**
 - Specify the number of days after which to automatically perform detection. A value of 0 means that scheduling will be disabled and detections will not be performed repeatedly.
- **Agent Verification**
    - **Agent Authentication Code** - Enter the code used to authenticate autonomous Agents when communicating with the Web Service. You must enter the same code when installing Agents. This code can also be blank.
