---
category: "CNF"
cvss: "4.7"
---
### Insufficient Memory Protection
{The host was||Several hosts were} seen to not have sufficient security protections against memory leakage attacks. Windows stores passwords in memory which can be extracted in clear text using publicly available tools, if the following security configurations are not configured:

* LSA protections
* Wdigest protections
* Credential Guard

Please note that local administrator rights are required on the system{||s} to perform this attack. More information about these protections can be found at the following URLs:

[https://learn.microsoft.com/en-us/windows/security/identity-protection/credential-guard/]()
[https://learn.microsoft.com/en-us/windows-server/security/credentials-protection-and-management/configuring-additional-lsa-protection]()
[https://support.microsoft.com/en-us/topic/microsoft-security-advisory-update-to-improve-credentials-protection-and-management-may-13-2014-93434251-04ac-b7f3-52aa-9f951c14b649]()
#### Impact: High
An attacker can obtain clear text passwords from memory. If credentials of highly privileged domain accounts can be obtained, this could result in a complete compromise of the Active Directory domain.
#### Likelihood: Low
The techniques for obtaining clear text passwords from memory are well known, and a number of publicly available tools exist to perform these attacks. However, an attacker would first need to obtain local administrator privileges on the host{||s}.
#### Recommendation
{==OPTION==}Enforce LSA protection by creating the following registry keys with the corresponding values in "HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control\Lsa":

* RunAsPPL=1
* DisableRestrictedAdmin=0
* DisableRestrictedAdminOutboundCreds=1

{==OPTION==}Enforce Wdigest protection by creating the registry key UseLogonCredential in "HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control\SecurityProviders\WDigest" and set the value to 0.

{==OPTION==}Enable Windows Defender Credential Guard to protect LSA.

The following articles provide further information regarding the prevention and detection of this type of attacks:

[https://attack.mitre.org/techniques/T1003/]()
[https://www.sans.org/white-papers/36780/]()

Please note that a motivated attacker may be able to disable these protection configurations and still gain access to sensitive information stored in memory. As such, good housekeeping such as terminating idle sessions should also be performed.
