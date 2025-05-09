---
category: "APP-CNF"
cvss: "N/A"
---
### Administration Functionality Insufficiently Isolated
The administration functionality available at the following URL{s are|| is} insufficiently isolated from the main website, in the sense that it is currently hosted on the same host as the main website. This is shown below:

Main website:
{==URL==}
{==SCREENSHOT==}

Administration panel:
{==URL==}
{==SCREENSHOT==}
#### Impact: Medium
Web vulnerabilities that can lead to client-side attacks, such as reflected cross-site scripting {==XREF_XSS_If_Target_admins==}, and that affect the main website{s||}, could also affect the administration system and aid attackers in targeting privileged users.
#### Likelihood: Low
An attacker would need to exploit an existing security flaw in the main website{s||} to attack the administration functionality{==OPTIONInterfacePubliclyAvailable/MultiFactorAuth==} in this manner. {==OPTION==} During testing no cross-site scripting flaws that could affect the administration functionality were identified.
#### Recommendation
Consider separating the administration from the front-end functionality, ideally using separate domains.

{==OPTION==}Consider restricting access to this functionality, so that only internal or trusted IP addresses are permitted (see section {==XREF_InterfacePubliclyAvailable==}).
