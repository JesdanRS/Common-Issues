---
category: "NET"
cvss: "4.0"
---
### Public IP Range In Use
The {==DESCRIPTION==} internal network is using a public IP address range ({==RANGE==}), rather than one of the private network ranges defined in RFC 1918. This IP address belongs to a range owned by "{==OWNER==}", as shown below:

$ whois {==RANGE==}
```
WHOISDATA
```
#### Impact: Medium
Typically the use of a public IP range for an internal network could result in internal traffic being unintentionally routed to external systems, or cause connectivity issues should there be a requirement to communicate with the actual public network. {==OPTION==} However, Internet access is not available within the network and as such this issue currently has no security impact.
#### Likelihood: Medium
Connectivity issues would only arise if internal users need to access systems owned by {==OWNER==}, or if internal routing is misconfigured to send traffic externally.
#### Recommendation
Consider the use of a designated internal IP address range for the network in order to avoid potential issues should systems need to communicate with any external systems owned by {==OWNER==}. A list of IP ranges specifically allocated for internal use is available at the following URL:

https://en.wikipedia.org/wiki/Private_network
