---
category: "APP-CNF"
cvss: "TBC"
---
### Missing HTTP Security Headers
The affected website{s||} {are||is} missing a number of useful HTTP security headers that could help to enhance the security of the website{s||} significantly. These headers are as follows:

 * {==Content-Security-Policy==}
 * {==X-Content-Type-Options==}
 * {==Strict-Transport-Security==}

{==OPTION==} Note that while these headers were seen to be in place on some pages, they were not applied consistently throughout the website{s||}.

{==OPTIONAPI==} Please note that some of these headers are intended to be used with HTML responses, and as such may not provide any additional security benefits to an API that does not return HTML.

However, should the function of the headers, or the types of information that the API returns change (or may change in future), then it is recommended to include them as part of a defence-in-depth approach. Please see the URL below for further information:

[https://cheatsheetseries.owasp.org/cheatsheets/REST_Security_Cheat_Sheet.html#security-headers]()

For further information about HTTP security headers and a detailed description, please refer to the following article:

[https://cheatsheetseries.owasp.org/cheatsheets/HTTP_Headers_Cheat_Sheet.html]()
#### Impact: Medium
By not using standardised and well tested security mechanisms, as in this case the HTTP security headers, the website{s remain|| remains} more susceptible to certain type of attacks that could be easily avoided or mitigated.
#### Likelihood: Low
An attacker would need to exploit an existing security flaw on the website{s||} to take advantage of the lack of HTTP security headers.
#### Recommendation
Consider implementing available HTTP security headers as a way of improving the overall security of the website{s||}. Refer to the article mentioned above for further information.

{==OPTION Apache Tomcat==} For Apache Tomcat, modify and uncomment the relevant options in the "Built In Filter Definitions" section of the web.xml file. Refer to the following article for further information:

[https://tomcat.apache.org/tomcat-9.0-doc/config/filter.html#HTTP_Header_Security_Filter]()

{==OPTIONWordPress==} The following WordPress plugin can be used to set security headers if access to the web server configuration is not available:

[https://wordpress.org/plugins/headers-security-advanced-hsts-wp]()

{==Drupal==} Publicly developed Drupal modules such as the ones below can be used to set security headers if access to the web server configuration is not available:

{==CSP==} [https://www.drupal.org/project/csp]()

{==HSTS==} [https://www.drupal.org/project/hsts]()

As the modules are developed by the general public, they may contain unintended software bugs. As such, please ensure sufficient testing have been done before deployment.