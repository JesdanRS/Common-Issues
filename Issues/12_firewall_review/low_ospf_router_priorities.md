---
category: "CNF"
cvss: "TBA"
---
### Low OSPF Router Priorities
Open Shortest Path First (OSPF) is a routing protocol used to dynamically update routing tables in response to changes in the network topology. Multiple routers can be configured on a network for fault tolerance, in that situation the router with the highest priority will take precedence. Router priorities can range from 0 to 255.

If set to 0 the router will not become the designated or backup designated router. If two routers have the same priority, the router with the highest router Identifier (ID) will take precedence.
#### Impact: Medium
An attacker who can configure OSPF with the relevant authentication configuration, could configure a higher priority on a malicious device to take precedence over the existing router. If an attacker can control a routing device, they would be able to monitor network traffic sent between network segments and perform various man in the middle attacks.
#### Likelihood: Low
The attacker would require access to a network segment where they could participate in OSPF routing. They would first have to determine the existing OSPF configuration. If authentication credentials are used, the attacker could extract them from the captured network packets. Publicly available tools can facilitate each step of this process.
#### Recommendation
An OSPF priority of 255 should be configured on one of the routers to ensure it becomes the designated router. On Cisco devices, the OSPF priority can be configured with the following interface command:

```
ip ospf priority priority-no
```
