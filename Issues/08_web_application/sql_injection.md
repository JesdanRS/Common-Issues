---
category: "APP-INJ"
cvss: "10.0"
report_on_external_network_test: true
---
### SQL Injection
A number of web pages on the affected website{s||} are vulnerable to SQL injection, these are listed below. This vulnerability allows an {==anonymous==} attacker to inject malicious code into website parameters, which will then be executed as part of SQL queries on the server-side. This can be exploited to access and read sensitive information stored in the {==SQL Server/Oracle/ MySQL==} database, including {==personal data of website users==}.

{==OPTION==} The website also uses the {=="root" MySQL/"sa" SQL Server login==} to connect to the database. Note that other pages may be vulnerable that are not listed below.

Page
Fields
{==RELATIVEURL==}
{==LISTOFFIELDS==}

{==PROOF OF CONCEPT - Explain why and what payload you used==}
#### Impact: High
An attacker can get access to {==SENSITIVEDATA such as...==}. {==OPTION==} This information can be used for spamming or identity theft.

As the website uses the {=="root" MySQL/"sa" SQL Server==} login to connect to the database an attacker may be able to write script files to the web server and so get access to the operating system.

{==OPTION==} An attacker can update the website content and add malicious JavaScript to attempt to exploit visitors' browsers and compromise their systems.
#### Likelihood: High
SQL injection is a well-known vulnerability and some of the pages that are vulnerable are publicly accessible and straightforward to exploit. A large number of automated tools exist to exploit SQL injection.
#### Recommendation
Review all of the code used by the website and use prepared statements where possible for all SQL calls. If this is not possible, at a minimum ensure that all SQL statements escape single quotes for all strings or use data type casting for all other data types.

{==OPTION==} The website should not use {=="root"/"sa"==} but use a lower privileged user to access the database. This user should only have the minimum privileges required to access the data. {==OPTION==} Consider using separate database logins for the public and private areas with different privileges.

Please see the following OWASP article for more information:

[https://cheatsheetseries.owasp.org/cheatsheets/SQL_Injection_Prevention_Cheat_Sheet.html]()

{==OPTION==} Please see the following URL for code examples of using prepared (parameterised) statements in PHP:

[https://php.net/pdo.prepared-statements]()

{==OPTION==} Please see the following Microsoft article for more information on how prevent SQL injection in Transact SQL:

[https://docs.microsoft.com/en-us/sql/relational-databases/security/sql-injection?view=sql-server-ver15]()