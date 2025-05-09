---
category: "{==APP-DAT/NET==}"
cvss: "6.5"
---
### SMTP Service Supports Clear Text Authentication
The Simple Mail Transfer Protocol (SMTP) service{s||} listed above advertise{||s} that {they||it} support{||s} plain text authentication.

{==POC==}
#### Impact: Medium
If someone was able to intercept the data passing clear text over the network the username and password could be compromised, allowing unauthorised access to the SMTP server. As a result of this, an attacker would be able to send both spam emails and phishing emails.
#### Likelihood: Low
To intercept the clear text passwords off the network an attacker on another host would need to use an attack such as an ARP poisoning attack.
#### Recommendation
Consider implementing encrypted authentication utilising STARTTLS, and migrating the authenticated submission service to a dedicated RFC-compliant message submission interface on port 587, as defined by RFC 6409.

The following article discusses STARTTLS in more detail:

[https://en.wikipedia.org/wiki/STARTTLS]()
