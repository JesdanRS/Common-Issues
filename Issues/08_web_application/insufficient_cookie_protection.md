---
category: "APP-ATH"
cvss: "3.1"
---
### Insufficient Cookie Protection
The website{s set|| sets} {a number of cookies||the "NAME" session cookie} that {do||does} not make use of security attributes which notify browsers to provide additional protections that would restrict access to {the cookie||these cookies}.

The following table shows the missing security attributes for each cookie:

| URL | Cookie Name | HttpOnly | Secure | SameSite |
| | | | | |

{==OPTION==}Please note that the cookie behaviour of setting "SameSite" to "Lax" is the same to not setting the attribute and it offers partial protection.
#### Impact: Medium
{==OPTIONHttpOnly==} The lack of the "HttpOnly" attribute means that the cookie{==s==} can be retrieved using JavaScript, allowing attackers to read and modify the cookie via a Cross-Site Scripting (XSS) vulnerability (see section {==XREFXss==}). {==OPTIONSecure==} The lack of the "Secure" attribute means that the cookie{==s==} will be sent over unencrypted HTTP connections, potentially allowing an attacker to intercept {it||them}. {==OPTIONSameSite==} The lack of the "SameSite" attribute leaves the website{s||} more vulnerable to Cross-Site Request Forgery (CSRF) attacks (see section {==XREFCsrf==}).
#### Likelihood: Low
In order to exploit any of these issues, an attacker either needs to perform a man in the middle attack, or to exploit another vulnerability in the website{s||}.
#### Recommendation
Where possible, implement these security attributes to provide a greater level of protection for the cookie{==s==}. The following Mozilla article provides further information:

[https://developer.mozilla.org/en-US/docs/Web/HTTP/Cookies]()
