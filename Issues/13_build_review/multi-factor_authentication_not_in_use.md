---
category: "TBA"
cvss: "TBA"
---
### Multi-Factor Authentication Not in Use
{==Best practices|NCSC==} suggest to use a secondary credential mechanism in order to unlock the device after booting, such as Windows Hello for Business. Windows Hello for Business allows a user to log in with a PIN code or biometrics linked to the device. In this way a strong multi-factor authentication mechanism is enforced.

Although a PIN could be seen to be similar to a password, with Windows Hello for Business it allows the following features:

 * PIN is tied to the device, meaning that the PIN cannot be used anywhere except on that specific device. If a PIN is compromised it cannot be easily re-used by an attacker.
 * PIN can be backed by hardware (TPM), which includes multiple physical security mechanisms to make it tamper resistant, and malicious software is unable to tamper with the security functions of the TPM.
 * PIN can be complex and subject to the same level of restrictions and policies as a password.
#### Impact: Medium
If multi-factor authentication is not in use, an attacker gaining access to the user's password will be able to authenticate as that user on any machine connected to the network.
#### Likelihood: Medium
An attacker would need to have a valid password in order to exploit the lack of multi-factor authentication.
#### Recommendation
Consider the use of multi-factor authentication, such as Windows Hello for Business, for user devices. Further information on Windows Hello for Business can be found at the following Microsoft article:

[https://docs.microsoft.com/en-us/windows/access-protection/hello-for-business/hello-identity-verification]()
