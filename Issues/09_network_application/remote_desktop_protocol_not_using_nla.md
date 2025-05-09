---
category: "CNF"
cvss: "3.4"
generation:
  getIssueContext: |
    return issueGeneration.nessus.helpers.getReportItemsForPluginIds("58453");
  getAffectedSystems: |
    return [...new Set(issueContext.map((x) => x.hostName))].sort((a, b) =>
      a.localeCompare(b)
    );
---
### Remote Desktop Protocol Not Using NLA
The Remote Desktop Protocol (RDP) is widely used throughout the {==CLIENTNAME==} network for remote administration of production systems. Most of these systems were not using Network Level Authentication (NLA) to protect the communication between the RDP client and the RDP session host.

NLA is a security feature introduced in Microsoft Windows Vista and Microsoft Windows Server 2008, and is enabled by default. Client systems running Windows XP SP3 or later can support connections to an NLA enabled server with a registry change, but cannot accept inbound NLA enabled connections.

The following article gives more information on the use of NLA for RDP connections:

[https://docs.microsoft.com/en-gb/previous-versions/windows/it-pro/windows-server-2008-R2-and-2008/cc732713(v=ws.11)]()
#### Impact: Medium
An attacker can potentially launch man-in-the-middle attacks against RDP connections which do not use NLA.
#### Likelihood: Low
The RDP connections in use at {==CLIENTNAME==} use Kerberos Authentication, to provide mutual authentication, and also support encryption of RDP communication. An attacker would need to exploit a weakness in both RDP itself, and in Kerberos to successfully launch a man-in-the-middle attack.
#### Recommendation
Consider enabling NLA on all systems which will support it. Please note that this may impact availability on some legacy systems which do not support NLA.
