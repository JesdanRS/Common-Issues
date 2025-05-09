---
category: "ATH"
cvss: "5.4"
---
### Insufficient Session Restrictions
The Azure Portal allows multiple simultaneous logins, using the same valid credentials, each being granted a separate session.

Additionally, user sessions remain valid after a long period of inactivity (over {==XREF 18==} hours), as shown in the screenshot below:

{==XREF_SCREENSHOT==}
#### Impact: Medium
If an attacker is able to hijack a user's session, either through performing a man in the middle (MitM) attack or by gaining access to their workstation, they will gain access to the Azure resources and information the user has access to and potentially gain control of the Azure environment.
#### Likelihood: Low
An attacker would need to hijack or otherwise gain access to a valid session. The long session expiry time would increase the window in which this could be performed.
#### Recommendation
If possible, restrict concurrent sessions on the portal, and reduce the time before the session expires due to inactivity. As Microsoft does not appear to currently provide this functionality, consider raising a support case with them. In the interim, conduct a risk assessment for this issue to identify whether any other technical or procedural controls can be implemented to mitigate the issue. Otherwise, ensure that staff manually sign out of the Azure portal to terminate their sessions when they are no longer required.
