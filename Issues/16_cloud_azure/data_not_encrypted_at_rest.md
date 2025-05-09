---
category: "CRY"
cvss: "4.7"
---
### Data Not Encrypted at Rest
The operating system volume of the "{==NAME(s)==}" Azure virtual machine available in the "{==NAME(s)==}" resource group is not encrypted, as shown in the screenshot below:

{==XREF_SCREENSHOT==}
#### Impact: Medium
As data is not encrypted at rest, an attacker gaining access to a virtual hard disk could exploit this to gain access to data stored on the disk. An attacker gaining access to the virtual hard disk would have unrestricted access to the information stored on it. This may include sensitive information, saved login credentials, or local passwords.
#### Likelihood: Low
An attacker would have to gain access to a workstation of a user who has downloaded a copy of the virtual hard disk.
#### Recommendation
Enable and deploy Azure Disk Encryption on all virtual hard disks. In addition, ensure secure key management procedures are in place. The Azure Key Vault is one possible solution. More information can be found at the following URL:

[https://docs.microsoft.com/en-us/azure/security/fundamentals/azure-disk-encryption-vms-vmss]()