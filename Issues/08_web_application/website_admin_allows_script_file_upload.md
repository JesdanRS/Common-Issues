---
category: "APP-CNF"
cvss: "9.1"
---
### Website Admin Allows Script File Upload
Website administrators manage the website at {==URL==}. This section should just allow documents and images to be uploaded, however there is no restriction on the type of file that can be uploaded. This means that script files can be uploaded and run in the context of the web server, as shown in the example below:

{==PoC==}
#### Impact: Medium
Someone getting access to the administration section can upload script files such as {==CFM==} and {==ASP==} files, and get access to the operating system on the web server. An attacker could then has access any {==other websites and databases==} on the web server.
#### Likelihood: Low
An attacker would need to gain authenticated access to the administration section first.
#### Recommendation
Restrict uploading of file types to certain extensions, for example only documents and images. Do not allow scripts to be run in the document directories by removing that flag in {==IIS==}.