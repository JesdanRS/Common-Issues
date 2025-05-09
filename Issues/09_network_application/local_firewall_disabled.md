---
category: "NET"
cvss: "4.3"
---
### Local Firewall Disabled
Local firewall protection on Windows servers and workstations was seen to be disabled throughout the network, as shown in the example below:

{==HOSTNAME==}
{==SCREENSHOT==}
#### Impact: Medium
The lack of a local firewall could expose services to internal attackers, this would further aid them into compromising {==CLIENTNAME==} systems and data.
#### Likelihood: Medium
A lack of local firewall protection would be quickly determined through the use of port scanning tool.
#### Recommendation
Enable the Windows Firewall internally, or deploy a third-party firewall solution. Whilst historically, Windows Firewall is considered by many to offer relatively weak protection, it is generally considered to be far preferable to no local firewall, and so should be enabled by default, except when disabled by alternative endpoint solutions.
