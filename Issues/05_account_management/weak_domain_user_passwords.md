---
category: "PWD"
cvss: "8.8"
---
### Weak Domain User Passwords
Domain user accounts were seen to use weak passwords ({==X==} out of {==X==} active user accounts), including several administrative accounts (see section {==XREF==}). While these passwords may comply with the current password policy, they are considered weak as they are based on the following easily guessed patterns:

 * {==Variations on usernames;==}
 * {==Variations on organisational details (such as the address and organisation name);==}
 * {==Variations on common passwords (such as Password and 123456);==}
 * {==Variations on the date of last password change;==}
 * {==Knowledge of internal procedures;==}
#### Impact: Medium
Anyone guessing these passwords or obtaining them through other means could gain access to sensitive or inappropriate systems or data. Actions performed by a compromised account could be incorrectly attributed to the account holder.
#### Likelihood: High
Some of the weak passwords identified were found to be trivial and easily guessable. Furthermore, many of these passwords could be obtained through offline password hash cracking.
#### Recommendation
Ensure that all accounts are secured with a passphrase that is enforced technically with a password policy. A strong passphrase is typically comprised of at least three random words that is not based on the username, common phrases, organisation details, or well-known alphanumeric sequences.

Consider carrying out regular password auditing. The following links show how to audit Active Directory passwords:

[https://www.dionach.com/active-directory-password-auditing-part-1-dumping-the-hashes]()
[https://www.dionach.com/active-directory-password-auditing-part-2-cracking-the-hashes]()
[https://www.dionach.com/active-directory-password-auditing-part-3-analysing-the-hashes]()
