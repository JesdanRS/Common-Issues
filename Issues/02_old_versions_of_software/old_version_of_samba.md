---
category: "UPD"
cvss: "TBC"
---
### Old Version of Samba
The version{s||} of Samba used by the affected host{s||} {are||is} outdated. Samba appears to be running version {==5.1.6==}. {==The latest stable version of Samba is 4.9.11==}.

{==HOSTS==}

The identified version{s||} may be vulnerable to:

 * Buffer overrun in smbd, potentially resulting in remote code execution ({==CVE-2004-0882..==}).
 * Denial of service attacks ({==CVE-2004-0930==}).

Further information relating to the potential security vulnerabilities associated with older versions of Samba can be found on the following page:

[http://www.samba.org/samba/history/security.html]()
#### Impact: Medium
There are a number of vulnerabilities in the versions of Samba identified during the test, which may allow an attacker to compromise the system{s||} or cause a denial of service.
#### Likelihood: Low
A number of exploits for Samba are publicly available and well documented. However in some cases specific configuration options are required for them to be exploitable.
#### Recommendation
Upgrade to the latest supported versions of Samba. Please see the vendor website below for further details:

[https://www.samba.org/samba/download]()
