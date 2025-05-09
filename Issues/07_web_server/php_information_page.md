---
category: "APP-CNF"
cvss: "5.3"
report_on_external_network_test: true
generation:
  getIssueContext: |
    return issueGeneration.nessus.helpers.getReportItemsForPluginIds("11229");
  getAffectedSystems: |
    return [...new Set(issueContext.map((x) => x.hostName))].sort((a, b) =>
      a.localeCompare(b)
    );
  getPlaceholderContent: |
    return [...new Set(issueContext.map((x) => /.*(http.*)\n/.exec(x.reportItem.querySelector("plugin_output").innerHTML)[1]))]
      .sort((a, b) => a.localeCompare(b))
      .map((x) => `* ${x}`)
      .join("\n");
---
### PHP Information Page
The affected website{s||} {have||has} a test PHP information page. This reveals the PHP version and other system information, as shown below:

{==PLACEHOLDER==}
#### Impact: Low
The version of PHP and the modules installed are shown, as well as internal information such as server directories. This is very useful information to an attacker.
#### Likelihood: Medium
It is common for PHP information pages to be named {=="phpinfo.php"==} and stored in the {==web root==}, as such this page and will be quickly identified by an attacker using manual inspection or automated scanning tools.
#### Recommendation
Remove this page from the website and review change control procedures to ensure that test pages are not used or left on production websites.