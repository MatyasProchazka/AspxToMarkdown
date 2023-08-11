# Mapping SCIM attributes to object properties
   
In Alvao, the following [properties](../../../../../../alvao-asset-management/objects-and-properties) of objects are synchronized via the SCIM protocol:

| *Object property* | *Attribute in SCIM* |
| --- | --- |
| User | displayName |
| UserName | userName |
| E-mail | emails[type eq "work"].value |
| Phone | phoneNumbers[type eq "work"].value |
| Mobile | phoneNumbers[type eq "mobile"].value |
| Division | urn:ietf:params:scim:schemas:extension:enterprise:2.0:User:department |
| Functions | title |
| City | addresses[type eq "work"].locality |
| Land | addresses[type eq "work"].region |
| Company | urn:ietf:params:scim:schemas:extension:enterprise:2.0:User:organization |
| Street | addresses[type eq "work"].streetAddress |
| District | addresses[type eq "work"].country |
| CT | addresses[type eq "work"].postalCode |
| Home phone | phoneNumbers[type eq "home"].value |
| Pager | phoneNumbers[type eq "pager"].value |
| Fax | phoneNumbers[type eq "fax"].value |
| Account is blocked | Active (negated value) |
| Personal number | urn:ietf:params:scim:schemas:extension:enterprise:2.0:User:employeeNumber |
| (tblNode.txtLDAPGUID) | externalId |

## Mapping attributes in AAD to object properties
   
If you want to import attributes from AAD to custom user properties in the object tree, follow the same steps as for [mapping to custom user entries](../../../../../../alvao-asset-management/implementation/users/authentication/aad/provisioning/person-attribute-mapping), except that for each property, create a new attribute with a name of the form urn:ietf:params:scim:schemas:extension:alvao\_tblProperty:2.0:User:kindId\_{propertyID}.

> [!NOTE]
> 

Example: To import values into a property with kindId = 9, create an attribute named urn:ietf:params:scim:schemas:extension:alvao\_tblProperty:2.0:User:kindId\_9
