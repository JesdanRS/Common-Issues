---
category: "PRV"
cvss: "N/A"
---
### User API Access Key Never Used
Manual inspection revealed that the API access key {==KEY==} for the user {==USER==} has never been used, which may indicate that no user access control review has occurred since {==DATE==}.
#### Impact: Medium
If access keys are not rotated (see section {==XREF_INSUFFICIENT_ROTATION_ACCESS_KEY==}), revoked or deleted when no longer required, an attacker gaining access to the key and secret would be able to compromise AWS services depending on the access the API keys have, such as E2 instances and S3 buckets.
#### Likelihood: Low
An attacker would need to gain access to the user access key and secret in order to exploit this issue.
#### Recommendation
Review user account management procedures to ensure that if users no longer require API access, their keys should be revoked or deleted. For further information, please refer to AWS best practices for managing access keys:

[https://docs.aws.amazon.com/general/latest/gr/aws-access-keys-best-practices.html]()