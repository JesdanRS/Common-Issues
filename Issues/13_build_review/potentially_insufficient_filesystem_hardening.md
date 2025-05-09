---
category: "CNF"
cvss: "N/A"
---
### Potentially Insufficient Filesystem Hardening
The {==/tmp/ and /home/==} folders on the server{s listed below|| "NAME"} are part of the main filesystem, and have not been mounted with restrictions to prevent users from creating or executing SUID files or binaries.
#### Impact: Medium
A low privileged attacker gaining access to the system{s||}, for example by compromising a running service, would be able to create and execute files in the /tmp/ folder, or within their home folders. This could allow them to execute arbitrary code on the system, including hacking tools or kernel exploits in an attempt to escalate their privileges.
#### Likelihood: Low
An attacker would need to gain access to the system{s||} by compromising another vulnerability in order to exploit this issue, for example, compromising a running service, or by using weak or stolen credentials.
#### Recommendation
Consider moving {==/tmp/ and /home/==} onto separate partitions, and mounting them with the "noexec", "nodev" and "nosuid" flags in order to prevent an attacker from being able to execute code, create devices or create setUID binaries within those folders. Restrict filesystem permissions to prevent normal users from writing to any other folders.
