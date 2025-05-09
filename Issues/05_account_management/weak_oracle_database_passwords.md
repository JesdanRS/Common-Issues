---
category: "PWD"
cvss: "TBC"
---
### Weak Oracle Database Passwords
The Oracle database running on the affected system{s||} {have||has} several users with very {==weak and/or default==} passwords. These are listed below. Note that passwords are masked.

{==TABLE==}
#### Impact: High
An attacker guessing the password for a valid user account would be able to access any data on the Oracle instance to which that account has access. In addition, if the user is sufficiently privileged, they may also be able to execute operating system commands.
#### Likelihood: High
Many of these passwords would be quickly guessed, particularly by someone with knowledge of {==CLIENTNAME==}'s internal procedures. {==OPTION==} Many of these passwords are well-known default passwords, and would be quickly guessed by an attacker.
#### Recommendation
Ensure that accounts are protected with strong complex passwords which are not based on the username, common phrases, organisational details, or well-known alphanumeric sequences and are at least 8 characters long and contain uppercase, lowercase and special characters. Disable users if they are not required.
