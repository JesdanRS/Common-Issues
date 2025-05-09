---
category: "CNF"
cvss: "8.6"
---
### DNS Server Distributed Denial of Service
The Domain Name System (DNS) server at {==IPADDRESS==} can be used in a distributed denial of service attack (DDoS), as it answers to any request. It is possible to query the name servers (NS) of the root zone (".") and get an answer which is larger than the original request. By spoofing the source IP address, a remote attacker can leverage this amplification to launch a denial of service attack against a third-party host using the remote DNS server.
#### Impact: Low
The DDoS attack would not be against this host, but would use the host to attack another. This could affect the reputation of {==CLIENTNAME==}.
#### Likelihood: Medium
These attacks are easy to carry out and occur regularly.
#### Recommendation
Review the secure BIND configuration for DDoS prevention:

[https://www.cymru.com/Documents/secure-bind-template.html]()