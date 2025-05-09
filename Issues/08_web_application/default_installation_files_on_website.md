---
category: "APP-CNF"
cvss: "5.3"
report_on_external_network_test: true
---
### Default Installation Files on Website
Software installation support files are present on the affected website{s||} listed above.

Examples include the following files

 * {==URL/site/INSTALL.mysql.txt==}
 * {==URL/site/INSTALL.pgsql.txt==}
 * {==URL/site/INSTALL.sqlite.txt==}
 * {==URL/site/INSTALL.txt==}
 * {==URL/site/LICENSE.txt==}
 * {==URL/site/UPGRADE.txt ==}
 * {==URL/site/COPYRIGHT.txt==}
 * {==URL/site/sites/README.txt==}
 * {==URL/site/scripts/test.script==}

{==OPTION==} The release notes on the website{s||} indicate that the version of {==Drupal==} in use is "{==7.26==}", as shown below:

{==URL/site/CHANGELOG.txt==}
#### Impact: Low
These files indicate that the website{s||} {have||has} not been adequately hardened, and reveal information that could be of use for further attacks.
#### Likelihood: Medium
These files will be quickly identified through automated scanning or manual inspection.
#### Recommendation
Remove these files, and review change management processes to ensure that inappropriate and default content is not put or kept on production systems.