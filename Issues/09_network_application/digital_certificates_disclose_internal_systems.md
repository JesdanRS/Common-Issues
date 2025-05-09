---
category: "CNF"
cvss: "5.3"
---
### Digital Certificates Disclose Internal Systems
The {following services||service at URL} use{||s a} digital certificate{s||} which reveal{||s} internal systems in the indicated certificate fields:

{==URL==}
```
{==Subject: hostname.localdomain==}
{==Issuer: internal CA==}
{==CRL Distribution Points:==}
{==Authority Information Access:==}
```
#### Impact: Low
Unnecessary system information is exposed. Although in isolation this information may not be significant, an accumulation of information relating to internal systems and network infrastructure can help an attacker to form an attack strategy.
#### Likelihood: Medium
This information can be retrieved by attempting to connect to the service{s||} and inspecting the digital certificate{s||}.
#### Recommendation
Ensure that all externally available services use a digital certificate {==issued to the correct external domain name and ==}signed by an externally trusted certificate authority (see section {==XREF_Untrusted==}).