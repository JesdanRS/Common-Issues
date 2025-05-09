---
category: "UPD"
cvss: "{==TBC==}"
report_on_external_network_test: true
---
### Old Versions of WordPress and Plugins
The affected website{s||} listed above {were||was} found to be running outdated versions of WordPress Core and plugins.

The WordPress version installed is {==5.6.2==} (see section {==XREF_WORDPRESS_VERSION_DISCLOSURE==}), while the latest version is {==6.4.2==}.

{=OPTION WordPress version CVEs==}
This version of WordPress has been associated with a number of known exploits which can lead to {==explain the public exploits==}.

In addition, the following WordPress plugins were seen to be outdated {==OPTION Plugins CVEs==}and found to have several vulnerabilities:
{==Create table==}
{==Plugin | Installed Version | Latest Version | CVE(s)==}

The vulnerabilities affecting these plugins relate to {==CHANGEME SQL injection and cross-site scripting==} flaws, which may allow an attacker to {==CHANGEME retrieve the content of the database or execute client site attacks against users and administrators==}. More information can be found at the following URLs:
{==CVE URLs==}
#### Impact: High
An attacker could potentially exploit these vulnerabilities to {==CHANGEME dump the website's database or carry out client-side attacks against website users, leading to reputational damage and financial losses UPDATE IMPACT LEVEL APPROPRIATELY==}. The use of old versions of software and plugins could also result in vulnerabilities being exploited which would be mitigated in newer versions.
#### Likelihood: Medium
WordPress is a popular target for attackers and new vulnerabilities are frequently identified in old software over time.{== Although the vulnerabilities for both WordPress and its plugins are documented, they require certain configurations to be present in order to be exploited.==}
#### Recommendation
Update to the latest secure version of WordPress Core. A process should be in place to regularly review and update installed plugins. Consider configuring plugins to automatically update. Please refer to the following URL for further information on how to update an existing WordPress installation:

[https://wordpress.org/support/article/updating-wordpress]()
