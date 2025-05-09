---
category: TBA
cvss: TBA
---
### Potentially Insufficient Domain Audit Policy
The audit policy for the Active Directory domain controllers in the "{==FQDN==}" {==domain/forest==} is potentially insufficient. The current audit policy configuration does not meet the current Microsoft baseline recommendations, the non-compliant policies are listed below:

* {==Logon events are only logged when a failure occurs, but not when a logon is successful.==}
* {==Computer Account Management events are only logged when successful, but not when a failure occurs.==}
#### Impact: Medium
There may be an impact on accountability of actions performed on domain systems if it is not possible to verify when users authenticate on the systems, or when account management operations fail. This could lead to lack of useful information relating to malicious activities, such as domain users brute force attacks, in case of an incident requiring investigation (see section {==XREF_LogsRotationPolicy==}).
#### Likelihood: Low
Although the described events will likely occur on a regular basis, situations where the necessary logs are required, such a system compromise, are less likely to happen.
#### Recommendation
Review the current audit policy and consider making changes based on industry best practices. The following article details Microsoft's baseline recommendations for audit settings and highlights where additional logging is recommended in addition to the Windows defaults.

[https://learn.microsoft.com/en-us/windows-server/identity/ad-ds/plan/security-best-practices/audit-policy-recommendations]()
