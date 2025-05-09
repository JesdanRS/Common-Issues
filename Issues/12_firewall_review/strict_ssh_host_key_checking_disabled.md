---
category: "CNF"
cvss: "3.7"
---
### Strict SSH Host Key Checking Disabled
The firewall{s below have|| HOSTNAME has} strict SSH host key checking disabled. This means that when a file is copied from the firewall using the SCP protocol, the host key will not be checked, and will be accepted regardless of whether it has been seen before or not.
#### Impact: Medium
SSH host key checking is used to defend against man in the middle attackers, or an attacker impersonating a valid SSH server, which could potentially allow them to obtain sensitive information or to exploit weaknesses in the SSH protocol. Disabling the protection increases the likelihood of such an attack being successful.
#### Likelihood: Low
This issue would be very difficult to exploit, and would require an attacker to perform a man in the middle attack, or otherwise impersonate a legitimate server.
#### Recommendation
Enable strict SSH host key checking with the following command:

```
ssh stricthostkeycheck
```
