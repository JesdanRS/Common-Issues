---
category: "CNF"
cvss: "5.3"
generation:
  getIssueContext: |
    return issueGeneration.nessus.helpers.getReportItemsForPluginIds("57608");
  getAffectedSystems: |
    return [...new Set(issueContext.map((x) => x.hostName))].sort((a, b) =>
      a.localeCompare(b)
    );
---
### SMB Signing Not Enforced
SMB signing is not enforced on a large number of systems within the {==DOMAINNAME==} Active Directory domain. As a result, any systems which do not use SMB signing will not require SMB communication to be mutually authenticated. {==OPTION==} Systems identified with SMB signing disabled are listed above.
#### Impact: Medium
Communications over SMB could be spoofed or intercepted through a man-in-the-middle attack, by an attacker on the local network, in order to access sensitive information, bypass authentication, or intercept domain user credentials.
#### Likelihood: Medium
This vulnerability requires the use of another attack such as ARP spoofing, DNS poisoning or replying to NetBIOS and LLMNR protocols {==(see section XREF_Broadcast_Protocols_issue)==}. A number of publicly available tools exist to exploit this. {==OPTION==}During the time allocated for testing, it was not possible to exploit this to obtain privileged access to the systems above.
#### Recommendation
Consider enforcing SMB signing through Active Directory Group Policy settings, as detailed in the article at the following URL.

[https://learn.microsoft.com/en-us/previous-versions/windows/it-pro/windows-10/security/threat-protection/security-policy-settings/microsoft-network-server-digitally-sign-communications-always]()

Please note that this may impact availability on some legacy or non-Windows systems, and so requires appropriate planning and testing.