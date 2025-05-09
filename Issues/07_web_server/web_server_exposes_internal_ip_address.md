---
category: "APP-CNF"
cvss: "5.3"
---
### Web Server Exposes Internal IP Address
The web server{s||} listed above expose{s its|| their} internal IP address{es|| (INTERNALIP)}. This information can be useful to an attacker. {These||This} IP address{es||} can be exposed by sending a single HTTP request to the web server using a tool such as curl:

curl --http1.0 -IH "Host:" {==URL==}
```
{==REPSONSE==}
```
#### Impact: Low
Unnecessary system information is exposed which may be useful to an attacker looking to exploit further vulnerabilities, such as server-side request forgery. {==OPTION==} Note that requirement 1.4.5 of PCI DSS states that internal IP addresses must not be disclosed.
#### Likelihood: Medium
This information is easily available through automated scanning or manual inspection.
#### Recommendation
{==OPTION IIS6==} Ensure that KB834141 is installed, and configure the server to respond with a hostname, rather than its internal IP address, as discussed in the following Microsoft article:

[https://support.microsoft.com/en-us/help/834141]()

{==OPTION IIS7==} Ensure that KB967342 is installed, and configure the server to respond with a hostname, rather than its internal IP address, by setting the "alternateHostName" configuration option:

```
<system.webServer>
  <serverRuntime alternateHostName="{==HOSTNAME==}" />
</system.webServer>
```

{==OPTION Apache==} Ensure that the "ServerName" directive is set to the website hostname in the Apache configuration files in order to ensure that the internal IP address is not disclosed.
