---
category: "ATH"
cvss: "5.3"
---
### Wireless Controller Administration over HTTP
The web based administration portals for the wireless controllers are accessible over clear text HTTP at the URLs listed below. This means that all usernames, passwords, user sessions, and potentially any sensitive configuration information will be transmitted over the network in clear text.

{==URLS==}
#### Impact: High
An attacker may be able to intercept sensitive information off the local network and gain access to the wireless controllers.
#### Likelihood: Low
{==OPTION==} Given that the devices are in a separate physical network to the rest of the infrastructure, and are used infrequently by IT staff, it is relatively unlikely that an attacker is able to intercept sensitive information.
#### Recommendation
Enforce encryption over HTTPS with a digital certificate signed by a trusted Certificate Authority. This certificate authority could be part of an internal public key infrastructure.
