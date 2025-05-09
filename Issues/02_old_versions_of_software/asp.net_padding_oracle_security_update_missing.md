---
category: "UPD"
cvss: "5.3"
---
### ASP.NET Padding Oracle Security Update Missing
Automated scanning suggests that the affected system{s||} may be missing the security update MS10-070, which addresses a weakness in the ASP.NET framework. This weakness, relating to the mechanism in which the framework creates encrypted URL parameters, could allow an attacker to directly access sensitive web application files, such as the "web.config" configuration file, which would not normally be accessible.

{==OPTION==} Please note that Dionach were not able to verify or exploit this vulnerability during testing, and that automated tools are prone to false positives. As such, this issue may not actually be valid.
#### Impact: High
If an attacker sends a sufficient number of specially crafted requests to the web server, they can obtain the server's encryption key. This can then be used to request sensitive content which would not otherwise be accessible.
#### Likelihood: Low
While this vulnerability is widely reported and well-known, exploitation generally requires a large number of crafted requests to be sent to the web server, and a high level of technical skill.
#### Recommendation
Review the web server configuration and ensure that all relevant security updates have been installed. The security bulletin at the following URL gives more information on this particular flaw:

[https://docs.microsoft.com/en-gb/security-updates/SecurityBulletins/2010/ms10-070]()
