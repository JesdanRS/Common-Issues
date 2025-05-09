---
category: "UPD"
cvss: "3.7"
---
### OpenSSL Session Resume Allows Cipher Suite Downgrade
The version of OpenSSL installed on the affected system{s||} suffer{s||} from a session resume vulnerability which could allow an attacker to downgrade the cipher suite and use weaker or disabled ciphers.

An attacker can downgrade the cipher suite by manipulating the session cache, which will cause subsequent resumes of the session to use the cipher suite selected by the attacker. This can be seen in the example below:

{==https://url==}
```
Initial Cipher : {==TLS1_CK_DHE_RSA_WITH_AES_256_CBC_SHA==}
Resumed Cipher : {==SSL3_CK_ADH_DES_192_CBC_SHA==}
```
#### Impact: Medium
An attacker may be able to force resumed sessions to use weaker cipher chosen by them. This could aid the attacker when launching other attacks.
#### Likelihood: Low
An attacker would need to be on the client's network and have exploited an ARP poisoning or DNS poisoning attack.
#### Recommendation
Check the versions of all OpenSSL installations to ensure that the latest secure version is installed ({==version==}). Further information can be found from the OpenSSL website:

[https://www.openssl.org]()