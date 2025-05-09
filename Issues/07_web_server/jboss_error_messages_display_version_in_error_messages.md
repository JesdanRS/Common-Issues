---
category: "APP-CNF"
cvss: "5.3"
---
### JBoss Error Messages Display Version in Error Messages
When an error in JBoss is encountered, the version of JBoss installed on the server is displayed:

{==URL==}
{==SCREENSHOT==}
#### Impact: Low
Unnecessary system information is revealed.
#### Likelihood: Medium
Generating error messages is a standard part of any attack strategy.
#### Recommendation
Create custom error pages, then reference them in the web.xml file as follows:

```
<error-page>
  <error-code>500</error-code>
  <location>/server_error.html</location>
</error-page>
<error-page>
  <error-code>404</error-code>
  <location>/file_not_found.html</location>
</error-page>
```
