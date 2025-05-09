---
category: "MOB-ATH"
cvss: "3.2"
---
### Insufficient Session Management on Application Pause or Stop
The mobile application{s do|| does} not log the user out when the application is paused{==, for example when switching between applications, returning to the home screen, or when the user manually terminates the application or restarts the device==}.
#### Impact: Medium
An attacker with access to a user's device could gain access to the application and the user's account.
#### Likelihood: Low
An attacker would first need physical access to a user's device and the user would need to have recently logged in to the application. Additionally, users may have other device restrictions enabled, such as a passcode or other authentication mechanism.
#### Recommendation
Consider prompting the user to re-authenticate to their account when the application is resumed.

{==OPTION==}Alternatively, consider providing users the option to refresh their access tokens using {==fingerprint/Touch ID==} authentication, or a PIN.