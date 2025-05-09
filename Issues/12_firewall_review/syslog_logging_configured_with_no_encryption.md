---
category: "CRY"
cvss: "3.5"
---
### Syslog Logging Configured With No Encryption
The firewall{s below are|| HOSTNAME is} not configured to encrypt syslog traffic sent to remote systems.
#### Impact: Medium
An attacker could obtain potentially sensitive log information relating to the network and firewalls.
#### Likelihood: Low
An attacker would need to gain access to the internal network in order to intercept the syslog communication.
#### Recommendation
Consider encrypting syslog traffic. This can be achieved using the following command:

```
logging host <interface> <ip-address> tcp/<port> secure
```

Note that the receiving host must also support secure connections and that by default ASAs will stop all traffic if the TCP syslog destination is unavailable . If undesired, this behaviour can be disabled with the following command:

```
logging permit-hostdown
```
