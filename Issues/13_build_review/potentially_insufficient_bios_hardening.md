---
category: "CNF"
cvss: "N/A"
---
### Potentially Insufficient BIOS Hardening
A number of additional hardening settings were identified in the BIOS that were not configured on the laptop{s||}.

| Name | Configured Setting | Recommended Setting |
| ---- | ------------------ | ------------------- |
| {==Secure Boot==} | Disabled | Enabled |

{==OPTION==} Note that it may not be possible to implement Secure Boot with the current operating system.
#### Impact: Medium
A number of hardware devices are enabled in the BIOS that are not required, and could potentially be used to carry out unauthorised activity if the user is able to gain root access to the Linux operating system. Additionally, some security options such as TXT are disabled, which could potentially leave the system more vulnerable to exploitation.
#### Likelihood: Low
The BIOS hardening may increase the attack surface of the system, and could also prevent the use of certain operating system security features {==OPTION==} such as Device Guard, as discussed in section {==XREFVirtualisationBasedSecurityDisabled==}. {==OPTION==} Operating system level restrictions are in place that would prevent the use of most of these hardware devices.
#### Recommendation
Ensure that the BIOS is appropriately hardened, with unnecessary devices being disabled, and all relevant security features being configured.. Note that if future deployments use different hardware, additional BIOS hardening steps may be required.

Consider creating a documented hardening process for each system used, with a formal specification of how the BIOS should be configured.
