---
category: "CNF"
cvss: "N/A"
---
### Insufficient Rotation of Storage Accounts Access Keys
Automated scanning of Azure resources indicated that the access keys used for Azure Storage Accounts are not rotated periodically, for example every 90 days.
#### Impact: Medium
An attacker compromising an access key would be able to use it to perform malicious activities against the storage indefinitely or until the key is revoked or deleted.
#### Likelihood: Low
Access keys that are not periodically rotated are more likely to be compromised, for example as a result of sharing keys. However, an attacker would still need to gain access to the keys, for instance by compromising a system where keys are stored.
#### Recommendation
Consider periodically rotating access keys as recommended by Microsoft best practices. If using the Azure Key Vault, it is possible to automatically rotate the access keys periodically, this could be every 90 days. Based on the sensitivity of every storage account, access keys could be rotated less frequently.

If it is not possible to use the Key Vault and to automatically rotate the access keys, it may be possible to achieve this programmatically by leveraging Azure PowerShell. The following page shows an example:

[https://learn.microsoft.com/en-us/azure/storage/scripts/storage-common-rotate-account-keys-powershell]()
