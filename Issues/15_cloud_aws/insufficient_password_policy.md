---
category: "PWD"
cvss: "4"
---
### Insufficient Password Policy
A review of the IAM service settings revealed a weak password policy, which allows users to set weak passwords as shown below:

{==XREF_SCREENSHOT AWS PASSWORD POLICY==}
#### Impact: High
Users can set weak passwords, which are more susceptible to password guessing attacks.{==OPTION==} An attacker compromising an IAM account would potentially be able to access AWS resources{==, such as EC2 instances and the content of the S3 buckets==}.
#### Likelihood: Low
An attacker would need to guess a weak password.{==OPTION==} Additionally, multi factor authentication is not enabled (see section {==XREF-multi-factor-authentication-not-enforced==}).
#### Recommendation
Consider implementing a stronger password policy, especially for administrative accounts used on Internet facing login portals. For AWS accounts, a minimum length of 14 characters or more is recommended by CIS, and consider enforcing password complexity. Please refer to the following AWS documentation for further information of password policies in AWS Identity and Access management (IAM):

[https://docs.aws.amazon.com/securityhub/latest/userguide/iam-controls.html#iam-15]()
[https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_passwords_account-policy.html]()

NCSC publish guidance on password policies, see the following URL for further details:

[https://www.ncsc.gov.uk/collection/passwords]()
