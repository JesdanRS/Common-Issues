---
category: "PRC"
cvss: "3.1"
---
### Wireless Network Pre-Shared Keys Never Changed
Discussion with relevant {==CLIENTNAME==} staff revealed that WPA and WPA2 Pre-Shared Keys (PSK) have not been changed in over {==PERIOD==}.

As a result, an attacker who is aware of the wireless keys would be able to connect to the wireless network and access sensitive information or to attempt to compromise sensitive servers or workstations. Examples of attackers who may be aware of the key includes previous visitors who were granted access, disgruntled or dismissed employees, or an external attacker who recovered the wireless key from a captured handshake.

The following wireless SSIDs were seen to be configured with WPA or WPA2 authentication:

```
{==SSIDLIST==}
```
#### Impact: High
The lack of a periodic change of wireless keys increases the chance that they become known to a malicious user. As a result, an attacker knowing the wireless keys would then be able to access the internal network (see section {==XREF==}) or target other clients connected to the wireless network, which have access to sensitive or confidential information.
#### Likelihood: High
Taking into consideration that wireless keys have not been changed in over {==PERIOD==} and given the size of the organisation it is reasonable to assume that a large number of potential attackers are aware of the wireless keys. Moreover, as some of the wireless networks are reachable from outside of the {==CLIENTNAME==} perimeter (see section {==XREF==}) an attacker could be more motivated to target {==CLIENTNAME==}'s network via these wireless networks as it is less likely that they would be detected.
#### Recommendation
Consider migrating the staff wireless authentication mechanisms from WPA or WPA2 to WPA2-Enterprise. If this is not possible, develop a policy that ensures that wireless keys are regularly changed. Although not ideal, this should be done every time an employee leaves. If this is not possible, {==CLIENTNAME==}'s relevant staff should conduct a risk assessment to establish a lapse of time which guarantees a reasonable level of security but is also in line with the organisation's operations.

Ensure visitors or guests receive their own separate network access, and that this provision is risk assessed. Ensure the guest network is restricted to internet access only and that strict content filtering controls are in place to prevent misuse. If a pre-shared key is used for visitor access, ensure it is changed regularly. Otherwise consider a captive portal system with individual accounts provided for each visitor.
