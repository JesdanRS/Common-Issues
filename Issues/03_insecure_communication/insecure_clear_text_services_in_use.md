---
category: "{==APP-DAT/NET==}"
cvss: "6.5"
---
### Insecure Clear Text Services in Use
A number of hosts were seen to be running insecure services on standard ports. These services are insecure in the sense that they are not encrypted. Anyone intercepting the data that passes between the client and the server will be able to read the clear text communication, including logins and passwords.

These services are listed below:

{==LIST OF HOSTS WITH TELNET/FTP/HTTP/VNC==}
#### Impact: Medium
Sensitive information passing in clear text over the network could be compromised, potentially allowing unauthorised access to the affected services.
#### Likelihood: Low
An attacker on another host on the same network would need to perform a man in the middle attack, such as ARP poisoning.
#### Recommendation
Replace the insecure services with more secure protocols. {==OPTION Telnet services should be replaced with SSH, FTP should be replaced with SFTP, and HTTP should be replaced with HTTPS and configured with a valid certificate.==}
If this is not possible, consider wrapping service communication using an encryption protocol, such as TLS.
