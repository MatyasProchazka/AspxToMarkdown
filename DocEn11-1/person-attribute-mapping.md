# Mapping SCIM attributes to user items
     
In Alvao, the following [user attributes](../../../../../../list-of-windows/alvao-webapp/administration/users) are synchronized via the SCIM protocol:

| *User attribute in Alvao* | *Column in DB (see [tPerson](../../../../../../alvao-asset-management/implementation/customization/database#U_dbo.tPerson))* | *Attribute in SCIM* |
| --- | --- | --- |
| - | AzureAdObjectId | externalId |
| Account is blocked | bPersonAccountDisabled | active (negated value) |
| - | sAdDisplayName | displayName |
| - | sFirstName | name.givenName |
| - | sLastName | name.familyName |
| First and last name | sPerson | name.formatted |
| Functions | sPersonWorkPosition | title |
| E-mail | sPersonEmail | emails[type eq "work"].value |
| Mobile | sPersonMobile | phoneNumbers[type eq "mobile"].value |
| Phone for work | sPersonPhone | phoneNumbers[type eq "work"].value |
| username | sPersonLogin | userName |
| - | iPersonLocaleId | locale |
| Preferred language | sPersonPrefferedLanguage | preferredLanguage |
| Time zone | TimeZone | timeZone |
| Other contacts | mPersonContact | addresses[type eq "work"].formatted |
| City | sPersonCity | addresses[type eq "work"].locality |
| Land | sPersonCountry | addresses[type eq "work"].region |
| Personal Number | sPersonPersonalNumber | urn:ietf:params:scim:schemas:extension:enterprise:2.0:User:employeeNumber |
| Division | sPersonDepartment | urn:ietf:params:scim:schemas:extension:enterprise:2.0:User:department |
| Organization | liAccountId | urn:ietf:params:scim:schemas:extension:enterprise:2.0:User:organization |
| Subordinate | iPersonManagerPersonId | urn:ietf:params:scim:schemas:extension:enterprise:2.0:User:manager |
| Other (custom fields) | tPersonCust.\* | urn:ietf:params:scim:schemas:extension:alvao\_tPersonCust:2.0:User:\* |

Ignored attributes in SCIM:
     
- ims (Instant messangings)
- nickname
- addresses (other than "work")
- addresses[type eq "work"].postalCode, addresses[type eq "work"].steetAddress
- emails (other than "work")
- urn:ietf:params:scim:schemas:extension:enterprise:2.0:User:**costCenter**
- urn:ietf:params:scim:schemas:extension:enterprise:2.0:User:**division**
- custom attribute extensions not related to Alvao (alvao\_tPersonCust, alvao\_tblProperty)

## Mapping attributes in AAD to custom user items
     
If you want to import attributes from AAD into custom user items, do the following:

1. In AAD, navigate to the mapping settings (*Provisioning - Edit provisioning - Mappings - Provision Azure Active Directory Users*).
2. View advanced options and navigate to *Edit attribute list for customappsso*
3. For each custom user entry, create a new attribute with a name of the form

            urn:ietf:params:scim:schemas:extension:alvao\_tPersonCust:2.0:User:{column name of the custom field in the database}.  

            Example: to import values into a custom tPersonCust.IpTelefon item, create an attribute named urn:ietf:params:scim:schemas:extension:alvao\_tPersonCust:2.0:User:IpTelefon
4. Save your changes and go back to the list of mapped attributes.
5. Use the *Add New Mapping* command to create a mapping between the new attributes in SCIM and the items from AAD (the mapping specifies what and how the attributes will be populated).
6. All existing users are updated during the next setup cycle.

For more information on mapping individual attributes, see [Tutorial - Customize Azure Active Directory attribute mappings in Application Provisioning | Microsoft Docs](https://docs.microsoft.com/en-us/azure/active-directory/app-provisioning/customize-application-attributes).
