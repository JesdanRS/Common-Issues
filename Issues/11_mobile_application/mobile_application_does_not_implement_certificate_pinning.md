---
category: "MOB-COM"
cvss: "3"
---
### Mobile Application Does Not Implement Certificate Pinning
{==NOTE: SSL certificate validation is different from certificate pinning, although related. If they do not validate certificates at all and MitM to steal credentials is possible, increase this to medium==}
{==OPTION Pinning Only:==}The mobile application{s do|| does} not implement certificate pinning in order to ensure that the app{s connect|| connects} to the supporting {== API web server==} with the expected SSL certificate and public key.

{==OPTION SSL Validation & Pinning:==}The mobile application{s neither validate|| neither validates} SSL certificates nor {implement ||implements} certificate pinning in order to ensure that the app{s connect|| connects} to the supporting {== API web server==} with the expected SSL certificate and public key.

As a consequence, HTTPS communications could be intercepted by an inline proxy server or could allow an attacker to perform a man-in-the-middle attack{==OPTION Pinning Only:==}, if they present a similar, trusted certificate.
#### Impact: Medium
Potentially sensitive information, {==such as personal details==}, could be intercepted as it passes over the network. Additionally, a malicious user could intercept the traffic with a web proxy in order to gain a better understanding of how the application interacts with the supporting API server.
#### Likelihood: Low
The attacker must control a proxy server that presents an SSL certificate which has been signed by a trusted certificate authority, or for which a preconfigured exception exists on the user's device.
#### Recommendation
Implement SSL pinning for the mobile application{s||}. The following guide from OWASP provides detailed information on how to implement this in {==Android AND/OR iOS==}:

[https://owasp.org/www-community/controls/Certificate_and_Public_Key_Pinning]()

{==OPTION Android:==} The following code snippet, for trusting unknown certificate authorities, from the official Android documentation, can be as well used as a guideline for implementing SSL pinning.

[https://developer.android.com/privacy-and-security/security-ssl#UnknownCa]()

Please note that although SSL pinning increases the difficulty for an attacker to perform the attacks described above, it will not completely stop a determined and skilled attacker from bypassing it in a {==rooted or jailbroken==} device {==IF: (see section XREF-RootJailBreakDetection)==}.
