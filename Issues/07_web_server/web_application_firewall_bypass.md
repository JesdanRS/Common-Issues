---
category: "APP-CNF"
cvss: "6.5"
---
### Web Application Firewall Bypass
The tested {websites use||website uses} a {==WAF NAME==} web application firewall (WAF) to provide protection against various types of attacks. However, the origin web {servers||server} hosting the {websites||website} at {==URLs==} can be discovered by {==using open source tools==}.

Dionach discovered the {webservers||webserver} listed below hosting the {websites||website}. {These webservers||This webserver} allowed requests from any IP address, which means that an attacker can bypass the WAF by accessing the {IP addresses||IP address} directly.

{==LIST IP addresses==}
#### Impact: Medium
An attacker can attempt to exploit any website vulnerabilities without being blocked by the WAF {==XREF XSS, SQLi, etc.==}.
#### Likelihood: Medium
Attempting to bypass WAF restrictions is essential to any attack strategy, and discovering the {IP addresses of the origin servers||IP address of the origin server} by {==using open source tools==} is straightforward.
#### Recommendation
Restrict direct access to all origin servers to the trusted IP addresses of the WAF at the firewall level. This will ensure that all requests for the {websites||websites} must first pass through the WAF.
