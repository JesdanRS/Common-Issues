---
category: "CNF"
cvss: "N/A"
---
### Azure Active Directory Identity Protection Not Enabled
Azure Active Directory Identity Protection is a feature available in Azure that can help protect user accounts, services, and systems. The feature can help detect leaked accounts, logins from infected devices, simultaneous logins from geographically distant locations, which could indicate an account compromise, and logins from unfamiliar or suspicious locations.

The {==user risk, sign-in risk and MFA registration policies==} were found to be not enforced, as shown in the screenshots below:

{==ADD EXAMPLES WITH SCREENSHOTS==}
#### Impact: Medium
The lack of protective monitoring means that suspicious activity may not be identified in a timely manner. This could result in attacks not being detected.
#### Likelihood: Low
{==Currently most of the Azure portal users use on-premises Active Directory rather than Azure Active Directory.==}OR{==All users have multifactor authentication enforced and receive regular security awareness training.==}
#### Recommendation
Consider enforcing Azure Active Directory Identity Protection risk policies. Please see the following Microsoft article for further information:

[https://learn.microsoft.com/en-gb/azure/active-directory/identity-protection/overview-identity-protection]()
