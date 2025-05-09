---
category: "CNF"
cvss: "4.4"
---
### Insufficient Administrative Interface Session Timeout
The following devices have potentially insufficient session timeout configured on their administrative interfaces.

{==Table listing device, interface (protocol), timeout for each==}
#### Impact: Medium
If someone were to hijack an idle session, or regain access to an improperly closed session, they could attempt to continue entering commands, and changing device configuration, in the original connection context.
#### Likelihood: Low
An attacker would need to hijack an existing session that has been abandoned, or gain access to an administrator's computer.
#### Recommendation
Set a timeout to an appropriate value such as 10 minutes.

{==OPTION if Cisco==}
```
console timeout <timeout-minutes>
http server idle-timeout <timeout-minutes>
ssh timeout <timeout-minutes>
```
