---
category: "APP-ATH"
cvss: "TBC"
report_on_external_network_test: true
---
### Credentials in Clear Text in Source Code
Usernames and passwords were found in clear text in the source code of the {==XML==} file{s||} listed below. {==OPTION:==} Please note that {these files are||this file is} available anonymously as discussed in issue {==XREF==}.

{==URLs==}
```
{==Source Code==}
```

{==OPTION:==} Dionach were not able to use these credentials to gain access to websites or systems within the scope of the penetration test. However, these credentials could be valid on other {==CLIENTNAME==}'s systems that are not in the scope. Please note that further files may contain passwords that are not listed above.
#### Impact: High
An attacker getting access to {these files||this file} could be able to login on other {==CLIENTNAME==}'s systems or websites. Users commonly use the same password for different applications or websites.
#### Likelihood: Medium
Any {==ROLE:authenticated/anonymous==} user can easily exploit this issue. {==OPTION==} An anonymous attacker would first need to identify the vulnerable file{s||}; this would be straightforward with a directory brute-forcing tool.
#### Recommendation
Remove {these files||this file} if {they are||it is} not required. Otherwise configure the web application so that sensitive information is not stored in clear text.