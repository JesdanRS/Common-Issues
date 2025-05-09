---
category: "{==APP-DAT/NET==}"
cvss: "6.5"
generation:
  getIssueContext: |
    return issueGeneration.nessus.helpers.getReportItemsForPluginIds("11819");
  getAffectedSystems: |
    return [...new Set(issueContext.map((x) => x.hostName))].sort((a, b) =>
      a.localeCompare(b)
    );
  getPlaceholderContent: |
    return [...new Set(issueContext.map((x) => x.serviceName))]
      .sort((a, b) => a.localeCompare(b))
      .map((x) => `* ${x}`)
      .join("\n");
---
### TFTP Service in Use
The affected system{s||} {are||is} running a Trivial File Transfer Protocol (TFTP) server over UDP port 69.

TFTP is an insecure protocol in the sense that it does not authenticate the client and it is not encrypted. An attacker who successfully guesses the names of the files hosted by the TFTP server will be able to download these files. Also, anyone intercepting the data that passes between the TFTP client and the TFTP server will be able to read the clear text communication.
#### Impact: Medium
Normally, TFTP servers are used to host system configuration files and system binaries. If an attacker successfully downloads these files the information obtained could be used to support other attacks against network resources.
#### Likelihood: Low
An attacker will have to use a dictionary or a brute force attack to discover the names of the files hosted by the TFTP server.
#### Recommendation
If the TFTP service is not being used, then disable it. Otherwise, consider amending firewall rules to only allow access to this service from trusted IP addresses.
