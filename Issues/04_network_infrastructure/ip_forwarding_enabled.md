---
category: "CNF"
cvss: "4.2"
---
### IP Forwarding Enabled
The affected system{s||} {have||has} IP forwarding enabled.
#### Impact: Medium
An attacker may use this flaw to route packets through {these hosts||this host} and potentially bypass firewall restrictions.
#### Likelihood: Low
The success of this attack depends on a number of factors and configurations that make exploitation difficult.
#### Recommendation
Unless the host is a router, it is recommended to disable IP forwarding. On Linux, IP forwarding can be disabled by executing the following command:

```
sysctl net.ipv4.ip_forward net.ipv4.ip_forward = 0
```


{==Windows==}To disable IPv4 forwarding on all Windows network adapters, the following command can be used:

```
Set-NetIPInterface -Forwarding Disabled
```

For other operating systems, please refer to vendor's documentation.
