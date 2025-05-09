---
category: "N/A"
cvss: "N/A"
generation:
  getIssueContext: |
    return Array.from(issueGeneration.nessus.context.querySelectorAll("ReportItem"))
      .filter(
        (x) =>
          /KB\d+/.exec(x.getAttribute("pluginName")) !== null ||
          /MS\d+-\d+/.exec(x.getAttribute("pluginName"))
      )
      .filter(
        (x) =>
          x.querySelector("plugin_output") &&
          !x
            .querySelector("plugin_output")
            .innerHTML.includes("Installed version") &&
          !x.querySelector("plugin_output").innerHTML.includes("Remote version")
      )
      .map((x) => {
        return {
          hostName: window.issueGeneration.nessus.helpers.getHostNameFromReportHost(
            x.parentNode
          ),
          reportItem: x,
        };
      });
  getAffectedSystems: |
    return [...new Set(issueContext.map((x) => x.hostName))].sort((a, b) =>
      a.localeCompare(b)
    );
  getPlaceholderContent: |
    return [
      "| Host | Patch | Plugin Title |\n| -- | -- | -- |",
      ...issueContext.map(
        (x) =>
          `| ${x.hostName} | ${
            /KB\d+/.exec(x.reportItem.getAttribute("pluginName")) !== null
              ? /KB\d+/.exec(x.reportItem.getAttribute("pluginName"))[0]
              : /MS\d+-\d+/.exec(x.reportItem.getAttribute("pluginName"))[0]
          } |  ${x.reportItem.getAttribute("pluginName")} |`
      ),
    ].join("\n");
---
### Missing Windows Update Workarounds
This is a generated helper issue which attempts to pull missing Window update workarounds from Nessus based on issues with titles containing "KB/d+" or "MS/d+-/d+" and not containing the text "Installed version" or "Remote version" in the plugin output.

It is recommended to:

- Double check the flagged issues. You may need to remove any that are incorrect or inappropriate as well as add any from Nessus that did not match the above rules.
- Report the table as appropriate. Depending on the length, this could be in your own missing workaround issue, as an appendix, or as a spreadsheet.

Remember Nessus is not very consistent on how it reports issues hence the difficulty in generating a good issue. Be sure to double check your results.

{==PLACEHOLDER==}
#### Impact: Low
N/A
#### Likelihood: Low
N/A
#### Recommendation
N/A