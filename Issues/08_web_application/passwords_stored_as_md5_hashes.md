---
category: "APP-ATH"
cvss: "6.0"
---
### Passwords Stored as MD5 Hashes
The web application at {==URL==} stores passwords as hashes using the MD5 algorithm. Storing passwords as MD5 hashes is far better than clear text or using a reversible encryption algorithm; however over time MD5 has become more vulnerable to brute force attacks through increased processing speed and the use of rainbow tables.
#### Impact: Medium
An attacker that has access to the MD5 hashes can use a tool such as John the Ripper or Hashcat, or can use online tools to crack hashes. The resulting clear text passwords can then be used to login to the application, or to any other systems on which the same credentials are used.
#### Likelihood: Low
An attacker will need to get access to the password hashes first, for example through {==SQL injection==} (see section {==XREFSqlInjection==}).
#### Recommendation
Store password hashes using algorithms such as bcrypt, scrypt or PBKDF2, which use unique salts for each user and are designed to be resistant to brute-force attacks.

{==OPTION PHP==} The following article contains guidance on upgrading stored MD5 hashes to Bcrypt:

[https://www.michalspacek.com/upgrading-existing-password-hashes]()
