---
category: "PRV"
cvss: "N/A"
---
### Multiple Access Keys Assigned to Users
A review of the AWS IAM service revealed that multiple access keys were assigned to individual users.{==OPTION==} {==NUMBER==} of these users have administrator privileges and {==NUMBER==} access keys were never used (see section XREF_USER_API_ACCESS_KEY_NEVER_USED) which are in grey in the table below:

{==TABLE: User|Access Key ID|Password and Access Key Enabled|Administrator Privileges==}
#### Impact: Medium
An attacker compromising an access key would be able to perform malicious actions, although the level of access would depend on the permissions granted to the compromised account.
#### Likelihood: Medium
The use of a large number of unnecessary access keys increases management overhead and chances of being compromised. Additionally, overly privileged access keys are more likely to be assigned incorrectly. However, an attacker would still require gaining access to a system or resource where access keys are stored.
#### Recommendation
Review current access keys assigned to users to determine whether the keys are required. Ensure that policies and procedures include regular reviews of accounts and access keys associated with them. Finally, perform a risk assessment in order to evaluate the need of having multiple access keys, and the need of having password based and key based authentication for the same account, as indicated by AWS security best practices:

[https://docs.aws.amazon.com/IAM/latest/UserGuide/best-practices.html#remove-credentials]()

{==OPTION==}Additionally, ensure that MFA is enabled (see section XREF_MFA_NOT_ENABLED) and unused key is deleted (see section XREF_USER_API_ACCESS_KEY_NEVER_USED).
