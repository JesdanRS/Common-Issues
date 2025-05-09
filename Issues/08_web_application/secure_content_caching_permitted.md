---
category: "APP-CNF"
cvss: "3.3"
---
### Secure Content Caching Permitted
The affected website{s||} {do||does} not have headers that instruct the browser not to cache secure content on some of {their||its} pages. Most modern client applications will cache secure content by default if no header is presented.

{==URLs==}
#### Impact: Medium
Sensitive information from {these pages||this page} may be cached by a client application, such as a browser, which could potentially allow an attacker to gain access to an offline copy of this information.
#### Likelihood: Low
To exploit this vulnerability an attacker would have to gain access to a user's computer.
#### Recommendation
Review the content of {these pages||this page}, and if there is any sensitive information contained in them, specifically disable caching by adding the following HTTP headers:

```
Cache-Control: no-cache, no-store, must-revalidate
Pragma: no-cache
```