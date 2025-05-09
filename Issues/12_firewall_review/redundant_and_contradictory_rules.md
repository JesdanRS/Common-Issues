---
category: "TBA"
cvss: "TBA"
---
### Redundant and Contradictory Rules
Inspection of the firewall rules configured on the devices revealed the presence of several redundant rules which in some instances contradict subsequent rules. This can be seen in the following examples:

{==List each set of conflicting rules in its own table, grouped per firewall device==}

| ACL | Src Address | Src Port | Dst Address | Dst Port |
| rule | | | | |
| The above rules are redundant because of the following rule |
| rule | | | | |
#### Impact: Medium
Contradicting firewall rules could result in unauthorised traffic being allowed in or out of the network. Additionally, redundant rules can increase administrative overhead, and reduce device performance. These could also increase the likelihood of misconfiguration, which could impact the security of the network.
#### Likelihood: Medium
Many redundant and conflicting rules were identified. These rules could potentially allow unauthorised traffic through the firewall.
#### Recommendation
Review firewall rules and remove contradicting and redundant rules. Consider implementing a formal periodic review of firewall rules to ensure that rules are up to date and locked down as much as possible.

Additionally, review change management procedures to ensure that temporary rules or project specific rules are removed once they are no longer required.
