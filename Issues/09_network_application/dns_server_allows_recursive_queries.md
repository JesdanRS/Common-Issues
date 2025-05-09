---
category: "CNF"
cvss: "5.3"
---
### DNS Server Allows Recursive Queries
The Domain Name System (DNS) service at {==IPADDRESS==} allows recursive queries. This means that anyone from any remote location is able to use these servers to resolve third-party names. This can also be used for a distributed denial of service attack.
#### Impact: Low
Anyone can use the DNS service as a public name resolution service. The service can also be used for a distributed denial of service attack.
#### Likelihood: Medium
It is straightforward to determine if DNS servers allow recursive queries.
#### Recommendation
Restrict recursive queries to only those hosts that should use these name servers, such as those of the LAN connected to it.