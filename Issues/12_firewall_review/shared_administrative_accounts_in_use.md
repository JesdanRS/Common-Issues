---
category: "TBA"
cvss: "TBA"
---
### Shared Administrative Accounts in Use
A review of the configuration of the following firewall{s||} revealed that shared administrative accounts ared used to manage the device{s||}.

{==Table listing devices and usernames that indicate shared nature==}
#### Impact: Medium
The use of shared accounts means that accountability for any actions performed by that account is lost; making attributing malicious activity to specific individuals difficult. In addition, use of shared accounts increases the likelihood of passwords being exposed unnecessarily.
#### Likelihood: Medium
The password for the administrative account{==s==} {==is || are==} known to a small number of trusted users. It is possible that {==it is || they are==} also known outside of that group, particularly if the password{==s==} {==is || are==} reused across other accounts and systems, or if the password{==s==} {==was || were==} not updated when former staff members with access left the organisation.
#### Recommendation
Avoid the use of shared accounts, instead utilising uniquely identifiable named accounts. Additionally, consider using Active Directory authentication or a central authentication server wherever possible, which would allow accounts to be centrally managed. {==OPTION if Cisco==} For information on how to configure central authentication, authorisation and accounting on Cisco ASA, please see the following link:

[https://www.dionach.com/blog/cisco-asa-firewall-hardening/#central_aaa]()
