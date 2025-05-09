---
category: "PRC"
cvss: "N/A"
---
### AWS Trusted Advisor Service Not in Use
A number of security recommendations are pending on the Amazon Web Services (AWS) Trusted Advisor service, indicating that this is not sufficiently monitored, as shown below:

{==NOTE: UPDATE REGION CODE IN URL BELOW==}
[https://console.aws.amazon.com/trustedadvisor/home?region=REGION-CODE#/dashboard]()
{==SCREENSHOT==}
#### Impact: High
{==CLIENTNAME==} AWS infrastructure may not be sufficiently hardened, which may lead to unauthorised access to AWS services such as S3 buckets.
#### Likelihood: Low
It is likely that misconfigurations affecting security, performance, or costs will not be promptly identified and fixed.
#### Recommendation
Periodically review and implement security recommendations provided by the AWS Trusted Advisor. AWS' CloudWatch can be used to detect and react to changes in the status of Trusted Advisor checks. Further details on this can be found at the following URL:

[https://docs.aws.amazon.com/awssupport/latest/user/cloudwatch-events-ta.html]()

In addition, dismiss any unnecessary recommendations within the Trusted Advisor dashboard to ensure effective security monitoring.