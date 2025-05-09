---
category: "APP-CNF"
cvss: "TBC"
---
### Development and Test Sites Publicly Accessible
{A number of development and test websites||A development and test website} for {==CLIENTNAME==} {were||was} found to be publicly accessible via the following URL{s||}:

{==XREF_URLs==}
#### Impact: Medium
Exploitable vulnerabilities may be present in code that is under development which could lead to a compromise of the website, and potentially any other websites on the system.{==OPTION==} As the website was seen to be using live data, this could lead to the exposure of potentially sensitive {==commercial==} information.
#### Likelihood: Low
In some cases, development servers are sought after by attackers seeking application vulnerabilities as they are typically less thoroughly hardened and less rigorously tested for security vulnerabilities than live environments.
#### Recommendation
Consider restricting access to{|| the} development website{s||} to trusted sources, for example by applying IP address restrictions and authentication mechanisms.
