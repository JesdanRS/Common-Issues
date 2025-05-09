---
category: "APP-ACC"
cvss: "7.5"
---
### Insufficient Static File Access Control
The website stores a number of static files in the "{==assets==}" directory on the web server. These files include uploaded content, such as:

{==BULLETS==}

No access control is enforced on the "{==assets==}" directory or its subdirectories and as such all files are available to anyone with network level access to the website, assuming they know a valid URL. {==OPTION==} The majority of files were seen to use GUIDs in the filenames, {==OR==} The files were seen to have predictable file names, as shown in the example below:

{==URL==}
{==SCREENSHOT==}

{==OPTION==} During testing, none of the available content was deemed overly sensitive, although discussions with development staff indicated that this would be unlikely to be the case in production.
#### Impact: High
An attacker could gain access to potentially sensitive information stored within static files in the "{==assets==}" directory.
#### Likelihood: Low
This issue is readily exploitable with a standard web browser, however an attacker would need to know valid URLs in order to access specific files. {==OPTION==} As the web servers allows directory listing (see section {==XREFDirectoryListing==}, discovering the file names would be trivial. {==OPTION==} The use of GUIDs in filenames makes guessing a valid filename extremely unlikely.
#### Recommendation
Store static files outside of the web root and enforce access control using a file download handler. Where possible, a file download handler should be implemented using well-tested framework functionality, as there are a number of common vulnerabilities associated with custom file download handlers. The following OWASP guidance contains further information about potential vulnerabilities in file download handlers:

[https://www.owasp.org/index.php/Unrestricted_File_Upload]()
