---
category: "PRV"
cvss: "8.3"
---
### Computer Accounts Members of Privileged Domain Groups
A review of the {==PRIVILEGEDDOMAINGROUP==} group contained a number of computer accounts:

{==COMPUTERACCOUNTS==}

The {==PRIVILEGEDDOMAINGROUP==} group was found to be part of the local administrators group on a large number of systems, however this group contains computer accounts which can be leveraged by an attacker to authenticate to systems with administrative privileges.
#### Impact: High
An attacker exploiting a computer account either by obtaining a password from the Windows LSA secrets registry hive or by relaying account hashes {==XREFNTLMRELAY==} can gain administrative access on a large number of workstations within the {==CLIENTNAME==} environment.
#### Likelihood: Medium
A number of computer accounts are part of a privileged domain group with local administrative access to a large number of computers throughout the {==CLIENTNAME==} environment {==XREFLOCALADMINGROUP==}. It may be common practice within {==CLIENTNAME==} and as such, it could be likely that more computer accounts are added to privileged domain groups at time progresses.
#### Recommendation
Review current privileged domain groups such as {==EXAMPLEGROUP==} group and remove computer accounts and instead, add service accounts to these groups to reduce the privileges required by the services. If computer accounts are required to be included in these domain groups, then consider enabling the "Account is sensitive and cannot be delegated" for these accounts to ensure that authentication credentials are not relayed to attacker controlled systems. For more information please refer to the following article:

[https://learn.microsoft.com/en-gb/archive/blogs/poshchap/security-focus-analysing-account-is-sensitive-and-cannot-be-delegated-for-privileged-accounts]()
