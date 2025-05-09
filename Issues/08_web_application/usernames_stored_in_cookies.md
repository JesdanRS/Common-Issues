---
category: "APP-ATH"
cvss: "2.2"
---
### Usernames Stored in Cookies
The affected website{s||} store{||s} the user's username in a cookie, as shown below:

```
{==COOKIENAME=username==}
```
#### Impact: Medium
An attacker accessing this cookie would be able to harvest valid usernames that could then be used in further attacks against the website. Additionally, if the contents of the cookie is trusted by any application functionality, this could leave the application vulnerable to access control issues.
#### Likelihood: Low
An attacker would need to be in the same network as the victim to intercept traffic as it crosses the shared network or have access a user's browser. {==OPTION==} The application appears to only use this cookie to remember the username for the login page, and modifying the cookie value did not affect the user's session or permissions.
#### Recommendation
Where possible, do not include the username in cookies, and only store it in the user's session. If username is stored in a cookie, ensure that it is treated as untrusted, and is only used to remember the username on the login page, or similar functionality.