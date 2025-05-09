---
category: "CNF"
cvss: "N/A"
---
### Potentially Unnecessary Software Packages Installed
A number of potentially unnecessary software packages were installed on the {==Linux laptop==}, listed below:

 * {==LIST==}

{==OPTION==} Additionally, configuration files for a large number of default packages were seen to be present on the system; although the packages themselves had been removed.
#### Impact: Medium
Unnecessary software packages increase the attack surface of the system, and also provide the user with more tools which could potentially be used to carry out further attacks against other systems.
#### Likelihood: Low
An attacker would need to exploit a vulnerability in one of these packages, or to find a way to utilise these packages in attacks against other systems.
#### Recommendation
Carry out a manual review of all installed packages and remove any that are not strictly required. Ensure that packages are fully removed using the {=="purge" command in apt==}, which will also remove any associated configuration files. Where additional software is added to the system image, its dependencies should also be reviewed, with the objective of keeping the system image as minimal as possible.
