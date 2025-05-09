---
category: "{==APP-CNF/NET==}"
cvss: "TBC"
---
### Legacy UNIX Services Available
The affected system{s||} {are||is} running the indicated legacy network services:

{==HOSTS and SERVICES==}

These legacy network services were originally intended for use in testing network connections and measuring round trip times and are not required in nearly all circumstances. Echo has been superseded by ICMP echo requests.

An attacker can exploit the design of some of these protocols, such as echo and CHARGEN, in order to cause a denial of service against hosts running the same service by spoofing the IP address of one host and sending data to another. This results in an infinite loop of messages that could consume host and network resources.
#### Impact: Medium
An attacker could exploit these services as part of a denial of service attack to target other systems on the network.
#### Likelihood: Low
It is unlikely that an attacker would choose to target these services, and there are much more effective denial of service attacks that can be performed with local network access.
#### Recommendation
Disable the legacy services or filter traffic to these ports.
