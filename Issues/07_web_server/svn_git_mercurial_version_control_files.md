---
category: "APP-CNF"
cvss: "5.3"
report_on_external_network_test: true
---
### SVN/Git/Mercurial Version Control Files
{==SVN==} version control system files disclose system information such as usernames, file names and directories. As well as the files found below, there may be files in other folders. {==Each of the directories listed also have SVN files in all subdirectories.==}

{==LIST==}

```
{==EXAMPLE==}
```
#### Impact: Low
Information is exposed that is useful to an attacker. Files and folders can be browsed using the {==SVN==} files to look for configuration files or pages that may not have sufficient access control.
#### Likelihood: Medium
These files are straightforward to find manually or using a web site scanning tool.
#### Recommendation
Remove the {==SVN==} files from the production website.