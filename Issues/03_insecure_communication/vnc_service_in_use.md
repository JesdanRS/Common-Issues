---
category: "{==APP-DAT/NET==}"
cvss: "6.5"
---
### VNC Service in Use
The affected system{s||} {are||is} running the VNC service on the indicated port.

VNC is an insecure protocol in the sense that it is not encrypted by default. Anyone intercepting the data that passes between the VNC client and the VNC server will be able to read the clear text communication, including entered credentials, as well as eavesdropping on, or interacting with, the currently logged on session.
#### Impact: Medium
If someone was able to intercept the data passing clear text over the network sensitive data such as credentials could be compromised, allowing unauthorised access to the affected system.
#### Likelihood: Low
To intercept the clear text passwords off the network an attacker on another host would need to use an attack such as an ARP poisoning attack.
#### Recommendation
Consider replacing the current VNC implementation with one which supports encryption, or use an alternative remote administration mechanism such as Microsoft Remote Desktop Protocol.
