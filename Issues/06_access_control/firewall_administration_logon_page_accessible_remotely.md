---
category: "{==APP-CNF/CNF==}"
cvss: "5.3"
---
### Firewall Administration Logon Page Accessible Remotely
{Login pages were||A login page was} identified for the administrative functionality of the firewall device{s||} at the following URL{s||}:

{==URL==}
{==SCREENSHOT==}
#### Impact: Medium
An attacker who manages to obtain valid credentials, for example through social engineering or a brute-force attack, could take administrative control of the firewall device.
#### Likelihood: Medium
The page would be quickly identified, however an attacker would require valid credentials to be able to proceed further.
#### Recommendation
Consider whether remote access to the firewall's administrative functionality is required. If so, consider applying access control to allow only authorised IP address ranges to access {these pages||this page}. Furthermore, ensure that administrative access is secured with a complex password compliant with {==CLIENTNAME==}'s security policy.
