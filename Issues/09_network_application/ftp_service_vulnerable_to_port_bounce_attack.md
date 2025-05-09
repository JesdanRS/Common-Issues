---
category: "CNF"
cvss: "7.2"
---
### FTP Service Vulnerable to PORT Bounce Attack
The File Transfer Protocol (FTP) service{s||} on the affected server{s||} {are||is} vulnerable to an FTP PORT bounce attack.

This means that an attacker can launch a port scan from {these||this} host{s||}.
#### Impact: Low
An attacker could use {these||this} host{s||} to perform reconnaissance on internal and remote targets, and the source of the probes would appear to be from the targeted FTP server.
#### Likelihood: Medium
This vulnerability is well-known, easily exploited, and likely to be detected by most automated vulnerability scanners.
#### Recommendation
Consider removing the FTP service{s||} if {they are||it is} not required. Otherwise, contact the vendor for a patch against this issue. The following article gives more information on this vulnerability, as well as potential workarounds and fixes:

[https://www.cert.org/historical/advisories/CA-1997-27.cfm]()