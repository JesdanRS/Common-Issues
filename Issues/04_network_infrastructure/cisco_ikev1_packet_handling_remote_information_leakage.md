---
category: "UPD"
cvss: "7.5"
---
### Cisco IKEv1 Packet Handling Remote Information Leakage
The IKE service running on the remote Cisco IOS device{s||} listed above {are||is} vulnerable to an information disclosure vulnerability, known as BENIGNCERTAIN, in the Internet Key Exchange version 1 (IKEv1) subsystem, due to improper handling of IKEv1 security negotiation requests.

It is possible to send specially crafted UDP packets to port 500, that the VPN device will then respond to with partial memory contents, resulting in the disclosure of confidential information such as VPN connection credentials. An example of the partial memory contents retrieved is shown below:

{==HOST==}
```
{==HEXDUMP==}
```

{==OPTION==} Please note that during the test, Dionach did not observe sensitive information such as the VPN pre-shared key or any configuration settings in the returned memory contents, however, an attacker with more time may be able to get such information.
#### Impact: High
An unauthenticated attacker could attempt to retrieve sensitive information from the network device, including credentials or configuration settings, which could lead to the compromise of VPN connection details or the device itself. This may give an anonymous attacker a foothold on {==CLIENTNAME==} internal network, allowing the attacker to launch further attacks against sensitive internal systems.
#### Likelihood: High
This is a widely publicised vulnerability, which is actively being exploited and for which automated exploitation tools have been published.
#### Recommendation
Update the Cisco devices' firmware to the latest version. More information can be found at the following URLs:

[https://tools.cisco.com/security/center/content/CiscoSecurityAdvisory/cisco-sa-20160916-ikev1]()
[https://blogs.cisco.com/security/shadow-brokers]()

Additionally, review current policies and procedures regarding the updating and patching of network devices and services to ensure that systems are patched within a prompt timeframe in order to defend against emerging threats.
