---
category: "TBA"
cvss: "TBA"
---
### Insufficient Administrative Interfaces Access Restrictions
The firewall device{==s==} below have their administrative management interface{==s==}, which {==is|are==} available over HTTPS and SSH, accessible from a large number of internal network ranges{==OPTION Amend if they are also exposed externally==}. This could allow an attacker on the internal network to target the firewall's administrative interface{==s==}:

{==List services, internal IP ranges and interfaces per device==}
#### Impact: Medium
An attacker who manages to obtain valid credentials, for example through social engineering or a brute-force attack, could take administrative control of {==these devices|this device==}.
#### Likelihood: Low
The service{==s==} would be quickly identified, however, an attacker would need to be on the internal network and require valid credentials to be able to proceed further.
#### Recommendation
Consider applying stricter access control to allow only select authorised IP addresses or IP ranges to access {==this service|these services==}. Furthermore, ensure that all administrative access is secured with a complex password compliant with the organisation's security policy.
