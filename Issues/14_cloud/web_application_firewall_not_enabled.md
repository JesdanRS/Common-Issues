---
category: "NET"
cvss: "N/A"
---
### Web Application Firewall Not Enabled
{==OPTION AWS==} A review of the AWS WAF configuration revealed that protections against common web application vulnerabilities such as cross-site scripting and SQL injection attacks have not been configured.

{==OPTION GCP==} A review of the Google Armour WAF configuration revealed that protections against common web application vulnerabilities such as cross-site scripting and SQL injection attacks have not been configured.

{==OPTION AZURE==} A review of the Azure configuration revealed that protections against common web application vulnerabilities such as cross-site scripting and SQL injection attacks have not been configured.

{==[SCREENSHOTS]==}
#### Impact: Medium
Disabling the WAF protection could leave the web applications and servers susceptible to web application vulnerabilities. This could allow attackers to compromise confidentiality, integrity and availability of the data on the web application and potentially compromise the hosting server.
#### Likelihood: Low
The hosted web application would need to be vulnerable to common web application flaws for this issue to represent a significant risk to {==CLIENT==}{==OPTION==} (see section XREF). Furthermore, external and web application penetration tests are regularly conducted as indicated by {==CLIENT==} staff.
#### Recommendation
{==OPTION AWS==}Consider enabling the AWS WAF protections in order to enhance the security of the web applications running on the AWS instances. See the following URL for further details:

https://aws.amazon.com/waf/

{==OPTION GCP==} Consider enabling the Google Armour WAF protections in order to enhance the security of the web applications running on the Google Cloud Platform instances. See the following URL for further details:

[https://cloud.google.com/armor/](https://cloud.google.com/armor/)

{==OPTION AZURE==} Consider enabling the Azure Application Gateway in order to enhance the security of the web applications running on the Azure instances. See the following URL for further details:

[https://azure.microsoft.com/en-us/services/application-gateway/](https://azure.microsoft.com/en-us/services/application-gateway/)

{==OPTION ANY==} Note that this is one potential solution and may be a false positive if another third-party service is already used, such as the Cloudflare Web Application Firewall. See the following URL for further details:

[https://www.cloudflare.com/en-gb/waf/](https://www.cloudflare.com/en-gb/waf/)
