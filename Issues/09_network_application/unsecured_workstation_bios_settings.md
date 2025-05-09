---
category: "PRV"
cvss: "5.7"
---
### Unsecured Workstation BIOS Settings
The workstation provided did not have a BIOS password set. This would allow someone gaining access to the system to change low-level configuration settings, such as the boot order of devices.

{==OPTION==} Additionally, the workstation allowed the user to select an alternative boot device on start up through the initial boot menu.
#### Impact: Medium
An attacker would be able to change BIOS level settings, and would be able to boot the workstation from alternate media, potentially allowing them to bypass local security restrictions.
#### Likelihood: Low
An attacker would need to gain unobserved physical access to a workstation. This is most likely to be performed by someone who has otherwise authorised access to internal system
#### Recommendation
Ensure that a secure BIOS password is set on all workstations, and that the workstation can only boot from the primary hard drive.
