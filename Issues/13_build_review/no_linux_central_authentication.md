---
category: "ATH"
cvss: "N/A"
---
### No Linux Central Authentication
There does not appear to be any central authentication in use on the reviewed Linux servers. {==OPTION==} The same accounts existed on all the servers, and inspection of the password hashes indicated that the passwords were the same across the different systems for each account. However, these accounts were locally created on each server, rather than being part of a central authentication systems such as LDAP.
#### Impact: Medium
The lack of central management increases the administrative overhead of maintaining user accounts across the network, including changing users' passwords, and removing user accounts that are no longer required. This increases the likelihood of users' passwords remaining unchanged for long periods of time, and of old user accounts being left on production systems.
#### Likelihood: Medium
The relatively small number of systems and accounts reduces the likelihood of legacy accounts being left on systems. {==OPTION==} There appears to be an existing scripted process in place to manage user accounts across multiple systems; however it is unknown how effective this process is. {==OPTION==} The nature of the systems means that staff turnover is likely to be relatively low.
#### Recommendation
Consider the use of a central authentication system such as Kerberos with LDAP to manage user accounts across the environment. If this is not possible, then ensure that users set strong and unique passwords, and that processes are established to remove user accounts across the environment when staff leave.
