---
category: "APP-ATH"
cvss: "N/A"
---
### Website Supports Concurrent Sessions
The affected website{s||} allow{s||} multiple simultaneous logins, using the same valid credentials, each being granted a separate session.
#### Impact: Medium
There is little accountability if logins are shared, as audited actions cannot be tied to an individual person. As there is no alerting or prevention of concurrent sessions then users may be unaware if their account has been compromised.
#### Likelihood: Low
An attacker would need to either know or guess valid credentials in order to login to the website{s||}.
#### Recommendation
Institute server side controls to prevent concurrent sessions. For further information, please refer to the following URL:

[https://cheatsheetseries.owasp.org/cheatsheets/Session_Management_Cheat_Sheet.html#simultaneous-session-logons]()

{==OPTION==} For ASP.NET consider use of the property "System.Web.Security.MembershipUser.IsOnline". Further information can be found at the following URL:

[https://learn.microsoft.com/en-gb/dotnet/api/system.web.security.membershipuser.isonline]()

{==OPTION==} If preventing concurrent sessions is not feasible due to business requirements, consider implementing session monitoring to detect unusual patterns, such as multiple concurrent logins from different locations or devices. Ensure that alerts are triggered in the event of unusual patterns being detected and that the user and the security team are notified.