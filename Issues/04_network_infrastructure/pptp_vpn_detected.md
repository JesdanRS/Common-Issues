---
category: "{==APP-DAT/NET==}"
cvss: "5.3"
---
### PPTP VPN Detected
{Endpoints||An endpoint} for Point-to-Point Tunnelling Protocol (PPTP) VPN connections {were||was} detected at the affected system{s||} listed above.

PPTP relies on user authentication with the MS-CHAPv2 (Microsoft Challenge Handshake Protocol Version 2), and encryption with the cryptographically weak MPPE (Microsoft Point-to-Point Encryption) algorithm, based on a pre-shared key by default. Further information about the vulnerabilities in PPTP VPNs can be found in the following article:

[https://www.schneier.com/academic/pptp/faq.html]()

Most VPN endpoints will also support Layer 2 Tunnelling Protocol with IPsec Encryption (L2TP/IPsec), or SSL VPNs, which are more secure protocols.
#### Impact: Medium
Intercepted traffic could be decrypted via a brute-force attack, particularly if a weak pre-shared key is chosen. Additionally, an attacker could use the VPN handshake to obtain valid credentials, and then gain access to the internal network.
#### Likelihood: Medium
There are a number of resources available online which report extremely high levels of success in breaking PPTP VPN communication traffic, some with close to 100% success.
#### Recommendation
If possible, replace the PPTP VPN endpoint with an L2TP/IPsec, Microsoft DirectAccess or SSL VPN solution.
