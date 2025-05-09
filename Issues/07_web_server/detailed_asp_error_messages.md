---
category: "APP-CNF"
cvss: "5.3"
---
### Detailed ASP Error Messages
The affected website{s||} {have|has} the default setting for ASP applications, where detailed error messages are sent to the client browser. Useful system information is generally provided in these messages if an attacker can force an error, as shown below:

{==https://link==}
```
{==ERROR==}
```
#### Impact: Low
System information is disclosed.
#### Likelihood: Medium
An attacker will need to manually try and generate error messages by amending fields, or alternatively spider the website and use one of a number of freely available tools to fuzz the website fields.
#### Recommendation
Change the setting in Internet Services Manager for the ASP application so that only a general error message is returned.
