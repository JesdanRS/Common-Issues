---
category: "APP-CNF"
cvss: "5.3"
---
### Detailed IIS Error Messages
The affected website{s||} show{s||} detailed IIS error messages that reveal application code and paths, as shown below:

{==https://link==}
```
{==ERROR==}
```
#### Impact: Low
Unnecessary system information is exposed. Although in isolation this information may not be significant, an accumulation of information relating to internal systems and network infrastructure can help an attacker to form an attack strategy.
#### Likelihood: Medium
It is relatively straightforward to generate an error, for example by requesting a non-existent web page.
#### Recommendation
For IIS websites amend the "httpErrors" section in the application's "web.config" file so that detailed error messages are not shown remotely. Please refer to the reference link below for more information.

```
<configuration>
  <system.webServer>
    <httpErrors errorMode="DetailedLocalOnly" />
  system.webServer>
</configuration>

```

See the following article for further information:

[https://docs.microsoft.com/en-gb/iis/configuration/system.webServer/httpErrors/]()
