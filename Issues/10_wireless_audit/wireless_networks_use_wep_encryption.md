---
category: "CRY"
cvss: "4.6"
---
### Wireless Networks Use WEP Encryption
The wireless networks with SSID listed below are protected by the Wired Equivalent Privacy (WEP) security protocol.

{==SSID_LIST==}

While WEP is better than an unencrypted network, WEP suffers from a number of known weaknesses and by intercepting a sufficiently large amount of wireless network data, around fifty-thousand packets, an attacker can easily identify the WEP key in use. This key can then be used by the attacker to connect to the wireless network.

{==OPTION==} Note that, due to the low usage of the wireless networks, Dionach did not attempt to crack the wireless keys due to the time that would be required and as IT staff determined that a proof of concept was not required.
#### Impact: High
WEP encryption has a number of well-known technical flaws which could allow an attacker with a sufficient volume of intercepted encrypted traffic to identify the key in order to make an authenticated connection to the wireless network.
#### Likelihood: Medium
Breaking WEP encryption is relatively straightforward and there are a number of tutorials available online. In addition, the nature of wireless network communication means that many of the attacks against the network can be performed without being detected, and in some cases without being physically present at the site for more than a few minutes at a time. {==OPTION==} As the "{==SSID==}" network was not in use by client devices during the testing period, it could take a significant time for an attacker to obtain a sufficient amount of encrypted data in order to obtain the key.
#### Recommendation
Replace the WEP based network with a WPA2 based network as a matter of urgency.
