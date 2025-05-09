---
category: "{==APP-DAT/NET==}"
cvss: "6.5"
generation:
  getIssueContext: |
    return issueGeneration.nessus.helpers.getReportItemsForPluginIds("10092");
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
### FTP Service in Use
The affected system{s||} {are||is} running a File Transfer Protocol (FTP) service. FTP is an insecure protocol in the sense that it is not encrypted. Anyone intercepting the data that passes between the FTP client and the FTP server will be able to read the clear text communication, including logins, passwords and downloaded files. {==OPTIONAL==} Note that, although encryption is available through the STARTTLS command {==on some servers==}, this is not enforced.

{==PLACEHOLDER==}
#### Impact: Medium
If someone was able to intercept the data passing clear text over the network the username and password could be compromised, allowing unauthorised access to the FTP server.
#### Likelihood: Low
To intercept the clear text passwords off the network an attacker on another host would need to use an attack such as an ARP poisoning attack.
#### Recommendation
Replace the FTP service with a more secure protocol such as SFTP, or tunnel FTP over SSL.

{==OPTION IF MICROSOFT==} The Microsoft IIS service in use can be configured to require SSL. The following URL gives detailed configuration steps:

[https://docs.microsoft.com/en-gb/iis/configuration/system.applicationhost/sites/site/ftpserver/security/ssl]()
