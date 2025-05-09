---
category: TBA
cvss: N/A
---
### Customer Managed Encryption Keys Not Rotated
Inspection of the customer managed keys showed that the keys are not being rotated automatically, the identified keys are listed below:

{==XREF_TABLE: Alias|ID==}

An example is shown below:

{==XREF_SCREENSHOT==}
#### Impact: Medium
An attacker compromising an encryption key will be able to use it to decrypt potentially sensitive data indefinitely or until the key is revoked or deleted. The level of sensitivity of data would depend on the type of data the key is encrypting.
#### Likelihood: Low
Encryption keys that are not periodically rotated are more likely to be compromised. However, an attacker would still need to gain access to the keys, for example by compromising a system where keys are stored.
#### Recommendation
Ensure that customer managed keys are automatically rotated on a yearly basis. Based on the sensitivity of data protected with encryption, consider rotating keys manually on a 90-days basis using aliases. The following pages from AWS provide more information:

[https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html]()
[https://aws.amazon.com/premiumsupport/knowledge-center/rotate-keys-customer-managed-kms/]()