---
category: "CRY"
cvss: "3.7"
---
### Weak IPsec Transforms Enabled
The firewall{s below are|| HOSTNAME is} configured to use hashing and encryption algorithms that are considered weak, such as {==MD5 and DES==}. The supported weak transforms are listed{ in the table||} below:

{==TRANSFORM_OR_TABLE==}
#### Impact: Medium
An attacker could potentially decrypt or modify traffic sent over these VPN connections.
#### Likelihood: Low
Although there are known weaknesses in these algorithms, exploiting them would require a high degree of technical skill and significant computational power. Additionally, an attacker would need to intercept traffic.
#### Recommendation
Consider disabling the weaker transforms, and requiring the use of stronger algorithms such as AES-256-SHA.

{==OPTION==} Note that an ASA software update may be required to support the most complete range of modern encryption ciphers.
