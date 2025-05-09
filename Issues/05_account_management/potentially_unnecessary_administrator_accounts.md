---
category: "PRV"
cvss: "N/A"
---
### Potentially Unnecessary Administrator Accounts
The domain {==DOMAINNAME==} has a number of user accounts which are members of the highly privileged "{==Administrators==}", "{==Domain Admins==}" or "{==Enterprise Admins==}" security groups, and which may not be appropriate. These users are listed below; with their relevant group memberships:

Username
Administrator
Domain Admin
Enterprise Admin
{==USER1r==}
{==X==}
{==X==}
{==X==}
{==USER2==}
{==X==}
{==X==}
#### Impact: High
A large number of privileged accounts significantly increase the likelihood of domain compromise, as well as significantly increasing the administrative overhead of maintaining the Active Directory domain.
#### Likelihood: Medium
Privileged accounts would still require weak passwords in order to be compromised. {==OPTION==} This was seen to be the case with a number of accounts.
#### Recommendation
Ensure that regular auditing of security group membership and user access rights is undertaken to prevent inappropriate permissions from being granted to user accounts.
