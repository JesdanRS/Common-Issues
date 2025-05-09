---
category: "APP-ATH"
cvss: "5.3"
report_on_external_network_test: true
---
### Weak Authentication Mechanism
The website at {==URL==} requires users to enter their {==date of birth and postcode==}, in order to {==login==}. This information can be easily obtained about a target through public information resources, and so should not be used as the sole means of authentication.
#### Impact: High
An attacker guessing this information could have access to potentially sensitive documents, which may contain {==personal information==}.
#### Likelihood: Medium
An attacker could easily obtain this information through social engineering, or through use of social media websites. However, knowledge of the target would be required to perform this attack.
#### Recommendation
Review this authentication mechanism and consider replacing it with a username and password. Passwords should have a minimum of eight characters, including numbers and uppercase characters, and should be stored as salted hashes, formed using secure password storage algorithms such as bcrypt, scrypt and PBKDF2.