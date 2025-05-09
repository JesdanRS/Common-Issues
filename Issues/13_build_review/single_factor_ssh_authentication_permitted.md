---
category: "ATH"
cvss: "N/A"
comment: |
  This issue should only be reported on build reviews where the configuration file has been reviewed. It is not possible to accurately verify the number of factors required from attempting to authenticate to the service alone, as it is possible to configure a password prompt before other methods.
---
### Single Factor SSH Authentication Permitted
All of the systems within the environment require only a single factor (either a password or an SSH key) in order to authenticate to them.
#### Impact: Medium
An attacker obtaining either a user's password or SSH key would be able to authenticate on the systems, and potentially gain full administrative control if they had compromised the user's password. {==OPTION==} Note that a number of users were seen to have weak passwords, as discussed in section {==XREFWeakLinuxPasswords==}.
#### Likelihood: Low
An attacker would need to obtain either a password or an SSH key in order to exploit this issue.
#### Recommendation
Consider configuring the servers to require multi-factor authentication. {==OPTION==} This can be done by setting the following directive in the OpenSSH configuration file to require the use of both an SSH key and a password:

```
RequiredAuthentications2 publickey,password
```

{==OPTION==} There are a number of mechanisms that can be used to achieve this in Windows, such as the use of smart cards, as detailed in the following Microsoft documentation.

[https://docs.microsoft.com/en-gb/windows/security/identity-protection/smart-cards/smart-card-architecture]()
