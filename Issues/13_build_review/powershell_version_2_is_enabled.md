---
category: "CNF"
cvss: "N/A"
---
### PowerShell Version 2 is Enabled
Windows PowerShell 2.0 was found to be enabled on the sampled {==laptop==}. Newer versions such as Windows PowerShell 5.0 added advanced logging features which can provide additional detail when malware has been run on a system. Disabling Windows PowerShell 2.0 mitigates against a downgrade attack that evades the Windows PowerShell 5.0 script block logging feature.

{==SCREENSHOT==}
#### Impact: Medium
An attacker might be able to perform a downgrade attack and evade logging features of newer PowerShell versions.
#### Likelihood: Low
A large number of recent techniques use PowerShell to perform malicious activities. However, to exploit this issue, an attacker would need to be motivated and have knowledge of {==CLIENTNAME==} environment.
#### Recommendation
To disable Windows PowerShell 2.0, ensure that "Windows PowerShell 2.0" is not enabled under the Windows "Turn Windows features on or off" feature.
