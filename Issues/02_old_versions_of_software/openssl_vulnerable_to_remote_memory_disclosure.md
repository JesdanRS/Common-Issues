---
category: "UPD"
cvss: "7.5"
---
### OpenSSL Vulnerable to Remote Memory Disclosure
The version of OpenSSL installed on the affected system{s||} {is||are} vulnerable to a memory disclosure issue. A remote, unauthenticated, attacker can exploit this issue by sending a malformed Heartbeat Extension packet which results in a buffer over-read and the return of arbitrary memory contents in the response. An example of the information returned is shown below:

python heartbleed.py {==IP==} -p {==PORT==}
```
{==OUTPUT EXAMPLE==}
```

{==OPTION IF COOKIE FOUND==} Please note that, a session cookie was contained within the returned memory fragment. An attacker may be able to use this to hijack the original user's session and so access the website, although during testing the session cookie was seen to be no longer valid.

Further information regarding this vulnerability is available from the following URLs:

[http://heartbleed.com]()
[https://cve.mitre.org/cgi-bin/cvename.cgi?name=CVE-2014-0160]()
#### Impact: High
An attacker can read the contents of memory fragments from the server. This results in the disclosure of sensitive information, including, but not limited to, {==passwords, session IDs and SSL private keys.==}
#### Likelihood: High
This vulnerability is well known and exploit code is publicly available. This vulnerability is being actively targeted in the wild.

{==OPTION==} As the website{s||} {are||is} restricted by IP address to trusted users only, an attacker would first need access to the website in order to attempt to exploit this vulnerability.
#### Recommendation
This issue can be resolved by upgrading OpenSSL to the latest version, or by recompiling OpenSSL with the "-DOPENSSL_NO_HEARTBEATS" option.

{==OPTION IF NAS This will require a firmware update==}. {==DETAILS OF VENDORS FIRMWARE UPDATE STATUS.==}