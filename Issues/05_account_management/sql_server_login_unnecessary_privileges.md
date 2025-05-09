---
category: "PRV"
cvss: "8.2"
---
### SQL Server Login Unnecessary Privileges
The SQL Server logins shown below are members of the privileged "{==sysadmin==}" role on the SQL Server instance. As a result, these logins can be used to access any data in any database on the SQL Server instance, and can also run operating system commands in the context of the SQL Server service account. {==OPTION==} Please note that these logins are used by several {==internal==} web applications.

HOST
IP
SYSADMIN
{==HOST==}
{==IP==}
{==USERS==}

Please note that the credentials for these accounts were stored in clear text in a number of configuration files ({==see section XREFConfigPasswords==}) and the service was running in the context of an account with full Administrator level privileges over the entire {==DOMAINNAME==} Active Directory domain.

{==OPTION==} Please also note that the execution of operating system commands was enabled on the database instance, suggesting either that this functionality is frequently in use, or that the SQL Server instance has not been hardened.

{==OPTION==} The SQL server instances below are also configured with the BUILTIN\Users group, permitting domain users login rights in addition to running extended stored procedures such as "xp_dirtree" or "xp_cmdshell" which can be leveraged to exploit SQL service accounts (see section {==XREFSQLServerServiceUnnecessaryPrivileges==}).
#### Impact: High
An attacker successfully authenticating to this SQL Server instance would be able to run operating system commands, access or modify potentially sensitive data, or cause a denial of service by deleting or shutting down databases. {==OPTION==} Additionally an attacker may also be able to execute SQL stored procedures such as "xp_dirtree" or "xp_cmdshell" in order to force the SQL Server instances to authenticate to attacker controlled systems.
#### Likelihood: Medium
An attacker would need to obtain the credentials for these accounts. This can be achieved by using passwords found in one of the shared folders ({==see section XREFShareAccessControl==}), or exploiting a vulnerability in the hosting server, such as a weak SQL Server login password or local administrator account password ({==see section XREFLocalAdminPassword==}).
#### Recommendation
Avoid the use of privileged accounts, such as members of the "{==sysadmins==}" role, instead using low privileged accounts which only have access to the data they require. {==OPTION==}Additionally, consider disabling support for execution of operating system commands on the SQL Server instance. Please note that an attacker with sufficient access can often easily re-enable this. {==OPTION==} Remove the "BUILTIN\Users" group from the SQL Server instance, or restrict access to extended stored procedures such as "xp_dirtree" or "xp_cmdshell".
