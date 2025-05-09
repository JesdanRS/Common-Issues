---
category: "MOB-TAM"
cvss: "2"
---
### Mobile Application No Tampering Detection
{==NOTE for iOS this is way more difficult, so likelihood could be lower==}
The mobile application{s do|| does} not check whether {their||its} application code has been modified. This means that an attacker can alter the application's behaviour during runtime, {==OPTION Android==} or modify its source code and then recompile it, signing it with a custom certificate.

{==XREF POC if something meaningful can be done, for example, are you able to patch the APK to bypass login pages.==}
#### Impact: Medium
An attacker tampering with the application could circumvent security protections. {==OPTION Android==}Additionally, an attacker could inject malicious code in the application{s||} targeting legitimate users.
#### Likelihood: Low
Modifying an application's code requires a significant level of skill and knowledge. {==OPTION==} Additionally, the application{s do|| does} not seem to rely on client side code for handling sensitive information or providing sensitive functionality.
#### Recommendation
Consider modifying the application{s||} to include checks that compare {their||its} signature against {==CLIENTNAME's==} developer signature. Additionally, consider amending the application to send a notification to {== CLIENTNAME's==} servers with the incorrect signature for further analysis. These checks should be carried out periodically on the runtime to detect runtime modifications of the source code. Refer to the following page from OWASP for more information:

[https://owasp.org/www-project-mobile-top-10/2016-risks/m8-code-tampering]()

{==OPTION Android==}The following article discusses a number of protection mechanisms which can be implemented on an Android application to deter attackers from tampering with the application:

[https://www.dionach.com/blog/android-binary-protection-methods]()

Please note that although anti-tampering verification measures will increase the difficulty of modifying the application, they cannot prevent a determined and skilled attacker.
