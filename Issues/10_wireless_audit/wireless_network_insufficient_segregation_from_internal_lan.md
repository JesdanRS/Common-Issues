---
category: "NET"
cvss: "4.4"
---
### Wireless Network Insufficient Segregation From Internal LAN
Network scanning from the following wireless network SSIDs revealed that there is no network segregation between the wireless networks and the internal {==NAME==} network.

```
{==LIST_OF_SSID==}
```

When a client is connected through any of these wireless networks they are able to reach the domain controller at {==ADDRESS==}, which is in the internal network, as shown in the port scan results in the appendix {==XREF==}. Thus, an attacker compromising a client connected to any of these wireless networks will gain unrestricted access to the {==CLIENTNAME==} network and resources.
#### Impact: High
An attacker authenticated to the wireless networks above would be able to access {==NAME==} internal network. This will potentially allow the attacker to perform further attacks and compromise key systems in order to gain access to confidential data.
#### Likelihood: Medium
{==OPTION==} [if open network, set likelihood high, if wpa-2 with strong keys, set likelihood low]
An attacker would need to obtain access to the wireless network in order to perform this attack.
#### Recommendation
{==OPTION_IS_GUEST==} This is a guest network, as such disable any access to the internal network.

{==OPTION_IS_STAFF==} Review the configuration of the wireless networks above and conduct a risk assessment to determine whether access to the internal network is needed.

If internal access is required, ensure that security controls are in place to prevent an authorised access to the wireless network. For example, consider migrating the wireless network to WPA2-Enterprise or alternatively require all wireless clients to establish a VPN connection to reach internal network resources. Ensure policies and procedures are in place to disable dismissed accounts and to performing regular wireless assessments.
