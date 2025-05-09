---
category: "APP-ATH"
cvss: "4.4"
---
### No Logout Functionality
The affected website{s||} {have||has} no logout functionality. As such, users will not be able to end their session, and their session cookies will stay active until they expire.
#### Impact: Medium
A missing logout functionality can prevent users from logging out of the application{s||}, which could allow an attacker to compromise the user's active session.
#### Likelihood: Low
An attacker would only be able to exploit this issue by gaining physical access to a user's machine, for example if it has been left unattended. {==OPTION short session expiry==} Additionally, there is a limited time in which the session cookies would remain valid. {==OPTION long session expiry==} Note that sessions were seen to remain valid for a long period of time, increasing the likelihood of this attack (see section {==XREF==}).
#### Recommendation
Add a logout functionality to the web application{s||} which expires and invalidates users' session cookies. Sessions should be invalidated on the server-side so that they do not remain valid if recreated. The following page from OWASP provides further information:

[https://cheatsheetseries.owasp.org/cheatsheets/Session_Management_Cheat_Sheet.html#logout-button]()
