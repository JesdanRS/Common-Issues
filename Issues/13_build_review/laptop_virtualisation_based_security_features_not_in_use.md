---
category: "CNF"
cvss: "N/A"
---
### Laptop Virtualisation Based Security Features Not in Use
Windows has a number of virtualisation-based security features, including Device Guard and Credential Guard, which help protect the systems against both remote attacks and local privilege escalation. These features are not enabled on the sampled laptop.

Device Guard is a set of features which work together to prevent untrusted code from running within Windows, these are:

* Configurable Code Integrity (CCI), which ensures that only trusted code is executed after the boot loader.
* Virtual Secure Mode (VSM) Protected Code Integrity, which moves Kernel Mode Code Integrity (KMCI) and Hypervisor Code Integrity (HVCI) into VSM to harden them against attacks.
* Platform and UEFI Secure Boot, which is used to ensure that boot loader and UEFI firmware have not been tampered with.

Credential Guard uses VSM to create an isolated version of the Local Security Authority (LSA/LSASS) to protect the storage and management of user and system credentials.
#### Impact: Medium
A lack of virtualisation-based security features leaves the laptop more suspectable to compromise through the execution of untrusted code and credential harvesting attacks.
#### Likelihood: Low
An attacker would need to need to obtain valid credentials and physical access to the laptop to attempt to perform any of the attacks that virtualisation-based security features are designed to protect against.
#### Recommendation
Consider implementing the virtualisation-based security features on the laptop. Further information about Device Guard and Credentials Guard can be found in the following Microsoft documentation:

[https://learn.microsoft.com/en-gb/windows/security/identity-protection/credential-guard/credential-guard-manage]()
[https://learn.microsoft.com/en-gb/windows/security/threat-protection/device-guard/introduction-to-device-guard-virtualization-based-security-and-windows-defender-application-control]()
