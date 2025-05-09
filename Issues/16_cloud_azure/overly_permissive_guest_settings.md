---
category: "TBA"
cvss: "TBA"
---
### Overly Permissive Guest Settings
The current guest settings are overly permissive in that they allow any user, including other guest users, to invite guest users to the tenant, as shown below:

<https://portal.azure.com/#blade/Microsoft_AAD_IAM/CompanyRelationshipsMenuBlade/Settings>
{==SCREENSHOT==}
#### Impact: Medium
Allowing users to invite guests without interaction with IT support may result in the creation user accounts that do not meet business standards or comply with change control processes. Guest accounts created without interaction with IT support may be overly privileged and have access to tenant directory objects and resources inappropriately.
#### Likelihood: Medium
It is trivial for users to invite guest users and users may not be aware of the consequences of doing so. However, by default, guest user access will be limited unless further permissions are granted through group or role membership.
#### Recommendation
Consider preventing users from inviting guests, or alternatively restrict guest invitations to a group of authorised users. Further information regarding restricting guest invitation is available at the following URL:

<https://docs.microsoft.com/en-us/azure/active-directory/external-identities/delegate-invitations>
