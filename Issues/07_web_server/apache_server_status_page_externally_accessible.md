---
category: "APP-CNF"
cvss: "5.3"
---
### Apache Server Status Page Externally Accessible
{The web servers below disclose information about their status||The web server below discloses information about its status}. It is possible to obtain an overview of the remote Apache web server{s'||'s} activity and performance by requesting the URL{s||} below. This overview included information such as {==current client IP addresses, requested URLs, the number of idle and service requests, and CPU utilization==}.

{==URL(s) + screenshot==}
#### Impact: Medium
Unnecessary system information is exposed, including {==the IP addresses of website users, and the URLs they request==}.{==OPTION (bumps up to medium impact)==} This may include users' {==credentials or session cookies==} (see section {==XREF creds/cookies in URL==}).
#### Likelihood: Medium
{These pages are||This page is} straightforward to discover and can be found by guessing common website paths, or by using a website scanning tool.
#### Recommendation
Update the Apache configuration to either disable "mod_status" or ensure that access control is properly enforced to prevent unnecessary access to {these pages||this page}. For more information please see the following URL:

{==OPTION Apache 2.2==}[https://httpd.apache.org/docs/2.2/mod/mod_status.html]()
{==OPTION Apache 2.4==}[https://httpd.apache.org/docs/2.4/mod/mod_status.html]()
