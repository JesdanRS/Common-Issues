---
category: "CNF"
cvss: "6.5"
---
### Privileged Accounts Insufficiently Protected
{==OPTION_NOT_PROTECTED==} Sensitive domain accounts, such as domain administrators, were not seen as members of the "Protected Users" security group.

The "Protected Users" group was designed to enhance the security of high-privileged accounts against credential theft attacks. Members of this group benefit from non-configurable protections, which include:
- Disabling the use of NTLM authentication, digest authentication, or CredSSP for authentication, which prevents plaintext credentials from being cached.
- Removing the possibility of offline sign-ins.
- Ensuring that DES or RC4 encryption types are not used during Kerberos pre-authentication.
- Restricting members from being delegated via Kerberos unconstrained or constrained delegation.
- Limiting the renewal of Kerberos Ticket Granting Tickets (TGTs) beyond the initial four-hour lifetime.

By restricting the use of NTLM authentication, the "Protected Users" group provides defence against NTLM relay attacks {==(see section XREF_Broadcast_protocol)==}. Furthermore, preventing delegation for members of this group safeguards against Kerberos delegation vulnerabilities {==(see section XREF_delegation_issue)==}.

{==OPTION_NOT_DELEGATED==} Additionally, sensitive accounts were seen not to be marked as "Account is sensitive and cannot be delegated". When set, this flag prevents delegation and impersonation of the configured accounts. For more details, please visit the following link.

[https://learn.microsoft.com/en-us/windows-server/security/credentials-protection-and-management/protected-users-security-group#BKMK_HowItWorks]()
#### Impact: Medium
This issue can be exploited to perform privilege escalation within an Active Directory environment. Multiple vulnerabilities exist in NTLM authentication and Kerberos delegation, providing attackers with a mean to target domain administrators. Exploiting these vulnerabilities could result in the complete compromise of the domain.
#### Likelihood: Medium
Security issues in Kerberos delegation and NTLM authentication are by design and are therefore well known. However, an attacker will need to exploit another vulnerability in Active Directory to take advantage of this issue.
#### Recommendation
Review sensitive accounts such as domain administrators and consider adding them to the "Protected Users" group, as well as enabling the "Account is sensitive and cannot be delegated" flag to prevent delegation.

Please note that the default Administrator account can be delegated and impersonated even if member of the Protected Users group. It is suggested to mark said account as "Sensitive and cannot be delegated". For more information, please visit the following link:

[https://learn.microsoft.com/en-us/windows-server/identity/ad-ds/manage/how-to-configure-protected-accounts]()
