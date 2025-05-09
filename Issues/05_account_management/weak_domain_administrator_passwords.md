---
category: "PWD"
cvss: "9.6"
---
### Weak Domain Administrator Passwords
The following account{s||}, which {were members||was a member} of {==the==} privileged domain security group{==s==} ({==Administrators, Domain Admins and Enterprise Admins==}), {were||was} seen to have weak password{s||}:

{==|User|Masked Passwords|==}
{==|----|----|==}
{==|Test|Pa******d!|==}

{==OPTION==} Although {these||this} privileged domain account{s have passwords that comply||has a password that complies} with the domain password policy, {they are||it is} considered weak as {they are ||it is} based on {==DESCRIPTION OF PATTERNS==}.
#### Impact: High
Compromising {any of these accounts||this account} would grant an attacker full control over the entire {==DOMAINNAME==} Active Directory domain.
#### Likelihood: High
In some cases, {these||this} password{s||} would be quickly guessed. There are multiple attacks in an Active Directory environment (e.g. kerberoasting, broadcast protocols, forced SMB connections, etc.) which allow attackers to retrieve domain user password hashes. Offline password cracking techniques can then be utilised to reveal the plaintext passwords.
#### Recommendation
Ensure that all accounts, particularly those with high privileges, are secured with a strong passphrase or a unique randomly generated password which also complies with the current password policy. A strong passphrase typically consists of a unique randomly generated string that does not contain the account username, common phrases, organisation details, or well-known alphanumeric sequences. To help users create memorable passphrases, consider combining three or more random dictionary words then applying modifiers to meet complexity requirements.

Additionally, consider implementing a fine-grained policy for privileged accounts. Please refer to the following Microsoft article:

[https://learn.microsoft.com/en-us/windows-server/identity/ad-ds/get-started/adac/introduction-to-active-directory-administrative-center-enhancements--level-100-#fine_grained_pswd_policy_mgmt]()

Finally, consider carrying out regular password auditing. The following links show how to audit Active Directory passwords:

[https://www.dionach.com/active-directory-password-auditing-part-1-dumping-the-hashes]()
[https://www.dionach.com/active-directory-password-auditing-part-2-cracking-the-hashes]()
[https://www.dionach.com/active-directory-password-auditing-part-3-analysing-the-hashes]()
