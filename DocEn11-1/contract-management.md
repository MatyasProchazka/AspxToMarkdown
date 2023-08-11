# Contract registry
     
You can record contracts with your service providers, e.g. for servicing printers, servers, UPS units, air conditioners, etc., as objects in the object tree.
     
## Contracts folder
     
In the object tree, create the following folders for recording contracts in your organization using the ready-made Contract object template:
     
- **Contracts** (Object Type=Contracts, Name=Contracts, Contract Status=Active)
    - **Archive** (Object Type=Contracts, Name=Archive, Contract Status=Archive)

Set access permissions on the folders, see [Object security](objects-and-properties/object-access-rights) or [Property security](objects-and-properties/property-security).
     
## Creating a new contract

1. In the Contracts folder, create a new object using the Contract template.
2. Fill in the properties of the new contract.
3. In the object journal, create a [note](object-notes) and insert the scanned contract file into its attachment.  

            Alternatively, create a new [document](documents) for the contract, save the scanned contract to its attachments, and add the document to the object journal.
4. If you use the [ALVAO Configuration Management](../modules/alvao-configuration-management) module, you can link the contract object to the objects that the contract relates to.

## Notification of impending expiration
     
In **WebApp - Administration** - [Regular Alerts](../list-of-windows/alvao-webapp/administration/periodic-alerts), create a new alert with the script below.
     
The script generates alerts for active [contracts](contract-management) that are about to expire. The alert will be sent if there are fewer days left until the date specified in the contract in the *Expiry by* property than the number of days specified in the *Advance warning of expiry (days)* property.
     
The notification sender is the [messaging sender](../list-of-windows/alvao-webapp/administration/settings/messaging) of the Alvao system. The notification is sent to the members of the group that is specified in the script in the *recipientsGroup* variable.
     
The contract table will contain the *Name, Path in tree, Expiration by* and a url link to the contract object.

    declare @recipientsGroup nvarchar(50) = N'Contract Administrators'; -- Group containing the recipients of the notificationdeclare @contractFolderPath nvarchar(100) = null; -- Path to the folder containing the contracts. Null = The entire object tree is searched.select NULL as [From],
      stuff( (
      select cast(';' as varchar(max)) + P.sPersonEmai from tPerson P
      join tRolePerson RP on RP.liRolePersonPersonId = P.iPersonIjoin tRole R on R.sRole = @recipientsGroup and R.iRoleId = RP.liRolePersonRoleIWHERE P.dPersonRemoved is null and ISNULL(P.sPersonEmail, '') != ''
      for xml path('')
      ), 1, 1, '') as [To],
      null as [Cc],
      null as [Bcc],
      N'Expired contracts' as [Subject],
      N'Hello,The contracts listed below will expire soon.' as [Text],
      N.txtName as [Name],
      N.txtPath as [Path in tree],
      expiration.txtValue as [Expiration by],
      (select sPropertyValue from tProperty where sProperty='WebAppURL')+ '/Object/' + cast(N.intNodeId as varchar) as URLfrom vNodeClass N
    join vPropertyKind expiration on expiration.lintNodeId = N.intNodeId and expiration.intKindCode = 163 join vPropertyKind notify on notify.lintNodeId = N.intNodeId and notify.intKindCode = 164join vPropertyKindInherited state on state.lintNodeId = N.intNodeId and state.intKindCode = 165where (N.txtPath like @contractFolderPath + '%' or @contractFolderPath is null) and N.bolHidden = 0 and N.bolScrapped = 0 and N.lintClassId = 56 and expiration.txtValue is not null and notify.txtValue is not null and state.txtValue = N'Active' and (CONVERT(datetime, expiration.txtValue, 103) < DATEADD(day, -cast(notify.txtValue as int), GETUTCDATE()))

> [!TIP]
> If you want to be notified when an automatic contract renewal is coming up, set the *Expiration by*property to the date of the automatic renewal, and update it after the renewal.

     
## Contract Extension

1. For a given contract, edit the *Expiry by* and any other properties that have changed.
2. Add a new [note](object-notes) or [document](documents) with the contract or amendment file to the request log.

> [!NOTE]
> Changes to contract property values are automatically recorded in the object log.

      
## Archiving the contract
     
Move expired contracts to the *Archive* folder.
