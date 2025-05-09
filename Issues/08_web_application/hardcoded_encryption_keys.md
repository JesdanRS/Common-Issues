---
category: "APP-DAT"
cvss: "3.8"
---
### Hardcoded Encryption Keys
Inspection of the {==application source code==} identified a number of hardcoded encryption keys, as shown below:

{==FIXME==}
#### Impact: Medium
An attacker could potentially use these keys to decrypt sensitive information, or to perform further attacks against the application.
#### Likelihood: Low
An attacker gaining access to the application code would quickly identify these keys, as well as the encryption algorithms that they are used with. {==OPTION==} However, it is unknown whether these encryption keys are currently in use in the application.
#### Recommendation
Wherever possible, do not hardcode keys in applications; instead store them in configuration files or the back-end database used by the application. Ideally, these keys should be stored in an encrypted form.

If applications only need to be able to encrypt data, rather than decrypting it, consider the use of public key cryptography, with only the public key available to the application.