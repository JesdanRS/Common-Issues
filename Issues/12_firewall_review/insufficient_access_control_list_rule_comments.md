---
category: "PRC"
cvss: "N/A"
---
### Insufficient Access Control List Rule Comments
{== OPTION Object descriptions and filter rules comments in the configuration files for the reviewed firewalls revealed that a large number of entries did not have any comments.==}
{== OPTION Object descriptions and filter rules comments in the configuration files for the reviewed firewalls revealed that a number of firewall rules exist with insufficient comments, in the sense that these do not explain the purpose of the rule.==}
#### Impact: Low
Without clear comments, technical staff may have difficulty in understanding certain rules, configurations and settings; especially if they are new to the organisation. This could also make it difficult to determine if firewall rules are still required or not. Additionally, as time progresses, it will not be clear what firewall rules are used for and whether these are still required. This makes the configuration more prone to errors.
#### Likelihood: Medium
{==Several|A large number of==} rules without comments were identified. It is likely that a staff member who encounters issues when reading the configuration file will seek advice and guidance from a colleague, however this may not always be possible, for example staff members that created the rules may no longer work for the organisation.
#### Recommendation
Add a clear description to every rule that shows ownership, date and purpose of the rule, or a ticket reference which will help staff when reading the configuration file. For more information, please see the following link:

[https://www.dionach.com/blog/cisco-asa-firewall-hardening/#add_comments]()
