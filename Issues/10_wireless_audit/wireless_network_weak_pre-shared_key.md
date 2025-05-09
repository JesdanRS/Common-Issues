---
category: "ATH"
cvss: "2.4"
---
### Wireless Network Weak Pre-Shared Key
Inspection of the device configuration for the sample {==DEVICETYPE==} "{==DEVICENAME==}" indicated that the pre-shared key (PSK), used to protect the wireless communication between the router and the designated user's laptop, was relatively weak. {==OPTION==} The key was {==REASON_CONSIDERED_WEAK==}, as shown below:

{==MASKED_KEY==}
#### Impact: Medium
This password could be broken by manual guessing or a targeted brute-force attack.
#### Likelihood: Low
Someone would need to be motivated to target the wireless network exposed by this device. {==OPTION==} Due to the nature of {==CLIENTNAME==}s work an attacker would be interested in gaining access. {==OPTION==} As the SSID is directly based on the organisational name, it's more likely that this will be guessed by an attacker.
#### Recommendation
{==OPTION==} Consider if a move from a Pre-Shared Key environment to WPA2-Enterprise is possible and if so migrate staff to a WPA2-Enterprise based service which utilises individual accounts for each user.

Use a complex pre-shared key which complies with {==CLIENTNAME==} security policy and ensure this is changed periodically so that leaving staff do not retain access. {==OPTION==} Discussion with relevant staff indicated that randomly generated complex keys are generally used.
