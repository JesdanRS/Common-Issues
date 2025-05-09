---
category: "APP-CNF"
cvss: "5.3"
---
### WebDAV Exposes Internal IP Address
The web server{s belowserver{s||} listed above expose{s its||their } internal IP address{es||} through the WebDAV interface. This information can be useful to an attacker.

{==OPTION==} Note that requirement 1.4.5 of PCI DSS states that internal IP addresses must not be disclosed.
#### Impact: Low
Unnecessary system information is exposed.
#### Likelihood: Medium
This information is easily available through automated scanning or manual inspection.
#### Recommendation
Disable WebDAV if this functionality is not used. The link below has instructions on how to do this on IIS 5.

[https://support2.microsoft.com/default.aspx?kbid=241520]()
