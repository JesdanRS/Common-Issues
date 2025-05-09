---
category: "CNF"
cvss: "N/A"
---
### SMB Version 1 in Use
SMB version 1 was found enabled on the affected system{s||}. SMBv1 is an old protocol and lacks the security features that have been implemented in newer versions of SMB such as pre-authentication integrity, secure dialect negotiation, encryption, improved man in the middle (MitM) attacks protections and message signing.

Further information on security related issues affecting SMBv1 can be found at the following Microsoft article:

[https://techcommunity.microsoft.com/t5/storage-at-microsoft/stop-using-smb1/ba-p/425858]()

{==OPTION, IF KB4013389 is not installed==}Additionally, the {==laptop==} was found to be missing the patch KB4013389. This patch fixes a vulnerability (CVE-2017-0144) which allows an attacker to execute remote code on a target system (see section {==XREF_MISSING_WINDOWS_UPDATES==}). Exploit code, called ETERNALBLUE, is publicly available and a large number of systems were affected by this vulnerability and compromised by the WannaCry malware.
#### Impact: Medium
The use of SMBv1 introduces vulnerabilities that are mitigated in the newer versions. An attacker could take advantage of this vulnerabilities to perform downgrade attacks, MitM attacks or execute remote code on the {==laptop==} (see section {==XREF_MISSING_WINDOWS_UPDATES==}).
#### Likelihood: Medium
SMBv1 is installed and enabled on most versions of Windows. Furthermore, exploits which take advantage of vulnerabilities affecting SMBv1 are publicly available.
#### Recommendation
Consider disabling SMBv1, in accordance with Microsoft's recommendation as detailed in the article below.

[https://learn.microsoft.com/en-gb/windows-server/storage/file-server/troubleshoot/detect-enable-and-disable-smbv1-v2-v3]()

Please note that old versions of Windows or third-party applications might not be able to operate over newer versions of SMB, as detailed in the following article:

[https://learn.microsoft.com/en-gb/archive/blogs/josebda/windows-server-2012-r2-which-version-of-the-smb-protocol-smb-1-0-smb-2-0-smb-2-1-smb-3-0-or-smb-3-02-are-you-using]()
