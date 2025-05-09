---
category: "MOB-PLF"
cvss: "N/A"
---
### Insecure Functions in Use
Static analysis of the {==APK/IPA==} file{s||} revealed that a number of insecure functions are in use. The following table is a summary of the identified functions:

{==TABLE listing insecure functions reported by MobSF==}

{==Weak crypto functions in use==} Note that the cryptographic functions, such as {==Random Number Generator and Java Hash Code==}, are considered to be cryptographically weak algorithms, which may result in collisions that could be exploited by attackers. In some cases, collision resistance may not be required and therefore these algorithms would not pose a security risk.
#### Impact: Medium
An attacker can potentially perform overflow attacks which can impact the logic of the application and potentially lead to execution of malicious code. {==OPTION Weak Crypto Function==} The use of cryptographically weak algorithms could allow attackers to decrypt and access unauthorised data.
#### Likelihood: Low
Successful exploitation of this issue will require significant time and resources.{==OPTION Due to time constraints Dionach did not attempt to exploit the vulnerabilities identified in these functions.==}
#### Recommendation
Review these functions and, where possible, replace them with secure alternatives. {==OPTION Examples of secure functions can be found at the following URLs:==}

{==Provide links to secure alternatives to the weak functions listed above==}

Otherwise, {==CLIENTNAME==} should perform a risk assessment to evaluate whether the use of insecure functions is an acceptable risk within the organisation.
