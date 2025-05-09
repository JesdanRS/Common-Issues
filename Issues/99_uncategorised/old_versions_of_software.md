---
category: "N/A"
cvss: "N/A"
comment: |
  This is a helper issue only. Follow guidance in the description.
generation:
  getIssueContext: |
    return Array.from(issueGeneration.nessus.context.querySelectorAll("ReportItem"))
      .filter((x) => x.querySelector("plugin_output"))
      .filter(
        (x) =>
          x
            .querySelector("plugin_output")
            .innerHTML.toLowerCase().includes("installed version") ||
          x.querySelector("plugin_output").innerHTML.toLowerCase().includes("remote version")
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
      "| Host | Software | Version |\n| -- | -- | -- |",
      ...issueContext.map(
        (x) =>
          `| ${x.hostName} | ${x.reportItem.getAttribute("pluginName")} | ${
            /(?:[Ii]nstalled|[Rr]emote) [Vv]ersion *: *(.*)/.exec(
              x.reportItem.querySelector("plugin_output").innerHTML
            ) !== null
              ? /(?:[Ii]nstalled|[Rr]emote) [Vv]ersion *: *(.*)/.exec(
                  x.reportItem.querySelector("plugin_output").innerHTML
                )[1]
              : x.reportItem.querySelector("plugin_output").innerHTML
          } |`
      ),
    ].join("\n");
---
### Old Versions of Software
This is a generated helper issue which attempts to pull old versions of software from nessus based on issues containing the text "Installed version" or "Remote version".

It is recommended to:

* Double check the flagged issues. You may need to remove any that are incorrect or inappropriate as well as add any from Nessus that did not contain the text "Installed version" or "Remote version".
* Copy the table to a text editor and use find replace to change issue titles to the correct software names.
* Use `cat | uniq` or your perferred method to remove duplicate rows.
* Report the table as appropriate. Depending on the length, this could be in your own old version issue, as an appendix, or as a spreadsheet.

Remember Nessus is not very consistent on how it reports issues hence the difficulty in generating a good issue. Be sure to double check your results.

{==PLACEHOLDER==}
#### Impact: Low
N/A
#### Likelihood: Low
N/A
#### Recommendation
N/A
