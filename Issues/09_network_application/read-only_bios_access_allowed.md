---
category: "PRV"
cvss: "2.4"
---
### Read-Only BIOS Access Allowed
The affected system{s||} allow{s||} read-only access to the BIOS. Whilst changing any configuration required the use of a password, a large amount of information relating to the computer{s||}, including firmware versions and installed hardware, can be obtained.

{==OPTION==} It was also possible to select alternate boot devices without entering a password (see section {==XREFAlternateBoot==}.
#### Impact: Low
Unnecessary system information is exposed.
#### Likelihood: Medium
Accessing the BIOS is a straightforward and routine activity whenever information about a physically accessible computer system is required. The process to access the BIOS on most devices is generally consistent, requiring only the pressing of a key such as F10, and is well-documented.
#### Recommendation
Consider requiring a password to access the BIOS, if supported by the computer{s||}. {==OPTION==} Configure the computer{s||} to require a password to boot from alternate devices. If this is not supported, review the information exposed, and undertake a risk assessment to determine the acceptability of this information leakage. Please note that, in most cases, much of this information can be obtained through physical examination of the computer hardware.
