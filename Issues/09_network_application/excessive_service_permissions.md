---
category: "PRV"
cvss: "8.8"
---
### Excessive Service Permissions
A review of the services running on the affected server{s||} identified that the following service{s are|| is} running as a member of the "{==Domain Administrator==}" group.
#### Impact: High
If an attacker can compromise the server{||s}, they will be able to escalate their privileges to take control of the Active Directory (see issue {==XREF==}).
#### Likelihood: Medium
Anyone who has gained or has been granted access to the above system{||s} can exploit this issue.
#### Recommendation
Review service permissions wherever possible, and grant them only the specific rights that they require for full service and application functionality. In most cases, the local "Network Service" account, or a named domain user account with equivalent permissions, will be sufficient. This is likely to be a time consuming process, and will likely require a large degree of interaction with software vendors.