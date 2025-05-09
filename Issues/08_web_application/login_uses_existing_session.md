---
category: "APP-ATH"
cvss: "4"
---
### Login Uses Existing Session
When a user logs in to the affected website{s||} a new session identifier is not created. This means the application is vulnerable to session fixation. If an attacker can obtain or preset the session cookie on the victim's browser before the victim logs in then the attacker can use this to get a logged in session.
#### Impact: Medium
If an attacker can hijack a user's session, the attacker will be logged in as the user and so can access{== or modify==} confidential or personal information.
#### Likelihood: Low
An attacker will generally need to have access to the PC that the victim is using to set the cookie and then take a copy of it, prior to the victim using the website.
#### Recommendation
Create a new session when a user logs in. This can be done by abandoning the anonymous session and then creating a new one. The following article gives more information:

{==PHP==} [https://php.net/manual/en/function.session-regenerate-id.php]()
{==ASPNet==} [https://docs.microsoft.com/en-gb/dotnet/api/system.web.sessionstate.httpsessionstate.abandon]()
