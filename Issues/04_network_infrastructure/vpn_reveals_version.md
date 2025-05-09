---
category: "CNF"
cvss: "5.3"
---
### VPN Reveals Version
The affected VPN device{s||} expose{s its||their} versions{s||} in response to specific Internet Key Exchange (IKE) requests.

```
{==$ ike-scan COMMAND==}
{==OUTPUT==}
```
#### Impact: Low
The version information can be useful information to an attacker when searching for vulnerabilities. Unnecessary system information is exposed.
#### Likelihood: Medium
This information is can be easily obtained using IKE scanning tools.
#### Recommendation
Contact the {==VENDOR==} and request a patch for this vulnerability.
