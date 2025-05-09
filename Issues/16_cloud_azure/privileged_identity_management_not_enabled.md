---
category: "TBA"
cvss: "TBA"
---
### Privileged Identity Management Not Enabled
{==ONLY Report if Azure AD P2 License==}Inspection of the tenant revealed that Azure Privileged Identity Management was not enabled. Privileged Identity Management offers the following features:

* Provide just-in-time privileged access to Azure AD and Azure resources.
* Assign time-bound access to resources using start and end dates.
* Require approval to activate privileged roles.
* Enforce multi-factor authentication to activate any role.
* Use justification to understand why users want to escalate their privileges.
* Get notifications when privileged roles are activated.
* Conduct access reviews to ensure users still require the roles assigned to them.
* Download audit history for internal or external audit.
* Prevents removal of the last active Global Administrator role.
#### Impact: High
An attacker could potentially gain administrative permissions to the Azure tenancy and launch further attacks against the organisation. This will affect the integrity, confidentiality and availability of the information on the environment.
#### Likelihood: Low
An attacker would need to compromise an administrative account in order to be able to exploit this weakness. {==OPTION==}However, multi-factor authentication was seen to be enabled.
#### Recommendation
Consider enabling and configuring Privileged Identity Management in Azure. Please refer to the following Microsoft documentation for further information:

<https://docs.microsoft.com/en-us/azure/active-directory/privileged-identity-management/pim-configure>
