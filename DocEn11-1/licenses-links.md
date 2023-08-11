# Links between licenses
     
Links can be created between licenses in ALVAO Asset Management to define the relationships between licenses.
      
## Links tab
     
You can manage your links in the main window of the **ALVAO Asset Management Console**         in the **Edit License** window on the **links** tab. There are both direct and indirect (transitive) links.
     
### Views
     
By default, the following views are displayed on the "links" tab:
     
- **Direct** - displays only direct links, i.e. links whose starting or ending license is the directly selected license.
- **Follows** - displays a list of licenses that the selected license follows.
- **Precedes** - displays a list of licenses that the selected license precedes.

### Columns

 Name | Description || Path | Path to the linked object. |
| Object kind | Type of linked object. |
| Object name | Name of the linked object. |
| Direct | Yes - this is a direct link to the object that is selected in the tree.  <br>
                    No - this is an indirect link to the object that is selected in the tree (link via another object). |
| Link type | The type of link from the perspective of the currently selected object in the tree. |
| Modified | Date and time when the link was last modified. |
| Edit | The person who last modified the link. |
| From object (path) | The path to the object on which the link is defined. For direct links, this is the selected object in the tree. |
| From object (type) | The type of object on which the link is defined. |
| From object (name) | The name of the object on which the link is defined. |
| From object (link type) | The type of link from the view of the object on which the link is defined. |

## Link Types
     
The following link types can be defined between objects:

 Link type | Description || Related to - Related to | License A is related to License B. |
| Precedes before - Follows after | License A precedes License B. For example: the MS Office 2003 license precedes the MS Office 2010 license. |

## Direct and indirect links
     
For example, the following links exist between licences A to E:  
         A -&gt; B -&gt; **C** -&gt; D -&gt; E
     
If the selected licencet is C, then the links B-&gt;C and C-&gt;D are **direct**, because they directly follow from or point to licencet C.
     
Links A-&gt; C and C-&gt; E are **indirect**,   because licence A is indirectly linked to C via licence B. Similarly, license E is indirectly linked to C via license D.
     
## Adding a new link

1. In the **AM Console**, display the **Edit License** window for the license you want to add a link to.
2. From the local menu on the **Links** tab, select the **Links** command.Add.
3. The **Add link** window will open. The license at the top of the window is pre-populated according to the license that is being edited. This selection cannot be changed.
4. In the **link Type** drop-down menu, select the desired link type, for example "License (top)**Follows**
            License****(bottom)."
5. Type part of the license name and select the object from the drop-down menu.
6. After filling in the details, click the **OK** button.

## Edit an existing link

1. On the **links** tab of the **Edit License** window, select the link you want to edit and select **Edit** from the local menu.
2. In the **Edit link** window, edit the link type and end licenses as needed and click **OK**.

## Removing a link

1. On the **links** tab in the **Edit License** window.locate the link you want to remove and select **Remove**.
2. Confirm the removal of the link.

## Example: License links When Upgrading a Software License
     
Perform an upgrade         ![](../../list-of-windows/alvao-asset-management-console/LicIn.GIF)         Purchase 10 Windows 98 licenses to         ![](../../list-of-windows/alvao-asset-management-console/LicIn.GIF)         purchasing 10 licenses of Windows XP Professional.           
         The license list will have the following entries after the upgrade:         ![](../../list-of-windows/alvao-asset-management-console/LicIn.GIF)         Purchase 10 Windows 98 licenses,         ![](../../list-of-windows/alvao-asset-management-console/LicOut.GIF)         cancelling 10 Windows 98 licenses and         ![](../../list-of-windows/alvao-asset-management-console/LicIn.GIF)purchasing 10 Windows XP Pro licenses.           
         In the list of links         ![](../../list-of-windows/alvao-asset-management-console/LicIn.GIF)of purchasing a Windows98 license, the following will appear:         ![](../../list-of-windows/alvao-asset-management-console/LicRelRight.GIF)![](../../list-of-windows/alvao-asset-management-console/LicOut.GIF)         Windows 98 and         ![](../../list-of-windows/alvao-asset-management-console/LicRelRight.GIF)![](../../list-of-windows/alvao-asset-management-console/LicIn.GIF)         Windows XP Pro.           
         In the list of links         ![](../../list-of-windows/alvao-asset-management-console/LicOut.GIF)of the Windows 98 license cancellation, the following appears:         ![](../../list-of-windows/alvao-asset-management-console/LicRelLeft.GIF)![](../../list-of-windows/alvao-asset-management-console/LicOut.GIF)         Windows 98 and         ![](../../list-of-windows/alvao-asset-management-console/LicRelRight.GIF)![](../../list-of-windows/alvao-asset-management-console/LicIn.GIF)         Windows XP Pro.           
         In the links list         ![](../../list-of-windows/alvao-asset-management-console/LicIn.GIF)of a Windows XP Pro license purchase, the following will appear:         ![](../../list-of-windows/alvao-asset-management-console/LicRelLeft.GIF)![](../../list-of-windows/alvao-asset-management-console/LicOut.GIF)         Windows 98 and         ![](../../list-of-windows/alvao-asset-management-console/LicRelLeft.GIF)![](../../list-of-windows/alvao-asset-management-console/LicIn.GIF)         Windows 98.
