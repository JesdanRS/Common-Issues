---
category: "UPD"
cvss: "TBC"
---
### Potentially Old Software
The affected system{s||} appear{s||} to be running a number of old versions of software, which are shown below.

| Software | Version in Use | Latest {==Distribution==} Package Version |
| | | |

{==OPTION==} The revealed version information {==and the HTTP headers==} suggest{==s==} that the server above is running {==CentOS 6==}. If the software listed above has been installed using a package manager, then backported security patches may also be installed, and as such, this issue may be a false positive.
#### Impact: Medium
An attacker may be able to exploit any vulnerabilities in old versions of the above software to compromise the system. Old versions of software will not receive security updates to mitigate against newly discovered vulnerabilities.
#### Likelihood: Low
While a number of vulnerabilities exist for these software versions, they require specific configurations to be exploitable, or are complex to exploit. As previously mentioned, it is likely that the running versions have security patches applied.
#### Recommendation
Check the installed package versions and ensure that they match the latest available version. {==OPTION==} On CentOS, the installed package version can be checked as follows:

```
$ rpm -q <package name>
```

{==OPTION==} On Debian, the installed package version can be checked as follows:

```
$ apt-cache policy <package name>
```

Ensure that procedures are in place so that software is updated in a timely manner when new versions become available.
