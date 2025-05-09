---
category: "LOG"
cvss: "N/A"
---
### Log Retention Policy Insufficient
{==OPTION==} Discussion with relevant staff revealed an unclear policy for wireless LAN controllers log retention. As a result, relevant logs which could be used for forensic investigations or incident response plans might not be available when required.

{==OPTION==} Discussion with relevant staff revealed that wireless LAN controllers logs are retained for only {==NUMBER==} days. As a result, relevant logs which could be used for forensic investigations or incident response plans might not be available when required.
#### Impact: Medium
Although controllers send logs to a remote server over syslogd, relevant logs which could be used for forensic investigations or incident response plans might not be available.
#### Likelihood: Low
Logs were seen to be sent to a remote server. For this to become an issue, an attacker would need to gain access to the wireless network and to perform further attacks from there.
#### Recommendation
Establish a rigorous policy for log retention on the remote server and implement controls to ensure that such policy is followed.

{==OPTION==} Consider a minimum period of 90 days of logs retained.
