---
category: "UPD"
cvss: "TBC"
---
### Old and Unsupported Versions of Software
{==The sampled workstations and servers==} listed above were found to be running old versions of client software. The following list gives examples of identified old versions of client and server software. In some cases, installed versions were also seen to be unsupported by the respective vendors. Please note that this list is not exhaustive.

Client Software
{==
 * Adobe AIR
 * Adobe Reader
 * Cisco AnyConnect
 * Microsoft Visio
 * Java
==}
#### Impact: High
Numerous security vulnerabilities exist in old versions of the above software. In some cases, {==exploits are publicly available and actively exploited==}.
#### Likelihood: High
This issue could be exploited by a remote attacker, and client software, such as {==Adobe Reader==}, is an extremely common target for attackers, due to the large number of vulnerabilities in the software. Successful exploitation may be dependent on the configuration of the specific system.
#### Recommendation
Ensure that central patch management is configured for third party software, that it covers all hosts, and that the identified updates are applied promptly. Consider also using a vulnerability scanning tool to check for missing security updates. Review patch management policies for third party software, and consider implementing software restrictions on workstations to prevent users from installing software that will not be updated.

{==OPTION M365==} Ensure that installed software is monitored to allow IT staff to remove or update any vulnerable versions discovered or software that is not strictly necessary. Microsoft Defender Advanced Hunting can be used to assist in the identification of vulnerable and outdated software and affected systems. For example, the following query will show all inventoried instances of vulnerable software:

[https://security.microsoft.com/v2/advanced-hunting]()
```
DeviceTvmSoftwareVulnerabilities
| distinct DeviceName, SoftwareVendor, SoftwareName, SoftwareVersion
| sort by SoftwareVendor asc, SoftwareName asc
```

The following query will show all inventoried instances of unsupported software:

[https://security.microsoft.com/v2/advanced-hunting]()
```
DeviceTvmSoftwareInventory
| where EndOfSupportStatus == "EOS Version"
| distinct DeviceName, SoftwareVendor, SoftwareName, SoftwareVersion, EndOfSupportDate
| sort by SoftwareVendor asc, SoftwareName asc
```

Finally, ensure that installed software is monitored to allow IT staff to remove or update any vulnerable versions discovered or software that is not strictly necessary. For example, all users may not require a specific version of Java. If an old version of Java is required, please see the following article for guidance of reducing the risk of running it:

[https://www.dionach.com/blog/minimising-the-risk-of-using-java]()