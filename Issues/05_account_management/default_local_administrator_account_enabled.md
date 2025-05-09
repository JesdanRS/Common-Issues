---
category: "PRV"
cvss: "N/A"
---
### Default Local Administrator Account Enabled
The default local Administrator account (RID 500) was found to be enabled on the affected system{s||} listed above.

{==OPTION==} Additionally, this account was seen to have the same password on a number of systems (see issue {==XREFLocalAdministatorPasswordReuse==}), including the test workstation provided.
#### Impact: High
Anyone obtaining the local Administrator password, or its hash, can fully compromise the system. As the local Administrator account cannot be locked out, it is more susceptible to brute force attacks. Attackers obtaining this accounts' hash would be able to pass-the-hash and authenticate on other servers.
#### Likelihood: Low
Although the default local Administrator account (RID 500) is typically abused by malicious users, an attacker would need to obtain the local Administrator password hash in order to perform further attacks. {==OPTION==} Note that as the system{s are|| is} not encrypted, this would be trivial with unrestricted physical access.
#### Recommendation
Consider disabling the local Administrator account if it is not required. Alternatively, consider implementing the Windows Local Administrator Password Solution (Windows LAPS), which automatically changes the Administrator password to a strong unique password on each system, changes the password every two weeks and stores the passwords in Active Directory. Please see the following article for further information:

[https://learn.microsoft.com/en-us/windows-server/identity/laps/laps-overview]()
