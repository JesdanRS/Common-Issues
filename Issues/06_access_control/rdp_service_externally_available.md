---
category: "{==APP-CNF/NET==}"
cvss: "N/A"
---
### RDP Service Externally Available
The Windows Remote Desktop Protocol (RDP) service is available on the affected system{s||} on TCP port {==3389==}. Potential attacks on this service include:

 * Password guessing
 * Unauthorised external access using legitimate credentials
 * Man in the middle attack
 * Information leakage relating to usernames, hostnames and domains in use.
#### Impact: High
An attacker guessing or otherwise obtaining valid credentials could authenticate on the system, which may allow them direct access into {==CLIENTNAME==}'s internal network. This could allow them to access, modify or encrypt potentially sensitive information, or to attempt to escalate their privileges or perform further attacks.
#### Likelihood: Medium
Externally facing RDP services are a common target for ransomware and other attackers. An attacker would still need to either guess or obtain a password or carry out a man in the middle attack.
#### Recommendation
Disable this service if it is not required externally. If a remote desktop is required externally, it should ideally only be accessed over a VPN connection. At a minimum, amend firewall rules to only allow access from trusted IP addresses.
