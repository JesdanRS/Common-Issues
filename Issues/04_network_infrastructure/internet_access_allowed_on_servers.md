---
category: "CNF"
cvss: "N/A"
---
### Internet Access Allowed On Servers
A sample review of the servers in scope revealed that outbound Internet access was allowed, as shown in the following proof of concept:

{==SCREENSHOT==}
#### Impact: High
An attacker who has compromised a server can maintain persistent access and attempt to compromise further internal systems by downloading malicious scripts and tools. Additionally, the server could be compromised by malware through drive by downloads.
#### Likelihood: Low
An attacker would first need to compromise a server or an administrator would need to visit a malicious website.
#### Recommendation
Unless Internet access is specifically required, for example on WSUS servers to download Microsoft patches, it should be disabled or restricted to specific source destinations and services.
