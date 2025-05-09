---
category: "NET"
cvss: "3.7"
---
### Insufficient Outbound Security Group Rules
{==OPTION==} Although inbound firewall rules were enabled, a review of the security groups revealed that there is no restriction for outbound traffic. An example is shown below:

{==[SCREENSHOT OF SECURITY GROUP WITH ALL:ALL ALLOWED]==}
#### Impact: Medium
Unrestricted outbound traffic would allow an attacker to establish a connection from a compromised server in the {==BACKEND==} {==CLIENTNAME==} infrastructure to a server on the Internet controlled by the attacker. This connection can be used to remotely control {==CLIENTNAME==} systems and to exfiltrate data out of the backend infrastructure.
#### Likelihood: Low
Outbound access through the firewall is unrestricted. However, for someone to exploit this in order to compromise the {==NAME==} network, they would first need to gain an initial foothold on the backend network through the exploitation of another vulnerability.
#### Recommendation
Consider applying appropriate restrictions to all traffic which crosses {==CLIENTNAME==} networks and systems. Also consider completely isolating systems that are on the {==DOMAINNAME==} domain if Internet access is not required. If Internet access is required for example for downloading Windows updates, consider restricting access to specific destinations.

{==OPTION AZURE==} Further information regarding Azure network security best practices is available at the following URL:

[https://docs.microsoft.com/en-us/azure/security/azure-security-network-security-best-practices](https://docs.microsoft.com/en-us/azure/security/azure-security-network-security-best-practices)

{==OPTION AWS==} Further information regarding AWS network security best practices is available at the following URL:

[https://aws.amazon.com/whitepapers/aws-security-best-practices/](https://aws.amazon.com/whitepapers/aws-security-best-practices/)

AWS security groups are also documented at the following URL:

{==OPTION VPC==}[https://docs.aws.amazon.com/vpc/latest/userguide/VPC_SecurityGroups.html](https://docs.aws.amazon.com/vpc/latest/userguide/VPC_SecurityGroups.html)
{==OPTION EC2==}[https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html](https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html)
