---
category: "UPD"
cvss: "TBC"
---
### Missing Windows Security Updates
The sampled {==servers/workstations==} listed above were seen to be missing a number of Windows Updates. Of the identified missing updates, the oldest observed was from {==2014==} and a number of these updates related to vulnerabilities that could potentially allow {==remote code execution==}, as shown {==below:/in appendix X.==}

{==MISSING_UPDATES==}

{==OPTION==} Please note that a number of updates such as {==MS15-011==} and {==MS15-124==} are installed, but require configuration changes to be effectively applied, please see the relevant Microsoft advisories for more information.
#### Impact: High
Windows systems within the network are affected by a number of vulnerabilities that have been addressed by missing Windows updates. {==The most serious of the vulnerabilities identified could allow complete compromise of affected systems and potentially lead to the compromise of the Active Directory domain.==}
#### Likelihood: Medium
This issue was found on {==all==} sampled systems, and some of the identified vulnerabilities are easily exploitable. Automated tools are available that will scan a network for easily exploitable Windows vulnerabilities in order to compromise a large number of hosts in short order.
#### Recommendation
Ensure that central patch management is configured for Windows systems, that it covers all hosts, and that the identified updates are applied promptly. Consider also using a vulnerability scanning or endpoint management tool to check for missing security updates.
