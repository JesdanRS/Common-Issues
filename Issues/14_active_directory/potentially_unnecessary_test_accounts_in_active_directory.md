---
category: "PRV"
cvss: "N/A"
---
### Potentially Unnecessary Test Accounts in Active Directory
The following accounts on the {==DOMAIN==} domain appeared to be used for testing purposes.

{==LIST==}
#### Impact: Low
Compromising a test account will allow attackers to gain a foothold within the {==DOMAIN==} domain. Subsequently, they could utilise this access to launch further attacks that are only feasible with a domain account.
#### Likelihood: Medium
Test accounts are a common target for attackers as they are frequently over privileged and have weak passwords. However, an attacker will need to exploit another vulnerability, such as the use of weak passwords, to take advantage of this issue.
#### Recommendation
Ensure that when test accounts are created, they are only granted permissions relevant to their purpose, have a strong and unique password, are set to expire after a short period of time, and are manually disabled or removed when no longer required.
