---
category: "ATH"
cvss: "2.3"
---
### Windows Caches Passwords
The affected system{s||} {were||is} seen to cache users' login credentials in the local security accounts manager (SAM) database.
#### Impact: Medium
An attacker with access to the cached password hashes could perform offline password cracking attacks in order to obtain valid login credentials. These credentials could then be used to launch further attacks on the internal network.
#### Likelihood: Low
An attacker would need to have administrator or SYSTEM level access to the hosts listed above in order to obtain the cached hashes. Also, users would need to use fairly weak passwords, such as dictionary words or common phrases, in order for the passwords to be cracked.
#### Recommendation
Consider disabling caching of Windows login credentials by setting the following group policy to 0:

```
Computer Configuration\Windows Settings\Security Settings\Local Policies\Security Options\Interactive logon: Number of previous logons to cache (in case domain controller is not available)
```

Note that there are potential availability issues, particularly for laptops, which may prevent users from successfully logging in if caching is not enabled. More information is available in the following article:

[https://learn.microsoft.com/en-gb/previous-versions/windows/it-pro/windows-10/security/threat-protection/security-policy-settings/interactive-logon-number-of-previous-logons-to-cache-in-case-domain-controller-is-not-available]()
