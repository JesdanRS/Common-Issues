---
category: "NET"
cvss: "4.3"
---
### Wireless Controller Insufficient Network Restrictions
Network scanning from following wireless SSIDs revealed that there is no restriction in accessing the admin login of the Wireless LAN Controllers (WLC).

```
{==SSID_LIST_OR_TABLE==}
```

Please see the table below showing which wireless SSIDs allow access to WLC interfaces:

{==TABLE==}

{==OPTION==} Please note that the "{==SSID==}" wireless network is an open wireless network which does not require authentication. As a result, anyone can connect to it and start attacking the Wireless LAN Controller.
#### Impact: Medium
Anonymous users can reach the Wireless LAN Controllers in the {==CLIENTNAME==} network. This would allow them to execute attacks against these controllers, including brute-forcing attacks on the web portal or on the SSH service. If an attacker compromises a controller, they would be able to edit network configurations in order to redirect their traffic to the internal {==CLIENTNAME==} network.
#### Likelihood: Medium
An attacker would need to compromise a Wireless LAN Controller in order to gain access to the internal network which would require another vulnerability to exist, such as a weak password or a vulnerability in the device.
#### Recommendation
Prevent access to Wireless LAN Controllers from clients connected from any wireless network. Use VLAN, routing, and firewall configurations to enable tightly controlled traffic flows.
