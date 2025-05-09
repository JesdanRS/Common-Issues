---
category: "ATH"
cvss: "N/A"
---
### No Central Authentication
The firewall{s were not|| was not} configured to use central authentication such as via TACACS+ or RADIUS. Instead, the firewall{s have|| has} a number of local user accounts configured which are used to authenticate. {==OPTION==} Note that some of these local user accounts appeared to be shared (see section {==XREFSharedUserAccounts==}).
#### Impact: Medium
The lack of central authentication increases the administrative overhead of managing the firewalls, as passwords must be changed in multiple places, rather than on a single central system. {==OPTION==} This may be a contributing factor to the current use of shared accounts (see section {==XREFSharedUserAccounts==}).
#### Likelihood: Medium
All of the firewall{s were|| was} seen to use local accounts. It is unknown whether other automated systems are in place to help manage user accounts.
#### Recommendation
Consider the use of a central authentication system such as via TACACS+ or RADIUS.
