---
category: "{==APP-DAT/NET==}"
cvss: "6.5"
---
### NNTP Service in Use
The affected system{s||} {are||is} running a clear text Network News Transfer Protocol (NNTP) service on the standard port, TCP 119. By default, NNTP traffic is not encrypted and as such anyone intercepting the data that passes between the newsreader and the NNTP server will be able to read the clear text communication, including logins, passwords and downloaded messages.

{==HOSTS==}

Please note that, the NNTP server{s||} appear{||s} to be unused as {they||it} contain{||s} no messages and {are||is} configured only with default groups.
#### Impact: Medium
If someone was able to intercept the data passing clear text over the network the username and password could be compromised, allowing unauthorised access to the server. Unnecessary services increase the attack surface of a host and increase the likelihood that an attacker would be able to compromise the host.
#### Likelihood: Low
To intercept the clear text passwords off the network an attacker on another host would need to use an attack such as an ARP poisoning attack.
#### Recommendation
If the NNTP service{s||} {are||is} not required, disable {them||it}. If {they||it} {are||is} required, consider disabling clear text communication on TCP port 119 and enforce communication over the encrypted channel on TCP port 563.