---
category: "CNF"
cvss: "7.5"
---
### Domain Accounts Do Not Require Kerberos Pre-Authentication
The Active Directory accounts listed above have been configured to not require Kerberos pre-authentication. Pre-Authentication happens when a user asks a TGT (Ticket Granting Ticket) to the KDC (Key Distribution Center) on the domain controller. The user will encrypt a timestamp, to prevent replay attacks, with a key derived from his password and will send the encrypted timestamp to the KDC. The KDC will decrypt the encrypted timestamp confirming that the user is who they say they are and then will return an encrypted TGT to the user along with a session key.

When a user is configured to not require pre-authentication, the step described above is not performed, allowing any user to request a TGT on behalf of the misconfigured user. The KDC has no way to validate the identity of the requestor and therefore will still issue an encrypted TGT. The message from the KDC which contains the encrypted TGT and the session key is called AS-REP.
An attacker can exploit this vulnerability by requesting TGTs for misconfigured users, attempting to crack them offline and retrieving the user's password, as shown in the following proof of concept:

{==POC==}
PS> Get-ADUser -filter {DoesNotRequirePreAuth -eq $true} | Select Name
```
{==PASTE_OUTPUT==}
```
#### Impact: Medium
{==OPTION IF vulnerable account with high priv like DA and weak PWD, impact High==} An attacker exploiting this issue would quickly gain access to highly privileged accounts leading to the complete compromise of {==XREF_DOMAIN==} domain.
{==OPTION IF vulnerable account with high priv like DA and NO weak PWD, impact High==} An attacker exploiting this issue would quickly gain access to password hashes of highly privileged accounts. Although these accounts were not seen to use weak passwords, an attacker may be able to crack the hashes with more time and resources, which could lead to the complete compromise of {==XREF_DOMAIN==} domain.
{==OPTION IF vulnerable account(s) with no priv like DA and weak pwd, impact Medium==} An attacker exploiting this issue would be able to quickly compromise domain {==service==} accounts. The compromised domain {==service==} accounts could be used to access additional resources or systems, or to attempt privilege escalation attacks within the {==XREF_DOMAIN==} domain.
{==OPTION IF vulnerable account(s) with no priv like DA and NO weak pwd, impact Medium==} An attacker exploiting this issue would quickly gain access to password hashes of domain {==service==} accounts. Although these accounts were not seen to use weak passwords, an attacker may be able to crack the hashes with more time and resources, which could then be used by the attacker to escalate their privileges within the {==XREF_DOMAIN==} domain.
#### Likelihood: High
{==OPTION IF weak password, likelihood High==}Numerous public tools are available to exploit this issue. Any low privileged domain user would be able to retrieve the password hashes of domain accounts set to not require pre-authentication. Additionally, a large number of accounts were seen to have weak passwords (see section {==XREF_WEAK_DOMAIN_USER_PASSWORDS==}).
{==OPTION IF not weak password, likelihood Medium==}Numerous public tools are available to exploit this issue. Any low privileged domain user would be able to retrieve the password hashes of domain accounts associated with an SPN. However, the above domain {==service==} accounts would need to have weak passwords which were not seen to be the case.
#### Recommendation
Review the affected accounts and ensure that no account is configured with Kerberos pre-authentication. If this is not possible for compatibility reasons, ensure that affected accounts use strong passwords to reduce the risk of a successful compromise.
