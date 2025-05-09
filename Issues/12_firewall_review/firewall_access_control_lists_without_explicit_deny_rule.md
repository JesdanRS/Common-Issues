---
category: "CNF"
cvss: "N/A"
---
### Firewall Access Control Lists Without Explicit Deny Rule
The following firewall access control lists did not contain an explicit deny rule at the end of the rule sets. Network devices that are capable of performing network filtering will usually drop all network traffic when it does not match any of the configured network filter rules. However, this network traffic is also usually excluded from logging when a network filter rule does not apply, making it harder to identify malicious or misconfigured traffic.

{==List ACLs per device==}
#### Impact: Medium
The lack of logging of traffic that did not match any defined firewall rules could make it difficult to identify network reconnaissance attacks against the network.
#### Likelihood: Low
Any network traffic that does not match any network filter rules will not be logged.
#### Recommendation
Add a final deny rule to all firewall access rule sets which has logging enabled. For information on doing this through both the GUI and CLI, please see the following link:

{==OPTION if Cisco==}[https://www.dionach.com/blog/cisco-asa-firewall-hardening/#deny_all_rule]()
