---
category: "PRV"
cvss: "6.3"
---
### No Role Based Access Control on Azure Storage Accounts
A review of the Azure storage accounts revealed that Role Based Access Control (RBAC) was not configured. As such, any user or system with access to the storage account has full control of all of the information stored within them. The {following storage accounts were||storage account XREF_NAME was} identified without RBAC{:||.}

{==ACCOUNTS==}

{==OPTION==} Please note that these appear to be classic storage accounts (see section {==XREF_ClassicAcc==}), rather than the newer Azure Resource Manager storage accounts, and that RBAC is not available on classic accounts. Note that other security features such as Storage Service Encryption (SSE) are also unavailable on classic storage accounts (see section {==XREFNoStorageServiceEncryption==}).
#### Impact: Medium
An attacker compromising a system that utilises {one of||} the storage account{s||} would gain full control of all the data within the storage account{s||}, potentially allowing them access to compromise other systems that also relied rely on that storage account.
#### Likelihood: Low
An attacker would need to compromise a system or user with access to {one of||} the storage account{s||} in order to exploit this issue.
#### Recommendation
Consider migrating the data within the classic storage accounts into Azure Resource Manager storage accounts, which would allow RBAC to be used to configure granular access on user accounts. This access should be granted based on the principle of least privilege, with accounts only being granted the minimum level of access required for their function. The following Microsoft article contains further information about RBAC:

[https://docs.microsoft.com/en-gb/azure/storage/blobs/security-recommendations]()