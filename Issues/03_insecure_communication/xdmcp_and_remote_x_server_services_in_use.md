---
category: "{==APP-DAT/NET==}"
cvss: "6.5"
---
### XDMCP and Remote X Server Services in Use
The affected system{s||} allow{s||} remote connections to XDMCP and X server on UDP port {==177==} and TCP port {==6003==} respectively. These are potentially insecure protocols in the sense that they are not encrypted by default. Anyone intercepting the data that passes between the client and the server will be able to read the clear text communication, including logins and passwords.
#### Impact: Medium
If someone was able to intercept the data passing clear text over the network the username and password could be compromised, allowing unauthorised access to the host.
#### Likelihood: Low
To intercept the clear text passwords off the network an attacker on another host would need to use an attack such as an ARP poisoning attack.
#### Recommendation
Consider filtering remote access to these services if it is not required. Alternatively force connections to be tunnelled over SSL.