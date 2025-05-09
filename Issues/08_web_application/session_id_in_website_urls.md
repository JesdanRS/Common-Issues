---
category: "APP-ATH"
cvss: "3.1"
---
### Session ID in Website URLs
The affected website{s||} include{||s} the session ID in some URLs, as shown below:

{==http://url?sessionid=FIXME==}
{==SCREENSHOT==}
#### Impact: Medium
A local attacker may be able to view {these||this} URL{s||}, for example, if {they are||it is} saved in a browser's history. This will give the attacker access to confidential information depending on the role of the victim.
#### Likelihood: Low
An attacker will need to gain local access to the victim's computer, access to a server or access to a proxy server that may have recorded the URL{s||}, or they could intercept traffic as it crosses a shared network.
#### Recommendation
Do not include the session ID in URLs; it should be stored only in a cookie which is protected with the "Secure", "HttpOnly", and "SameSite" attributes.
