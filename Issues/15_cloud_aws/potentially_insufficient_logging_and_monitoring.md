---
category: "LOG"
cvss: "N/A"
---
### Potentially Insufficient Logging and Monitoring
Review of the AWS portal revealed that no trails have been created in CloudTrail. By default, AWS retains CloudTrail events for 90 days, however, creating a trail will allow {==CLIENTNAME==} to retain audit logs for longer periods in line with the organisations log retention policy. Moreover, using trails would allow {==CLIENTNAME==} to perform a variety of activities against the audit logs such as automated alerting using event metrics and trigger alerts.

Review of the CloudWatch alarms and event metrics revealed that these are not being used to automatically monitor event logs, alert relevant personnel of potential security incidents, and where applicable to automatically respond to potential security incidents.
#### Impact: Medium
CloudTrail event logs are only retained for 90 days which could hamper a forensic investigation that is initiated after that period.

Insufficient monitoring, alerting, and automated incident response could result in security incidents not being identified and responded to in a timely manner.
#### Likelihood: Low
Insufficient audit log retention, monitoring and alerting would only become an issue if a security incident was to occur. For most organisations a log retention period of 90 days is acceptable.
#### Recommendation
Consider configuring a CloudTrail trail and automated monitoring and alerting. {==CLIENTNAME==} should consider at a minimum configuring alerts for the following:

 * AWS Management Console authentication failures
 * AWS Management Console login without MFA
 * Use of Root account
 * IAM policy changes
 * CloudTrail and CloudWatch configuration changes
 * VPC changes
 * Network Access Control List and Security Group changes
 * S3 bucket policy changes

Please refer to the following AWS documentation for more information:

[https://docs.aws.amazon.com/awscloudtrail/latest/userguide/how-cloudtrail-works.html]()

Consider configuring CloudWatch alarms and event metrics that are relevant to the organisation and the environment in order to automate audit log monitoring, alert relevant personnel of potential security incidents, and where applicable to implement automated incident response such as automatically disabling potentially compromise accounts. Please refer to the AWS CloudWatch documentation for more information:

[https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/WhatIsCloudWatch.html]()

Please refer to the following AWS documentation for more information on how to automate incident response using Lambda in response to a CloudWatch event:

[https://aws.amazon.com/premiumsupport/knowledge-center/lambda-automate-tasks/]()