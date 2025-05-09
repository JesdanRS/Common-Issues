---
category: "APP-CNF"
cvss: "5.3"
---
### Web Service Descriptions
An attacker can view web service descriptions at the following URL{s||}.

http://{==URL==}

This URL lists and describes the following web service operations:

 * {==Operation1==}
 * {==Operation2==}
#### Impact: Low
An attacker can view system information and attempt system operations.
#### Likelihood: Medium
This web service can be discovered using a web spidering tool or by manually navigating the site with a local web proxy tool.
#### Recommendation
Remove the descriptions for the ASMX file by adding the following line to the "web.config" file:

```
<webServices>
  <protocols>
    <remove name="Documentation" />
```
