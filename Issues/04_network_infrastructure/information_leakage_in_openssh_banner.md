---
category: "CNF"
cvss: "5.3"
---
### Information Leakage in OpenSSH Banner
The banner of the SSH services available on port 22 of the affected system{s||} shows the distribution and major version of the host operating system:

{==IP==}
```
{==SSH-2.0-OpenSSH_5.9p1 Debian-5ubuntu1==}
```
#### Impact: Low
Unnecessary system information relating to the distribution on the host is exposed.
#### Likelihood: Medium
This information can be easily identified by sending an SSH connection request to the server, and examining the headers of the response.
#### Recommendation
Add the following directives to the "sshd_config" configuration file:

```
DebianBanner no
```
