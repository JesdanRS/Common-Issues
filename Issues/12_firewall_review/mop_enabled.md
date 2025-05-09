---
category: "CNF"
cvss: "TBA"
---
### MOP Enabled
The Maintenance Operation Protocol (MOP) was enabled on the interfaces of the device{s||} listed above. MOP is used for utility services such as uploading and downloading system software, remote testing and problem diagnosis.
#### Impact: Medium
Running unused services increases the device's exposed attack surface and increases the likelihood of an attacker finding a security hole or fingerprinting a device.
#### Likelihood: Low
A number of tools such as DECnet are available which could be used to interact with the MOP service.
#### Recommendation
Disable MOP on all ethernet interfaces by adding the command below to their configuration. If it is required, MOP only poses a low risk, consider an internal risk assessment regarding leaving MOP enabled.

```
no mop enable
```
