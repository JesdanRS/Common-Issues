---
category: "ATH"
cvss: "TBA"
---
### Workstation Allows Alternative Boot
It was possible to boot the sample workstation ({==HOSTNAME==}) from alternative media, such as a removable USB device or CD-ROM. This could enable an attacker with physical access to the workstation, but lacking administrative credentials, to access sensitive information such as password hashes of local accounts which could be used to plan further attacks against {==CLIENTNAME==} resources.
#### Impact: Medium
A user could attempt to launch an alternative operating system in order to bypass restrictions or access sensitive data such as stored password hashes.
#### Likelihood: Medium
The layout and working pattern of {==CLIENTNAME==} makes it likely that this would be unnoticed, particularly if performed at the beginning or end of a normal working day.
#### Recommendation
Consider restricting system boot to a single local hard disk partition. This would need to be supported with a complex BIOS password to prevent unauthorised changes. A further level of security could be achieved by instituting full disk encryption. Note that in some cases BIOS passwords and restrictions can be removed with physical access to hardware.
