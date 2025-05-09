---
category: "APP-ACC"
cvss: "N/A"
report_on_external_network_test: false
---
### Weak Application Folder Permissions
The {==APPLICATION NAME==} application folders on the tested {==SERVER/WORKSTATION==} were seen to have weak security permissions, in that the {==low/high==} privileged {=="Domain Users/Authenticated Users/Everyone/Linux_Group"==} group has {==full control==} permissions on the folders, as shown below, allowing users to modify the files and folder contents.
{==SCREENSHOT==}

The following output details the application folder permissions on {==HOSTNAME==}
> icacls "C:\PATH\TO\APPLICATION\FOLDER" {==WINDOWS==}
$ ls -lR /PATH/TO/FOLDER {==LINUX==}
{==CODIFY OUTPUT==}

As a result, an authenticated attacker or malicious user could attempt to replace the executable or one of the DLL files within the application folder with a malicious version (see section {==XREF DLL HIJACKING==}). It may also be possible to perform additional attacks against users by placing a malicious Shell Command File (.scf) within the folder, for example, designed to capture domain users' Windows password hashes when opened by a user or service. {==AMEND FOR LINUX ETC==}
#### Impact: High
An attacker could exploit this issue to modify the application in order to perform arbitrary actions, such as those related to privilege escalation, or to perform attacks against other {==CLIENTNAME==} systems. The weak permissions could also be exploited in an attempt to obtain password hashes of other application users.
#### Likelihood: Medium
While users belonging to the {=="Domain Users/Authenticated Users/Everyone"==} group are able to exploit this issue, related attacks would require some technical knowledge in combination with the weak permissions seen during testing. An attacker would also need authenticated access to the system hosting the application.
#### Recommendation
Ensure that all software is installed in the protected directories, such as "C:\Program Files" or "C:\Program Files (x86)" and that only administrative users have "create", "modify" or "write" permissions to the installation directory to prevent an attacker from modifying or replacing application files.