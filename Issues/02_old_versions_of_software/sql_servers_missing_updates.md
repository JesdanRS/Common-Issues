---
category: "UPD"
cvss: "TBC"
---
### SQL Servers Missing Updates
The SQL Server instances listed below do not have the latest updates applied. The current version and the latest version are listed along with the SQL Server release.

{==TABLE==}
|Host     |Release|Build     |Installed SP|Latest SP|
|---------|-------|----------|------------|---------|
|127.0.0.1|2008 R2|10.50.2500|RTM         |SP2      |
{==END TABLE==}
#### Impact: Medium
There are number of well-known security issues affecting older versions of Microsoft SQL Server, which have been subsequently addressed in service packs and security updates.
#### Likelihood: Medium
Where security vulnerabilities exist, they are more likely to relate to local privilege escalation - which would require valid credentials on the SQL Server instance {==(see section XREF)==} - or denial of service vulnerabilities.
#### Recommendation
Ensure that the latest SQL Server service packs and security updates are applied. A list of SQL Server versions, with links to relevant updates, is maintained at the following URL:

[https://docs.microsoft.com/en-us/sql/database-engine/install-windows/latest-updates-for-microsoft-sql-server?view=sql-server-ver15]()
