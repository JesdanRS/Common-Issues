---
category: "APP-CNF"
cvss: "N/A"
report_on_external_network_test: true
---
### Unused CGI Scripts
The affected website{s||} {were||was} found to contain a number of unused CGI scripts, which appear to be from a default install of cPanel. Some examples of these are listed below.

{==URLs==}
#### Impact: Low
Many of these scripts have had historic vulnerabilities, however, as they have not been configured, they may not be readily exploitable.
#### Likelihood: Medium
These scripts are well known, and would be quickly discovered by automated tools.
#### Recommendation
Remove these scripts from the server, and review change control processes to ensure that default scripts are not left on production systems.