---
category: "CRY"
cvss: "3.7"
---
### Wireless Networks Use Weak Encryption
The wireless networks with SSIDs {==SSID==} and {==SSID==} permit clients to connect using {==OPTION_WEP_OR_WPA-TKIP==} encryption.

{==OPTION==} While WPA-TKIP this is considerably stronger than WEP, it still suffers from some vulnerabilities in the way that encryption keys are generated which could increase the rate at which an attacker could attempt to break the pre-shared key (PSK). In addition, weakness in the TKIP session key-generation could allow someone with pre-existing knowledge of the pre-shared key to target users of the wireless network in order to eavesdrop on their communications.

{==OPTION==} While WEP is better than an unencrypted network, it suffers from well-known vulnerabilities in the way that encryption keys are generated which result in an attacker being able to break the pre-shared key.
#### Impact: Medium
The wireless networks' encrypted communications could be decrypted by a sufficiently determined attacker, or someone with pre-existing knowledge of the pre-shared key.
#### Likelihood: Medium
Attacks against wireless networks are well-documented and there are a number of tutorials freely available online. In addition, the nature of wireless network communication means that many of the attacks against the network can be performed without being detected, and in some cases without being physically present at the site for more than a few minutes at a time.
#### Recommendation
{==OPTION==} As no clients connected during the testing period were using WPA-TKIP, consider removing support for this option, enforcing the use of WPA2-AES which is not as vulnerable to the attacks described above.
