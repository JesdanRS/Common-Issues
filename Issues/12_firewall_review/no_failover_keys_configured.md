---
category: "CNF"
cvss: "2"
---
### No Failover Keys Configured
The firewall{s below are|| HOSTNAME is} configured in failover pairs, in order to provide resilience in the event of a hardware failure; however failover keys are not configured on either firewall.

Failover keys are used to authenticate devices in a failover pair, and can also provide encryption of the traffic between them. The following Cisco documentation provides further information on failover keys:

[https://www.cisco.com/c/en/us/td/docs/security/asa/asa-command-reference/A-H/cmdref1/f1.html#failover_ipsec_pre-shared-key]()
#### Impact: Medium
An attacker gaining physical access to the devices may be able to obtain a copy of the configuration by impersonating one member of the failover pair. This could include sensitive information such as VPN tunnel PSKs.
#### Likelihood: Low
An attacker would need physical access to the devices and would need to break the failover pair in order to perform this attack.
#### Recommendation
Configure encrypted and authenticated failover traffic with the following command:

```
failover ipsec pre-shared-key 8 <encrypted password>
```
