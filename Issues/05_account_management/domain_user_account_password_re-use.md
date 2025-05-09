---
category: "PWD"
cvss: "8.7"
---
### Domain User Account Password Re-Use
Auditing of the active user accounts in the {==DOMAIN==} Active Directory domain identified that {==NUM==} users ({==PERCENT==}%) had non-unique passwords. The {==20==} most common passwords in use are shown below. Please note that due to the way Windows stores passwords, even if the password hash cannot be cracked to obtain the clear text password, it is possible to determine two passwords are identical.

{==TABLE==}

The following users were found to have matching passwords. Privileged accounts are highlighted in bold.

{==LIST OF USERS, create an Appendix if too many==}

{==OPTION==} Sharing passwords between standard and privileged domain accounts greatly increases the risk of compromise of the domain. If an attacker discovers the password of any of the above low-privileged accounts, they can take control of the privileged accounts sharing the same password, using attacks such as password spraying.
#### Impact: High
An attacker guessing or obtaining the password from any of these users could potentially compromise other user accounts. {==OPTION==} In some cases regular and administrative accounts were seen to use the same password, which would allow an attacker to quickly escalate their privileges within the domain.
#### Likelihood: Medium
Testing an obtained password on multiple systems or user accounts is a common attack strategy, especially where multiple accounts are known to be owned by the same user. However, an attacker would need to obtain either the password hashes or clear text password in order to exploit this issue.
#### Recommendation
Deliver awareness training to discourage users and IT staff from choosing common passwords or sharing their password between multiple accounts. Avoid using the same password for multiple user accounts and systems where possible, particularly if any of these accounts are granted privileged access to systems or resources. Consider performing regular password auditing to identify weak or non-unique passwords. This should also include reviewing password creation processes to ensure domain accounts are configured with unique passwords.

Additionally, ensure that domain accounts are configured with a unique passphrase as part of internal processes or procedures.

{==OPTION IF AZURE==} Consider enabling Microsoft Entra Password Protection to prevent the use of common passwords. Please see the following URL for more information:

https://learn.microsoft.com/en-us/entra/identity/authentication/concept-password-ban-bad

https://learn.microsoft.com/en-us/entra/identity/authentication/concept-password-ban-bad-on-premises
