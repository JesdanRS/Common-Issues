---
category: "PWD"
cvss: "1.9"
---
### Weak Password Hash Formats
The reviewed Linux server{s store|| stores} user passwords using a number of different hashing algorithms, some of which are known to be weak.

Although some users passwords are stored using the more secure {==SHA-512 crypt==} algorithm, other accounts are stored the legacy {==DES crypt==} algorithm, which is cryptographically weak. The accounts are listed below:

{==ACCOUNTLIST==}
#### Impact: Medium
An attacker obtaining these password hashes may be able to crack the hashes using a dictionary or brute-force attack, and obtain the user's clear text passwords. This could potentially allow them to authenticate against other systems if the password is re-used.
#### Likelihood: Low
An attacker would need to fully compromise one of the servers, or obtain the hashes through another attack vector, such as a system backup. Additionally, users would need to choose fairly weak passwords in order for them to be cracked in a reasonable timeframe.
#### Recommendation
Configure the server{s||} to use SHA-512 crypt to store passwords. Please note that the old password hashes will be stored until users change their passwords. {==OPTION_REDHAT==} This can be performed using the following command:

```
authconfig --passalgo=sha512 --update
```

{==OPTION_DEBIAN==} Set the following option in /etc/login.defs:

```
ENCRYPT_METHOD SHA512
```
