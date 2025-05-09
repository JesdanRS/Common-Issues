---
category: "APP-XXE"
cvss: "8.7"
report_on_external_network_test: true
---
### XML External Entity Injection
The {==FUNCTIONALITY NAME==} functionality on the affected website{s||} is vulnerable to XML external entity (XXE) injection. This was achieved by injecting malicious XML content into the submitted XML {==FILES OR DATA OR PARAMETER NAME==}.

{==URL==}
{==OR==}
Page Fields {==RELATIVEURL==} {==LISTOFFIELDS==}

XXE injection is a well-known web application security flaw which could allow an attacker to perform the following attacks:

{==DELETE AS APPLICABLE==}
 * Remote command execution, allowing an attacker to execute operating system commands under the context of the web server;
 * Local file inclusion, allowing an attacker to read arbitrary files on the file system which can be used to obtain sensitive information such as clear-text passwords in connection strings;
 * Server-side request forgery (SSRF), allowing an attacker to force the web server into sending requests to internally hosted services and systems;
 * Port scan, allowing an attacker to perform a remote port scan against the internal network or third party hosts;
 * Denial of service, by overwhelming the XML parser with very big XML documents, an attacker could crash the web server making the application unavailable to legitimate users.

{==AMEND POC AS APPROPRIATE==}
It was possible to exploit this vulnerability to instruct the web server to send the contents of the "{==FILE==}" file to a server under Dionach's control as can be seen in the following proof of concept example.

The following malicious XML data was used to instruct the website to read the contents of the "{==FILE==}" file and store them in the "file" parameter. The injected XML also instructs the website to retrieve and process an external Document Type Definition (DTD) file hosted on an external server under Dionach's control:

```
{==iNJECTED xml==}
```

The external DTD file is shown below. The file instructs the server to send the contents of the read file, in this instance "{==FILE==}", to a server under Dionach's control using an HTTP GET request:


{==DTD File Name==}
```
{==EXTERNAL DTD FILE==}
```

Inspection of the Dionach server's web access logs shows the requests made by the application and the contents of the read file as shown below:

{==screenshot or OUTPUT IN CODIFY BOX==}

The decoded contents of the "{==FILE==}" file are shown below:

```
{==DECODED FILE CONTENT==}
```

Further information about XML injection can be found at the following OWASP links:

[https://owasp.org/www-community/vulnerabilities/XML_External_Entity_(XXE)_Processing]()
[https://owasp.org/index.php/Testing_for_XML_Injection_(OTG-INPVAL-008)]()
[https://owasp.org/www-pdf-archive/XML_Exteral_Entity_Attack.pdf]()
#### Impact: High
An authenticated user could potentially perform XML injection attacks which would allow them to {==DELETE AS APPLICABLE==} read sensitive data from the server, execute arbitrary commands on the server, interact with internal servers not exposed on the Internet, launch port scans against the internal network, use {==CLIENTNAME==} servers to launch port scans against external third parties, or cause a denial of service and rendering the website{s||} unavailable to legitimate users.
#### Likelihood: Medium
This is a well-known flaw and documentation describing this technique is publicly available. {==OPTION==}An attacker would need to be authenticated in order to exploit this issue.
#### Recommendation
Ensure that the XML parser does not resolve and read external entities and DTD files. Please also refer to the following OWASP {==OPTION==}and Microsoft articles for further information:

[https://cheatsheetseries.owasp.org/cheatsheets/XML_External_Entity_Prevention_Cheat_Sheet.html]()
[https://cheatsheetseries.owasp.org/cheatsheets/XML_Security_Cheat_Sheet.html]()
{==OPTION==} [https://docs.microsoft.com/en-us/archive/msdn-magazine/2009/november/xml-denial-of-service-attacks-and-defenses]()