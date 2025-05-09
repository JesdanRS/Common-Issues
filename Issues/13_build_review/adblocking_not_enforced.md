---
category: "MAL"
cvss: "N/A"
---
### Adblocking Not Enforced
The sample {==laptop==} did not have any kind of advert blocking configured, either locally or at the network level. This leaves the system susceptible to attempts to compromise the browser via malicious adverts, a technique known as malvertising.

The majority of websites with adverts do not serve the adverts directly to the end user, but instead use a third-party advertising network who accept adverts from companies and load them into the visited website. However, many of these networks fail to adequately vet these adverts for malicious code, resulting in malicious adverts appearing on otherwise legitimate websites. The following NCSC article contains further information about malvertising:

[https://www.ncsc.gov.uk/blog-post/ill-make-you-offer-you-cant-refuse]()
#### Impact: Medium
The lack of advert blocking increases the likelihood that the user will be exposed to malicious adverts, which could either attempt to socially engineer them info installing malware (such as fake download buttons), or could attempt to exploit any missing patches or insecure browser plugins to directly compromise the system {==OPTION==} such as those discussed in section {==XREFOldVersions==}.
#### Likelihood: Low
Malicious adverts are common; however they rely on either social engineering or browser exploits in order to compromise the system.
#### Recommendation
Consider implementing advert blocking for all  systems. This can be done either at the network level, by filtering HTTPS traffic of denylisting known domains, or on the client systems with browser extensions, which can be installed via Group Policy in browsers such as Firefox and Chrome.
