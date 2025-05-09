---
category: "APP-DAT"
cvss: "6.5"
---
### Website Clear Text Passwords and Personal Data
The affected website{s||} {==(HTTP ONLY) uses | (HTTP/HTTPS) allows ==} plain text HTTP for communication between the web browser and the web server. This means that the {sites||site} {==(HTTP/HTTPS) may ==} {transmit||transmits} all usernames, passwords, sensitive information and user sessions over the network in clear text.
#### Impact: High
An attacker can intercept user credentials and other sensitive information off the local network in order to compromise user accounts and perform arbitrary actions on their behalf, or harvest personally identifiable information (PII).
#### Likelihood: Low
An attacker will need to be on the same local network as someone using the website{||s} or have control of an intermediate device in order to intercept the sensitive information. This is a straightforward attack on an open or shared wireless network.
#### Recommendation
{==OPTION ONLY HTTP==}Enforce encryption over HTTPS with a digital certificate signed by a trusted Certificate Authority and disable any clear text communication over HTTP. Alternatively, redirect all HTTP traffic to HTTPS and use the HSTS header with browser preload to cause browsers to upgrade insecure requests, as detailed in section {==XREF_HSTS==}.
{==OPTION HTTP/HTTPS==}Disable any clear text communication over HTTP. Alternatively, redirect all HTTP traffic to HTTPS and use the HSTS header with browser preload to cause browsers to upgrade insecure requests, as detailed in section {==XREF_HSTS==}.
