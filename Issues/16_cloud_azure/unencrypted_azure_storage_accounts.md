---
category: "CRY"
cvss: "2.3"
---
### Unencrypted Azure Storage Accounts
A review of the Azure storage accounts revealed that the following accounts were not using Storage Service Encryption (SSE), which provides encryption of the information stored within them:

{==ACCOUNT_LIST==}

{==OPTION==}Please note that these appear to be classic storage accounts, rather than the newer Azure Resource Manager storage accounts, and that SSE is not available on classic accounts. {==OPTION==}Note that other security features such as Role Based Access Control (RBAC) are also unavailable on classic storage accounts (see section {==XREF_Classic_Storage_Account==}).
#### Impact: Medium
Any information stored within these accounts is stored unencrypted, which could potentially allow someone with access to the underlying Azure infrastructure to gain access to it. Additionally, it may impact on the {==CLIENTNAME==}'s compliance with data protection standards.
#### Likelihood: Low
An attacker would need to gain privileged access to the Azure infrastructure in order to exploit this issue.
#### Recommendation
{==OPTION Classic Storage==}Consider migrating the data within the classic storage accounts into Azure Resource Manager storage accounts and configure SSE to encrypt the information (see section {==XREF_Classic_Storage_Account==}). The following Microsoft article contains further information:

[https://docs.microsoft.com/en-us/azure/storage/common/storage-service-encryption]()

{==OPTION Misconfiguration==}Review data protection and secure disposal requirements and identify if any data or systems require additional protection prior to migrating it to Azure. Enable SSE on storage accounts that will be used to store sensitive data which has been identified as requiring additional protection. Please refer to the following Microsoft article for further information:

[https://azure.microsoft.com/en-gb/documentation/articles/storage-service-encryption]()