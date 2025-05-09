---
category: "PRV"
cvss: "N/A"
---
### Insufficient Privilege Account Separation
Staff member{s listed below||} {were||was} seen to have domain administrator rights on their primary user account{|| named "username"}, which they use for all day-to-day activities, including receiving email and browsing the internet.

{==ACCOUNT_LIST==}
#### Impact: High
If {these||this} account{s are|| is} compromised, {they||it} would immediately lead to a complete compromise of the network. Additionally, if the user{s are|| is} infected by malware, particularly ransomware, this will run with full administrative privileges over the domain, and would potentially affect a large number of systems. Additionally, if a computer is ever left unattended while logged in with {these||this} account{s||}, it would lead to a full compromise of the network.
#### Likelihood: Medium
{These||this} user{s||} could be compromised as part of a targeted attack, such as a spear phishing email, or in an untargeted malware campaign, or an attacker would have to get unattended access to the users' system with a logged in session.
#### Recommendation
Ensure that users, including IT staff, do not have administrative rights on their primary accounts. Instead, require them to "runas" or login with a secondary account when administrative rights are required. Please refer to the following Microsoft guidelines for the implementation of secure administrative hosts:

[https://docs.microsoft.com/en-us/windows-server/identity/ad-ds/plan/security-best-practices/implementing-secure-administrative-hosts]()
