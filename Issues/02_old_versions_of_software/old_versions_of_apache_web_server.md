---
category: "UPD"
cvss: "TBC"
---
### Old Versions of Apache Web Server
The affected system{s||} may be running outdated version{s||} of the Apache web server:

Host
Current Apache Version
Latest Apache Version
{==IPorURL==}
{==2.0.48==}
{==2.4.10/2.2.==}29

The specific version{s||} observed during the test may be vulnerable to:

{==
 * Denial of service attacks including blocking new connections and crashing the process.
 * Buffer overflow attacks, allowing execution of arbitrary code.
==}

Further information relating to the potential security vulnerabilities associated with older versions of Apache can be found on the following page:

{==OPTION 2.2==} [https://httpd.apache.org/security/vulnerabilities_22.html]()
{==OPTION 2.4==} [https://httpd.apache.org/security/vulnerabilities_24.html]()

Note that Dionach did not attempt to exploit these vulnerabilities as most of the available exploits can results in a denial of service.

{==OPTION==} Please note that the web server{s||} may have backported patches, and as such this issue may be a false positive.
#### Impact: High
An anonymous attacker could potentially exploit these vulnerabilities to {==take control of the server, or perform a denial of service attack==}.
#### Likelihood: Medium
Numerous security vulnerabilities are documented for {each of these versions||this version} of Apache, and there are a number of published exploits; however, they are more likely to cause a denial of service than a compromise.
#### Recommendation
{==CHECK DISTRO - CENTOS/DEBIAN==}? Check the version{s||} of {all||the} Apache web server{s||} to ensure that the latest secure version is installed. Further information can be found from the Apache HTTP server project website:

[https://httpd.apache.org]()