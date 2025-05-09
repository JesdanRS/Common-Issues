---
category: "UPD"
cvss: "9.8"
---
### Windows Server 2003 No Longer Supported
The affected server{s||} appear{s||} to be running Microsoft Windows Server 2003{==, although the specific build and patch level cannot be positively identified==}.

{==HOSTS==}

Support for Windows Server 2003 ended on 14^th^ July 2015 and the product is now classed as obsolete and will no longer receive security updates.
#### Impact: High
No further updates for this operating system will be provided, and the software will become increasingly vulnerable to attack as time progresses. There are a number of remotely exploitable vulnerabilities in Windows Server 2003 for which exploit code is publicly available.
#### Likelihood: High
Windows Server 2003 is an extremely prolific operating system and is likely to be increasingly actively targeted as time progresses. Identifying the operating system is straightforward{==, as the version can be deduced from the IIS HTTP response headers (see issue XREF)==}.
#### Recommendation
Consider upgrading to a later operating system as soon as possible. Currently supported options include Windows Server 2016 and Windows Server 2019. Please note that Windows Server 2008, Windows Server 2008 R2, Windows Server 2012 and Windows Server 2012 R2 are currently in extended support. These will become end of life in January 2020 and October 2023, respectively, and it is therefore not recommended to upgrade to these versions unless explicitly required.

The following link from NCSC provides short-term mitigation guidelines for organisations unable to migrate from obsolete software in time:

[https://www.ncsc.gov.uk/guidance/obsolete-platforms-security-guidance]()

Please be aware that some legacy applications, such as those based on Classic ASP or older versions of the Microsoft .NET Framework may not work on later operating systems and so adequate testing and development time should be included in any migration plans.