---
category: "UPD"
cvss: "TBC"
---
### Old Version of Tomcat
The affected host{s||} {are||is} running an outdated version ({==VERSION==}) of the Tomcat web server. The current stable version is {==VERSION==}.

The specific version observed during the test may be vulnerable to:

 * {==Denial of service attacks.==}
 * {==Information leakage.==}
 * {==Authentication Bypass.==}

Further information relating to the potential security vulnerabilities associated with older versions of Tomcat can be found at the following URL:

[https://tomcat.apache.org/security.html]()

OPTION: Please note that this version number was obtained from an error page {==(see section XREF),==} and as such may be a false positive if security fixes are backported to an older release by an operating system distribution maintainer.
#### Impact: Medium
An anonymous attacker could potentially exploit these vulnerabilities to {==gain access to the sensitive data or to perform a denial of service attack==} on the server{s||}.
#### Likelihood: Medium
Numerous security vulnerabilities are documented for this version and there are a number of published exploits available; however, they are more likely to cause a denial of service rather than compromise.
#### Recommendation
Check the version of the Tomcat web server to ensure that the latest secure version is installed. Further information can be found from the Tomcat project website:

https://tomcat.apache.org/whichversion.html

In addition, review policies and procedures to ensure tracking software updates is an assigned responsibility so that the website and other systems receive timely security updates.