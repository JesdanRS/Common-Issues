---
category: "CNF"
cvss: "3.1"
---
### Storage Secure Transfer Not Enabled
The following storage account{s||} did not have the "Secure transfer required" option enabled. This allows requests to the accounts from insecure connections (e.g. HTTP instead of HTTPS).

{==ACCOUNT_LIST==}
#### Impact: Medium
An attacker could sniff sensitive information transmitted by storage account{s||} off the network.
#### Likelihood: Low
To sniff sensitive information from a storage account an attacker on another host would need to use an attack such as ARP poisoning.
#### Recommendation
Consider enabling the "Secure transfer required" option on critical Azure assets. Further details on how to enable the "Secure transfer required" option can be found at the following URL:

[https://docs.microsoft.com/en-us/azure/storage/common/storage-require-secure-transfer]()