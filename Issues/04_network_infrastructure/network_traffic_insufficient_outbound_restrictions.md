---
category: "NET"
cvss: "5.3"
---
### Network Traffic Insufficient Outbound Restrictions
There are insufficient outbound network restrictions, as a large number of ports could be used to access an external server from the {==internal and wireless==} network{==s==} using the sample {==workstations and laptops==}. {==OPTION==} It was also possible to ping a public system from the sample {==workstations and laptops==} meaning that ICMP traffic is not restricted at {==CLIENTNAME==} perimeter firewall.
#### Impact: Medium
An attacker can access arbitrary unfiltered content on the Internet or perform malicious and illegal activities against systems available on the Internet which would appear to be performed by {==CLIENTNAME==} staff. This could cause an impact to the reputation and public image of {==CLIENTNAME==} or cause legal issues. {==OPTION==} Furthermore, these protocols can be used as a communication channel to send and receive commands to an external server when an internal system is compromised.
#### Likelihood: Medium
An attacker would need to gain access to the {==internal and wireless==} network{==s==} to exploit this issue.
#### Recommendation
Consider installing an Intrusion Detection System (IDS) which performs packet inspection and detects malicious traffic. {==OPTION==} Restrict outbound traffic from the {==internal and wireless==} network{==s==} to specific services, for example by allowing access to HTTP and HTTPS only, although this will only limit the attack surface. {==OPTION==} Unless specifically required, ensure that ICMP and all unnecessary protocols are denied at the perimeter firewall.

Ensure content filtering is in place to reduce potential misuse and ensure logging is active so that misuse can be detected and tracked in the event of an incident.
