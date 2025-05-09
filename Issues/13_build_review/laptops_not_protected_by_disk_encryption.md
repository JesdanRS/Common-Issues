---
category: "MOB"
cvss: "6.8"
---
### Laptops Not Protected by Disk Encryption
The sample laptop {==LAPTOP==} provided for testing did not utilise disk encryption. This would allow an attacker with physical access to a laptop to gain full control, and read or modify any information on the laptop.
#### Impact: High
An attacker gaining physical access to a laptop, whether onsite, or if the machine was stolen or decommissioned, would have unrestricted access to the information stored on it. This may include sensitive information, saved login credentials, or local passwords.
#### Likelihood: Medium
An attacker would need to gain unobserved physical access to a laptop. This is most likely to occur if the laptop is stolen, either from the office or while it has been taken offsite.
#### Recommendation
Consider implementing full disk encryption on all laptops. There are a number of enterprise level solutions available, such as Microsoft BitLocker. Some vendors of IT systems include their own encryption software as part of a bundle.
