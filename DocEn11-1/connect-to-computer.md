# Connecting the reader to the computer
   
In order to copy files to the reader, you must first connect it to your computer.
   
1. Make sure you have "Windows Mobile Device Center" (Microsoft Windows Mobile Device Center) installed in Windows.
2. If it is not installed, [download it](https://www.google.com/search?q=%22Microsoft+Windows+Mobile+Device+Center%22+download) and install it.
3. Connect the reader to your computer using a USB cable.
4. The "Windows Mobile Device Center" will appear and select "Connect without setting up a device."  
> [!NOTE]
> If you have Windows 10 OS on your computer and after connecting the reader with the cable, "Windows Mobile Device Center" will not appear:

    1. Disconnect the cable with the reader from the computer.
    2. Launch a command prompt as administrator and the following commands in it:  

            REG ADD HKLM\SYSTEM\CurrentControlSet\Services\RapiMgr /v SvcHostSplitDisable /t REG_DWORD /d 1 /f
            REG ADD HKLM\SYSTEM\CurrentControlSet\Services\WcesComm /v SvcHostSplitDisable /t REG_DWORD /d 1 /f

> [!NOTE]
> after running the commands, the following information must be displayed

    3. Restart the computer.
    4. After Windows boots up, reconnect the reader to the computer with the USB cable.
