---
category: "CRY"
cvss: "2.4"
---
### BitLocker Only Encrypts Used Space
The laptop{s use|| uses}  BitLocker for disk encryption; however, BitLocker has been configured to only encrypt used space on the drive, rather than encrypting the entire disk.
#### Impact: Medium
Information that was previously stored on the drive before Windows was installed may still be present in the unused areas of the disk. This could include potentially sensitive personal information, system configuration or password hashes.
#### Likelihood: Low
Discussion with {==CLIENTNAME==} staff indicated that the laptops would never have any sensitive data stored on them prior to being encrypted, as newly purchased laptops would have only the factory image, and the Windows build would then be installed on top of this. However, there is a potential for data to be exposed if the Windows image is deployed to older systems that have previously been used unencrypted at some point.
#### Recommendation
Configure BitLocker to encrypt the full disk, rather than just used space. This can be done by setting the encryption type to "Full Encryption" in Group Policy, as discussed in the article below. Please note that this policy will only affect systems encrypted after the policy is defined. Existing systems must be unencrypted and re-encrypted in order to fully encrypt the disks.

[https://docs.microsoft.com/en-us/windows/security/information-protection/bitlocker/bitlocker-group-policy-settings#bkmk-detypefdd]()
