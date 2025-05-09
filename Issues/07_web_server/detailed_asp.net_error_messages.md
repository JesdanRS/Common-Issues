---
category: "APP-CNF"
cvss: "5.3"
---
### Detailed ASP.NET Error Messages
The ASP.NET affected website{s||} show{s||} detailed error messages that reveal application code and paths as shown below:

{==https://link==}
```
{==ERROR==}
```
#### Impact: Low
Unnecessary system information is exposed. Although in isolation this information may not be significant, an accumulation of information relating to internal systems and network infrastructure can help an attacker to form an attack strategy.
#### Likelihood: Medium
It is relatively straightforward to generate an error, for example by requesting a non-existent web page.
#### Recommendation
For ASP.NET applications amend the "customErrors" section in the application's "web.config" file so that detailed error messages are not shown remotely.

```
<configuration>
  <system.web>
    <customErrors mode="RemoteOnly"/>
  </system.web>
</configuration>
```

See the following MSDN article for further information:

[https://learn.microsoft.com/en-us/previous-versions/994a1482(v=vs.140)]()
