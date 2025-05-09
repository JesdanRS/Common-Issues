---
category: "APP-INJ"
cvss: "{==TBC==}"
report_on_external_network_test: true
---
### Server-Side Request Forgery
The "{==FUNCTIONALITY==}" functionality of the affected website{s||} was found to be vulnerable to server-side request forgery (SSRF), which allows an attacker to perform arbitrary {==HTTP/OTHER_PROTOCOL==} requests as the service account running the web server.

In the following example, {==EXPLAIN CONTEXT e.g. reach endpoints that are designed to only be available internally (admin panels/APIs), obtain credentials used to..., port scan other internal systems, etc.==}.

{==OPTION LOCAL FILE INCLUSION==} It was also possible to read local files from the server{s||}. {==EXPLANATION: The "TAG" HTML tag was used to load the local "LOCAL_FILE" file by EXPLAIN_YOUR_METHOD, as shown in the following example:==}

{==ADD POC==}
#### Impact: Medium
An attacker can execute malicious actions as the web server to {==read arbitrary files on the web server, including configuration files containing sensitive information/access systems hosted internally/perform OOB requests to arbitrary systems/etc.==}. {==OPTION REDUCE IMPACT==} However, no sensitive information was disclosed.
#### Likelihood: Medium
SSRF vulnerabilities are commonly sought by attackers, as this could provide access to internal resources. {==OPTION LIMITATIONS==} However, an attacker would need to {==be authenticated and assigned to proper role==} to exploit this vulnerability.
#### Recommendation
Sanitise and validate all client-supplied input data to ensure that only allowed characters are submitted. Where users are permitted to submit URLs or domains to the website, restrict entries to allowlisted domains. This should be enforced using server-side controls. Please see the following URL for high level concepts:

[https://cheatsheetseries.owasp.org/cheatsheets/Server_Side_Request_Forgery_Prevention_Cheat_Sheet.html#available-protections]()

{==OPTION DOCUMENT GENERATION==} Additionally, review vendor documentation for the {==pdf|docx|excel==} library to ensure that URLs, file paths and other references to external content are not processed.