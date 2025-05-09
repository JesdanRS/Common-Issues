---
category: "APP-DAT"
cvss: "6.5"
---
### Login Clear Text Passwords
The affected web portal{s||} listed above, found on the internal network, {use||uses} plain text HTTP for communication between the web browser and the web server. These are listed below. This means that the {sites transmit||site transmits} all usernames, passwords, sensitive information and user sessions over the network in clear text.

{==URLs==}
#### Impact: High
An attacker can sniff sensitive information off the local network in order to compromise user accounts and perform arbitrary actions on their behalf.
#### Likelihood: Low
An attacker will need to be on the same local network as someone using the website or have control of an intermediate device in order to sniff the sensitive information. This is a straightforward attack on an open or shared wireless network.
#### Recommendation
Enforce encryption over HTTPS with a digital certificate signed by a trusted Certificate Authority and disable any clear text communication over HTTP.
