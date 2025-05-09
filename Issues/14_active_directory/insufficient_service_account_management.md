---
category: "CNF"
cvss: "8.7"
---
### Insufficient Service Account Management
Service accounts were seen to be used within the {==XREF_Domain==} domain. These accounts are primary targets for attackers as they often have broader privileges due to their need to interact with multiple applications and systems on the network. As such, a service can be associated with a Service Principal Name (SPN) in order to be accessible over the network. SPNs bind a service instance, such as the SQL server instance "MSSQLSvc", to the service account running the instance. The following service accounts were seen to be associated with a SPN:

| Service Account | Associated SPN |
| SQLServiceAcc | MSSQLSvc/HOST.domain.internal |
| | |

A vulnerability in the Kerberos authentication protocol, known as "Kerberoasting", allows an attacker to retrieve the password hash of any service account associated with SPNs. In essence, when a user wants to access a service, they send a request to the domain controller that includes the SPN of the service. The domain controller verifies which account is running the service and returns a Ticket Granting Service (TGS) encrypted with the NT hash of this account.

However, the domain controller does not verify whether the user requesting access to a specific service is authorised to do so, which means that any domain user can request a TGS for any service having a valid SPN. Therefore, a domain user can arbitrarily obtain a Kerberos TGS encrypted with the NT hash of the respective service accounts. An attacker can leverage this vulnerability to attack the TGS offline in an attempt to crack service accounts' passwords. A successful offline brute-force attack would allow an attacker to retrieve the plaintext password of any service account mapped with an SPN.

An example of this attack being performed using the publicly available "GetUserSPNs.py" script from Impacket is shown below {==OPTION the publicly available Rubeus tool is shown below==}:

{==EXAMPLE==}

Undertaking offline cracking against these hashes revealed that the "{==XREF_ACCOUNT==}" domain {==service==} account uses a weak password (see section {==XREF_WEAK_PASSWORDS/ADMIN_WEAK_PASSWORD==}).{==OPTION_ADMIN_ACCOUNT==} Since the domain {==service==} account "{==XREF_ACCOUNT==}" was part of the highly privileged "{==XREF_GROUP==}" group, an attacker exploiting this issue will take full control of the {==XREF_DOMAIN==} domain.

{==OPTION_NON_SERVICE_ACCOUNT==} Please note that the "{==XREF_ACCOUNT==}" account was also seen to be a standard domain user {==was also seen to be a domain administrator ==} account. Using a standard domain user {==domain administrator==} account as a service account can introduce a number of vulnerabilities within an Active Directory environment, as previously demonstrated with the Kerberoasting attack. In addition, the nature and sensitivity of a service account requires specific configurations and tight controls, which are not compatible with the day-to-day {==administrative==} activities of a standard domain user {==domain administrator==}.

For more information on SPNs and how the "Kerberoasting" attack works, please refer to the following URLs:

[https://learn.microsoft.com/en-us/windows/win32/ad/service-principal-names]()
[https://blog.xpnsec.com/kerberos-attacks-part-1]()
#### Impact: Medium
{==OPTION IF vulnerable account with high priv like DA and weak PWD, impact High==} An attacker exploiting this issue would quickly gain access to highly privileged accounts leading to the complete compromise of {==XREF_DOMAIN==} domain.
{==OPTION IF vulnerable account with high priv like DA and NO weak PWD, impact High==} An attacker exploiting this issue would quickly gain access to password hashes of highly privileged accounts. Although these accounts were not seen to use weak passwords, an attacker may be able to crack the hashes with more time and resources, which could lead to the complete compromise of {==XREF_DOMAIN==} domain.
{==OPTION IF vulnerable account(s) with no priv like DA and weak pwd, impact Medium==} An attacker exploiting this issue would be able to quickly compromise domain {==service==} accounts. The compromised domain {==service==} accounts could be used to access additional resources or systems, or to attempt privilege escalation attacks within the {==XREF_DOMAIN==} domain.
{==OPTION IF vulnerable account(s) with no priv like DA and NO weak pwd, impact Medium==} An attacker exploiting this issue would quickly gain access to password hashes of domain {==service==} accounts. Although these accounts were not seen to use weak passwords, an attacker may be able to crack the hashes with more time and resources, which could then be used by the attacker to escalate their privileges within the {==XREF_DOMAIN==} domain.
#### Likelihood: High
{==OPTION IF weak password, likelihood High==}Numerous public tools are available to exploit this issue. Any low privileged domain user would be able to retrieve the password hashes of domain accounts associated with an SPN. Additionally, a large number of accounts were seen to have weak passwords {==(see section XREF_WEAK_DOMAIN_USER_PASSWORDS)==}
{==OPTION IF not weak password, likelihood Medium==}Numerous public tools are available to exploit this issue. Any low privileged domain user would be able to retrieve the password hashes of domain accounts associated with an SPN. However, the above domain {==service==} accounts would need to have weak passwords which were not seen to be the case.
#### Recommendation
{==OPTION IF SPNs set up for domain user==} Ensure that SPNs are not configured for arbitrary domain user accounts{==OPTION IF SPNs set up for domain admin==}, especially those with domain administrator privileges.

Ensure that service accounts, particularly those with an SPN, are configured according to the principle of least privilege and with strong uniquely generated passphrases. {==OPTION Service accounts should not require domain administrator privileges.==} Note that Microsoft offers the ability to manage service accounts through Managed Service Account (MSA), which will ensure that these service accounts use complex and periodically changed passwords. More information can be found in the following articles:

[https://learn.microsoft.com/en-us/windows-server/identity/ad-ds/manage/group-managed-service-accounts/group-managed-service-accounts/group-managed-service-accounts-overview]()
[https://techcommunity.microsoft.com/t5/ask-the-directory-services-team/managed-service-accounts-understanding-implementing-best/ba-p/397009]()

Additionally, ensure that interactive logon is not permitted for service accounts. This can be configured via Group policy with the "Log on as a service" setting, which grants service accounts limited access to specific hosts. Further details can be found below:

[https://learn.microsoft.com/en-us/system-center/scsm/enable-service-log-on-sm?view=sc-sm-2022]()

Lastly, conduct regular reviews of all service accounts to ensure that they are still required, do not have excessive permissions, and use a strong password.
