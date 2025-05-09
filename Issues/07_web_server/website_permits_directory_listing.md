---
category: "APP-CNF"
cvss: "5.3"
---
### Website Permits Directory Listing
The affected website{s||} {have|has} directory listing on the following directories and their sub-directories. This can expose sensitive files not normally visible and also can be useful to an attacker when attempting file upload attacks.

{==URLs==}
#### Impact: Low
No sensitive information was disclosed. However, if other directories not discovered in this test are available externally more sensitive information may be exposed.
#### Likelihood: Medium
Most automated vulnerability scanners will find this issue.
#### Recommendation
{==OPTION APACHE==}
Disable directory listings by removing the Indexes option from the "Options" directive in the Apache configuration files.

{==OPTION IIS==}
Disable directory listings in IIS by modifying the website permissions as discussed in the following Microsoft article:

[https://docs.microsoft.com/en-us/iis/configuration/system.webserver/directorybrowse]()

{==OPTION JETTY==}
To disable directory listing by default in Jetty, set the following configuration value:

```
webAppContext.setInitParameter("org.eclipse.jetty.servlet.Default.dirAllowed", "false");
```
