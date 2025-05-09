---
category: "APP-CNF"
cvss: "5.3"
report_on_external_network_test: true
---
### Robots File Exposes Disallowed Folders
The robots.txt file{s||} for the affected website{s||} {are||is} used to specify which files a search engine robot should or should not index. The robots.txt file{s||} contents are shown below.

https://{==site==}/robots.txt
```
{==CONTENTS==}
```

{==OPTION==} Note that this file appears to be the default robots.txt file for {==DRUPAL==}
#### Impact: Low
This information can be useful to an attacker who can see if these files or folders exist and find if any vulnerable files or sensitive information resides in these files or folders.
#### Likelihood: Medium
Examining robots.txt files is a common information gathering technique used by attackers, and many automated tools will detect this file.
#### Recommendation
Perform a risk assessment to determine whether these paths are required to be in the robots.txt file, and whether the risk associated with listing them there is acceptable. The "ROBOTS" meta tag can be used on sensitive pages to prevent them from being indexed, and to avoid including them in the robots.txt file. See the following page for more information:

[https://www.robotstxt.org/meta.html]()
