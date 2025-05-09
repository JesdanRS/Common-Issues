---
category: "APP-CNF"
cvss: "5.3"
---
### Apache Tomcat Sample and Documentation Pages
The affected system{s||} {were||was} found to contain the default Tomcat documentation and sample files.

The following Tomcat server{s were|| was} found to contain the default Tomcat documentation only:

{==URLs==}
#### Impact: Low
Default pages indicate that the server{s have|| has} not been sufficiently hardened, and the Tomcat sample files have historically been a common source of vulnerabilities. The Tomcat documentation pages also reveal the version of Tomcat in use. {==OPTION==} Note that this version of Tomcat appeared to be outdated, as discussed in section {==XREFOldTomcat==}.
#### Likelihood: Medium
The default pages are available in standard locations and automated vulnerability scanners will detect this issue. No vulnerabilities were discovered in the default pages{==, other than those identified elsewhere in this report (see section XREFTomcatSampleFileXSS)==}.
#### Recommendation
Remove the default pages from the server{s||}. The following OWASP guide provides further information related to hardening Tomcat:

[https://www.owasp.org/index.php/Securing_tomcat]()
