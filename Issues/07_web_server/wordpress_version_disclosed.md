---
category: "APP-CNF"
cvss: "5.3"
report_on_external_network_test: true
---
### WordPress Version Disclosed
{==OPTION==} The website shows the exact version of WordPress in use (version {==VERSIONNUM==}) in the readme file:

http://SITE/readme.html
{==SCREENSHOT==}

{==OPTION==} The version is also disclosed in the XML source of the RSS feeds:

http://SITE/feed/
```
<generator>http://wordpress.org/?v={==VERSIONNUM==}</generator>
```
#### Impact: Low
The version information can be useful to an attacker when searching for vulnerabilities. Unnecessary system information is exposed.
#### Likelihood: Medium
{==OPTION==} The readme file is straightforward to find and is part of the default installation of WordPress. {==OPTION==} The "generator" tag can be found by looking at the XML source of the RSS feed.
#### Recommendation
{==OPTION==} Remove the "readme.html" file from the website.

{==OPTION==} Consider using a plugin which removes version metadata from the site. An example plugin is described at the following URL:

[https://wordpress.org/plugins/meta-generator-and-version-info-remover]()
