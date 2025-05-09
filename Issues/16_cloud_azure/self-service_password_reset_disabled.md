---
category: "CNF"
cvss: "N/A"
---
### Self-Service Password Reset Disabled
Current settings relating to password reset functionality identified that the self-service password reset feature was disabled:

{==SCREENSHOT==}

If enabled, users will be able to self-service password reset in Azure AD and no longer need to engage administrators and the service desk for password resets.
#### Impact: Medium
Password reset policies in use by service desk support staff may introduce common weak passwords. These passwords may not be updated by users and could result in accounts being compromised. Additionally, users who have had their passwords compromised will be unable to change their passwords in timely manner.
#### Likelihood: Low
An attacker would need to abuse the current password reset procedure, and a component of social engineering is required.
#### Recommendation
Consider enabling the self-service password reset functionality. For more information, please refer to the following URL:

[https://learn.microsoft.com/en-us/azure/active-directory/authentication/concept-sspr-howitworks]()
