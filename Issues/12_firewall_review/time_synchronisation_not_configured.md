---
category: "CNF"
cvss: "N/A"
---
### Time Synchronisation Not Configured
The firewall{s below do|| HOSTNAME does} not have any form of time synchronisation configured, such as NTP. Time synchronization for network devices is important as a number of authentication protocols rely on accurate system time, but more importantly to ensure that any event logs created by the device have accurate timestamps to allow them to be correlated with other systems.
#### Impact: Medium
Lack of time synchronization would make it more difficult to correlate events in logs. This would make a forensic investigation more complex and hinder troubleshooting. Furthermore, the lack of time synchronisation could disrupt systems that depend on accurate time, such as some authentication systems.
#### Likelihood: Low
Over a period of time the initial configuration could gradually drift away resulting in the device being configured with the wrong time.
#### Recommendation
Configure the device to obtain time updates from at least one trusted NTP server, but preferably more such as three or five so that inaccurate sources can be automatically ignored by the software. Also, consider enabling authentication for the NTP service. NTP can be configured using the following command:

```
ntp server <server IP> source outside
```
