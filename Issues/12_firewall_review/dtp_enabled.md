---
category: "CNF"
cvss: "TBA"
---
### DTP Enabled
The Dynamic Trunking Protocol (DTP) was found to be enabled on the interface{s||} of the above device{s||}. DTP is used to negotiate Virtual Local Area Network (VLAN) trunking between switches. When enabled, the switch can dynamically negotiate trunking with an attached switch without requiring manual configuration.

Once the negotiation is successful, any VLANs configured to trunk will be allowed to pass between the connected device{s||}. If specific VLANs have not been specified, all VLANs will be permitted over the trunk.
#### Impact: Medium
An attacker with access to the internal network could attempt to negotiate a trunk link with the device to gain access to all VLANs configured on the trunk. This could allow an attacker to bypass network segregation used to restrict access between VLANs, potentially compromising sensitive devices.
#### Likelihood: Low
Public tools can be used by an attacker to negotiate trunk access with the switch. However, the attacker would need to be connected to the internal network to exploit this issue.
#### Recommendation
If not required, disable DTP on the device interfaces. Consider configuring the switch ports to access mode. This can be achieved by using the interface command below. If it is required, DTP only poses a low risk, consider an internal risk assessment regarding leaving DTP enabled.

```
switchport mode access
```
