---
category: "{==APP-CNF/NET==}"
cvss: "5.3"
---
### MSRPC Externally Available
The Microsoft Remote Procedure Call (MSRPC) service was found to be listening on the following TCP ports of the affected system{s||} listed above.

An attacker can use the MSRPC port mapper to enumerate services listening on the host. An example of the information which can be obtained from the MSRPC port mapper is shown below:

```
$ dcedump {==IPADDRES==}
{==OUTPUT==}
```
#### Impact: Low
System information, which may be useful to an attacker, is unnecessarily exposed. This also indicates that the host has not been sufficiently hardened and firewalled.
#### Likelihood: Medium
The MSRPC service can be accessed anonymously and there are a number of freely available tools online which can be used to enumerate running services.
#### Recommendation
Unless external access to the MSRPC service is specifically required, consider disabling access to these ports at the firewall. If external access is required it should be restricted to trusted IP addresses only.
