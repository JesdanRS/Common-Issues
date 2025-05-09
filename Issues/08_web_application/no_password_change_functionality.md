---
category: "APP-ATH"
cvss: "N/A"
---
### No Password Change Functionality
The affected website{s||} {do|does} not provide functionality for users to change their passwords.
#### Impact: Medium
Users may not be able to change their password in the event that they are compromised which could allow an unauthorised user to access their account.
#### Likelihood: Low
An attacker would need to compromise an account on the website either through a brute-force attack to obtain weak passwords (see section {==XREF NoAccountLockoutOrPasswordComplexity==}), by exploiting another vulnerability in the website {==such as the cross-site scripting/SQL injection vulnerability discussed in section XREF==}, or through the use of a social engineering attack. Additionally, an attacker may be able to find leaked passwords which have been used on other websites.  {==OPTION==} Users could {==use the forgotten password functionality or==} contact the service desk to reset their passwords.
#### Recommendation
Implement functionality to allow users to change their passwords. {==OPTION==} A password complexity policy should be enforced for new passwords (see section {==XREF==}), and users should be required to enter their current password in order to change it.
