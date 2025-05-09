---
category: "ATH"
cvss: "5.3"
---
### Windows Hosts Allow SMB Login via Null Session
The affected system{s||} allow{s||} anonymous logon to the "IPC$" share via SMB.

This allows a vast amount of information to be obtained from the Windows host including:

 * Enumeration of network shares,
 * SID extraction,
 * Service enumeration,
 * Windows system browse list (via LANMAN).
#### Impact: Low
Information can be obtained regarding the domain by someone who has no credentials.
#### Likelihood: Medium
There are numerous tools that can easily extract this information.
#### Recommendation
Although a relatively minor issue, if limited access by anonymous logon users is not specifically required, it should be disabled. The following Microsoft article gives further guidance on this issue.

[https://support.microsoft.com/en-gb/kb/143474]()