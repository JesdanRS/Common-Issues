---
category: "APP-CNF"
cvss: "6.6"
comment: |
  This issue is intended for traditional shared hosts, where each user is given limited shell access or code execution on the same host (e.g. GeoCities). This will likely be seen where the site is hosted by the developer or where multi-tenant hosting control panels are in use (e.g. cPanel). It should not be reported when all sites belong to the same organisation or when a reverse proxy is in use. It is extremely unlikely this issue is relevant for SaaS/PaaS, such as AWS, Azure, Cloudflare, etc.
---
### Websites on Shared Hosting
The affected website{s||} {are||is} hosted on a shared hosting server provided by {==HOST COMPANY==}. A large number of other websites are also hosted on the same server, as shown in the port scan in appendix {==B==}.

{==URLS==}
#### Impact: Medium
A vulnerability in or a malicious administrator for one of the other websites hosted on the same server could potentially result in a compromise of the shared server and unauthorised access to {==CLIENTNAME==}'s website{s||} and data. Additionally, as the server is outside of {==CLIENTNAME==}'s control, preventing, rectifying or responding to security issues becomes the responsibility of the hosting provider.
#### Likelihood: Medium
The shared hosting environment includes a large number of web applications, any one of which could have serious vulnerabilities leading to a compromise of {==CLIENTNAME==}'s website{s||} or data. The hosting provider may have technical measures in place to manage this risk, thus reducing the likelihood of exploitation of this issue.
#### Recommendation
Consider moving the website{s||} to internal hosting, or onto a dedicated Virtual Private Server (VPS). If this is not possible, liaise with the hosting provider to ensure that the server is kept up to date and securely configured, and that websites are sufficiently isolated from one another.
