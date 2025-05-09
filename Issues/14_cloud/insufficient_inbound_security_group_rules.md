---
category: "NET"
cvss: "5.3"
---
### Insufficient Inbound Security Group Rules
Review of the security groups revealed that all inbound traffic is permitted from a number of sources, without rules to limit network communications to specific services for which there is a business need, as shown in the following examples:

{==[SECURITY  GROUP NAME]==}
{==[SCREENSHOT]==}
#### Impact: Medium
The lack of rigorous inbound traffic rules would expose unnecessary services on instances that could be potentially exploited by an attacker.
#### Likelihood: Medium
An attacker would need to exploit another vulnerability in the exposed services for this to be an issue. Individual systems may have their own host-based firewalls.
#### Recommendation
Consider reviewing the security groups to ensure that inbound rules are in place to only allow the type of traffic that is required from specific IP addresses or network ranges.

{==OPTION AZURE==} Further information regarding Azure network security best practices is available at the following URL:

[https://docs.microsoft.com/en-us/azure/security/azure-security-network-security-best-practices](https://docs.microsoft.com/en-us/azure/security/azure-security-network-security-best-practices)

{==OPTION AWS==} Further information regarding AWS network security best practices is available at the following URL:

[https://aws.amazon.com/whitepapers/aws-security-best-practices/](https://aws.amazon.com/whitepapers/aws-security-best-practices/)

AWS security groups are also documented at the following URL:

{==OPTION VPC==}[https://docs.aws.amazon.com/vpc/latest/userguide/VPC_SecurityGroups.html](https://docs.aws.amazon.com/vpc/latest/userguide/VPC_SecurityGroups.html)
{==OPTION EC2==}[https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html](https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html)
