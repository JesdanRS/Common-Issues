---
category: "PRV"
cvss: "N/A"
---
### Password Based Access Not Used in a Long Time
The following users have not accessed AWS in more than 90 days, which may mean that these accounts are not required, or might belong to staff whose roles or positions have changed. This may indicate an inefficiency in user account management.

{==USER_LIST==}
#### Impact: Medium
Unnecessary accounts could increase the likelihood of compromise via guessed credentials, as well as significantly increasing the administrative overhead of maintaining AWS IAM service.
#### Likelihood: Low
An attacker would need guess a user's password in order to exploit this issue. The victim would need to use a weak password, not have MFA enabled (see section {==XREF_MFA_DISABLED==}), or accounts for leavers might have not been deleted.
#### Recommendation
Review these accounts to see if they are still required. If they are not required, delete the accounts. If they are required, verify their purpose and enforce MFA on the accounts (see section {==XREF_MFA_DISABLED==}) if not already. Ensure user accounts are being reviewed periodically, such as every three months, and that leavers processes and role change processes include adjustment of AWS accounts. Review user account management procedures to ensure that if users no longer require API access, their keys are revoked or deleted (see section {==XREF_API_ACCESS_KEY_NEVER_USED==}).