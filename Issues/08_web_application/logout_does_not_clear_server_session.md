---
category: "APP-ATH"
cvss: "4"
---
### Logout Does Not Clear Server Session
The logout function{s||} on the affected website{s||} {does|do} not {==clear the user's session on the server/invalidate the user's bearer tokens on the server, in the sense that the tokens remain active==}. {==When a user clicks the "Logout" link, they are redirected to the "logon.aspx" page, and their session cookie is removed==}. However, the session is not ended on the server, meaning that if the session cookie is recreated, the user's session is still active.

{==OPTIONBearers: Change title to -> Logout Does Not Invalidate Bearer Tokens, remove this note==}
#### Impact: Medium
An attacker gaining access to a {==session ID/an API bearer token==} would still be able to continue the user's session, even after the original user had logged out of the website.
#### Likelihood: Low
An attacker would have to gain access to a valid {==session ID/API bearer token==}, either through a man-in-the-middle attack, or by exploiting another vulnerability in the website. {==OPTION==}{==Sessions/Bearer tokens==} on the website expire after 24 hours.
#### Recommendation
Ensure that {==the server-side session is ended/API bearer tokens are invalidated==} when the user logs out.