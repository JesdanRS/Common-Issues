---
category: "CNF"
cvss: "N/A"
---
### Insufficient External Collaboration Settings
A review of the external collaboration settings within Azure Active Directory (AAD) revealed that {==anyone including guests==} can add guests into the 365 environment and access resources, such as SharePoint, in order to provide collaboration on projects.{==OPTION==}Additionally, the invitations are not restricted by domain. These settings can be seen below:

{==SCREENSHOT==}
#### Impact: Medium
External access to 365 resources from non-verified users could result in sensitive information being disclosed, or an attacker gaining additional information about the environment to conduct further attacks.
#### Likelihood: Low
An attacker would need to persuade {==CLIENTNAME==} users to invite them into the 365 environment in order to gain access to these resources. Additionally, guest accounts have further restrictions limiting what they can access.
#### Recommendation
Review the external collaboration settings and restrict the ability for non-administrators to add guests into the environment, in addition to preventing these guests from adding other users also. For more information please refer to the following URL:

[https://learn.microsoft.com/en-us/microsoft-365/solutions/microsoft-365-guest-settings?view=o365-worldwide]()
