---
category: "APP-CNF"
cvss: "5.3"
---
### Default ISAPI Extensions on Windows IIS Web Servers
Default IIS extensions including the .IDA indexing service and .printer (IPP) were discovered on the affected system{s||} listed above.
#### Impact: Medium
These extensions have had a number of vulnerabilities associated with them in the past.
#### Likelihood: Low
Exploitation would require an unpatched version of the ISAPI filter. The presence of the .IDA indexing service or the .printer service can often indicate the presence of a default unhardened web server.
#### Recommendation
Remove unnecessary ISAPI extensions and related files from IIS web servers as part of the web server hardening process. This can be done using the IIS lockdown tool from Microsoft. See the following page for more information:

[https://support.microsoft.com/en-gb/kb/325864]()
