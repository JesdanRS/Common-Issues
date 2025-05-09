---
category: "APP-CNF"
cvss: "5.3"
report_on_external_network_test: true
---
### Version of Software in Source Code
The affected website{s||} show{s||} the version of {==Software==} in use in the HTML source code of the web page:

{==URL==}
```
{==Example:==}
{==<!-- FrontPage Configuration Information==}
{==    FPVersion="5.0.2.6790"==}
```
#### Impact: Low
The version information can be useful to an attacker when searching for vulnerabilities. Unnecessary system information is exposed.
#### Likelihood: Medium
This information is present in the HTML source code of the web page, so is straightforward to identify.
#### Recommendation
Remove this information from the HTML source code of the web page.
