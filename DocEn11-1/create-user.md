# New user
    
The form is used to create a new user in Alvao.
      
Options:
   
- **Name and surname** - enter the user's first and last name.
- **User name** - enter the username under which the user will log into the Alvao system.
- **Contact information**
    - **Mobile phone** - if applicable enter the user's mobile phone number.
    - **E-mail** - if applicable enter the user's e-mail address.
    - **E-mail 2** - if applicable enter the user's second email.
    - **E-phone** - if applicable enter the user's phone number.
    - **Business phone 2** - if applicable enter the user's second phone number.
    - **Additional contacts** - if applicable enter additional contacts for the user.
- **Organization**
    - **Organization** - if applicable, enter an organization or select one from the list.
    - **Department** - if applicable enter the user's department.
    - **Position** - if applicable specify the user's function.
    - **Office** - if applicable, enter the office where the user works.
    - **Manager** - if applicable, select the person who is the user's direct supervisor.
    - **Substitute** - if applicable, select the person who will represent the user in their absence.
    - **Personal number** - if applicable, enter the user's personal number.
- **Other** - if applicable, fill in additional [custom fields](../../../../alvao-service-desk/implementation/custom-items).
- **Extended**
    - **Preferred language** - select the user's preferred language.
    - **Time zone** - select the time zone in which to display time data to the user.
    - **Account is disabled** - enable to [disable the account](../../../../alvao-service-desk/implementation/users/inactive-accounts).
  The selected user then won't be able to log into Alvao applications.
    - **Shared account** - enable if the account is a shared account, i.e. a common account for a group of requesters who log into the system with the same username and password and only fill in their contact details when working with the system.
    - **Hide in menus** - turn on if this is an auxiliary account that you want to hide in the application. This is the recommended way to hide all system and auxiliary accounts that have been [entered into Alvao from Active Directory](../../../../alvao-asset-management/implementation/users) or other sources, and do not represent actual system users.
    - **Application account** - enable if the account is to be used by an application or script to access the [ALVAO REST API](../../../../modules/alvao-am-enterprise-api). You cannot log into Alvao interactive applications (WebApp or AM Console) with this account.
        - **AAD application**- select if this is an application account that is registered in Azure Active Directory (AAD). The application then authenticates to the ALVAO REST API with its AAD token.
            - **Application (client) ID** - enter the corresponding value of the account in AAD.
            - **Directory (tenant) ID** - enter the corresponding value of the account in AAD.
        - **Other applications** - select if this is not an AAD application. The application is authenticated in the ALVAO REST API with a username and password.
