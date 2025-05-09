---
category: "APP-CNF"
cvss: "N/A"
report_on_external_network_test: true
---
### Web Administration Interface Publicly Available
The administrative login {pages are||page is} publicly available on the affected site{s||} above through the following URL{s||}:

{==URL==}

{==SCREENSHOT==}
#### Impact: Medium
An attacker who manages to obtain valid credentials, for example through social engineering or a brute-force attack, could take administrative control of the website.
#### Likelihood: Low
{==OPTION==} This is the default administrative page for {==SOFTWARE==} {==OR==} This page would be quickly identified. However, an attacker would require valid credentials to be able to proceed further. Another vulnerability, such as weak administrative credentials or a software flaw, would be required to exploit this issue. {==OPTION==} During testing, no weak credentials were found.

{==OPTION==} The website has additional security controls, including CAPTCHA and account lockout, which would reduce the chance of a successful brute-force attack against administrative credentials.
#### Recommendation
Consider restricting access to this service by allowlisting specific, trusted IP addresses that are used for administration of the site.

{==OPTION==} As a minimum, ensure that account lockout is in place as a defence against password guessing attacks and that administrative accounts use strong and complex passwords which are compliant with {==CLIENT==} password policies. {==OPTION IF known not to be in place, XREF to related policies==}

{==OPTION==} Note that having a web administration interface on the same domain as the website can allow any cross-site scripting vulnerabilities in the administered website to be used to target a website administrator and perform actions on the administration interface on their behalf (see section {==XREF==}).
