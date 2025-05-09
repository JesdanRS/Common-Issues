---
category: "CNF"
cvss: "5.3"
---
### IDENT Service in Use
The affected system{s||} {are||is} is running the "ident" service on TCP port 113. This service allows an attacker to identify the user context of a given application daemon on a chosen port. {==OPTION==} For example, it is possible to identify that the service {==SERVICE==}, running on TCP port {==NUMBER==}, is running in the context of the "{==ROLE==}" user, as shown below:

```
#./ident-user-enum.pl {==IPADDRESS==} {==PORT==}
{==OUTPUT==}
```
#### Impact: Low
Unnecessary system information is exposed.
#### Likelihood: Medium
This issue is relatively easy to identify and exploit.
#### Recommendation
Disable this service, or update firewall restrictions to allow access only from trusted sources.