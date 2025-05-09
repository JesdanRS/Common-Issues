---
category: "CNF"
cvss: "N/A"
---
### Insufficient PowerShell Restriction and Monitoring
During the internal penetration test several offensive PowerShell tools were used to enumerate users and groups, launch processes, or extract information loaded in memory. However, it appeared that {==CLIENTNAME==} IT staff were not notified of these activities. As a result, {==CLIENTNAME==} IT staff would not be able to promptly detect and respond to attacks performed through PowerShell tools.
#### Impact: Medium
An attacker can execute PowerShell scripts to perform malicious activities such as injecting code directly into memory, bypassing many antivirus solutions.
#### Likelihood: Medium
Several offensive techniques use PowerShell to perform malicious activities. Furthermore, PowerShell is installed by default since Windows 7 and Windows Server 2008 R2. An attacker would have to be authenticated to a {==CLIENTNAME==} system to carry out such attacks.
#### Recommendation
Install PowerShell v5 which provides enhanced security and improved logging such as "Script Block Logging" and "System-wide transcripts", and also ensure that PowerShell v2 is uninstalled where possible.

Enable "Constrained Language Mode". Constrained Language Mode only allows core PowerShell functionality and prevents execution of the extended language features often used by offensive PowerShell tools such as .Net & Windows API calls and COM access. This can be achieved via Group Policy by setting the "__PSLockdownPolicy" policy to "4" in the following location:

```
Computer Configuration\Preferences\Windows Settings\Environment\
```

Please note that these settings might prevent legitimate PowerShell scripts from being executed. As a result, further testing should be performed on a staging environment before deploying them into on all live systems.

Enable PowerShell logging to ensure that any activity performed through PowerShell is logged. This can be achieved by group policy by setting the "Turn on Module Logging" policy to "*" in the following location:

```
Computer Configuration\Policies\Administrative Template\Windows Components\Windows PowerShell\
```

Monitor and forward PowerShell log events (such as event ID 400 and 800) and PowerShell operation events (such as event ID 4100, 4103, 4104) to a central logging solution which checks for key indicators such as "TOKEN_PRIVILEGES", "SE_PRIVILEGE_ENABLED" and "System.Reflection.AssemblyName".

Please refer to the following articles for further information:

[https://learn.microsoft.com/en-gb/archive/blogs/kfalde/pslockdownpolicy-and-powershell-constrained-language-mode]()
[https://adsecurity.org/?p=2604]()