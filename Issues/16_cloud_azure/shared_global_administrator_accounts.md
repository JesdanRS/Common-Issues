---
category: "PRV"
cvss: "N/A"
---
### Shared Global Administrator Accounts
The majority of the accounts on the Azure portal are named accounts, however {multiple accounts listed below do||one account, "XREF_ACCOUNT_NAME", does} not appear to be associated with an individual. {==OPTION==}{These accounts have||This account has} the "Global Administrator" role on the portal.
#### Impact: Medium
It may not be possible to link actions performed by {these accounts||this account} to a specific individual, which results in a lack of accountability for any changes made.
#### Likelihood: Low
{==CLIENTNAME==} internal processes to control access to {these accounts||this account} may be in place. {==OPTION-2FAEnabled==}The use of two factor authentication may tie actions to an individual at {==CLIENTNAME==}.
#### Recommendation
Review each account, and if they are not required then consider disabling or removing them. Wherever possible, ensure that accounts are linked to an individual. Review policies and procedures to ensure that a periodic access rights review takes place, such as once a year or every 6 months.