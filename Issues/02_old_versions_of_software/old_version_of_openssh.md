---
category: "UPD"
cvss: "TBC"
---
### Old Version of OpenSSH
The affected system{s appear|| above appears} to be running {outdated versions||an outdated version} of OpenSSH. The latest stable version of OpenSSH is {==VERSION==}.

{==HOSTS==}

The version number{s||} can be obtained from the OpenSSH banner{s||}, as shown below:

```
$ nc {==HOST==} 22

{==VERSION BANNER==}
```

The running version{s||} of OpenSSH {are||is} affected by a number of vulnerabilities, including:

 * {==Information leakage==}
 * {==Denial of service attacks==}

Further information relating to the security vulnerabilities in older versions of OpenSSH can be found at the following link:

[https://www.openssh.com/security.html]()

{==OPTION==} Please note that this version information was obtained from a service banner, and as such this issue may be a false positive if backported security patches have been applied.
#### Impact: High
An anonymous attacker could {==potentially exploit these vulnerabilities to gain unauthorised access, extract sensitive information, or perform a denial of service attack on the server==}. Additionally, the use of old versions of software could introduce vulnerabilities that are mitigated in newer versions.
#### Likelihood: Low
While a large number of vulnerabilities exist, many of them require authenticated access or specific configurations to be exploitable.
#### Recommendation
If the running OpenSSH service is packaged as part of an operating system distribution, verify that the distribution is still being maintained, and use the distribution's package manager to verify that there are no outstanding security updates.

{==OPTION==} The following command checks for updates on the {==IDENTIFIED_DISTRO==} distribution:

Otherwise, manually upgrade to the latest version of OpenSSH. Please see [https://www.openssh.com]() for more information.
