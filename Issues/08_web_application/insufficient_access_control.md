---
category: "APP-ACC"
cvss: "TODO"
---
### Insufficient Access Control
The affected web application{s do|| does} not implement adequate access control to protect the confidentiality and integrity of data. This could allow attackers to access functionality or data that they are not authorised to access.

{==Detail the vulnerability and PoC, such as, anonymous access, access/modify other users data, performing restricted actions, privilege escalation==}
#### Impact: High
{==Impact should be custom and specific to the vulnerability==}
#### Likelihood: High
Access control vulnerabilities are well-known web application flaws and are regularly abused by attackers. {==Remainder of likelihood should be custom and specific to the vulnerability==}
#### Recommendation
Review the current access control mechanisms and ensure that users can only access or modify appropriate resources and only perform authorised actions. Access controls should be enforced using server-side code rather than client-side code.

The following Open Web Application Security Project (OWASP) article provides further information regarding considerations when implementing secure access control:

[https://cheatsheetseries.owasp.org/cheatsheets/Authorization_Cheat_Sheet.html]()
