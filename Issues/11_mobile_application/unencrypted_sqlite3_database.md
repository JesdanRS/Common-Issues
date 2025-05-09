---
category: "MOB-CRP"
cvss: "3.8"
---
### Unencrypted SQLite3 Database
The {==iOS/Android==} mobile application was found to store information in the local device file system in {a||multiple} SQLite3 database{s||},{==DBname==}, which {was||were} found to be unencrypted. This can be seen in the following screenshot, where information is available in clear text.

{==path\to\the\database==}
{==Screenshot==}
#### Impact: High
An attacker obtaining access to {an unencrypted database||unencrypted databases} could access sensitive information, such as {==user IDs and access tokens==}.
#### Likelihood: Low
Although retrieving sensitive information from a SQLite3 database is straightforward, an attacker would first need to obtain access to the database file by gaining physical access to a {==rooted/jailbroken==} device.
#### Recommendation
Encrypt this and any other SQLite3 databases that contain sensitive information.
One available solution is SQLCipher, which provides encryption for database files. More information can be found at the following link:

[https://www.zetetic.net/sqlcipher/open-source]()
