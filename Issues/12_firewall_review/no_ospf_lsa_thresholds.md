---
category: "CNF"
cvss: "TBA"
---
### No OSPF LSA Thresholds
The OSPF (Open Shortest Path First) configuration on the device{s||} above did not have a link-state advertisement (LSA) message threshold configured. OSPF is a routing protocol that can be configured to dynamically update the routing table with changes to the network topology. OSPF uses LSA to communicate changes to other routers and update the routers own Link State Database (LSDB). Devices can be configured with a LSA message threshold to limit the number of LSA messages being processed by the device.
#### Impact: Medium
An attacker may be able to perform an OSPF denial of service (DoS) by flooding the device with LSA messages.
#### Likelihood: Low
Existing public tools can be used to perform a DoS by flooding the device with LSA messages.
#### Recommendation
Limit the number of OSPF LSA messages accepted by the device by adding the following router command to the affected device configuration:

```
max-lsa threshold
```
