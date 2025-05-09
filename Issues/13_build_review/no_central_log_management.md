---
category: "LOG"
cvss: "N/A"
---
### No Central Log Management
There did not appear to be any central collection and storage of system logs from the server{s below:|| at HOSTNAME.}
#### Impact: Medium
Events will be stored locally on the systems for a limited period of time before being overwritten. Additionally, if an attacker if able to compromise a system, they could modify or erase the existing event logs, which could hamper a forensic investigation.
#### Likelihood: Low
Event logs are primarily used for diagnostics, and the circumstances where they are required for forensic investigations are relatively rare. Additional logging may be in place at the network level.
#### Recommendation
Consider implementing central log collecting and archiving, so that event logs from all systems are collected into a single location, and are kept for an appropriate period of time, such as 90 days.
