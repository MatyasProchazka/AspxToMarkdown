# Firewall settings
      
### Setting up the Windows Firewall using the command line
     
When Windows XP SP2 and above is installed, the Windows Firewall is activated and by default does not allow remote access. The Netsh command is used to set up the Windows firewall. The Netsh command is a command-line scripting tool that interacts with other operating system components through dynamic-link library (DLL) files. How to modify the configuration of firewall services using the Netsh command is explained below.

- **No Agent** - Enable remote administration. Remote Admin must be enabled for communication between the Collector and the detected computer, which is disabled by default on the Windows firewall. 
            
    Procedure to enable remote admin via command line (Cmd.exe) on the local station

        netsh firewall set service RemoteAdmin enable subnet

    If you want to enable remote administration remotely, you can use the freeware utility PsExec and the Cmd.exe command line. Basic PsExec syntax:

    psexec [\\computer[,computer[,...]] [-u user] [-p pswd]] cmd

    Parameters:

    - **\\computer** - the computer on which cmd will run. If you use \\\*, cmd will run on all computers in the current domain.
    - **-u** - the account under which the command will be executed.
    - **-p** - password for the above account.
    - **cmd** - the program to be run.

    **Example 2. PsExec - Example of enabling remote administration**

    We want to enable remote administration on a computer with the network name PCOFFICE. Remote administration will be enabled from the entire local network.

        psexec\\pcoffice -u administrator_account_name-p administrator_account_name
        netsh firewall set service remoteadmin enable subnet 

    **Example 3. PsExec - Example of enabling remote administration**

    We want to enable remote administration on all computers in the current domain. Remote administration will be enabled from the entire local network.

        psexec\* -u domain_administrator_account_name
        -p domain_administrator_account_name
        netsh firewall set service remoteadmin enable subnet 

    **Example 4. PsExec - Example of enabling remote administration**

    We want to enable remote administration on all computers in the current domain. The account from which PsExec was started is used. Remote administration will only be enabled from computer 192.168.10.21.

        psexec \\* netsh firewall set service remoteadmin enable custom 192.168.10.21
- **Agent over TCP/IP - port enable** - the agent needs to be allowed access through the Windows firewall port to communicate with the Collector. The default port for the Agent is port 760.
            
    **Example 5. Example of opening a port**

    We want to enable port 760 through the command line (Cmd) on the local station. Remote administration will be enabled from the entire local network.

        netsh firewall set porttopening TCP 760 ALC_EP enable subnet

    **Example 6. PsExec - port opening example**

    Using the PsExec utility, we want to remotely enable port 760 on all computers in the current domain. Remote administration will be enabled from the entire local network.

        psexec \* -u administrator_account_name-p administrator_account_name
        netsh firewall set portopening TCP 760 ALC_EP enable subnet

### Setting up the Winows Firewall by using Group Policy in Active Directory
         
When Windows XP SP2 and above is installed, the Windows firewall is activated and does not allow remote access by default. Group Policy is used to set up the Windows firewall.
         
Setting up the Windows Firewall using Group Policy in Active Directory can only be done on networks with a Windows Server 2008 R2 or higher domain server.

- **No Agent - Enable Remote Management**-
 procedure for enabling remote admin using Group Policy in Active Directory.
    1. Open **Start - Run - mmc**
    2. In the tree, select *Local Computer - -Policies - - Computer Configuration - - Administrative Templates - - Network - - Network Connections - - Windows Firewall - - Domain Profile*
    3. From the list, select *Windows Firewall - -Enable remote management exceptions*
         Switch to the **Enabled** state. If you need more security, enter the **Junk Message Sources Allowed** field.
  the IP address or subnet from which messages will be allowed to be received.
- **Agent over TCP/IP - Port Enable**- The procedure to enable port 760 using Group Policy in Active Directory. Remote administration will be enabled from the entire local network.
    1. Open **Start - Run - mmc**
    2. In the tree, select **Local Computer - -Policies- -Computer Configuration- - Administrative Templates- - Network- - Network Connections- - Windows Firewall- - Domain Profile**
    3. From the list, select *Windows Firewall- -Set Port Exceptions* to switch to the **Enabled** state. This will activate the **Show** button, click on it. In the following window, click the **Add** button and enter the following value.
  "760:TCP:Localsubnet:enabled:ALC\_EP"

> [!CAUTION]
> If you have made settings via Group Policy in Active Directory, you can no longer change these settings via the command line, but again only in Group Policy!
