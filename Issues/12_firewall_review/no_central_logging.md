---
category: "LOG"
cvss: "N/A"
---
### No Central Logging
The firewall{s below are|| HOSTNAME is} not configured with any central logging, such as syslog.
#### Impact: Medium
Although logs will be stored on the firewalls themselves, these will only be retained for a short period of time. Additionally, if the firewalls are compromised, these logs could be deleted by the attacker. This could hamper incident response processes or a forensic investigation.
#### Likelihood: Low
The lack of central logging would only become an issue if a security incident occurred that required access to the log information.
#### Recommendation
Consider configuring the firewalls to log to a remote syslog server using encrypted syslog. This can be achieved using the following command:

```
logging host <interface> <ip-address> tcp/<port> secure
```

Note that the receiving host must also support secure connections and that by default ASAs will stop all traffic if the TCP syslog destination is unavailable . If undesired, this behaviour can be disabled with the following command:

```
logging permit-hostdown
```
