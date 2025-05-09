---
category: "ATH"
cvss: "2.3"
---
### Domain Passwords Stored Using LM Hashing Algorithm
The Active Directory domain {==DOMAIN==} stores the passwords of the following user accounts using the LM hashing algorithm.

{==ACCOUNTS==}

There are a number of well-known weaknesses in this hashing algorithm which makes it comparatively easy to obtain users passwords, given a specific hash. Furthermore, approximately 99.99% of the entire LM key space has been mapped which makes Rainbow Table cryptanalysis straightforward.

{==OPTION==} Please note that the domain controllers have been configured to not store LM hashes for any new passwords; however existing LM hashes will not be removed until the passwords for those accounts are changed.
#### Impact: Medium
A Domain Admin level user or an attacker with access to the LM hashes could quickly obtain the raw passwords. They could then attempt to re-use these passwords on other accounts or systems (see section {==XREFPasswordReuse==}), or use them as a starting point to crack passwords stored in the more secure NTLM format.
#### Likelihood: Low
An attacker would first need to have achieved Domain Admin level access or SYSTEM level access on a Domain Controller in order to obtain these hashes, or to have retrieved them from a stolen backup or through physical access to the system.
#### Recommendation
Ensure that the security setting "Network security: Do not store LAN Manager hash value on next password change" is enabled in the "Default Domain Policy" group policy object. Ensure that all users change their passwords to ensure that LM hashes are removed from the Active Directory following the enabling of this setting. The article below gives more information.

[https://learn.microsoft.com/en-us/troubleshoot/windows-server/windows-security/prevent-windows-store-lm-hash-password]()

{==OPTION==} Note that many of the accounts with LM hashes were seen to be used for running services, rather than being regular user accounts.
