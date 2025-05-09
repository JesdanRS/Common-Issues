---
category: NET
cvss: 6.8
---
### WSUS Updates Over HTTP
{A number of systems were||The sampled system was} seen to be configured to fetch updates using the HTTP protocol. This configuration on the sample {==server/workstation==} can be seen by inspecting the settings configured on "{==HOSTNAME==}", as shown in the screenshot below:

{==SCREENSHOT==}

This configuration can be abused by an attacker by injecting malicious updates from a rogue server on the network, for example by performing a man-in-the-middle attack using ARP poisoning or modifying the proxy settings on the vulnerable systems. If successful, the malicious code will be executed under SYSTEM privileges, leading to a full compromise of the machine.

{==OPTION==}Note that this attack was not performed by Dionach in order to avoid disrupting the servers and network.
#### Impact: High
An attacker that successfully exploits this misconfiguration would be able to fully compromise the affected system. In the event of a domain controller, this would allow them to fully compromise the domain.
#### Likelihood: Medium
An attacker would need to use a rogue WSUS update server on the network, by hosting this on the network and performing another attack such as ARP poisoning. Note that tools to exploit this are publicly available, such as Wsuxploit, Wsuspect-proxy and PyWsus.
#### Recommendation
Ensure that WSUS updates are performed over HTTPS only. Please see the following Microsoft documentation at the following URL for further information:

[https://docs.microsoft.com/en-us/previous-versions/windows/it-pro/windows-server-2012-R2-and-2012/hh852346(v=ws.11)#35-secure-wsus-with-the-secure-sockets-layer-protocol]()
