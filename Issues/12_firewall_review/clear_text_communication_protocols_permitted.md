---
category: "TBA"
cvss: "TBA"
---
### Clear Text Communication Protocols Permitted
A review of the device{s||} configuration indicated that external traffic using insecure protocols, such as {==Telnet, FTP, LDAP and HTTP==}, which are not encrypted, is allowed through the firewall{s||}. Anyone sniffing the data that passes between the client and the server will be able to read the clear text communication, including any sensitive information, such as credentials.
#### Impact: Medium
If someone is able to sniff data passing over the network such as login credentials, this could allow them to gain unauthorised access to devices, servers or applications. An attacker could leverage this to further attack the organisation's systems.
#### Likelihood: Medium
In order to sniff the clear text passwords or other sensitive information off the network, an attacker would need to successfully use another attack such as an ARP poisoning attack.
#### Recommendation
Consider only using encrypted communication protocols and services. {==OPTION Replace the Telnet services with a more secure protocol such as SSH. Replace clear-text FTP services with a more secure protocol such as SFTP, or tunnel FTP over SSL. Enforce websites to use HTTPS with a digital certificate signed by a trusted Certificate Authority==}.
