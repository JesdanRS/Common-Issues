---
category: "APP-CNF"
cvss: "N/A"
report_on_external_network_test: true
---
### WordPress XML-RPC Interface Enabled
The WordPress XML-RPC interface is enabled on the affected website above and is available at the following URL:

http://SITE/xmlrpc.php
#### Impact: Medium
The XML-RPC interface increases the attack surface for an attacker when attempting to exploit the website. {==OPTION==} Additionally, there are known vulnerabilities in the currently installed version of WordPress that can exploited using the XML-RPC interface (see section {==XREF==}).
#### Likelihood: Low
An attacker would need to exploit a vulnerability in the XML-RPC interface. There are no known vulnerabilities in the XML-RPC interface of the installed version of WordPress ({==3.6==}).
#### Recommendation
If the XML-RPC interface is not used, consider disabling it. This can be done either via WordPress plugins or by using the web service to restrict access to the "xmlrpc.php" file.

{==OPTION Apache:==} For Apache, the following configuration will deny access to the "xmlrpc.php" file:

```
<Files xmlrpc.php>
Deny from all
</Files>
```

{==OPTION Nginx:==} For Nginx, the following configuration will deny access to the "xmlrpc.php" file:

```
location = /xmlrpc.php {
   deny all;
   access_log off;
   log_not_found off;
}
```
