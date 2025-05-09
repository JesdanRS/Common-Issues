---
category: "PRV"
cvss: "8.2"
---
### SQL Server Service Unnecessary Privileges
The SQL Server instance{s||} installed on the affected system{s||} {are||is} running under the domain account "{==ACCOUNT==}". {==OPTION==} This account is a member of the privileged "{==GROUP==}" domain security group. As a result, any operation performed by this instance or its supporting services will be run with {==EITHER==} complete "Administrator" level privileges{== OR ==}the privileges of an equivalent user to the SQL service account.
{==SCREENSHOT==}

{==OPTION==} It is also possible to exploit this issue with a low privileged domain user account when the SQL instance contains the "BUILTIN\Users" group {==XREFSQLSERVERLOGINUNNECESSARYPRIVILEGES==} by leveraging the extended stored procedure "xp_dirtree" command to force the SQL instance to authenticate to an attacker controlled server where the Net-NTLMv2 hash can be captured and relayed onto a server where the domain user account has administrative privileges. The following example demonstrates how the hash can be captured from the domain user account {==DOMAINUSERNAME==} and relayed to authenticate to another server, when SMB signing is not enforced {==XREFSMBSIGNINGNOTENFOCED==}:
{==SCREENSHOT==}
{==OPTION==} As the SQL Server instance is running under the domain user account {==DOMAINUSERNAME==} which is part of the local administrator on a number of systems, an attacker can leverage this issue to achieve remote command execution.
#### Impact: High
Anyone gaining administrative access to the SQL Server instance, a supporting service, or the hosting server, would quickly gain complete control over the entire Active Directory domain.
#### Likelihood: Low
An attacker could only exploit this issue in combination with another issue such as weak SQL Server login password (see section {==XREFWeakSQLLoginPassword==}), or a weak local "Administrator" account password (see section {==XREFWeakLocalAdministratorAccount==}). An attacker may also be able to exploit this issue if overly permissive SQL server login permissions are configured which allow for the execution of the xp_dirtree command in order to force the SQL Service instance account to perform Net-NTLMv2 authentication (see section {==XREFSQLServerUnnecessaryPrivilges==}).
#### Recommendation
Review and reduce the privileges assigned to this account and the SQL Server services. There are very few situations where a SQL Server instance requires {==UPDATE AS APPROPRIATE==} SYSTEM or Administrator level privileges and typically the local "Network Service" account, or a named low privilege domain account, would be sufficient.
