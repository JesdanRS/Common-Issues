---
category: "CNF"
cvss: "5.3"
---
### DNS Server Allows Zone Transfers
A Domain Name System (DNS) zone transfer can be performed on the following domain{||s} using the indicated DNS server{||s}:

DNS Server
IP Address
{==NAMESERVER1==}
{==NAMESERVER1IP==}

This can be seen in the following example:

```
$ dig @{==NAMESERVER==} {==CLIENTDOMAIN==} axfr
{==OUTPUT==}
<...>
```
#### Impact: Low
Domains and IP addresses are exposed. This provides an attacker with a wealth of information about {==CLIENTNAME==}'s external systems, and could also be used to create a list of systems that could be used in phishing attacks against users.
#### Likelihood: Medium
This information is easily extracted by a simple request to the server and is a standard information gathering technique.
#### Recommendation
Disable DNS zone transfers from {this server||these servers} if possible or ensure that only permitted IP addresses are allowed to perform zone transfers.
