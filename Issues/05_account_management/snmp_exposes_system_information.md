---
category: "{==APP-CNF/CNF==}"
cvss: "5.3"
---
### SNMP Exposes System Information
The affected system{s||} {have||has} the Simple Network Management Protocol (SNMP) service available with the {==default "public"==} community string. This exposes a wealth of system information including details of the network interfaces installed, routing information for the device and various other system parameters.
#### Impact: Low
System information is exposed that is useful to an attacker such as network topology.
#### Likelihood: Medium
There are many freely available SNMP tools that can show this information.
#### Recommendation
If SNMP is not used, consider disabling or filtering it. If SNMP is utilised, implement SNMPv3 with strong and unique passwords (see section {==XREFSNMPv2InUse==}).
