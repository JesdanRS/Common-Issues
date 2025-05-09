---
category: "CRY"
cvss: "3.7"
---
### Wireless Networks Use WPA Encryption
The wireless network{||s} listed below permit{||s} clients to connect using Wi-Fi Protected Access (WPA) encryption.

{==SSID_LIST==}

Note that both WPA (using TKIP) and WPA2 (using AES) exist with WPA2 currently accepted as the strongest wireless protocol. There have been developments recently that suggest a number of vulnerabilities within the WPA protocol. Although largely theoretical, demonstrations using specific configurations of WPA have shown it to be breakable in a relatively short period of time. These types of exploits are currently not widely known or employed, but over time WPA could become as easy to break as WEP currently is. The same issue does not currently affect WPA2 with AES.
#### Impact: Medium
The wireless networks' encrypted communications could be decrypted by a sufficiently determined attacker, or someone with pre-existing knowledge of the pre-shared key.
#### Likelihood: Medium
Attacks against wireless networks are well-documented and there are a number of tutorials freely available online. In addition, the nature of wireless network communication means that many of the attacks against the network can be performed without being detected, and in some cases without being physically present at the site for more than a few minutes at a time.
#### Recommendation
Migrate WPA wireless networks to only WPA2 based services.
