---
category: "CNF"
cvss: "N/A"
---
### No Azure Portal Alert Rules Configured
A review of the Azure portal determined that no alerting rules had been configured for the portal, or for any of the storage accounts or service buses, as shown in the screenshot below:

{==XREF_SCREENSHOT==}
#### Impact: Medium
While the Azure platform may provide some default alerting, it is unlikely to be appropriate for the {==CLIENTNAME_ENVIRONMENT==} environment. Consequently, any security or availability issues affecting the systems may not be identified in a timely manner, potentially resulting in system outages.
#### Likelihood: Low
Other monitoring systems may be used in place of the built-in Azure alerting, including within the hosted environment.
#### Recommendation
Consider configuring alerting on key systems, particularly those in the {==production|staging|dev==} environment, so that issues can be quickly identified and resolved by the appropriate staff.