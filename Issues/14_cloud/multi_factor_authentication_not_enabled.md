---
category: "ATH"
cvss: "6.8"
---
### Multi Factor Authentication Not Enabled
A review of the {==CLIENTNAME==} {==CLOUDENVNAME==} revealed that users accounts do not enforce multi factor authentication (MFA/2FA). {==OPTION==} Note that {==CLIENTNAME==} users authenticate to the portal using the on-premises Active Directory which requires MFA.

{==[SCREENSHOT]==}
#### Impact: High
An attacker obtaining a user's password, for example through password guessing or social engineering attacks, would gain continuing access to the {==CLOUDENVNAME==} environment as the victim. In case an administrator account is compromised, this could allow the attacker to take full control of the {==CLOUDENVNAME==} environment, which can have reputational implications for {==CLIENTNAME==}, and affect the confidentiality and integrity of the environment.
#### Likelihood: Medium
An attacker would need to guess a weak password, exploit a re-used password disclosed elsewhere, compromise the environment where the passwords are stored such as an administrator's laptop or perform a social engineering attack in order to steal valid credentials.
#### Recommendation
Enforce MFA for all user accounts. If it is not possible to enforce MFA for all users, it should, at a minimum, be required for administrative accounts. Ensure that MFA is enabled for access methods utilising passwords or access keys.

{==[OPTION AWS]==} Please see the following URL for more details of MFA in the AWS environment:

[https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_mfa_enable_virtual.html]()

{==[OPTION AZURE]==} The following article provides further information regarding MFA in Azure:

[https://docs.microsoft.com/en-us/azure/multi-factor-authentication/multi-factor-authentication]()

If MFA is not possible for business reasons, consider other controls such as conditional access policies - for example preventing login for normal users out of pre defined hours or not from specific trusted source network ranges.
