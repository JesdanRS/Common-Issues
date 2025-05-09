---
category: "MAL"
cvss: "N/A"
---
### Antivirus Tamper Protection Not Configured
Inspection of the {==XREF domain controller==} showed that {==Sophos'/ESET's==} access password protection feature {==(TAMPER_PROTECTION_FEATURE_NAME)==} was not enabled. The purpose of this protection is to prevent unauthorised users from disabling antivirus protection or changing configuration settings. This is shown below:

{==XREF_SCREENSHOT==}
#### Impact: Medium
An attacker could modify or disable antivirus protection in order to attempt to infect systems with viruses, malware or other malicious software which would otherwise be detected. {==OPTION==}This would also enable an attacker to bypass security mechanisms, such as Host-based Intrusion Prevention System (HIPs), in order to perform further malicious activities or attacks.
#### Likelihood: Low
An attacker would need to first gain administrative access to an affected {==Windows==} system in order to access the local antivirus management console and attempt to modify or disable the antivirus protection.
#### Recommendation
Consider enabling the {==TAMPER_PROTECTION_FEATURE_NAME==} on antivirus installations for all systems in the network. Ensure that the chosen Tamper Protection password is sufficiently complex and that it complies with the organisation's password policy.
