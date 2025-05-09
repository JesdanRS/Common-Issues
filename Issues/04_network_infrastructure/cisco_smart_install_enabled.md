---
category: "CNF"
cvss: "9.8"
---
### Cisco Smart Install Enabled
The network device{s} listed above {are||is} seen to have the Cisco Smart Install management feature enabled{:||.}

The Smart Install protocol is used to configure newly deployed network devices, however it does not require authentication. As such, it allows an anonymous attacker to take complete control over the devices, including updating configuration settings, executing privileged commands, or modifying the installed IOS version. Further information can be found in the following Cisco security advisory:

[https://tools.cisco.com/security/center/content/CiscoSecurityAdvisory/cisco-sa-20170214-smi]()
#### Impact: High
An anonymous attacker can take complete control of the network devices, potentially allowing them to intercept traffic on the network, bypass security restrictions, or cause a denial of service.
#### Likelihood: Medium
Exploit code is publicly available for this vulnerability, and it has been seen to be actively exploited in the wild. However, there is an element of risk when targeting network devices, and changes to the configuration of these devices may be identified and logged by other systems.
#### Recommendation
Disable Smart Install on all network devices by issuing the following command in enable mode:

```
no vstack
```
