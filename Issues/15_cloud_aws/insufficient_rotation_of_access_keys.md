---
category: "PRC"
cvss: "N/A"
---
### Insufficient Rotation of Access Keys
Manual inspection indicated the following access keys for a number of administrators and low privileged user accounts are not rotated every 90 days or less.

{==TABLE: Access Key ID|Create Date|User|Role==}

{==OPTION==}Additionally, several accounts were seen to have multiple keys (see section {==XREF_Multiple_Access_Keys_Assigned_to_Users==}).
#### Impact: Medium
An attacker compromising an access key would be able to use it to perform malicious activities indefinitely or until the key is revoked or deleted. The level of access would depend on the permissions granted to the compromised account.
#### Likelihood: Medium
Access keys that are not periodically rotated are more likely to be compromised for example as a result of sharing keys. However, an attacker would still need to gain access to the keys, for example by compromising a system where keys are stored or by retrieving them from public S3 buckets or repositories.
#### Recommendation
Consider periodically rotating access keys as recommended by AWS best practices.

[https://docs.aws.amazon.com/accounts/latest/reference/credentials-access-keys-best-practices.html]()
[https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_access-keys.html#Using_RotateAccessKey]()
[https://aws.amazon.com/blogs/security/how-to-rotate-access-keys-for-iam-users/]()

Alternatively consider using temporary security credentials to help reduce the risk in case credentials are accidentally exposed. The following page provides more information:

[https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp.html]()
