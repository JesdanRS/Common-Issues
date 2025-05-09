---
category: "NET"
cvss: "N/A"
---
### Proxy Settings Are Not Enforced
Proxy settings on the sample {==laptop==} are not enforced. This means that any regular user can modify the proxy configuration in order to obtain unrestricted Internet access, as shown in the following image:

{==SCREENSHOT==}
#### Impact: Medium
This could allow an attacker to download malicious or inappropriate material, which could then be brought inside the internal network. Additionally, it could allow sensitive data to be exfiltrated outside of the network, either intentionally or accidentally, for example through third-party platforms such as web applications, mail solutions, or software such as Dropbox.
#### Likelihood: Medium
It is straightforward to amend the system wide proxy settings in Windows from various locations.
#### Recommendation
Consider enforcing proxy settings through Group Policy on all {==workstations and laptops==}, and use an externally hosted proxy service for laptops or other systems that are outside of the {==CLIENTNAME==} network. Additionally, consider blocking outbound connections at the firewall level. Alternatively, tunnel traffic for all systems outside of the network through a VPN connection.
