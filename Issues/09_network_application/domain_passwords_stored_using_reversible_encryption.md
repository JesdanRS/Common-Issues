---
category: "ATH"
cvss: "2.3"
---
### Domain Passwords Stored Using Reversible Encryption
A small number of users in the {==DOMAIN==} Active Directory domain were found to have passwords that were stored using reversible encryption. This means that the clear text passwords for these accounts can be decrypted by an attacker with Domain Administrator rights, or access to a backup of a domain controller. The accounts are listed below:

{==LIST==}

This feature is typically used when services use authentication protocols such as HTTP Digest Authentication and CHAP that require the clear text passwords to function properly.
#### Impact: Medium
An attacker could obtain clear text passwords for the all users in the domain. These could potentially be re-used to authenticate on other systems (see section {==XREFPasswordReuse==}, or as part of further attacks.
#### Likelihood: Low
An attacker would first need to have obtained administrative access to a Domain Controller in order to obtain these hashes, or to have retrieved them from a stolen backup or through physical access to the system.
#### Recommendation
{==OPTION==} The storage of passwords using reversible encryption was seen to be disabled on the domain, and the small number of accounts suggests that these are legacy accounts that have been unused for a period of time. If the accounts are no longer required then disable them; change the passwords for these accounts so that the new password is stored as an NTLM hash.
{==OPTION==} Unless specifically required, disable the storage of passwords using reversible encryption by setting the following Group Policy to "Disabled":

```
Computer Configuration\Policies\Windows Settings\Security Settings\Account Policies\Password Policy\Store password using reversible encryption
```

Please note that once this policy is configured, the reversibly encrypted passwords will be stored until the users next change their passwords. As such, processes should be put in place to expire and change all current passwords.

The following Microsoft article contains further details:

[https://docs.microsoft.com/en-gb/windows/device-security/security-policy-settings/store-passwords-using-reversible-encryption]()
