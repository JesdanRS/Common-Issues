---
category: "PRV"
cvss: "5.3"
---
### Overly Permissive S3 Bucket Permissions
A number of S3 objects have potentially excessive permissions. Public "Read object" access was seen to be applied to S3 objects of the following public S3 buckets:

{==BULLET_POINT_S3==}

An example is shown below:

{==SCREENSHOT==}

Additionally, the S3 path structure of the following S3 buckets is anonymously accessible:

{==BULLET_POINT_S3==}

An example below is shown below:

{==SCREENSHOT==}
#### Impact: High
An attacker can gain access to any objects stored within these S3 buckets, including highly sensitive information such as virtual machine backups, and documents from previous data migrations. Additionally, the filenames are available to anonymous users which may reveal sensitive information such as website content, or globally unique identifiers (GUID).
#### Likelihood: Medium
As the S3 path structure is anonymously accessible, it would be trivial for attacker to identify the bucket address and object names in order to access the objects. A number of high-profile breaches of sensitive data have occurred due to this security flaw.
#### Recommendation
Remove public permission to S3 buckets to ensure that S3 path structure is not available anonymously. Review and apply appropriate object permissions set on the all S3 buckets, if objects are no longer required then remove them. Additionally, consider using AWS Identity and Management Access Analyzer which allows to monitor S3 bucket access policies and configure alerts. Finally, review AWS security best practices for Amazon S3:

[https://docs.aws.amazon.com/AmazonS3/latest/dev/security-best-practices.html]()
