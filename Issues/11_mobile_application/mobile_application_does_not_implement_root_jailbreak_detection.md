---
category: "MOB-TAM"
cvss: "3.1"
---
### Mobile Application Does Not Implement Root/Jailbreak Detection
{==NOTE: Issue title (change plural in the issue if both iOS/Android). This risk of this issue can be from informational up to high depending on the sensitivity of the app (i.e. monetary gain) Adjust the risk level by amending the impact only. ==}
The mobile application{s do|| does} not perform any {==root or jailbreak==} detection checks, therefore, {they||it} can potentially be installed and run on {==rooted Android or jailbroken iOS==} devices.

Rooting {==Android devices and jailbreaking iOS devices==} is a well-known mechanism that allows all user-installed applications to execute privileged operations typically unavailable in the device's default configuration. Applications running with root privileges, granted after {==rooting or jailbreaking==} a device, have complete control over the device, and can therefore access any resource on the device. An attacker compromising a {==rooted or jailbroken==} device or a malicious application running on a {==rooted or jailbroken==} device can potentially access and modify any data that the application utilises, as shown in the following proof of concept {==examples==}.

{==(TRY: to read sensitive database files or dump sensitive data from memory such as credentials, visa numbers etc)==}

For further information, please see the following link from OWASP:

[https://wiki.owasp.org/index.php/Mobile_Jailbreaking_Cheat_Sheet?oldid=233121]()
#### Impact: Medium
If an attacker took control of a {==rooted or jailbroken==} device running the {==AppName==} application, it would be possible to access and manipulate any sensitive information utilised by the application. The integrity and confidentiality of the data used by the application may be affected.
#### Likelihood: Medium
The possibility of running the application on {==rooted or jailbroken==} devices widens the attack surface from the perspective of a malicious user or malware, although a compromise of the device would still be required. An attacker could also {==root or jailbreak==} a lost or stolen device and perform the same malicious actions.
#### Recommendation
Consider modifying the application to implement detection mechanisms and controls for preventing the application from running on {==rooted Android and jailbroken iOS==} devices. For more information on how to implement these detection mechanisms, please refer to the following article{==s==}, as well as the device's official documentation:

[https://owasp.org/www-project-mobile-top-10/2014-risks/m10-lack-of-binary-protections]()
{==OPTION ANDROID==}[https://www.dionach.com/android-binary-protection-methods]()

{==OPTION==} Alternatively, consider displaying a disclaimer when {==a rooted or a jailbroken==} device is detected, highlighting the potential risks of running the application on {==a rooted or a jailbroken==} device.

As a user with root access to a device is in total control of it, it is highly likely that any of these controls can be bypassed, and therefore {==CLIENTNAME==} should conduct a risk assessment to decide whether this issue represents an acceptable risk.
