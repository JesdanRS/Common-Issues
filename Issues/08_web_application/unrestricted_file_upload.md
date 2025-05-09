---
category: "APP-CNF"
cvss: "9.9"
report_on_external_network_test: true
---
### Unrestricted File Upload
The affected website{s||} contain{s||} {==multiple pages||a page==} that allow{==s==} {==unauthenticated==} users to upload files. The uploaded files are not restricted to specific file type extensions {==OPTION==} and are not scanned for malicious content. This would allow an attacker to upload HTML or executable files in order to carry out client-side attacks such as cross-site scripting attacks, drive-by download attacks or social engineering attacks.

{==URLS==}

The table below summarises the allowed {==extensions/content types==}:

{==TABLE==}

The following proof of concept shows {==PoC==}. The uploaded file will be then available on the web server at the following URL:

{==URL and screenshot==}

{==OPTION==} Please note that testing of this functionality also revealed that uploaded files are not scanned for malware (see section {==XREF-file-not-scanned==}).
#### Impact: High
An attacker could attempt to compromise an {==administrator==} account via client side attacks and obtain control of the website. {==OPTION==} Additionally, an attacker could distribute malware, such as ransomware, within {==CLIENTNAME==} network.
#### Likelihood: Medium
File upload vulnerabilities are well-known web application flaws, and are regularly abused by attackers. Exploiting this vulnerability is straightforward; however, it would require an element of social engineering {==OPTION==} , and an attacker would need to have a valid account with the {==ROLE==} role to exploit this vulnerability.
#### Recommendation
Restrict file uploads to a predefined and approved list of file types such as {==PNG==}. This should be achieved following an allowlist approach and should be enforced using server-side controls that verify both the file's extension and the file's actual content, as well as sanitising the file's metadata. Additionally, special characters should be removed from the filenames and their extensions, and a limit should be enforced on the filename length.

The following page from OWASP provides more information on preventing unrestricted file upload.

[https://cheatsheetseries.owasp.org/cheatsheets/File_Upload_Cheat_Sheet.html]()

{==OPTION==}Additionally, ensure that all uploaded files are scanned for malicious content by server-side antivirus before being served to users, and that malicious content is appropriately quarantined (see section XREF_file_not_scanned).
