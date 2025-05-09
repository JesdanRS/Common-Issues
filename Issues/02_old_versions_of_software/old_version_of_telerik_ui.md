---
category: "UPD"
cvss: "TBC"
---
### Old Version of Telerik UI
{The websites below use||The website at URL uses} an old version of the Telerik UI framework, which provides developers with the ability to create UI features such as charts. The identified version is affected by a number of vulnerabilities potentially leading to unauthenticated remote code execution.

{==URLs==}

{==OPTION CVE-2017-9248 or CVE-2017-11317==} The administrative Telerik UI pages are protected by weak encryption (CVE-2017-9248, CVE-2017-11317), which an unauthenticated attacker can exploit by brute forcing a valid encryption key to gain access to the administrative file upload panel. From there, it is possible to upload a web shell and gain remote code execution on the web server.

{==OPTION CVE-2019-18935==} When access restrictions prevent an attacker from executing code under the web root, a deserialization vulnerability in Telerik UI (CVE-2019-18935) allows code execution from any directory. By first exploiting the previous vulnerability to upload a malicious DLL file, an attacker can execute the code in it with a crafted serialized request containing a reference to the uploaded file.

As a proof of concept, it was possible to {==OPTION PoC depending on CVE==}.

For further information on these vulnerabilities, see the following security advisories:

[https://www.telerik.com/support/kb/aspnet-ajax/details/cryptographic-weakness]()
[https://www.telerik.com/support/kb/aspnet-ajax/upload-%27async%28/details/unrestricted-file-upload]()
[https://www.telerik.com/support/kb/aspnet-ajax/details/allows-javascriptserializer-deserialization]()
#### Impact: High
An unauthenticated attacker can{==OPTION==} perform administrative actions on the server, such as upload malicious files. This allows an attacker to gain remote code execution, leading to a complete compromise of a web server.
#### Likelihood: High
The version of Telerik UI can be identified through manual inspection of HTML source code (see section {==XREF==}). These vulnerabilities are well documented with publicly available tools to aid attackers in performing the exploits.
#### Recommendation
Update the version of Telerik UI to the latest version. Please see the following link for more information:

[https://www.telerik.com/support/whats-new]()

Additionally, review formal policies and procedures to ensure that software is regularly checked for available updates.