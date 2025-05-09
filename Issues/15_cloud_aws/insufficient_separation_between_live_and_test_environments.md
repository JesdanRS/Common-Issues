---
category: "NET"
cvss: "4.2"
---
### Insufficient Separation Between Live and Test Environments
Both the Live and the Test environments exist in the same account infrastructure.{==CLIENTNAME==}'s AWS environment contains data and resources for {==live, testing, UAT and training==} under the same AWS account {==AWS_ACCOUNT_NAME==}. An example is shown below:

{==SCREENSHOT==}
#### Impact: High
An attacker compromising an AWS account which was configured to access or manage {==testing, UAT and training data==} such as an API access key belonging to {==testing, UAT and training==} environment would be able to access content of the live environment. Additionally, unintentional changes to the live environment could be made by a legitimate user with access to {==testing, UAT and training==} environment.
#### Likelihood: Low
{==Testing, training, UAT ==} data and resources are typically less hardened and secure compared to live environments. However, an attacker would need to identify and exploit a vulnerability in one of the AWS resources in order to take advantage of this issue.
#### Recommendation
Consider using multiple AWS accounts in order to isolate the AWS live resources and data from {==testing, UAT and training ==} environment. Please refer to the following AWS resource for further information:

[https://d0.awsstatic.com/aws-answers/AWS_Multi_Account_Security_Strategy.pdf]()