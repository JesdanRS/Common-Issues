---
category: "CNF"
cvss: "4.7"
---
### No SPF Record for Domain
The domain{s below do not have|| "DOMAIN" does not have a} Sender Policy Framework (SPF) DNS record{s||} configured.

{==DOMAINLIST==}

SPF is a simple email validation system designed to detect email spoofing. It allows receiving mail exchangers to check that incoming mail from a domain is being sent from a host authorised by that domain's administrators. The lack of a SPF record allows attackers to spoof emails from the domain.
#### Impact: High
Attackers could spoof emails from the targeted domain{s||}, and potentially use this to target organisation's employees in a social engineering attack. The reputation of the organisation could also be damaged if an attacker sends malicious or inappropriate emails that appear to be from {==CLIENTNAME==}.
#### Likelihood: High
It is relatively straightforward to send a spoofed email, and there are a number of public tools that allow users to automate this process.
#### Recommendation
Consider setting {||a} hard failing SPF record{s||} to prevent attackers from spoofing emails from the targeted domain{s||}. Please note that the receiving mail server must be configured to honour SPF records in order to provide protection against spoofed emails. For further information about SPF please refer to the following link:

[https://en.wikipedia.org/wiki/Sender_Policy_Framework]()
