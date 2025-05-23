---
category: "APP-ATH"
cvss: "6.5"
---
### Passwords Emailed in Clear Text
When a user registers an account on {==URL==}, the website sends them an email containing their password in clear text, as shown below. {==OPTION==} The user is not required to change this generated password after signing in for the first time. {==OPTION==} Although the user is required to change this generated password after signing in for the first time, the website allows the user to use the same generated password as the new password.

{==IMG==}

{==OPTION==} Additionally, when a user resets their password, a new password is emailed to them in clear text, {==OPTION==} which they are not required to change.
#### Impact: High
An attacker gaining access to the user's email would gain access to the user's {==WEBSITE==} account without the user being made aware.
#### Likelihood: Low
An attacker would have to gain access to the user's email to exploit this issue. {==OPTION==} As the passwords are randomly generated by the website, most users would change them.
#### Recommendation
Do not include passwords in emails sent to users, this includes rescue passwords. When a user has forgotten their password and triggers the request to reset it, send a temporary single-use link URL in an email that when followed will give a prompt to enter a new password. If the link is not used within a certain time period, for example 10 minutes, it expires and cannot be used. If unused the original password is unaltered, causing no denial of service or annoyance for the end user if a third party triggers the reset for their account.