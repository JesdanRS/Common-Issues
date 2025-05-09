---
category: "PWD"
cvss: "7.2"
---
### Windows Stores Clear Text Passwords in Memory
It was possible to obtain clear text Windows credentials from memory on the affected system{s||} listed above. Using a publicly available tool called Mimikatz, it was possible to obtain the clear text password for the {=="DOMAIN\USERNAME"==} account, {==OPTION==} which had administrator rights on the domain.

The process of obtaining these clear text passwords is shown below. Please note that local Administrator rights are required on the system to perform this attack. Note also that the password below has been masked.

```
PS > .\mimikatz.exe
mimikatz # privilege::debug
Privilege '20' OK
mimikatz # sekurlsa::logonpasswords
<...>
* Username : USERNANE
* Domain   : DOMAIN
* Password : MASKED_PASSWORD
```
#### Impact: High
An attacker can obtain clear text passwords from memory. As these credentials were for an account with domain Administrator privileges, this resulted in a complete compromise of the {==DOMAIN==} Active Directory domain.
#### Likelihood: Low
The techniques for obtaining clear text password from memory are well known, and a number of publicly available tools exist to perform these attacks. However, an attacker would first need to obtain local administrator privileges on the {==server==}.
#### Recommendation
There are a number of defences that can be implemented in order to prevent and detect these types of attacks. The following SANS paper contains further information:

[https://www.sans.org/reading-room/whitepapers/detection/mimikatz-overview-defenses-detection-36780]()
