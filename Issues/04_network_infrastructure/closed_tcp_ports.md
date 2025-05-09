---
category: "{==APP-CNF/NET==}"
cvss: "N/A"
---
### Closed TCP Ports
A number of TCP ports were found to be in the state "closed" rather than "filtered". This often indicates that traffic is permitted through the firewall, but that there is no service listening on the port. An attacker, having exploited a remote command execution vulnerability, can potentially bind a shell daemon or remote access Trojan to these ports. {==OPTION==} Note that many firewalls return a RST packet in response to connection attempt to TCP port 113 (IDENT) for legacy reasons, and as such this port will often show as "closed" even when it is actually blocked by firewall rules.

The ports observed to be closed are shown in the port scan in appendix {==C==}.
#### Impact: Medium
An attacker may be able to use closed TCP ports to establish connections with an attacker's servers after compromising a host.
#### Likelihood: Low
While closed ports are easily detected through well-known port scanning techniques, this issue relies on an attacker being able to exploit a remote command execution vulnerability.
#### Recommendation
Investigate the configuration of the devices located on IP addresses listed in the port scan. Drop traffic to all ports that do not have services listening on them.
