---
category: "TBA"
cvss: "TBA"
---
### Credentials Stored in LSA Secrets
Several hosts were seen to run Windows services under the context of domain accounts. Windows stores encrypted credentials of these accounts in the registry, and they are typically referred to as LSA secrets. However, an attacker with local administrator rights can extract and decrypt them.

Further information about LSA secrets can be found at the following article:

[https://learn.microsoft.com/en-us/windows-server/security/credentials-protection-and-management/credentials-protection-and-management#lsa-protection]()

Please note that the following {==domain administrator==} credentials were seen to be stored in the LSA secrets.

{==XREF_TABLE==}

{==OPTION==}For a full list of credentials extracted from LSA secrets, please see {==JOBREF==} - Internal Network Penetration Test Findings spreadsheet.
#### Impact: High
An attacker can obtain clear text passwords from the LSA secrets, potentially of highly privileged domain accounts that could result in a complete compromise of the Active Directory domain.
#### Likelihood: Low
The technique for obtaining clear text passwords from LSA secrets is well known, and a number of publicly available tools exist to perform this attack. However, an attacker would first need to obtain local administrator privileges on the affected systems.
#### Recommendation
Consider using built-in service account instead of highly privileged accounts to run Windows services. Further information can be found at the following article:

[https://learn.microsoft.com/en-us/windows-server/identity/ad-ds/manage/understand-service-accounts]()

{==OPTION==}Also, consider changing the password of the accounts that were extracted from LSA secrets.
