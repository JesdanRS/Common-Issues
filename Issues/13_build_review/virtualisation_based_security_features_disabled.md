---
category: "CNF"
cvss: "N/A"
---
### Virtualisation Based Security Features Disabled
Windows {==10==} has a number of new virtualisation based security features, including Device Guard and Credentials Guard, which help protect the systems against both remote attacks and privilege escalation. These features are not enabled on the tested system{s||}, as shown below:

{==SCREENSHOT==}
#### Impact: Medium
Not having these additional security features enabled leaves the system{s||} more vulnerable to compromise.
#### Likelihood: Low
An attacker would need to gain access to the system{s||} and to exploit another vulnerability in order to take advantage of this issue.
#### Recommendation
Consider implementing the virtualisation based security features on the system{s||}. Further information about Device Guard and Credentials Guard can be found in the following Microsoft documentation:

[https://docs.microsoft.com/en-gb/windows/security/identity-protection/credential-guard/credential-guard-manage]()
[https://docs.microsoft.com/en-gb/windows/security/threat-protection/device-guard/introduction-to-device-guard-virtualization-based-security-and-windows-defender-application-control]()
