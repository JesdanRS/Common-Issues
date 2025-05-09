---
category: "CNF"
cvss: "4.6"
---
### Domain Users Permitted to Join Workstations to Domain
During testing, it was possible to join the workstation {==NAME==} to the {==DOMAIN==} domain with the low privileged test user {==ACCOUNT==}, as shown below:

{==SCREENSHOT==}

As a result, an attacker with access to a low privileged domain account can connect their computer to the {==DOMAI==} network and join it to the domain.
#### Impact: Medium
Any user can connect a system to the {==CLIENTNAME==} network and join the {==DOMAIN==} domain. This could be exploited to connect a system, such a personal laptop, to the domain. An attacker would have local admin rights on such a system, and this could be used to aid in further attacks against network resources.
#### Likelihood: Medium
This is the default Active Directory behaviour; however, an attacker would need a domain account in order to exploit this issue.
#### Recommendation
Review the users and groups allowed to join systems to the domain in order to ensure that such privileges are appropriate. The following TechNet article provides further guidance on restricting this policy:

[https://learn.microsoft.com/en-us/archive/technet-wiki/5446.active-directory-how-to-prevent-authenticated-users-from-joining-workstations-to-a-domain]()