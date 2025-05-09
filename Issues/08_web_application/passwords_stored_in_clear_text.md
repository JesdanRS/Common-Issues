---
category: "APP-ATH"
cvss: "6.0"
---
### Passwords Stored in Clear Text
User passwords are stored in clear text in the {==SQL Server==} database in the table {==TABLENAME==} on the affected system above.
#### Impact: High
An attacker getting access to these, for example through SQL injection (see section {==XREF==}), will be able to login as these users. The users may also use these passwords for other systems.
#### Likelihood: Low
An attacker will only be able to access these through exploiting another weakness in the system.
#### Recommendation
Store salted hashes of passwords in the database using a tried and tested hashing algorithm such as bcrypt, scrypt or PBKDF2. The salt should be unique for each user.