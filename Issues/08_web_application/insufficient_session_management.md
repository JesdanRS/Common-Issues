---
category: "APP-ATH"
cvss: "TBC"
---
### Insufficient Session Management
The affected website{s||} {are|is} vulnerable to session related vulnerabilities. As a result, an attacker could potentially gain access to logged in sessions, leading to a compromise of user accounts. The following configuration{==s==} leaves the website{s||} vulnerable session related attacks:

{==URL:==}
* {==Login Uses Existing Session==}
* {==Logout Does Not Clear Server Session==}
* {==Session ID in Website URLs==}
* {==Website Supports Concurrent Sessions==}
* {==No Session Termination Functionality==}

{== NOTE: Bold and underline the configuration heading in the following to make it into subsections for each configuration ==}

{==Login Uses Existing Session==}
**Login Uses Existing Session**
As the website does not create a new session identifier upon user login, the website is vulnerable to session fixation. If an attacker can obtain or pre-set the session cookie on the victim's browser before the victim logs in, then the attacker can use this to get a logged in session.

{==Logout Does Not Clear Server Session==}
**Logout Does Not Clear Server Session**
The logout functionality on the website does not clear the user's session on the server. {== When a user clicks the "Logout" link, they are redirected to the "logon.aspx" page, and their session cookie is removed.==} However, the session is not ended on the server, meaning that if the session cookie is recreated, the user's session is still active.

{==Session ID in Website URLs==}
**Session ID in Website URL{==s==}**
The website{s||} include{||s} the session ID {==in some URLs, as shown below:==}
{==http://url?sessionid=FIXME==}
{==SCREENSHOT==}

{==Website Supports Concurrent Sessions==}
**Website Supports Concurrent Sessions**
The website{s||} allow{||s} multiple simultaneous logins, using the same valid credentials, each being granted a separate session.

{==No Session Termination Functionality==}
**No Session Termination Functionality**
The website does not display a list of active logged in sessions in the {=="My Profile"==} or similar web pages. The ability to terminate active sessions were not provided to users. This means that victims who have had their accounts compromised will not have the ability to force attackers to log out from their accounts.
#### Impact: Medium
{==Login Uses Existing Session==} If an attacker can hijack a user's session, the attacker will be logged in as the user and so can access confidential or personal information.

{==Logout Does Not Clear Server Session==} An attacker gaining access to a session ID would still be able to continue the user's session, even after the original user had logged out of the website.

{==Session ID in Website URLs==} A local attacker may be able to view {these||this} URL{s||}, for example, if {they are||it is} saved in a browser's history. This will give the attacker access to confidential information depending on the role of the victim.

{==Website Supports Concurrent Sessions==} There is little accountability if logins are shared, as audited actions cannot be tied to an individual person. As there is no alerting or prevention of concurrent sessions then users may be unaware if their account has been compromised.

{==No Session Termination Functionality==} Attackers would remain logged into a compromised victim account even if the victim is aware and have changed the account password.

{==GenericOrMultiple==} An attacker could leverage these vulnerabilities to compromise valid user accounts. This will affect the confidentiality of data stored within the website in the case of a privileged account was compromised.
#### Likelihood: Low
{==Login Uses Existing Session==} An attacker will generally need to have access to the PC that the victim is using to set the cookie and then take a copy of it, prior to the victim using the website.

{==Logout Does Not Clear Server Session==} An attacker would have to gain access to a valid session ID, either through a man-in-the-middle attack, or by exploiting another vulnerability in the website.

{==Session ID in Website URLs==} An attacker will need to gain local access to the victim's computer, access to a server or access to a proxy server that may have recorded the URL{s||}, or they could intercept traffic as it crosses a shared network.

{==Website Supports Concurrent Sessions==} Valid credentials would be required to generate a valid session.

{==No Session Termination Functionality==} An attacker would first need to compromise a valid user account.

{==GenericOrMultiple==} An attacker would have to either gain access to a valid session by exploiting other vulnerabilities of the website or obtain credentials of victim's user accounts. {==IfPhysicalOrSameNetworkAccessRequried==} Additionally, an attacker would need physical access to a victim's PC or perform man-in-the-middle attacks to exploit these configurations.
#### Recommendation
{==Login Uses Existing Session==} Create a new session when a user logs in. This can be done by abandoning the anonymous session and then creating a new one. The following article gives more information:
{==PHP==} https://php.net/manual/en/function.session-regenerate-id.php
{==ASPNet==} https://docs.microsoft.com/en-gb/dotnet/api/system.web.sessionstate.httpsessionstate.abandon

{==Logout Does Not Clear Server Session==} Ensure that the server-side session is ended when the user logs out.

{==Session ID in Website URLs==} Do not include session IDs in URLs; it should be stored only in a cookie which is marked both "Secure" and "HttpOnly".

{==Website Supports Concurrent Sessions==} Institute server side controls to prevent concurrent sessions. There are a number of mechanisms which can be used. {==OPTION==} For ASP.NET consider use of the property "System.Web.Security.MembershipUser.IsOnline". Further information can be found at the following URL:
https://docs.microsoft.com/en-gb/dotnet/api/system.web.security.membershipuser.isonline
{==Others==} Institute server-side controls to prevent concurrent sessions. A counter should be created and assigned to a specific session whenever a user logs in. This should be stored on the server side such as databases rather than client side. When a user logs in, server-side scripts should then be used to check if the user has previously logged in via the counter and invalidate any previously created sessions.

{==No Session Termination Functionality==} Provide a list of active sessions in the "My Profile" or similar web pages for each user. This should allow users to terminate active sessions. Alternatively, provide users with the ability to terminate active sessions upon a successful account password change.

Please refer to the following OWASP article for further information on session management:

[https://cheatsheetseries.owasp.org/cheatsheets/Session_Management_Cheat_Sheet.html]()
