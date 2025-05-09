---
category: "PRC"
cvss: "N/A"
---
### Insufficient Security Monitoring
A large number of security recommendations were seen to be pending on the Azure portal's "Security Center", indicating that this is not actively being followed up. {==OPTION==} Please note that some of the recommendations are false positives as {==CLIENTNAME==} has implemented mitigating controls in a different manner than the ones proposed by Microsoft.

{==XREF_SCREENSHOT==}
#### Impact: Medium
Azure resources may not be sufficiently hardened.
#### Likelihood: Low
An attacker would still need to compromise one of the Azure resources for this to become an issue.
#### Recommendation
Periodically review and implement security recommendations provided in the Azure's "Security Center". Ensure any unnecessary recommendations are dismissed from the portal for an effective security monitoring. Further details on this can be found at the following URL:

[https://learn.microsoft.com/en-us/azure/defender-for-cloud/implement-security-recommendations]()