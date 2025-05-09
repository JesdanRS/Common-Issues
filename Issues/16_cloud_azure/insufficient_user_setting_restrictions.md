---
category: "CNF"
cvss: "N/A"
---
### Insufficient User Setting Restrictions
Current settings allow standard Azure AD users to {==register new applications, to connect their work accounts to LinkedIn and to also access the Azure AD administration portal==}, as shown in the settings below:

{==SCREENSHOT==}
#### Impact: Medium
{==IF Azure AD Admin Portal==}Standard users will be able to authenticate and access the Azure AD administration portal. This may lead to further attacks in case a vulnerability exists on the portal that allows users access to unauthorised functionality or data. {==IF register new applications==}Additionally, malicious applications installed by users will potentially be able to access sensitive data from the tenancy or execute malicious actions, which could lead to further attacks. {==IF LinkedIn==}Furthermore, integration with LinkedIn could expose data and functionality that could be used to aid social engineering attacks.
#### Likelihood: Low
{==OPTION==}Although standard users can log into Azure administration portal, other privileges would be required to perform actions, such as modifying or deleting AD Azure and Microsoft 365 application data. {==OPTION==}LinkedIn is a commonly used networking and social media site that several {==CLIENTNAME==} employees have profiles on. However, users would have to manually link the accounts and provide consent for data sharing.
#### Recommendation
{==OPTION==}Consider restricting access to the Azure administration portal to only privileged users.

{==OPTION==}Registration of new applications by standard users should not be allowed unless there is a very clear business justification, and there are robust security controls in place.

Please refer to the following URL for more information:

[https://learn.microsoft.com/en-us/azure/active-directory/develop/how-applications-are-added#who-has-permission-to-add-applications-to-my-azure-ad-instance]()

{==OPTION==}Additionally, review the requirement for allowing LinkedIn account connections, and restrict to a selected user group if it is required. If this is required ensure that users receive awareness training and that any data sharing is backed by defined policies.
