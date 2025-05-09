---
category: "CNF"
cvss: "TBA"
---
### Proxy ARP Enabled
The proxy ARP feature was enabled on the device{s||} above. This allows routers to answer ARP requests intended for another machine and then routing the packets to intended destination.
#### Impact: Medium
A network device that acts as a proxy for ARP requests will extend layer two access across multiple network segments connected to its interfaces, potentially breaking perimeter security.
#### Likelihood: Low
A number of ARP tools such as Bettercap can be downloaded from the internet for use in exploiting this finding.
#### Recommendation
Consider disabling Proxy ARP on router interfaces. This can be achieved using the following command:

```
no ip proxy-arp
```
