---
category: "CNF"
cvss: "3.7"
---
### Insufficient Internal Security Group Rules
No network security groups were configured on the "{==SUBNET_NAME==}" subnet ({==IP_RANGE==}), as shown in the screenshot below.

{==[IMAGE]==}
#### Impact: Medium
An attacker that compromises a host on the network can directly connect to these backend services in order to attempt to access data or exploit any vulnerabilities.
#### Likelihood: Low
Unrestricted traffic would help an attacker move laterally inside {==CLIENT==} infrastructure, however an attacker would need to exploit another vulnerability, in order to exploit this issue, or otherwise have access to the hosted network.
#### Recommendation
Consider reviewing the security groups to ensure that inbound rules are in place to only allow the type of traffic that is required from specific IP addresses or network ranges.

Implement segregation between the different subnets, with access only allowed between them when it is specifically required. {==OPTION AZURE==} Further information regarding Azure network security best practices is available at the following URL:

[https://docs.microsoft.com/en-us/azure/security/azure-security-network-security-best-practices](https://docs.microsoft.com/en-us/azure/security/azure-security-network-security-best-practices)

{==OPTION AWS==} Further information regarding AWS network security best practices is available at the following URL:

[https://aws.amazon.com/whitepapers/aws-security-best-practices/](https://aws.amazon.com/whitepapers/aws-security-best-practices/)

AWS security groups are also documented at the following URL:

{==OPTION VPC==}[https://docs.aws.amazon.com/vpc/latest/userguide/VPC_SecurityGroups.html](https://docs.aws.amazon.com/vpc/latest/userguide/VPC_SecurityGroups.html)
{==OPTION EC2==}[https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html](https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html)
