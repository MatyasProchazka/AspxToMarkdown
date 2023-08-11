# Handover protocols
      
A transfer report is a document which, when property is transferred, serves as evidence that the transferor has handed over the property to the recipient and that the recipient has accepted the property.
      
Alvao contains the following types of handover protocols:
      
- **Internal**- the movement of assets within an organization, usually between an asset warehouse and an employee.
    - **Intermediate** - only the assets currently being transferred are listed on the log. In order to document the assets currently held by a particular recipient, it is necessary to trace all historical transfer logs for that recipient or transferor.
    - **Summary** - contains a complete list of the property in the possession of the recipient at the time the protocol is issued, i.e. the property has been transferred to the recipient at some point in the past and has not yet been returned. The last protocol issued for a given beneficiaries replaces all their previous protocols, which therefore do not need to be archived.

                    We recommend the use of this type of protocol for the transfer of entrusted property to employees. On the other hand, for recipients who are responsible for a large number of assets, it may not be practical to issue a multi-page summary report for each transfer of assets. In that case, the only option is to archive the difference logs. Alternatively, you can combine the two approaches for these beneficiaries, e.g. issue difference reports during the year and issue a summary report once a year, which replaces the archive of difference reports issued up to that point and can also serve as a basis for the beneficiary to take stock of the assets for which is responsible.
- **External** - transfer of assets outside the organisation, e.g. between the organisation and a service company.

## Preparatory warehouse
     
A technician who hands over an asset to an employee often must first prepare the asset for use, e.g. install the necessary applications on the computer, etc. Similarly, when receiving returned property from an employee, the property must be prepared for storage, e.g. wiping the contents of the computer's hard drives, etc. In the object tree, you can create an object for each technician for these tasks according to the *Preparation Warehouse* template. In the [Responsible for assets](../implementation/tree-design) property, specify the name of the technician.
     
If a technicians is preparing several asset moves at the same time, they can create a separate work folder in their staging warehouse for each move in progress.
      
## Transfer of property to an employee

1. Move the assets in the object tree [from the warehouse to your staging warehouse](../objects-and-properties/moving-object) if you are using it.
2. Prepare the property for use.
3. Physically transfer the asset to the recipient while:
4. In the object tree, move the asset under the recipient.
5. If you want to issue a **summary** report, select the recipient in the tree. If you want to issue a **distributive** report, in the tree (or on the Child Objects tab),
  select only the asset that has just been moved.
6. Use the **Print** command and select the appropriate log template.
7. Edit or add missing data.
8. Print the protocol twice on paper.
9. Both copies to be signed by you and the recipient.
10. Give one copy to the recipient and file the other in the archives.

> [!TIP]
> You do not need to print internal handover protocols on paper or archive them in paper form or scan them into an electronic archive. Recipients can validate them directly in the application in PDF format. This functionality is part of the [ALVAO Electronic Handover Forms](../../modules/alvao-electronic-handover-forms) module.

## Receipt of returned property from an employee

1. Physically accept the returned property from the employee while:
2. Move the property in the [object tree](../objects-and-properties/moving-object) to your staging warehouse if you are using it.
3. If you want to issue a **summary** report, select the employee in the tree. If you want to issue a **distributive** log, in the tree (or on the Child Objects tab),
  select only the asset that has just been returned.
4. Use the **Print** command and select the appropriate log template.
5. Edit or add missing data.
6. Print the protocol twice on paper.
7. Both copies to be signed by you and the recipient.
8. Give one copy to the employee and file the other in the archives.
9. Prepare the subsequently returned property for storage.
10. Physically store the returned property in the warehouse and move the objects in the object tree.

## Employee's salary
     
For an employee leaving the organisation, upon return of all entrusted property, issue a (blank) **summary** handover protocol in paper form as evidence that all entrusted property has been returned.
      
## Archive of handover protocols
     
The archive of exposed internal handover protocols can be found in **AM Console - Tools - Lists -**[Documents](../../list-of-windows/alvao-asset-management-console/tools/lists/documents).   For each internal handover protocol, a [document](../documents) is automatically created, with the handover protocol as a PDF attachment.

> [!NOTE]
> See *Transfer Protocol Internal - Generate New Document*, or *WebApp - Administration - Asset Management - Settings - [General](../../list-of-windows/alvao-webapp/administration/asset-management/settings/general) - The "Generate New Document" option in the forwarding log will be enabled by default*.

> [!TIP]
> The internal handover protocol numbers can be automatically generated [in numeric sequence](sequences).
