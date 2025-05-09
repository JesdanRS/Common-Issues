---
category: "CNF"
cvss: "8.7"
---
### Group Policy Preferences Expose Administrator Passwords
Group Policy is used to set the password for local accounts on a number of systems within the network. The passwords for these accounts are stored using a static encryption key in readable files on the domain controllers. The encryption key is publicly available and as such it is trivial to obtain the clear text passwords.

{==UNCPATH==}
```
Username:
Password:
```
#### Impact: High
An attacker gaining access to these passwords would quickly be able to compromise a large number of internal systems and potentially compromise the entire domain.
#### Likelihood: High
This vulnerability is well known, and a number of publicly available tools exist that can automatically search for and decrypt the passwords.
#### Recommendation
Avoid setting local administrator passwords through Group Policy preferences. Alternatively, consider implementing the Windows Local Administrator Password Solution (Windows LAPS), which automatically changes the Administrator password to a strong unique password on each system, changes the password every two weeks and stores the passwords in Active Directory. Please see the following article for further information:

[https://learn.microsoft.com/en-us/windows-server/identity/laps/laps-overview]()
