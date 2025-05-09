---
category: "APP-XSS"
cvss: "N/A"
---
### Website Relies on ASP.NET Request Validation
The affected website{s||} rel{ies||y} on ASP.NET request validation in order to prevent cross-site scripting attacks. It was possible to exploit a vulnerability in the ASP.NET Request Validation and Internet Explorer 9 to inject malicious scripts and launch a stored cross-site scripting attack against website users (see section {==XREFXss==}).

The Microsoft ASP.NET security guidelines state that request validation should not be relied upon as a sole means to avoid input validation vulnerabilities.
#### Impact: High
Although request validation is effective in blocking many common forms of cross-site scripting, an attacker could bypass the request validation to launch a cross-site scripting attacks.
#### Likelihood: Low
An attacker needs to bypass request validation in order to launch a cross-site scripting attack. The currently known bypass techniques require the victim to be using an old version of Internet Explorer.
#### Recommendation
Encode the fields using the HttpServerUtility.HtmlEncode() method when displaying them in the web browser and perform input validation to ensure that any input values are realistic for the field. For further information, refer to the Microsoft ASP.NET security guidelines available at the following link:

[https://docs.microsoft.com/en-us/aspnet/aspnet/overview/web-development-best-practices/what-not-to-do-in-aspnet-and-what-to-do-instead#security]()