---
category: "{==APP-CNF/NET==}"
cvss: "6.5"
---
### SQL Database Allows Remote Connection
The {==MySQL==} service is remotely available on TCP port {==3306==} on the affected system{s||}. This exposes the version of the database and the operating system in the banner: "{==BANNER==}".
#### Impact: Medium
An attacker can attempt to brute force a valid database login and get access to the database, in order to {==access CMS user passwords or deface the website==}.
#### Likelihood: Low
An attacker will need to exploit a weak database account password.
#### Recommendation
Filter access to TCP port {==3306==} from the Internet. This is best practice and is also a requirement of the PCI Data Security Standards.
