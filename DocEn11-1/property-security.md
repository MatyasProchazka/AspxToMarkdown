# Property Security
     
[Property security](../../list-of-windows/alvao-webapp/administration/asset-management/property-definitions/detail/security) is used to set access permissions to object properties.         Property security is set for each [property definitions](../../list-of-windows/alvao-webapp/administration/asset-management/property-definitions/detail) independently of [object security](object-access-rights).
      
## Rights
     
The system allows you to set the following permissions:

| Permissions | Description |
| --- | --- |
| Read | The user sees the property and its values. Properties are displayed, for example, in the AM Console on the Properties and Objects tabs, in the Object Lists window, in the ALVAO WebApp on the object page, etc. |
> [!NOTE]
> If [object security](object-access-rights) is enabled, the user must also have the Modify permission enabled on the object. |


The permission can be specified unlimitedly for all object types, or it can be set only for a specific object type.
     
When you create a new property definition, the system automatically sets permissions for Asset Management system groups as follows:

| Group | Read | Change |
| --- | --- | --- |
| Object property readers | Yes |  |
| Object property administrators | Yes | Yes |

If no permissions are set on the property definition, only members of the *Asset Management administrators* group can see the property and change its value.

> [!NOTE]
> Asset Management administrators can always read and change all property values, permissions cannot be restricted for them.

> [!TIP]
> If you need to display a specific property to all users in the ALVAO WebApp in the My Trust section, set the system group Everyone to Read in the property definition. (In this case, users who are only registered in the object tree and are not listed in ALVAO WebApp - Administration - Users are exceptionally considered members of the Everyone group.)
