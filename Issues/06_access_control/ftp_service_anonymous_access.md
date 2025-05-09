---
category: "{==APP-CNF/CNF==}"
cvss: "5.3"
generation:
  getIssueContext: |
    return issueGeneration.nessus.helpers.getReportItemsForPluginIds("10079");
  getAffectedSystems: |
    return [...new Set(issueContext.map((x) => x.hostName))].sort((a, b) =>
      a.localeCompare(b)
    );
---
### FTP Service Anonymous Access
The File Transfer Protocol (FTP) service{s||} available on the affected system{s||} allow{s||} anonymous access:
#### Impact: Low
{==Write access is disabled, and there are no files to download.==}
#### Likelihood: Medium
Anonymous FTP servers can be easily discovered using automated scanning tools, and are a common target for attackers.
#### Recommendation
Restrict access to authenticated users. Additionally, consider replacing FTP with a more secure protocol, such as SFTP or FTPS (see section {==XREFFtpInUse==}).
