---
category: "APP-CNF"
cvss: "2.7"
---
### WebDAV Is Enabled On the Web Server
The web server{s||} listed above {are|is} running with WebDAV enabled. WebDAV is an industry standard extension to the HTTP specification. It adds a capability for authorised users to remotely add and manage the content of a web server.
#### Impact: Medium
If incorrectly configured, this can lead to information leakage and unauthorised access to the web server{s||} and directory structure. Its presence can also suggest that the web server{s have|| has} not been adequately hardened to remove unnecessary components.
#### Likelihood: Low
An attacker would need to authenticate to the web server{s||}.
#### Recommendation
Disable WebDAV if this functionality is not used. See the following Microsoft article for information on configuring WebDAV in IIS:

[https://docs.microsoft.com/en-gb/iis/configuration/system.webserver/webdav/]()
