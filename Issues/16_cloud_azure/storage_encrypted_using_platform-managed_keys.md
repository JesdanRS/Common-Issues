---
category: "CRY"
cvss: "N/A"
---
### Storage Encrypted Using Platform-Managed Keys
A number of resources in the environment are encrypted at rest using platform-managed keys (PMKs) instead of customer-managed keys (CMKs). Using CMKs allows organisations to have a more granular control over the data encryption and decryption process.

{==All Azure storage accounts, all virtual machine disks and all SQL servers were identified to be encrypted using Microsoft-managed keys.==}
#### Impact: Medium
Using PMKs gives less control over encryption keys and less visibility into how they are used. If a key is compromised, {==CLIENTNAME==} would not have an ability to revoke or rotate the key. This increases the risk of key compromise, as an attacker who gains access to a PMK can decrypt all of the resources that are encrypted with that key.
#### Likelihood: Low
An attacker would need to gain privileged access to the Azure infrastructure in order to exploit this issue which is not likely.
#### Recommendation
Review data protection requirements and ensure that they are appropriate for the sensitivity of the data stored. The following Microsoft articles provide further information on the use of customer-managed keys:

[https://learn.microsoft.com/en-us/azure/storage/common/storage-service-encryption]()
[https://learn.microsoft.com/en-us/azure/virtual-machines/disk-encryption]()
