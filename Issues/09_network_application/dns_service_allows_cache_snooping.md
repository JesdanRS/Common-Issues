---
category: "CNF"
cvss: "5.3"
---
### DNS Service Allows Cache Snooping
The Domain Name System (DNS) service on the external system{s||} listed above responds to queries for third-party domains that do not have the recursion bit set.

For more information see the following link:

[https://resources.infosecinstitute.com/topics/hacking/dns-cache-snooping/]()
#### Impact: Low
If this DNS service is used by the organisation's network, then an attacker could identify which online services are being used by the organisation.
#### Likelihood: Medium
This information can be exposed by using any DNS query tool. The DNS service needs to be in use for DNS requests by internal users.
#### Recommendation
Do not allow external access to the DNS service if it is not specifically required and set it to refuse non-recursive queries.
