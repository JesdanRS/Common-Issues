---
category: "UPD"
cvss: "TBC"
---
### Old Version of Dropbear SSH Service
The version of Dropbear SSH service on port 22 of the affected server{s listed above||above} may be outdated. The service banner reports the version of Dropbear in use to be {==2014.66==}, whilst the current stable version is {==2019.78==}.

The specific version observed during the test may be vulnerable to {==remote code execution, privilege escalation, buffer overflow and remote memory disclosure==} vulnerabilities, examples of which are listed below:

 * Execution of arbitrary code ({==CVE-2016-7406, CVE-2016-7407..==})
 * Remote memory disclosure ({==CVE-2016-7409==})
 * Remote privilege escalation ({==CVE-2004-2486==})
 * Buffer overflow ({==CVE-2005-4178==})

Further information relating to the potential security vulnerabilities associated with older versions of Dropbear SSH can be found at the following link:

[https://matt.ucc.asn.au/dropbear/CHANGES]()
#### Impact: High
An attacker could potentially exploit this vulnerability to gain access to the server{s||} or to perform a denial of service attack on the server{s||}.
#### Likelihood: Low
While a large number of vulnerabilities exist, many of them require authenticated access or specific configurations to be exploitable.
#### Recommendation
Update to the latest stable and secure version of Dropbear SSH, available at the following URL:

[https://matt.ucc.asn.au/dropbear]()