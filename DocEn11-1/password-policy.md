# Password rules
 
Use this page to set password policies for non-Active Directory users.
 
Options:

- **Password Complexity**
    - **Minimum password length (number of characters)**-
 Specify how many characters the shortest allowable password can be.
        - Allowed range: 0 - 14.
    - **Passwords must meet complexity requirements**-
 Enable this option if you want passwords to have to meet the following requirements:
        - Must be at least six characters in length.
        - Must contain characters from at least three of the following character groups:
            - uppercase letters
            - lowercase letters
            - numerals
            - symbols (for example !, $, #, %)
        - Must not contain the username or display name of the user.
- **History of passwords**
    - **Minimum password age (days)**- Enter the minimum number of days that must elapse between password changes.
        - Allowed range: 0 - 998.
    - **Maximum password age (days)**- Enter the maximum password age in days. After this period, the user will have to change password.
        - Allowed range: 0 - 999.
        - 0 means that passwords are valid indefinitely.
    - **Password history size (number)**- specify the number of passwords that the system will remember back for each user and will not allow the user to set the same password again.
        - Allowed range: 0 - 24.
