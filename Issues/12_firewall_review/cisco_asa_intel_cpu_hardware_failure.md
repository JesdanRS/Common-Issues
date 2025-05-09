---
category: "UPD"
cvss: "4.2"
---
### Cisco ASA Intel CPU Hardware Failure
The Cisco ASA firewall{s listed below|| HOSTNAME} appears to be affected by a hardware issue related to the Intel C2000 SoC the device is based on. This fault can cause the firewall to completely fail after a number of years of operation.

The device{s||} should be eligible for a replacement if a support contract is in place. {==OPTION==} Note that as this device is part of a failover pair, the other firewall in the pair may also be affected.

Further information can be found in the following Cisco support article:

[https://www.cisco.com/c/en/us/support/web/clock-signal.html#~faqs]()
#### Impact: High
The device may suffer from a complete hardware failure, rendering the network unavailable.
#### Likelihood: Medium
The firewall is part of a failover pair, and although this issue increases the likelihood of a failure, large numbers of affected devices are still functioning.
#### Recommendation
Confirm whether the device is eligible for replacement, and if so begin the process of requesting a replacement from Cisco. Otherwise, consider replacing it with a different model or device that is covered by a support contract and is not affected.
