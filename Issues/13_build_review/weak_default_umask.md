---
category: "PRV"
cvss: "3.3"
---
### Weak Default Umask
The Linux system{s||} listed above use{s||} the default umask of 022, which means that all files created by users will be world-readable by default.

This is shown in the example below, where a newly created file has the read permission set for all users on the system:

```
{==EXAMPLE==}
```
#### Impact: Medium
Any files created on the system can be read by any other users, assuming that they have permission to the folder containing these files. This could result in sensitive information or credentials being exposed (see section {==XREFFilesystemPermissions==}) to other users on the system.
#### Likelihood: Low
An attacker would need to have local access to the system in order to exploit this vulnerability.
#### Recommendation
Consider setting a strong umask so that files created by users are only accessible by the user and their group by default. This can be done by setting the following "UMASK" option in /etc/login.defs:

```
UMASK           027
```
