---
category: "{==APP-CNF/NET==}"
cvss: "5.3"
---
### ICMP Timestamp Request Allowed
A response was received from an Internet Control Message Protocol (ICMP) timestamp request to the affected system{s||} listed above. An ICMP timestamp request allows the time and date set on the device to be discovered.

{==HOSTS==}

A proof of concept example is shown below:

```
$ sudo /usr/sbin/hping3 --icmp --icmp-ts HOST
len=46 ip={==HOST==} ttl=48 id=47194 icmp_seq=1 rtt=15.2 ms
ICMP timestamp: Originate=45124593 Receive=45138003 Transmit=45138003
ICMP timestamp RTT tsrtt=16
```
#### Impact: Low
Unnecessary system information relating to the time and date set on the host{s||} is exposed. This can be useful when trying to defeat time based authentication protocols.
#### Likelihood: Medium
Sending ICMP timestamp requests easily reveals the time and date set on the remote host{s||}.
#### Recommendation
Consider filtering all external ICMP timestamp requests on the external firewall or router for this host. If the organisation specifically requires ICMP timestamp requests to be available externally, consider only allowing access to this function from specific known sources.
