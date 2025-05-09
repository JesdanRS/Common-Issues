---
category: "TBC"
cvss: "TBC"
---
### Unsupported Operating Systems
Review of the "{==FQDN.domain==}" Active Directory domain and {==sampling of==} servers showed that the affected systems{s} {are||is} running {||an} unsupported operating system{||s}, such as {==Windows XP, Windows 7, Windows Server 2008/2008 R2 and Windows 10 1809==}, and were still seen to be active.

{==HOSTS==}

Extended support for Windows 7 and Windows Server 2008 R2 ended on January 14, 2020 and the product is now classed as obsolete and will no longer receive security updates.
Similarly, support for Windows 10 1809 ended on November 10, 2020.
#### Impact: High
No further updates for th{is||ese} operating system{||s} will be provided, and the software will become increasingly vulnerable to attack as time progresses. {==There are a number of remotely exploitable vulnerabilities in Windows XP for which exploit code is publicly available==}.
#### Likelihood: High
This{||ese} operating system{||s} {is||are} likely to be increasingly actively targeted as time progresses. {==OPTION==} Additionally, there are a number of remotely exploitable vulnerabilities in each of these systems for which exploit code is publicly available, some of which can lead to remote code execution and complete compromise of the affected system{||s}.
#### Recommendation
Consider upgrading to supported operating systems as soon as possible. Currently supported options include {==Windows Server 2016, Windows Server 2019 and Windows Server 2022 for servers, and Windows 10 and Windows 11 21H2 and upwards for workstations.==}

The following link from NCSC provides short-term mitigation guidelines for organisations unable to migrate from obsolete software in time:

[https://www.ncsc.gov.uk/guidance/obsolete-platforms-security-guidance]()

Please also note that many legacy applications will require specific operating system configuration changes to be made before they can be made to run successfully on the latest supported versions of Windows.
