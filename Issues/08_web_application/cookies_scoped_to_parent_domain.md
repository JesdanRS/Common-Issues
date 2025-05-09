---
category: "APP-ATH"
cvss: "5.8"
---
### Cookies Scoped to Parent Domain
The cookies listed below are scoped to the parent domain "{==PARENT==}", rather than to the domain of the site that creates them "{==DOMAIN==}".

```
{==COOKIES==}
```
This means that the cookies would be accessible from not only the parent domain, but also any other subdomains of the parent. {==OPTION==} This includes the following subdomains:

{==LIST==}
#### Impact: Medium
If an attacker were able to exploit a vulnerability in the parent domain, or in any other subdomain of the parent, they would be able to {==OPTION==} steal the cookies and thus gain access to the website{==OPTION something else sensitive, adjust impact==}.
#### Likelihood: Low
An attacker would need to identify a vulnerability in one of the other subdomains of the parent in order to exploit this issue.
#### Recommendation
Ensure that cookies have the minimum scope required for them to function. Note that if cookies are created without explicitly scoping them to a domain, they will be scoped to the current domain.
