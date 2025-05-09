---
category: "MAL"
cvss: "N/A"
---
### Insufficient Internet Filtering
Internet access did not appear to be filtered on any of the wireless networks. As a result, an attacker can access inappropriate websites and download malicious content from the Internet. For example:

 * {==OPTION==} It was possible to browse to the "Exploit-DB" website, which is a well-known repository for public exploits at [https://www.exploit-db.com]()
 * {==OPTION==} It was possible to download an "EICAR" dummy test virus from [https://www.eicar.org/download-anti-malware-testfile/]()
 * {==OPTION==} It was possible to download the well known "Cain and Abel" exploitation program from [http://www.oxid.it/cain.html]()
#### Impact: Medium
An attacker can access arbitrary content on the Internet and download malicious software to compromise the affected systems or attack connected systems on the network. Furthermore, staff could be infected by malware or Trojans when they surf the Internet using the wireless networks. A potential liability may also exist if an attacker can misuse the connection, for example to download pirate material.
#### Likelihood: Medium
An attacker would first need to compromise a system connected to the wireless network or staff would need to visit a malicious website.
#### Recommendation
Ensure that web requests are filtered through a web proxy which adequately blocks unauthorised and malicious websites.{==OPTION==} Consider conducting a risk assessment to evaluate the risk on surfing of potential malicious website by {==CLIENTNAME==} staff.
