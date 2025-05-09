---
category: "TBA"
cvss: "TBA"
---
### Insufficient Traffic Restrictions
A review of the firewall rules on the tested firewall devices showed that although most of the rules are tied down to a specific source and destination and the rules have specific services, a large number of rules do not have sufficient traffic restrictions. The devices below had potentially unrestricted firewall rules. Please refer to {==XREF Appendix D==} for a list of the identified potentially overly permissive rules.

{==List devices; If all rules can fit in less than 5 pages consider adding them directly to this issue rather than an appendix. If in appendix consider summarising the nature of the violating rules here==}
#### Impact: High
The impact of having firewall rules without restrictions on services, sources and destinations depends purely on the individual rules and the nature of the interfaces that the access control lists are applied to. However, where these types of rules exist, they open up the potential for inappropriate access to systems. {==NOTE FOR TESTER: Discuss potential impact with the client.==}
#### Likelihood: Medium
Many of the identified rules are likely to allow potentially unauthorised traffic through the firewalls.
#### Recommendation
Review the firewall rules and only allow traffic where specifically required. This should be done with a view to always using a specific source, destination and services where possible. Consider implementing a formal periodic review of firewall rules to ensure that rules are up to date and locked down as much as possible.

Additionally, review change management procedures to ensure that temporary rules or project specific rules are removed once they are no longer required.

{==OPTION If Cisco==}For information on how to safely restrict potentially overpermissive rules on Cisco ASA without affecting legitimate traffic, please see the following link:

[https://www.dionach.com/blog/cisco-asa-firewall-hardening/#restrict_permissive_rules]()
