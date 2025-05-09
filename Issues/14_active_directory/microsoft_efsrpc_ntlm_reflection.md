---
category: "CNF"
cvss: "5.3"
---
### Microsoft EFSRPC NTLM Reflection
{==NOTE: only report the unauthenticated vector of PetitPotam; the authenticated exploit shuold not be report as MS said it's a design flaw and won't be fixed==}
The affected systems were vulnerable to a security flaw in the Encrypting File System Remote (EFSRPC) Protocol known as "PetitPotam" (CVE-2021-36942). EFSRPC is enabled by default on all Windows machines and it is typically used to maintain and manage encrypted data that is stored remotely and accessed over a network.

PetitPotam allows an unauthenticated attacker to force a remote server to authenticate to an arbitrary system under their control via the SMB protocol, disclosing the NTLM hash of the server's computer account. The following proof of concept shows how it was possible to perform this attack against the system at {==HOSTNAME==}.

{==Proof of concept==}
#### Impact: Medium
An attacker can force any Windows machine, including sensitive servers such as domain controllers, to attempt to connect to an attacker chosen system. This allows the NTLMv2 hash for the computer account to be captured. An attacker could use the captured credentials to gain administrative access to systems within the network and escalate privileges to compromise the Active Directory environment.
#### Likelihood: Medium
Tools to exploit this issue are publicly avialble allowing attackers to easily capture the NTLM hash for computer accounts. However, an attacker would need to exploit another vulnerability such as {==NTLM relaying or ADCS==}, to exploit this issue (please see section {==XREF NTLM relaying or ADCS Issue}).
#### Recommendation
Ensure that relevant security updates are installed as detailed in the following article:

[https://msrc.microsoft.com/update-guide/en-US/vulnerability/CVE-2021-36942]()

Please note that this patch only fixes the unauthenticated vector of PetitPotam and that no patch is currently available for the authenticated vector of this exploit. Therefore, ensure systems within the network are protected against relaying attacks by enforcing SMB and LDAP signing features and monitoring them to detect this attack.
