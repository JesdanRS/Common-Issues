---
category: "CNF"
cvss: "5.3"
---
### SMTP Banner Shows Version
The  affected SMTP server{s||} show{s||} the version of {==SOFTWARE NAME==} installed, as shown below.

{==IP ADDRESS==}
{==BANNER==}
#### Impact: Low
The version information can be useful information to an attacker when searching for vulnerabilities. Unnecessary system information is exposed.
#### Likelihood: Medium
This information is presented in the welcome banner headers so a simple scan or banner grab would obtain this information.
#### Recommendation
Specify a custom welcome banner that does not include version information.

{==OPTION GENERIC==} Consult the {==SOFTWARE NAME==} documentation for information on how to modify the SMTP banner returned by the server.

{==OPTION EXIM==} Edit the "smtp_banner" parameter in the "exim.conf" configuration file.

{==OPTION MailMarshall==} See the following URL for details on how to alter the banner in MailMarshall:

[https://www3.trustwave.com/support/kb/article.aspx?id=10436]()

{==OPTION IF MICROSOFT==} See the following article for more information.

[https://docs.microsoft.com/en-gb/powershell/module/exchange/set-receiveconnector]()