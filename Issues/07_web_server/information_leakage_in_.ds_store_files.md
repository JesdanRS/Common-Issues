---
category: "APP-DAT"
cvss: "5.3"
report_on_external_network_test: true
---
### Information Leakage in .DS_Store Files
The affected web server{s||} contain{s||} a number of ".DS_Store" files. These are special files used by the macOS operating system to store custom attributes of its containing folder, such as the position of icons or the choice of a background image. This information reveals a list of files and directories that may exist on the web server which an attacker can then attempt to access, as shown below.

{==URL==}
```
CONTENTS
```
#### Impact: Low
Unnecessary system information is exposed which could reveal sensitive information or aid an attacker in identifying further vulnerabilities.
#### Likelihood: Medium
{These Files||This file} would be quickly identified through automated scanning or manual inspection, although in this specific case, no overly sensitive information was revealed.
#### Recommendation
Remove the ".DS_Store" file{s||} from the web server. Review change control procedures to ensure that inappropriate files are not deployed to production systems. Additionally, consider configuring the web server to block access to files with this name.
