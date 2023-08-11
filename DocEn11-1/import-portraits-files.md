# Import user portraits from files
     
## User portrait folder
     
1. Create a folder with user portraits on the server disk, e.g. "C:\ProgramData\ALVAO\Portraits".
2. Into this folder, insert image files with user portraits in the following format:
    - File name must match the user name of the user (see *ALVAO WebApp - Administration* - [Users](../../../list-of-windows/alvao-webapp/administration/users)
                    - *User Name* column).
    - The recommended image size is 133x200 px (width x height).
    - Image format must be JPEG (extension .jpg).

            For example, the user "user1@company.local" will have the portrait saved in the file "C:\ProgramData\ALVAO\Portraits\user1@company.local.jpg".
3. Add portraits of new users to this folder on an ongoing basis.

            Tip:
        You can also store portraits in subfolders based on user domains.  In the portrait folder, create a subfolder for each network domain you use. The name of the subfolder must be the same as the domain name in the old username format (see ALVAO WebApp - Administration - [Users](../../../list-of-windows/alvao-webapp/administration/users)
        - *User Name column (for older systems)*).  

        For example, for a user with the username "company.local\user1", the portrait "user1.jpg" will be stored in the folder "C:\ProgramData\ALVAO\Portraits\company.local".

## Regular automatic import
     
On the server, create a scheduled task with a recurrence period of e.g. 1 time per day that runs the following command:
     
%ProgramFiles%\ALVAO\AlvaoService\utilities\ImportPortraitsFiles.exe /server &lt;sql\_server&gt; /db &lt;database\_alvao&gt; /path "C:\ProgramData\ALVAO\Portraits"

> [!NOTE]
> This task can optionally be created when you install ALVAO Server using [ALVAO Server Setup](../installation).

## One-time import
      
For a one-time import of portraits, run a scheduled task created on the server, or run the *ImportPortraitsFiles* application directly from the command line. The application can be found in the ALVAO Asset Management Console installation directory ("%ProgramFiles%\ALVAO\Asset Management Console\ImportUtilities"),or you can copy it from the application server from the ALVAO Service installation directory ("%ProgramFiles%\ALVAO\AlvaoService\utilities").
      
## Utility ImportPortraitsFiles
      
The ImportPortraitsFiles utility loads user portraits from files stored on disk into the Alvao system.
     
The utility is part of the ALVAO Service installation and is installed in the same folder, usually in "%ProgramFiles%\ALVAO\AlvaoService\utilities".
      
### Command line parameters

| Parameter | Description | Mandatory | Example |
| --- | --- | --- | --- |
| /conn &lt;string&gt;  <br>
                    /server &lt;server&gt;  <br>
                    /db &lt;db&gt; | Setting the DB connection. | Yes | /conn "Integrated Security=True;Initial Catalog=ALVAO;Data Source=.\SQLEXPRESS;TrustServerCertificate=True" /server .\SQLEXPRESS /db ALVAO |
| /path | Disk path to the portrait files folder. | Yes | /path "C:\ProgramData\ALVAO\Portraits" |
| /email | The files are named according to the users email.  <br>
> [!NOTE]
> Files may not be subfoldered by domain. | No | /email |

| /wait | Wait for a keystroke at the end of the import. | No | /wait |
