---
category: "CNF"
cvss: "TBC"
---
### S3 Bucket Security Settings Could Be Stronger
The security settings for the below S3 buckets could be stronger, in that some of them do not {==have access logging enabled, require secure transport (HTTPS) for data in transit, support versioning, enforce MFA delete of objects, enable server-side encryption and enabled public access==}.

| Name |Logging | Secure Transport | Versioning| MFA Delete | Encryption | Public Access |
| {==NAME==} | Enabled | Disabled | Enabled | Disabled | Enabled | Enabled |
| {==NAME==} | Enabled | Disabled | Enabled | Disabled | Enabled | Enabled |

{==OPTION==}Additionally, CloudTrail data logging is not configured for S3, which means that object-level actions, such as downloading a file, performed on S3 buckets are not being logged.
#### Impact: Medium
The current security settings may result in data being inappropriately stored or transmitted without encryption, or provide insufficient data restore capabilities and audit logging in the event of a compromise. This could lead to the loss or exposure of data stored in the S3 buckets.
#### Likelihood: Low
In order to exploit this issue an attacker would need to exploit another vulnerability, for example having compromised a system used to access buckets without encryption.
#### Recommendation
Review the security settings for all S3 buckets and ensure that they are appropriate for the sensitivity of the data stored. Please refer to the following AWS documentation for further information:

[https://docs.aws.amazon.com/AmazonS3/latest/dev/security.html]()

{==OPTION==}Consider configuring CloudTrail S3 data logging. Please refer to the following AWS documentation for further information:

[https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-management-and-data-events-with-cloudtrail.html?icmpid=docs_cloudtrail_console#logging-data-events]()
