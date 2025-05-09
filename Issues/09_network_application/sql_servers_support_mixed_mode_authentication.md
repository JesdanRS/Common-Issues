---
category: "ATH"
cvss: "N/A"
---
### SQL Servers Support Mixed Mode Authentication
The SQL Server instance{s||} installed on the affected system{s||} support{s||} SQL Server mixed mode authentication for connections from other network hosts.

Mixed mode allows authentication against the database{s||} using SQL Server accounts, rather than Windows authentication which uses local Windows or Active Directory accounts only.

{==OPTIONUnecryptedSQL==} Please note that although the login credentials are encrypted with TLS, all other traffic is sent conducted in unencrypted, as discussed in section {==XREFUnencryptedSQLTraffic==}.

{==OPTIONUnknown==} Please note that by default the login credentials are generally encrypted with TLS, they may be sent unencrypted by legacy or badly written client applications. Additionally, all other communication with SQL Server is conducted in clear text unless encrypted communications are enabled.
#### Impact: Medium
SQL Server accounts are not subject to the same policies as Active Directory accounts, and as such may not have password policies and account lockout configured. Additionally, as they are not centrally managed, they are frequently overlooked, which can result in weak passwords that are not changed for long periods.
#### Likelihood: Low
An attacker would need to guess or brute-force a SQL Server password in order to exploit this issue. {==OPTION==} Note that some accounts were seen to have weak passwords, as discussed in section {==XREFWeakSQLServerPasswords==}.
#### Recommendation
As the server{s are|| is} part of the internal domain, and the clients will most likely be domain member systems, consider disabling SQL Server authentication and using Windows authentication instead. {==OPTION==} Also consider implementing encrypted communications for all SQL Server instances; with the use of a digital certificate signed by a trusted Certification Authority. This could be internal, and integrated into the existing infrastructure. See the following link for more information.

[https://learn.microsoft.com/en-us/sql/relational-databases/security/choose-an-authentication-mode]()
