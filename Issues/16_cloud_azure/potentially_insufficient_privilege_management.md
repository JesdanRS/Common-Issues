---
category: "PRV"
cvss: "N/A"
---
### Potentially Insufficient Privilege Management
{==OPTION==}Inspection of the Azure portal revealed that almost all users were granted subscription admin and resource admin privileges.

{==OPTION==}Inspection of the Azure portal revealed that most of the users were assigned either "Owner" or "Contributor" permissions, although this may not be necessarily required. In addition, some of these have "Global Administrator" permissions on Azure Active Directory resources, as shown below:

{==TABLE |Name|Owner|Contributor|Global Administrator|==}
#### Impact: High
An attacker compromising resources assigned to these roles could escalate their privileges in order to gain administrative access to the Azure environment. This could allow them to take full control of the environment and customer data.
#### Likelihood: Low
An attacker would first need to compromise a resource assigned to these roles using a different vulnerability or gain a low privileged access to the Azure Management Console.
#### Recommendation
Ensure that regular auditing of user access rights is undertaken to prevent inappropriate permissions from being granted to user accounts. Privileges should be assigned using a least privileged principle. Please refer to the following articles for further information on Azure role based access control:

[https://docs.microsoft.com/en-us/azure/role-based-access-control/overview]()
[https://docs.microsoft.com/en-us/azure/role-based-access-control/role-assignments-portal]()

For Azure AD resources consider creating a periodic access control review task in the Azure portal. More information can be found at the following URL:

[https://docs.microsoft.com/en-us/azure/active-directory/governance/access-reviews-overview]()
