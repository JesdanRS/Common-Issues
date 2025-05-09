---
category: "PRV"
cvss: "N/A"
---
### Potentially Unnecessary Local Administrator Accounts
A number of users were seen to be part of the local administrator group on a large number of workstations and servers.

{==TABLE_OF_LOCAL_ADMINISTRATORS==}
#### Impact: High
An attacker compromising any accounts which are part of the local administrator group would quickly be able to escalate their privileges and potentially compromise the entire {==DOMAIN==} domain.
#### Likelihood: Low
Users were seen to be part of the local administrative group increasing the likelihood of any of these accounts becoming compromised through misconfigurations such as weak passwords.
#### Recommendation
Review the local administrator group and verify whether the users are required. This should be coupled with policies and procedures to regularly audit these groups to ensure that those within them actual require administrative permissions.
