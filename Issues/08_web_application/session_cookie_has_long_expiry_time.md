---
category: "APP-ATH"
cvss: "4.4"
---
### Session Cookie Has Long Expiry Time
The affected website{s||} {have||has} insufficient session management, as sessions stay active for more than {==NUMBER ==} hours and the session cookie has fixed expiry time which is valid for {==EXPIRES TIME==}.

```
{==SESSION COOKIE==}
{==EXPIRES DATE==}
```
#### Impact: Medium
If a website user was to leave their session logged on the website, an attacker obtaining access to their browser either through physical or remote access to their computer or by exploiting other vulnerabilities such as cross-site scripting, could resume their session or access their data.
#### Likelihood: Low
An attacker would need to get physical or logical access to the victim's computer.
#### Recommendation
Terminate sessions after an appropriate period of inactivity, say {==ten minutes==}. This should be done using server-side functionality, and not rely on client-side cookies or scripts.
