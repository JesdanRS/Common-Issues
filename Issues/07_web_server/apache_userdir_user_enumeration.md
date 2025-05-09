---
category: "APP-CNF"
cvss: "5.3"
---
### Apache UserDir User Enumeration
An attacker can determine whether operating system user names are valid by seeing if their home directory exists by making specific requests to the Apache web server. The following link shows that "root" exists as a permission error is displayed.

{==http://website/~root==}
```
You don't have permission to access /~root on this server.
```

When an invalid username is used, a different error message is returned:
{==http://website/~invaliduser==}
```
{==ERROR==}
```
#### Impact: Low
An attacker can use this to identify valid user accounts on the system. These usernames could then be used as part of a password guessing or social engineering attack.
#### Likelihood: Medium
This is a common vulnerability and a number of automated tools exist are publicly available to exploit it. However, an attacker would need to guess valid passwords or exploit another vulnerability in order to take advantage of this issue.
#### Recommendation
Consider disabling the default enabled "UserDir" directive in the Apache "httpd.conf" file as follows:

```
UserDir Disabled
```
