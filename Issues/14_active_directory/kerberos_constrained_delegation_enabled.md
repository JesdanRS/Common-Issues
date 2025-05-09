---
category: "CNF"
cvss: "7.6"
---
### Kerberos Constrained Delegation Enabled
Kerberos constrained delegation allows a domain account to access a specific list of services on behalf of another domain user via impersonation. In order to configure an account for constrained delegation, a Service Principal Name (SPN) needs to be created for said account. Constrained delegation is regulated by the "msDS-AllowedToDelegateTo" attribute.

To successfully impersonate another account via constrained delegation, two important steps need to take place:
- Service for user to self (S4U2Self): The account configured for constrained delegation requests a Service Ticket (TGS) on behalf of the impersonated user for their own SPN.
- Service for user to proxy (S4U2Proxy): The account configured for delegation, supplies the ticket requested via S4U2Self to the Key Distribution Center (KDC) and requests another TGS on behalf of the impersonated user. The KDC checks if the ticket obtained via S4U2Self has the "Forwardable" flag set and if the user requesting the ticket is actually allowed to perform delegation. If both checks are successful, the KDC issues the TGS to the impersonated user for the requested service.

This means that if an attacker compromises an account configured with constrained delegation, they will most likely be able to take full control of any host this account is allowed to delegate to.

For example, the {==COMPUTER==}{==USER==} account "{==ACCOUNT==}" has constrained delegation enabled and can access a number of services on behalf of any domain user. The list of the services this account can access is included in its "msDS-AllowedToDelegateTo" property, as shown below:

$ Get-ADUser {==ACCOUNT==} -Properties msDS-AllowedToDelegateTo | Select-Object -ExpandProperty msDS-AllowedToDelegateTo
{==OPTION==}$ Get-ADComputer {==ACCOUNT==} -Properties msDS-AllowedToDelegateTo | Select-Object -ExpandProperty msDS-AllowedToDelegateTo
```
{==COMMAND OUTPUT==}
{==Highlight all the hosts within the SPNs listed==}
```

Therefore, if an attacker compromises the "{==ACCOUNT==}" account, they will be able to take full control of any of the hosts highlighted above, such as {==HOSTNAME==}.

Resource-Based Constrained delegation (RBCD) {==Underline this title==}
Another type of constrained delegation is the resource-based constrained delegation, that manages which accounts can access resources to a computer on behalf of other accounts via impersonation. This is controlled by the "msDS-AllowedToActOnBehalfOfOtherIdentity" attribute of a computer account. If an attacker is able to modify this attribute, they will be able to take full control of the computer configured for RBCD. Note that any domain account can modify their own "msDS-AllowedToActOnBehalfOfOtherIdentity" attribute and enable RBCD. This is a significant difference between the other forms of delegation, which can only be enabled or modified by domain administrators.

In order to exploit this issue, an attacker would either need to have write access, for example due to misconfigured Discretionary Access Control Lists (DACLs) to the computer account properties or to take control of the computer account itself, mainly via NTLM relay attacks. This can be done for example by leveraging broadcast protocols and NTLM relay attacks, print system remote protocol or PetitPotam exploit (see sections {==XREF_RELEVANT_ISSUES==}).

Resource-based constrained delegation can also be set on domain controllers, so if an attacker is able to exploit it, they will gain administrative access to the domain controller itself and therefore to the entire infrastructure.

The critical security flaws found in Kerberos delegation are fully documented in the following post:

[https://shenaniganslabs.io/2019/01/28/Wagging-the-Dog.html]()

{==OPTION==} Please note that {==constrained/resource-based constrained delegation==} were not seen to be in use within the {==DOMAIN==} domain.
#### Impact: High
This issue can be exploited to perform privilege escalation within an Active Directory environment, which can, in certain cases, lead to the full compromise of the domain.
#### Likelihood: Medium
Security issues in Kerberos delegation are by design and are therefore well known. However, an attacker will need to exploit another vulnerability in Active Directory in order to take advantage of this issue.
#### Recommendation
{==OPTION==} Ensure that accounts allowed to delegate are configured according to the principle of least privilege and with strong uniquely generated passphrases. Note that Microsoft also offers the possibility to manage accounts via the usage of group Managed Service Accounts (gMSA), which have a strong and unique password that changes periodically. Please note that RBCD feature is only available on Windows Server 2012 and newer. More information can be found at the following URL:

[https://docs.microsoft.com/en-us/windows-server/security/kerberos/kerberos-constrained-delegation-overview]()

Kerberos delegation abuse can be partially mitigated by adding sensitive user accounts, such as domain administrator, to the "Protected Users" group and marking them as "Account is sensitive and cannot be delegated" (see section {==XREF_PRIVILEGED_USERS_NOT_PROTECTED==}). This will prevent any impersonation of that account via delegation. More information can be found at the following URL.

[https://docs.microsoft.com/en-us/windows-server/identity/ad-ds/manage/how-to-configure-protected-accounts]()
