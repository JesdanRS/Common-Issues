---
category: "UPD"
cvss: "TBC"
---
### Oracle TNS Listener Remote Poisoning
The remote Oracle TNS listener available on the affected system{s||} on TCP port {==1521==} {is||are} vulnerable to remote poisoning attacks. This allows an attacker to register a fake service with the listener, which would trick it into diverting client connections to a server under the attacker's control. This could allow an attacker to conduct man-in-the-middle, session-hijacking, or denial of service attacks (e.g. CVE-2012-1675).

Note that the Oracle TNS listener appears to be running version {==XREF_VERSION==}.

{==OPTION==} No attempt to exploit this was made, as this would redirect legitimate users using this service, resulting in a denial of service.
#### Impact: Medium
An attacker exploiting this vulnerability could be able to intercept users' credentials and other sensitive data sent to or from the server, hijack users' sessions in order to execute commands on the server, or render the server unavailable to legitimate users.
#### Likelihood: Medium
The vulnerability is well documented and proof of concept exploits are publicly available. However, exploitation is likely to result in a denial of service.
#### Recommendation
Update Oracle to the latest secure and supported version. Further information can be found at the following URL:

[http://www.oracle.com/technetwork/indexes/downloads/index.html]()

Additionally, review current policies and procedures regarding the updating and patching of software to ensure that systems are patched within a prompt timeframe in order to defend against emerging threats.