---
category: "CNF"
cvss: "3.7"
generation:
  getIssueContext: |
    return issueGeneration.nessus.helpers.getReportItemsForPluginIds("57690");
  getAffectedSystems: |
    return [...new Set(issueContext.map((x) => x.hostName))].sort((a, b) =>
      a.localeCompare(b)
    );
---
### Remote Desktop Protocol Encryption Can Be Stronger
The Remote Desktop Protocol (RDP) is widely used throughout the {==DOMAIN==} network for remote administration of production systems. In most cases the encryption level for RDP communication was set to "2 - Client Compatible". There are two higher levels of encryption supported for RDP communication, "3 - High" and "4 - FIPS Compliant".
#### Impact: Medium
An attacker could potentially intercept and decrypt communications using the "2 - Client Compatible" encryption setting in order to harvest credentials or sensitive information.
#### Likelihood: Low
The RDP connections in use at {==CLIENTNAME==} use Kerberos Authentication, to provide mutual authentication, and also support encryption of RDP communication. An attacker would need to exploit a weakness in both RDP itself, and in Kerberos to successfully launch a man-in-the-middle attack.
#### Recommendation
Consider enabling the strongest encryption level - "4 - FIPS Compliant" where supported, and "3 - High" as the minimum for all RDP communication. Consider also using trusted digital certificates to add an additional level of authentication for RDP communication.
