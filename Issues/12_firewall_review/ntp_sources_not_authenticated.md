---
category: "TBA"
cvss: "TBA"
---
### NTP Sources Not Authenticated
A review of the firewall configurations revealed that NTP authentication was disabled for the devices. Time synchronisation for network devices is inherently important, not just for the various services that make use of time, but also for accurate logging of events. The IP addresses of the NTP servers for {==each/the==} firewall are listed below:

{==Bullet list per firewall==}
#### Impact: Medium
If an attacker is able to modify a device's time with an inaccurate time update, then it would be more difficult during a forensic examination to correlate the system logs. Furthermore, any services that depend on an accurate time, such as some authentication services, could be disrupted and potentially cause a denial of service.
#### Likelihood: Low
With no NTP time authentication configured, an attacker could attempt to update the time by sending malicious time updates. An attacker could do this using available tools or by sending customized network packets and spoofing the source address.
#### Recommendation
Consider configuring NTP time authentication. {==OPTION If Cisco==} This can be achieved using the following commands:

```
ntp authenticate
ntp trusted-key <key-id>
ntp authentication-key <key-id> md5 <key-string>
ntp server <ip-address> key <key-id>
```

At a minimum, ensure that multiple independent and trusted time sources are configured, such as three or more, so that inaccurate time sources will be automatically ignored by the NTP service software.
