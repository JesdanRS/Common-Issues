---
category: "APP-CNF"
cvss: "5.3"
---
### Web Servers Show Software Versions in HTTP Headers
The web server{s||} listed above show{s||} the versions of various software installed in {their||its} HTTP headers.

{==HOSTS==}
#### Impact: Low
The version information can be useful to an attacker when searching for vulnerabilities. Unnecessary system information is exposed.
#### Likelihood: Medium
A simple scan or banner grab would obtain this information from the HTTP headers.
#### Recommendation
{==OPTION IF >= IIS 10.0==} In IIS 10 build 1709 and above, it is possible to remove the server header by adding the following lines to the configuration file:

```
<system.webServer>
  <security>
    <requestFiltering removeServerHeader="true" />
  </security>
<system.webServer/>
```

{==OPTION IF <= IIS 10.0 and >= IIS 7.0==} There are a number of mechanisms that can be used to remove unnecessary HTTP headers in IIS. Consider using a Native-Code module, which allows headers to be removed in an easy to deploy and scalable manner. The following article provides further information:

[https://www.dionach.com/easily-remove-unwanted-http-headers-in-iis-7-0-to-8-5/]()

{==OPTION IF <= IIS 6.0==} Set the "enableVersionHeader" runtime setting to false within the "httpRuntime" element in the ASP.NET Settings schema. See the following link for more information:

[https://msdn.microsoft.com/en-gb/library/system.web.configuration.httpruntimesection.enableversionheader.aspx]()

Use URLScan to stop IIS 6.0 from showing its version number in returned HTTP headers. URLScan is a free tool developed by Microsoft, designed to harden IIS and improve its security. More information about URLScan and its features can be found on the following link:

[https://docs.microsoft.com/en-gb/iis/extensions/working-with-urlscan/urlscan-overview]()

{==OPTION ASPNET header on IIS==} It is possible to remove the X-AspNet-Version header by adding the following lines to the configuration file:

```
<system. Web>
<httpRuntime enableVersionHeader="false" />
<system. Web/>
```
{==OPTION X-Powered-By header on IIS==} Please note that other methods can be used to remove these headers, including the X-Powered-By header. More information can be found in the following Microsoft article:

[https://techcommunity.microsoft.com/blog/iis-support-blog/remove-unwanted-http-response-headers/369710]()

{==OPTION Nginx==} In the Nginx configuration, set the following:

```
server_tokens off
```

{==OPTION APACHE==} Amending the following directive setting in the Apache "httpd.conf" configuration file will ensure that only the basic header "Apache" will be returned.

```
ServerTokens Prod
ServerSignature Off
```

"ServerSignature Off" tells Apache not to display the server version on error pages, or other pages it generates. "ServerTokens Prod" tells Apache to only return "Apache" in the Server header.

{==OPTION==} To turn off the PHP "X-Powered-By" header, set the "expose_php" variable to "off" in php.ini.

{==OPTION JETTY==} For the latest versions of Jetty, setting the following option in the configuration file will disable the server version header.

```
jetty.httpConfig.sendServerVersion=false
```

{==OPTION LIGHTTPD==} For lighttpd, setting the following option in the "server-tag.conf" configuration file will disable the server version header.

```
server.tag = ""
```
