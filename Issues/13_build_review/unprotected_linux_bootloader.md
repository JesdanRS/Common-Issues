---
category: "ATH"
cvss: "6.8"
---
### Unprotected Linux Bootloader
The Grub bootloader on the {==laptop==} does not implement password protection, allowing a user to modify the boot options for the operating systems. This would allow an attacker to boot the system into single user mode by pressing "e" on the main Grub menu, and then appending the following line to the kernel options:

```
init=/bin/bash
```

The system would then boot into single user mode, providing them with a root shell. From this point they would have full administrative control of the system, and could remove any of the Linux security hardening or configuration options.
#### Impact: High
An attacker can gain full administrative control of the device, allowing them to bypass the majority of the implemented security restrictions.
#### Likelihood: Medium
Single user mode is a well-known technique to gain administrative access to a Linux system. However an attacker would require physical access to the system in order to exploit this vulnerability.
#### Recommendation
Ensure that the Grub bootloader is securely configured on all systems, with a strong and unique password, in order to prevent users from being able to modify the boot options. Additionally, consider hiding the Grub menu by setting the timeout to zero, and removing any other menu options that are not required. Note that kernel updates will often add new entries to the Grub menu, so these would need to be removed after an updated image was produced.
