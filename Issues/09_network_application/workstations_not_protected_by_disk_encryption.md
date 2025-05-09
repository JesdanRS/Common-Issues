---
category: "CRY"
cvss: "6.1"
---
### Workstations Not Protected by Disk Encryption
The sample workstation{s||} provided to Dionach did not utilise disk encryption. This would allow an attacker with physical access to a workstation to gain full control, and read or modify any information on the workstation{s||}. {==EITHER==} Discussion with IT staff indicated that encryption is not typically utilised for workstations or laptops. {==OR==} Discussion with IT staff indicated that encryption is typically only implemented on particularly sensitive systems such as laptops.
#### Impact: High
An attacker gaining physical access to a workstation, whether on the {==CLIENTNAME==} site, or if the machine was stolen or decommissioned, would have unrestricted access to the information stored on it. This may include sensitive information, saved login credentials, or local passwords.
#### Likelihood: Low
An attacker would need to gain unobserved physical access to a workstation. This is most likely to be performed by someone who has otherwise authorised access to internal system.
#### Recommendation
Consider implementing full disk encryption on all workstations in the {==CLIENTNAME==} network. There are a number of enterprise level solutions available, such as Microsoft BitLocker. Some vendors of IT systems include their own encryption software as part of a bundle.
