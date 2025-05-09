---
category: "CNF"
cvss: "N/A"
---
### Users Can Create Microsoft 365 Groups
Users are allowed to create Microsoft 365 groups as shown below:

<https://entra.microsoft.com/#view/Microsoft_AAD_IAM/GroupsManagementMenuBlade/~/General/menuId/General>
{==SCREENSHOT==}

When creating an Microsoft 365 group a number of resources are typically provisioned, including SharePoint sites, Teams groups, and Exchange mailboxes. The following examples show a number of SharePoint sites that have been created by users and may be inappropriate:

{==EXAMPLES==}
#### Impact: Low
Allowing users to create groups without interaction with IT support may result in the creation of resources that do not meet business standards or comply with change control processes. Creation of a large number of groups can also increase the administrative burden of managing the tenant.
#### Likelihood: Medium
It is trivial for users to create Microsoft 365 groups and users may not be aware of the consequences of additional resource creation when creating groups in applications such as Teams or Planner. During the review, a number of groups were identified which were named in a manner which may suggest they are inappropriate.
#### Recommendation
Consider preventing users from creating Microsoft 365 groups, or alternatively restrict group creation to a group of authorised users. Further information regarding restricting group creation is available at the following URL:

<https://docs.microsoft.com/en-us/microsoft-365/solutions/manage-creation-of-groups>
