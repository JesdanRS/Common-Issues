---
category: "CNF"
cvss: "7.6"
---
### Kerberos Unconstrained Delegation Enabled
Kerberos unconstrained delegation is a feature in Windows Active Directory historically used to allow servers to request network resources on behalf of other users and computer by storing their TGTs (Ticket Granting Tickets).
Since TGTs are stored locally, an attacker who is able to gain local administrative access to the computer configured for unconstrained delegation can extract them from memory and be able to impersonate any user or computer that previously connected to the compromised server, leading to lateral movement or privilege escalation on the domain.

The following {==computers/users==} have been found to be configured with unconstrained delegation:
{==POC==}
$ findDelegation.py {==DOMAIN_FQDN==}/{==USER==}:{==PASSWORD==} -dc-ip {==DC_IP==}
PS> Get-ADComputer -f {TrustedForDelegation -eq $True} | Select Name
```
{==COMMAND_OUTPUT==}
```
#### Impact: High
This issue can be exploited to perform privilege escalation within an Active Directory environment, which could lead to full compromise of the domain.
#### Likelihood: Low
Security issues in Kerberos unconstrained delegation are by design and are therefore well known. However, an attacker will need to first take over the affected {==computer/user==} account in order to take advantage of this issue.
#### Recommendation
{==OPTION==} Replace unconstrained delegation with constrained delegation and resource-based constrained delegation. While the latter should be prioritised, as considered as more secure, this feature is only available on Windows Server 2012 and newer. More information can be found at the following URL:

[https://learn.microsoft.com/en-us/windows-server/security/kerberos/kerberos-constrained-delegation-overview]()

Additionally, Kerberos delegation abuse can be partially mitigated by adding sensitive user accounts, such as domain administrator, to the "Protected Users" group and marking them as "Account is sensitive and cannot be delegated" (see section {==XREF_PRIVILEGED_USERS_NOT_PROTECTED==}). This will prevent any impersonation of that account via delegation. More information can be found at the following URL.

[https://learn.microsoft.com/en-us/windows-server/identity/ad-ds/manage/how-to-configure-protected-accounts]()