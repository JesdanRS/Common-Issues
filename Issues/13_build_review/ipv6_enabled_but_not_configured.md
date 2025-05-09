---
category: "CNF"
cvss: "4.6"
---
### IPv6 Enabled But Not Configured
IPv6 is enabled on the reviewed system{s||}; however, it does not appear to be in use. For example, on the {==SYSTEM==} server, the network interface has a local IPv6 addresses, as shown below:

```
$ ifconfig
{==OUTPUT==}
```

However, inspection of the packet statistics in ip6tables indicated that these addresses were never used, and that all traffic was sent and received over the IPv4 addresses.

```
$ ip6tables -L -n -v
<...>
Chain INPUT (policy ACCEPT 0 packets, 0 bytes)
Chain OUTPUT (policy ACCEPT 0 packets, 0 bytes)
```

{==OPTION==} Note that no IPv6 firewall rules were configured on the host, and as such, any IPv6 traffic would be permitted.
#### Impact: Medium
A number of network-level attacks exist that utilise IPv6, some of which are designed to target systems that have IPv6 enabled but not fully configured. Additionally, security features such as firewalls may not be configured with appropriate rules to restrict IPv6 traffic.
#### Likelihood: Low
An attacker would need to gain access to the local network that the system{s||} are hosted on in order to communicate with them over IPv6.
#### Recommendation
Consider disabling IPv6 on the server by adding the following line to /etc/sysctl.conf

```
net.ipv6.conf.all.disable_ipv6 = 1
```
