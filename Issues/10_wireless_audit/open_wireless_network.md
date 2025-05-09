---
category: "NET"
cvss: "5.4"
---
### Open Wireless Network
During testing, the following wireless networks were found to be open, since authentication was not required to access the network:

```
{==LISTOFSSIDS==}
```
#### Impact: High
Anyone can access these wireless networks and perform malicious activities. For example, they could intercept traffic and retrieve credentials or other sensitive information.
#### Likelihood: High
Anyone can access these wireless networks since authentication is not required. There are readily available tools that could be used to intercept and analyse traffic passing across the wireless network.
#### Recommendation
{==OPTION_NOT_GUEST==} Secure the wireless connection using a strong mechanism such as WPA2-Enterprise.
{==OPTION_GUEST==} Secure the wireless connection with a strong encryption method such as WPA2. Additionally, ensure that {==CLIENTNAME==} policies prohibit the use of the unencrypted guest network for corporate devices.
