---
category: "PWD"
cvss: "TBC"
---
### Weak SQL Server Login Passwords
The following SQL Server instances were seen to have weak passwords. {==In most cases the password was the same as the username for the SQL Server login==}.

HOST
Username
Password
{==HOST==}
{==Username==}
{==P******d==}
#### Impact: Medium
Anyone on the local network guessing these passwords could connect to the SQL Server instances and access data hosted on them. In some cases they may also be able to execute operating system commands.
#### Likelihood: High
Many of the passwords identified would be quickly guessed, particularly by someone with knowledge of internal systems or procedures.
#### Recommendation
Unless there is a specific business requirement for SQL Server authentication to be supported, it should be disabled and Windows Integrated Authentication used instead (see section {==XREFSqlServerSupportsMixedMode==}). If SQL Server authentication is required, ensure that all SQL Server logins have passwords which comply with the {==CLIENTNAME==} security policy.
