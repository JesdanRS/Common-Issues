---
category: "APP-CNF"
cvss: "5.3"
generation:
  getIssueContext: |
    return issueGeneration.nessus.helpers
      .getReportItemsForPluginIds("11422")
      .map((x) => ({
        ...x,
        server: x.reportItem
          .querySelector("plugin_output")
          .textContent.replace(
            /\nThe default welcome page is from (.*).\n/,
            "$1"
          ),
      }));
  getAffectedSystems: |
    return [...new Set(issueContext.map((x) => x.hostName))].sort((a, b) =>
      a.localeCompare(b)
    );
  getPlaceholderContent: |
    let groupedIssueContext = issueGeneration.helpers.groupObjectArrayByKey(
      issueContext,
      "server"
    );
    return Object.keys(groupedIssueContext)
      .sort((a, b) => a.localeCompare(b))
      .map(
        (x) =>
          `The following web servers display the default page for ${x}:\n\n${groupedIssueContext[
            x
          ]
            .map((x) => `* <${x.serviceName}>`)
            .sort((a, b) => a.localeCompare(b))
            .join("\n")}`
      )
      .join("\n\n");
---
### Web Server Default Page
The web server{s below display default pages|| at URL displays a default page}.

{==PLACEHOLDER==}
#### Impact: Low
This indicates that the web server{s have|| has} not been hardened.
#### Likelihood: Medium
This is disclosed by navigating to the website root{s||} in a web browser.
#### Recommendation
Remove the default page{s||} and replace {them||it} with a redirect. Remove any other unnecessary services and pages.
