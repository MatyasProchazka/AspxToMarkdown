# Enrolment of computers
     
The following chapters describe the different ways of entering computers into the register.
      
## Finding computers on the network
     
First, we let the system search for computers on the network and create objects representing computer assemblies in bulk.
     
1. In the object tree, right-click on the root Organization object, or another Organization object into which you want to insert computers. Select the **New Computer** command from the menu.
2. A window will open on the screen [New Computer](../../list-of-windows/alvao-asset-management-console/edit/new-computer), in which select **Search for new computers on the network** and press the **Next**.
3. A window will open on the screen [New computers](../../list-of-windows/alvao-asset-management-console/edit/new-computers). Select the method that will be used to search for new computers on the network and press the **Next** button.
4. The program will search for computers and add them to the tree, which may take a few minutes. Before that, a [window will appear
  Date and Time](../../list-of-windows/alvao-asset-management-console/date-time), where you can enter the actual date the computers were put into service if you are entering them after the fact.  

> [!NOTE]
> The date and time query can be disabled. In this case, it will no longer appear when a new computer is added.

5. Use the **Cancel** button to reject the query whether to detect the software and hardware data of the found computers. We will perform the detection later. You can also perform the detection immediately. In this case, the data will be detected according to [global detection settings](detection#detection-options).
6. Move the created computer reports in the tree under the appropriate users.

Each found computer is represented in the tree by a pair of objects Assembly (i.e. computer assembly) and Computer. For example, the ARTUR computer in the tree looks like this:
     ![](artur.jpg)     
The top object represents the computer assembly, and the bottom object represents the computer itself. The computer is part of the assembly. The assembly may also contain a monitor, printer, keyboard, mouse, etc. The Assembly object serves only as a folder that groups individual devices that are linked together. Since it is not a real object, it should not have any properties.
     
Unless the computer hardware is detected, only these two basic objects will be visible in the tree. After the detection is done, other detected components of the assembly (monitor, printers, ...) and also computer components (processor, memory, hard drives, graphics card, ...) will appear.

> [!NOTE]
> Later, if you have the network computers searched in the same way, only new computers will be added to the tree. 

> [!NOTE]
> The Collector service also includes a feature to automatically find computers on the network. To set up a network scan, use the **WebApp - Administration - Asset Management - Servers**, the feature is in the [Network Scan](../../list-of-windows/alvao-webapp/administration/asset-management/servers/detail/scan-network) block.

## Insert one computer
     
If you want to add only one specific computer to the inventory for which hardware and software can be detected, do the following:

1. In the object tree, select the user under which you want to create the new computer, and from the local menu, select the **New Computer**.
2. A window will open on the screen [New Computer](../../list-of-windows/alvao-asset-management-console/edit/new-computer), in which you select the **Create Computer Manually** option. Select the computer object kind and enter a name on the network for the new computer. Also select the **Detect computer information over the network using saved settings**.
  Finally, press **Next** .  

> [!NOTE]
> If the number series for the selected computer type is active, the network name cannot be manually entered, but will be generated automatically.

3. The program adds the computer to the object tree. Before that, the window will appear[Date and Time](../../list-of-windows/alvao-asset-management-console/date-time), where you can enter the actual date the computer was put into service if you are adding it to the registry after the fact.

> [!TIP]
> If the computer is not connected to the network, you can detect the hardware and software manually with Agent.exe and load the resulting files into the AM Console. In this case, on the computer in the tree, select **Detection Settings...** from the local menu, select **Custom Detection Settings** in the window, and on the **Detection Method** tab, select *Detection Method. manually*.

## Automatic Computer Creation with Autonomous Agent
     
If you are using standalone agents to discover computers and you want new computers with the agent installed to be automatically added to the inventory, do the following:

- On the new computer, [install and set up](detection/agent) the autonomous agent.
- In the [Detection](../../list-of-windows/alvao-webapp/administration/asset-management/settings/detection) settings, turn on the **Automatically create new computers with Autonomous Agent** option in the registry.
- The next time you contact WebService, the computer will automatically be added to the "Found Computers on Network" folder in the registry.
- If you want to automatically detect hw and sw of new computers, in the default [detection profile](detection)
            set the automatic detection scheduling period and set the detection method to *Automatically* or *Autonomous Agent*.

## Creating computers that cannot be detected
     
The system can only detect hardware and software on computers running Windows 95 and later. Computers with other operating systems ( e.g. Apple OSX, Linux, ...) can be entered into the registry as follows:

1. In the object tree, select the user under which you want to create the new computer and select **from the local menu.  New Computer**.
2. A window will open on the screen [New Computer](../../list-of-windows/alvao-asset-management-console/edit/new-computer), in which you select the **Create Computer Manually** option. Select the computer object kind and enter a name on the network for the new computer. Do not select the **Detect computer information over the network using saved settings**.
  Finally, press **Next** .  

> [!NOTE]
> If the number series for the selected computer type is active, the network name cannot be manually entered, but will be generated automatically.

3. The program adds the report to the object tree. Before that, the window will appear[Date and Time](../../list-of-windows/alvao-asset-management-console/date-time), where you can enter the actual date the computer was put into service if you are adding it to the log after the fact.
4. Select the newly created computer in the object tree and use the **Detection Settings...** command from the local menu, selecting the **Custom Detection Settings** option in the window.
  and on the **Detection Method** tab, select **Detection Settings** manually.
5. Create any computer components - use the **New Object... command from the local menu in the object tree.**and insert additional computer components. Finally, go through all the computer components and the computer and enter the values of the properties you want to record.
6. If you want to register the software for the computer as well, go to the **Software** and use the **Installation - Log installation...** command to create a record of the software installed.

## Virtual machine visibility
      
Virtual computers are recommended to be registered as objects of type *Computer/virtual*.
     
The computer has a "Host Computer" property that lists the name of the physical computer that was last detected as the host of the virtual machine during hardware discovery. The value is informative. Physical computers have no value in this property. This property is automatically detected and cannot be manually changed.
     
Using the "Host Computer" property:

1. Information on which FPC the newly detected VPC is running. Accordingly, the VPC will be manually moved to the appropriate location in the tree.
2. Check if the VPC is correctly registered.

### First detection of virtual machines
     After the first detection of computers, we recommend to check if any computers have been detected as virtual and if so, change their object kind to *Computer/Virtual*. Do the following.
1. **Objects** tab - set the filter to display virtual computers: Type = computer, Model = virtual.
2. Select all computers that are patched virtual, select **Edit** from the local menu and change the object kind to *Modify.Computer/Virtual*.

### Virtual computers on one physical computer
     ![](fpc1.png)     

> [!NOTE]
> The virtual machine is placed in the tree in the assembly of the physical machine on which it was installed. The "Host computer" property shows the detected host computer, which should be the same as the parent physical computer. 

### Virtual computers running in a physical computer farm
     
Example of a farm where VPCs can potentially move automatically between FPCs according to the current load:
      ![](farm1.png)       
### Evidence of server farms without VMs
      ![](farm2.png)       
### Virtual machine visibility in the cloud
      ![](cloud.png)
