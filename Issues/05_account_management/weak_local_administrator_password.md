---
category: "PWD"
cvss: "8.1"
---
### Weak Local Administrator Password
The local account "Administrator" on the affected system{s||} was seen to be using the same password ({==MASKED PASSWORD==}). This password was very weak, and would be quickly guessed by someone with basic knowledge of {==CLIENTNAME==}.
Please note that it is likely that this account is also in use on other systems which were not within the testing scope.
#### Impact: Medium
Anyone guessing this password could quickly take full control of the affected systems. This could allow further compromise depending on the role of the affected system.
#### Likelihood: High
The password for the local "Administrator" account on the affected systems would be quickly guessed by someone with basic knowledge of {==CLIENTNAME==}.
#### Recommendation
Consider disabling the local "Administrator" account if it is not required. Alternatively, implement the Windows Local Administrator Password Solution (Windows LAPS), which automatically changes the Administrator password to a strong unique password on each system, changes the password every two weeks and stores the passwords in Active Directory. Please see the following article for further information:

[https://learn.microsoft.com/en-us/windows-server/identity/laps/laps-overview]()
