---
category: "APP-ATH"
cvss: "3.7"
---
### No Account Verification Mechanism
The website does not have an account verification mechanism. It is therefore possible for malicious users to register a large number of unverified accounts by using the registration form at the URL below:

{==URL==}

{==OPTION==} Please note that this form is protected by a CAPTCHA mechanism to prevent automated submissions (see section {==XREF==}), making it difficult to automatically register a large number of accounts.
#### Impact: Medium
A malicious user could register a large number of accounts that could fill up the database and make it difficult to manage and administer the application, or cause a denial of service.
#### Likelihood: Low
{==OPTION==} This issue is difficult to exploit due the CAPTCHA protection. An attacker would need to be motivated to target {==CLIENTNAME==} in this manner.
#### Recommendation
Consider adding an account verification mechanism to validate users' identities before creating an account on the website. When a user registers using their email address on the website, they should be sent a link containing a randomly generated token which is only valid for a fixed period of time, say 4 hours. The users should then be required to follow this link before being able to use their account on the website.

{==OPTION==} Additionally, consider using an effective CAPTCHA mechanism, as discussed in section {==XREF==}.
