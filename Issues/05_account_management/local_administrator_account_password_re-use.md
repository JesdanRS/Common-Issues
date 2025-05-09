---
category: "PWD"
cvss: "8.1"
---
### Local Administrator Account Password Re-Use
The password for the local administrator account {==Administrator==} is re-used between multiple systems within the {==DOMAIN==} Active Directory domain. This means that an attacker gaining administrative access to one of these systems could compromise any other system with the same local Administrator account password by passing the hash between systems.

Although Microsoft released an update in May 2014 to prevent pass-the-hash attacks, this patch still allowed the hash for the default local Administrator (RID 500) account, as discussed in the following article:

[https://posts.specterops.io/pass-the-hash-is-dead-long-live-localaccounttokenfilterpolicy-506c25a7c167]()

{==OPTION==} Note that it was possible to obtain this password via {==METHOD==} as discussed in section {==XREFLocaAdminPassword==}.
#### Impact: High
An attacker compromising one of these systems could move laterally throughout the network and compromise other systems, which would allow them to take complete control over the network.
#### Likelihood: Medium
Local administrator accounts are a common target for attackers, and there are a number of different tools and techniques available to exploit them. However, in order to do so an attacker would need to gain local administrative rights on one of these systems.
#### Recommendation
If the local Administrator account is not required then consider disabling it. Alternatively, consider implementing the Windows Local Administrator Password Solution (Windows LAPS), which automatically changes the Administrator password to a strong unique password on each system, changes the password every two weeks and stores the passwords in Active Directory. Please see the following article for further information:

[https://learn.microsoft.com/en-us/windows-server/identity/laps/laps-overview]()
