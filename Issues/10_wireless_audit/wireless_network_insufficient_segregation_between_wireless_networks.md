---
category: "NET"
cvss: "3.4"
---
### Wireless Network Insufficient Segregation Between Wireless Networks
Network scanning from wireless networks in the scope of the test revealed insufficient network segregation in the following areas:

{==OPTION_CAN_REACH_AND_PIVOT_VIA_OTHER_WIRELESS_NET==} A client connected to the {==SSID_1==} wireless network cannot access the internal network. However, they are able to reach the default gateway and clients connected to the {==SSID_2==} wireless network, from which is possible to reach the internal network. As a result, an attacker compromising a client in the **SSID_1==} wireless network, would then be able to pivot into the internal network.

{==OPTION==} A client connected to the "{==SSID_1==}" wireless network can reach the default gateway and clients of the "{==SSID_2==}" wireless network, and vice versa. Both wireless networks have access to the internal network.

{==OPTION==} A client connected to the "{==SSID_1==}" wireless network can reach the default gateway and clients of "{==SSID_2==}" wireless network, and vice versa. Both wireless networks have access to the internal network.

{==OPION==} See the table below which shows which wireless networks can route to other networks: {==TABLE==}
#### Impact: Medium
An attacker connected to the "{==SSID==}" wireless network and compromising a client of the "{==SSID==}" wireless network would be able to access the internal network. Furthermore, insufficient network segregation between wireless networks would potentially allow them to access and compromise systems which have access to confidential data.
#### Likelihood: Low
An attacker would first need to obtain access to the wireless networks. {==OPTION==} This might be possible because wireless keys have never been changed (see section {==XREF==}) {==OPTION==} and there is no deactivation of inactive accounts (see section {==XREF==}), they would still need to compromise other systems in order to access the internal network or access confidential information.
#### Recommendation
Segregate the wireless networks so that systems are grouped according to functionality and sensitivity levels. Use VLAN, routing, and firewall configurations to enable tightly controlled traffic flows.
