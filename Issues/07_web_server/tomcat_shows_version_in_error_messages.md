---
category: "APP-CNF"
cvss: "5.3"
---
### Tomcat Shows Version in Error Messages
When an error in Tomcat is encountered by the web server{s||} listed above, the version of Tomcat installed on the server is displayed in the error page:

{==URL + SCREENSHOT==}
#### Impact: Low
Unnecessary system information is revealed.
#### Likelihood: Medium
Generating error messages is a standard part of any attack strategy.
#### Recommendation
Restrict Tomcat error messages by adding a custom error page, then referencing it in the "web.xml" file as follows:

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
