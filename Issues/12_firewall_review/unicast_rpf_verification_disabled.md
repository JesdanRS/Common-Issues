---
category: "CNF"
cvss: "N/A"
---
### Unicast RPF Verification Disabled
The firewall{s listed below do|| HOSTNAME does} not have uRPF (unicast reverse path) protection configured on any interfaces in order to check that the source IP address of any traffic matches the routing table. Packets with spoofed source IP addresses are commonly seen in malicious traffic, such as those sent in denial of service attacks. Additionally, attackers could use spoofed IP addresses in order to bypass firewall rules and take advantage of trust relations between hosts.

Further information regarding uRPF is available from the following Cisco article:

[https://www.cisco.com/c/en/us/about/security-center/unicast-reverse-path-forwarding.html]()
#### Impact: Medium
With unicast RPF verification disabled and no alternative anti-spoofing network filtering configured, an attacker may be able to route network packets using a spoofed source address. This is especially useful for attackers when seeking to attain a degree of anonymity for denial of service attacks or when taking advantage of trust relationships between hosts.
#### Likelihood: Low
The use of a spoofed source IP addresses is a common method of masking the location and identity of an attacker. However, an attacker would have to be on a locally connected network in order to exploit this vulnerability.
#### Recommendation
Consider enabling uRPF protection in order to prevent malicious traffic. This can be achieved by using the following command:

```
ip verify reverse-path interface <interface>
```
