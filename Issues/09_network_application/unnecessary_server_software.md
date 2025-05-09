---
category: "CNF"
cvss: "N/A"
---
### Unnecessary Server Software
Many of the servers throughout the {==CLIENTNAME==} network were seen to have unnecessary software installed. As an example, the server {==SERVERNAME==} was found to have the following potentially unnecessary software installed:

{==BULLET_LIST_OF_SOFTWARE==}

{==OPTION)==} In many cases they were also seen to be running old and insecure versions (see section {==XREFOldThirdPartySoftware==}).
#### Impact: Medium
Unnecessary software greatly increases the attack surface of the system, especially for externally facing software such as web browser plugins. Additionally, its presence on the servers indicates weaknesses in change management and system hardening processes.
#### Likelihood: Medium
Unnecessary software was seen to be present on a large number of systems{==, and in many cases it was outdated.==}
#### Recommendation
Review change management and system hardening procedures to ensure that unnecessary software is not installed on production systems, and that where software is installed there is a clear and justified business case for it. Remove any unnecessary software from existing servers, and ensure that any remaining software is kept up to date with the latest security patches.
