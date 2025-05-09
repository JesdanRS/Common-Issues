---
category: "APP-CNF"
cvss: "5.3"
generation:
  getIssueContext: |
    return issueGeneration.nessus.helpers.getReportItemsForPluginIds("11213");
  getAffectedSystems: |
    return [...new Set(issueContext.map((x) => x.hostName))].sort((a, b) =>
      a.localeCompare(b)
    );
---
### Web Server Allows TRACE Method
The affected web server{s||} allow{s||} the HTTP method TRACE. TRACE is typically used to debug web server connections. When receiving a TRACE command, the web server echoes back what is sent to it. The HTTP header information bounced back can potentially include sensitive information such as credentials or session cookies. Many web servers have the TRACE method allowed by default.

{==HOSTS==}

The following OWASP page contains further information about exploiting the TRACE method:

[https://owasp.org/www-community/attacks/Cross_Site_Tracing]()

Please note that most modern browsers will now block TRACE requests.
#### Impact: Medium
Scripts can be constructed to issue TRACE commands and then forward the returned information to a destination under the control of an attacker.
#### Likelihood: Low
This would likely require a knowledgeable attacker, an element of social engineering and often other vulnerabilities to use in conjunction to be exploited successfully. Additionally, the victims would have to use outdated browsers.
#### Recommendation
The HTTP TRACE method should be disabled. {==OPTION==} This can be done by removing TRACE from the mapping in Internet Services Manager. URLScan can also be configured to only allow certain HTTP verbs, such as GET, HEAD and POST. {==OPTION==} For Apache add the following line to the "httpd.conf" file:

```
TraceEnable off
```
