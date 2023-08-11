# Enabling reCAPTCHA
  
For better protection against password guessing attacks, the reCAPTCHA display can be enabled in the ALVAO WebApp.   
The reCAPTCHA support is only valid for **version 2** (Checkbox variant). To enable it, proceed as follows.
 
1. Go to [reCAPTCHA](https://www.google.com/recaptcha/intro/index.html), create an account and get your public and private keys. Follow the instructions on the page.
2. Execute the following SQL statements on the database, adding the obtained public key (Site key) and private key (Secret key):	   
			INSERT INTO tProperty (tProperty,tPropertyValue) VALUES(N'WebApp.CAPTCHAPublicKey', N'&lt;public key&gt;');   
			INSERT INTO tProperty (tProperty,tPropertyValue) VALUES(N'WebApp.CAPTCHAPrivateKey';
3. In case of a large number of unsuccessful logins to the WebApp, the login will be checked to make sure they are human and not automated robots.

To disable this behavior, do the following:  
		DELETE FROM tProperty WHERE sProperty = N'WebApp.CAPTCHAPublicKey';   
		DELETE FROM tProperty WHERE
