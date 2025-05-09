---
category: "{==APP-CNF/CNF==}"
cvss: "5.3"
---
### Cisco VPN Devices Support Aggressive Mode
The affected Cisco VPN endpoint{s||} support{s||} IKE (Internet Key Exchange) aggressive mode over UDP port 500. Aggressive mode returns the PSK hash to the client as a part of the handshake process, and can allow an attacker to perform an offline brute force attack against the hash to discover the password.

[https://www.securityfocus.com/bid/7423]()
#### Impact: Medium
An attacker obtaining a valid PSK may then perform a brute force or dictionary attack against the hash to attempt to discover the password. If the password is found, this could be combined with a valid group name to gain them access to the internal network.
#### Likelihood: Low
An attacker would need to have knowledge of a valid VPN group name and a relatively weak PSK would be required to successfully exploit this issue.
#### Recommendation
Disable aggressive mode support, with the following command. Please note that this will render the VPN unavailable to any VPN clients that require aggressive mode.

```
crypto isakmp aggressive-mode disable
```

More information can be found at the following link:

[https://www.cisco.com/c/en/us/td/docs/ios-xml/ios/security/a1/sec-a1-cr-book/sec-cr-c4.html]()
