---
category: "PRV"
cvss: "N/A"
---
### No Software Restriction Policies Enforced
It was possible to run almost any application on the sample workstation{s||} ({==HOSTNAME(s)==}) without requiring local administrator permissions. This could allow other settings such as Internet Explorer proxy configuration or command line access restriction to be bypassed, or allow attempts to escalate local privileges with specially crafted attack tools. The example below shows that it was possible to download and run the tool "{==PuTTY==}", which is designed to establish remote connections over a number of network protocols, including SSH and Telnet, as well as being able to act as a SOCKS proxy:

{==SCREENSHOT==}
#### Impact: Medium
An attacker or authenticated user could execute specially crafted scripts to bypass local restrictions or attempt further privilege escalation attacks.
#### Likelihood: Medium
A number of freely available applications are available which can be run without administrator privileges, and are designed specifically to bypass local restrictions.
#### Recommendation
Consider implementing software deployment and restriction policies to ensure that all {workstations||laptops} have current versions of approved software, and unapproved software cannot be used. The following guides give more information on software restriction in Windows networks:

[https://learn.microsoft.com/en-gb/windows-server/identity/software-restriction-policies/software-restriction-policies]()
[https://learn.microsoft.com/en-gb/windows/security/application-security/application-control/app-control-for-business/applocker/applocker-overview]()
