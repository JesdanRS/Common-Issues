---
category: "{==APP-DAT/NET==}"
cvss: "6.5"
generation:
  getIssueContext: |
    return issueGeneration.nessus.helpers.getReportItemsForPluginIds("10281");
  getAffectedSystems: |
    return [...new Set(issueContext.map((x) => x.hostName))].sort((a, b) =>
      a.localeCompare(b)
    );
  getPlaceholderContent: |
    return [...new Set(issueContext.map((x) => x.serviceName))]
      .sort((a, b) => a.localeCompare(b))
      .map((x) => `* ${x}`)
      .join("\n")
---
### Telnet Service in Use
The affected system{s||} {are||is} running the Telnet service. Telnet is an insecure protocol in the sense that it is not encrypted. Anyone intercepting the data that passes between the Telnet client and the Telnet server will be able to read the clear text communication, including logins and passwords.

{==PLACEHOLDER==}
#### Impact: Medium
If someone was able to intercept the data passing clear text over the network the username and password could be compromised, allowing unauthorised access to the host{s||}.
#### Likelihood: Low
To intercept the clear text passwords off the network an attacker on another host would need to use an attack such as an ARP poisoning attack.
#### Recommendation
Replace the Telnet service{s||} with a more secure protocol such as SSH.
