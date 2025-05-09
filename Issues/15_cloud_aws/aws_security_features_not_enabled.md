---
category: CNF
cvss: TBA
---
### AWS Security Features Not Enabled
Inspection of the AWS account indicated that a number of AWS services designed to aid with hardening the environment and identifying security weaknesses within it, collecting logs and receiving alerts for potentially unwanted incidents have not been configured. Further details are provided in the subsections below.

{==NOTE: Every Subsection below is an OPTION and MAY require heavy modifications. Always review these services accordingly and discuss them with the customer as they may be doing stuff differently and not see the value in them (especially Macie/GuardDuty) and may have reviewed them and not require them as they incur costs==}

{==CloudTrail==}
{==OPTION1==}Although CloudTrail is configured for the main {==XREF==} account, it is not configured in line with security best practices to ensure sufficient logging and monitoring of the environment (see section {==XREF_AWS_Insufficient_Logging_and_Monitoring==}).

{==Trusted Advisor==}
Although AWS Trusted Advisor was being used to validate the security posture of the environment, a number of recommended actions may have not been acted upon{==, including IAM access key rotation (see section {==XREF==})==}:

{==SCREENSHOT==}

{==Inspector==}
Amazon Inspector did not appear to be in use. Inspector automatically assesses Amazon applications and services for misconfigurations, vulnerabilities, or missing security controls.

{==Macie==}
{==OPTION: If they use S3 with possibility of PII leakage==}Amazon Macie was not configured. Macie is an AWS managed data security and privacy service that aims to identify and alert on any sensitive data exposure affecting S3 buckets.

{==GuardDuty==}
Amazon GuardDuty was not seen to be enabled. GuardDuty is a threat detection service that acts similarly to an IDS, continuously monitoring network and API activities aiming to identify malicious activities and security events.

{==WAF & Shield==}
Inspection of the Amazon WAF panel indicated that it has not been configured for all relevant services running in the environment such as the API Gateways serving the lambda functions.
#### Impact: Medium
{==OPTION==}Undiscovered misconfigurations, vulnerabilities and data exposure would widen the attack surface and could lead to security weaknesses that could be exploited by attackers. {==OPTION==}Insufficient monitoring, alerting, and automated incident response could result in security incidents not being identified and responded to in a timely manner. {==OPTION==}Lack of WAF protection on web applications would aid attackers in looking for vulnerabilities affecting the web applications.
#### Likelihood: Low
It is likely that misconfigurations, data exposure and other vulnerabilities might not be promptly identified, especially if security assessments are not being regularly performed. Insufficient monitoring and alerting would only become an issue if a security incident was to occur.
#### Recommendation
{==OPTION==}Consider reviewing and configuring the above AWS security features to increase security coverage with a focus on improving logging and alerting with the use of CloudTrail and CloudWatch as discussed in section {==XREF==}. Additionally, ensure that the information from such security features is regularly monitored and reviewed and acted upon.

Please note that many of these security features will incur costs. It is recommended that the organisation periodically reviews these models using a risk assessment and cost-benefit analysis to determine whether the current security controls in place are sufficient, or whether additional security improvements offered by additional paid services justify the respective increase in costs.
