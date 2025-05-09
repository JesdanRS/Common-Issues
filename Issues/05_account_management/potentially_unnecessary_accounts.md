---
category: "PRV"
cvss: "N/A"
---
### Potentially Unnecessary Accounts
A review of Active Directory membership for the {==DOMAIN==} domain identified around {==PERCENTAGE==}% of the active accounts had not been accessed in more than 90 days, and around {==PERCENTAGE==}% had not been accessed for more than 1 year.

Please note that this information is based on the user account metadata stored by a domain controller and so may be a false positive as this metadata is not always correctly replicated between domain controllers.
#### Impact: Medium
Accounts that have not been used in some time may indicate staff or contractors who have left, but may still know the password, and may in some cases still have the ability to logon remotely. Additionally, unused accounts are less likely to be subject to the same password restrictions as other accounts, and are also more likely to have inappropriate permission settings.
#### Likelihood: Low
Accounts would need to use weak passwords for this issue to be exploited. For the account to be accessed by the user who should have had their account disabled, they will likely need remote access.
#### Recommendation
Remove or disable any accounts which are not needed. Review current new starters, movers and leavers procedures to ensure that IT is informed about any unnecessary accounts, and that IT regularly reviews the Active Directory for inactive accounts.
