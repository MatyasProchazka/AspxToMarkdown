# First Steps

- **Import users from Active Directory**
    - **LDAP path** - option to specify the LDAP path. For example: LDAP://dc=company,dc=com

> [!NOTE]
> If you need to use LDAPS, you must add Active Directory server hostname and port before specifying the variants. For example: "LDAP://domainserver**:636/**dc=company,dc=com".

    - **Create scheduled task for regular user import (1x/day)** - option to schedule regular user import 1x/day. The created task is named "ALVAO Import Users".
    - **Other settings**
        - **Remove users that do not exist in AD**
 - option to remove users that do not exist in AD.
        - **Person Name Template** - determines which attributes from AD will be used to build the Person Name in ALVAO.
        - **Active Directory record attribute**
 - A predefined selection of attributes. Select the attribute and click **. Paste** button to insert it into the top row.
- **Import portraits**
    - **Create a scheduled task for regular import of portraits from a folder (1x/day)** - option to import portraits regularly. The created task is named "ALVAO Import Portraits".
    - **Other settings**
        - **Path to portraits folder** -
 option to specify the path to the portraits.
