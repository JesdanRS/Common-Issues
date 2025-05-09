---
category: "APP-VUL"
cvss: "4.7"
---
### Old Version of JavaScript Libraries
The affected website{s||} {were||was} found to be using {==old versions of a number of JavaScript libraries/an old version of a JavaScript library==}. Details are shown below.
{==Versions==}
{==Describe the vulns, provide CVEs if possible==}

{==OPTION==} Old JavaScript libraries have been associated with a number of script injection flaws which can lead to client-side attacks. For more details about vulnerabilities related to the above {==libraries/library==}, please refer to the following URL{s||}:
{==URLs==}

{==OPTION jQuery vulns, verify at https://research.insecurelabs.org/jquery/test/==}
[https://bugs.jquery.com/ticket/11290]()
[https://bugs.jquery.com/ticket/9521]()
[https://github.com/jquery/jquery/issues/2432]()
[https://nvd.nist.gov/vuln/detail/CVE-2011-4969]()
[https://bugs.jquery.com/ticket/11974]()

{==OPTION jQuery 1.x or 2.x==} Please note that the version 1 and version 2 branches of jQuery are unsupported, and as such will no longer receive any future security updates.

{==OPTION Bootstrap==} Versions of Bootstrap below version 4 are vulnerable to a cross-site scripting vulnerability in specific circumstances. See the following URL for further details:

[https://github.com/twbs/bootstrap/issues/20184]()

Bootstrap version 4 reached end of life in January 2023 and is now unsupported, please see the release schedule here:

[https://github.com/twbs/release]()
[https://blog.getbootstrap.com/2022/07/19/bootstrap-4-6-2/]()

{==OPTION oldmoment==} All versions of the Moment library prior to version 2.11.2 are stated to be vulnerable to a denial of service condition. See the following URL for further detail:

[https://github.com/moment/moment/issues/2936]()
#### Impact: Medium
{==These versions/This version==} of the {==JavaScript==} libraries {==are/is==} vulnerable to cross-site scripting or HTML injection. Additionally, the use of old versions of scripts could introduce vulnerabilities that are mitigated in newer versions of the software.
#### Likelihood: Low
Although there are publicly available exploits for {==these versions/this version==}, they depend on certain configurations in order to be exploitable. {==OPTION==} During testing, these configurations did not appear to be in use. {==OPTION==} No public exploits are currently known for {==these versions/this version==}.
#### Recommendation
Consider upgrading the website{s||} to the latest stable version of the above JavaScript {==libraries/library==}, and perform periodic reviews to ensure that the latest secure version is installed. Monitoring the release notes and security advisories of client-side libraries may be possible using automated software and scripts.

{==OPTION multiple==} The most recent release{==s==} of {==AngularJS, jPlayer, jQuery, and Bootstrap==} can be downloaded from the following links:

[https://angularjs.org/]()
[https://jplayer.org/download/]()
[https://getbootstrap.com/]()
[https://jquery.com/download/]()
[https://jqueryui.com/download/]()

{==OPTION==} Consider checking for extra copies of JavaScript libraries that may be present on the file system and consolidating them to a single copy of the library where possible.

{==OPTION==} For libraries bundled as part of other software packages, consult the vendor documentation to verify whether it is possible to upgrade them separately and for guidance on how to update these.
