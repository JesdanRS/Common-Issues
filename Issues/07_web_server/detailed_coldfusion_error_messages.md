---
category: "APP-CNF"
cvss: "5.3"
---
### Detailed ColdFusion Error Messages
The affected website{s||} {have|has} the default setting for ColdFusion applications, where detailed error messages are sent to the client browser. Useful system information is generally provided in these messages if an attacker can force an error, as shown below:

{==https://link==}
```
{==ERROR==}
```
#### Impact: Low
System information is disclosed.
#### Likelihood: Medium
An attacker will need to manually try and generate error messages by amending fields, or alternatively spider the website{s||} and use one of a number of freely available tools to fuzz the website{s||} fields.
#### Recommendation
Change the setting in the ColdFusion Administrator Server Settings for site-wide error handling.
