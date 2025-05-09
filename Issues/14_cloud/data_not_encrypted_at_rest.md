---
category: "CRY"
cvss: "4.7"
---
### Data Not Encrypted at Rest
{==OPTION AWS==} Inspection of the S3 buckets revealed that encryption at rest is not enforced {==OPTION==}consistently. The screenshot below shows a backup of the {==NAME==} bucket which is not encrypted.

{==[SCREENSHOT OF BUCKET ENCRYPTION PROPERTIES]==}

{==OPTION AZURE==} The operating system volumes of the Azure virtual machines available in the "{==RESOURCEGROUP==}" resource group are not encrypted, as shown in the screenshot below:

{==[IMAGE]==}
#### Impact: High
As data is not encrypted at rest, an attacker gaining access to a virtual hard disk could exploit this to gain access to data stored on the disk.

{==OPTION AWS==} Buckets containing {==CLIENTNAME==} information could be accessible by an attacker who has compromised AWS servers or a valid access key (see section {==XREFKeyDisclosure==}).

{==OPTION AZURE==} An attacker gaining access to the virtual hard disks would have unrestricted access to the information stored on it. This may include sensitive information, saved login credentials, or local passwords.
#### Likelihood: Low
{==OPTION AWS==} An attacker would still need to compromise the server which hosts unencrypted S3 buckets of {==CLIENTNAME==} or obtained valid AWS access.

{==OPTION AZURE==} An attacker would have to gain access to a workstation of a user who has downloaded a copy of the virtual hard disk.
#### Recommendation
{==OPTION AWS==} Consider enforcing server side encryption on all S3 buckets. Please see the following URL for further information:

[https://docs.aws.amazon.com/AmazonS3/latest/dev/bucket-encryption.html]()

{==OPTION AZURE==} Enable and deploy Azure Disk Encryption on all virtual hard disks. In addition, ensure secure key management procedures are in place. The Azure Key Vault is one possible solution.

More information can be found at the following URL:

[https://docs.microsoft.com/en-gb/azure/security/fundamentals/azure-disk-encryption-vms-vmss]()
