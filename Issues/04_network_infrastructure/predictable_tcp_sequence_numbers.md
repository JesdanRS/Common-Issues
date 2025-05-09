---
category: "UPD"
cvss: "9.1"
---
### Predictable TCP Sequence Numbers
The affected system{s||} {use||uses} a weak algorithm to generate TCP sequence numbers. This may allow attackers to inject packets into TCP streams. Please note that this issue was identified through automated scanning, and as such may be a false positive.

{==HOSTS==}
#### Impact: Medium
If a host is using predictable sequence numbers, an attacker may be able to predict the TCP sequence numbers and perform a man in the middle attack by injecting packets into the TCP stream. There is also the possibility that an attacker could establish spoofed TCP connections or terminate existing connections. Attempts to exploit this are more to cause a denial of service on network level than a man in the middle attack.
#### Likelihood: Low
This issue is difficult to exploit and only motivated attackers would attempt to exploit this.
#### Recommendation
Update the server to the latest available kernel. Further details on this issue are available at the following URL:

[https://cve.mitre.org/cgi-bin/cvename.cgi?name=CVE-2011-3188]()
