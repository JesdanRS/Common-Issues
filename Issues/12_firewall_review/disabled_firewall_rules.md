---
category: "TBA"
cvss: "TBA"
---
### Disabled Firewall Rules
A review of the firewall devices identified {==several | a large number of==} disabled firewall rules on the following devices:

{==Add TABLE of devices and rules. If there are lots of rules then give a sample==}
#### Impact: Low
Whilst this does not represent a specific security risk, best practice dictates that disabled rules should be regularly reviewed and removed if they are not required. The presence of disabled rules could introduce misconfigurations.
#### Likelihood: Medium
Many disabled rules where identified. The presence of unused rules and entries makes it more likely that a misconfiguration will occur.
#### Recommendation
Ensure that any disabled rules are regularly reviewed and removed when no longer required. If not already the case, ensure that this is being carried as part of a regular firewall review process. {==OPTION if Cisco==} Please see the following links on how to do this:

[https://www.dionach.com/blog/cisco-asa-firewall-hardening/#unused_rule_sets]()
[https://www.dionach.com/blog/cisco-asa-firewall-hardening/#inactive_rules]()
