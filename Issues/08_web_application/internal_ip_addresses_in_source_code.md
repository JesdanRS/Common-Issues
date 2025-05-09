---
category: "APP-DAT"
cvss: "5.3"
report_on_external_network_test: true
---
### Internal IP Addresses in Source Code
Internal IP addresses of systems were found in the HTML source for the following pages on the affected website{s||} listed above.

{==http://URL==}
```
{==HTML SOURCE EXAMPLE==}
```
#### Impact: Low
Unnecessary system information is exposed which could be of use to an attacker as part of a co-ordinated attack strategy.
#### Likelihood: Medium
This information is present in the source code for the pages, and would be quickly identified through manual inspection.
#### Recommendation
Remove this information from the pages.