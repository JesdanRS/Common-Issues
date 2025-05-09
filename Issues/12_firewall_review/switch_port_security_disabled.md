---
category: "CNF"
cvss: "TBA"
---
### Switch Port Security Disabled
Switch port security was disabled on a large number or ports on the device{s||} above. Switch port security is used to monitor and restrict the devices that can be connected to a single switch port. The switch achieves this by monitoring the Media Access Control (MAC) addresses that originate from the switch port. The MAC addresses can either be specified for a particular switch port or they can be dynamically learned to significantly reduce the administrative overhead.
#### Impact: Medium
This could allow an attacker to connect unauthorised devices to the network.
#### Likelihood: Low
An attacker would have to gain access to a switch port with no security configured.
#### Recommendation
Where possible, enable port security on all switch ports. Furthermore, all switch ports that are not used should be shutdown. Please refer to the following article for further information:

https://www.cisco.com/c/en/us/td/docs/switches/datacenter/aci/apic/sw/2-x/Security_config/b_Cisco_APIC_Security_Configuration_Guide/b_Cisco_APIC_Security_Guide_chapter_0101.pdf
