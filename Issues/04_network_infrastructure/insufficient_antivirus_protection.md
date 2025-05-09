---
category: "MAL"
cvss: "10"
---
### Insufficient Antivirus Protection
During the internal penetration test it was discovered that common off the shelf malicious exploitation frameworks and programs such as Metasploit and CrackMapExec, which leverage PowerShell scripts such as {==Invoke-Mimikatz.ps1==}, were not detected by the local Antivirus. These tools are aimed at escalating privileges and worked successfully since they were not caught by the {==ANTIVIRUS==}(AV) software.
#### Impact: High
An attacker exploiting this issue could run malicious programs in order to escalate privileges or cause operational harm to {==CLIENT==}'s operations through ransomware attacks.
#### Likelihood: High
Publicly available programs and frameworks used for performing malicious actions are trivial to use which inject code into process memory in order to evade AV. Additionally, as AV is not detecting these tools attacks will likely go unnoticed for longer periods of time resulting in further compromise to {==CLIENT==}'s network.
#### Recommendation
Review the current AV solution in use, and ensure that it is configured to detect common off the shelf malicious exploitation frameworks and programs, in order to protect the local system.