---
category: "PRV"
cvss: "N/A"
---
### Root Account In Active Use
The privileged AWS generic root account appears to be in active use which may prevent tracking of specific actions conducted by individual administrative staff. The most recent usage of the root account was found to be {==NUMBER==} days before the AWS technical security audit date which suggests that the root account is actively used. The root account is highly privileged and only certain administrative AWS tasks require such access.
#### Impact: High
If this account is compromised, it would immediately lead to a complete compromise of the {==CLIENTNAME==} AWS infrastructure. Actions performed with this account could affect service availability, as well as the confidentiality and integrity of data. Additionally, if the shared root account is frequently used it is very difficult to trace system access and activities to particular individuals.
#### Likelihood: Low
An attacker would need to know the password for the shared root account, for example a disgruntled employee, or have compromised credentials for example via social engineering. {==OPTION==}However, multi-factor authentication (MFA) is enabled on this account, so the root password in isolation would not grant access to the AWS environment.
#### Recommendation
All users should use an individual, named account with permissions applied using the principle of least privilege.

Ownership of the root account should be split between at least two different parties, for example the developers knowing the account password and developers in possession of the MFA key. This ensures that use of the root account can be monitored and assists in enforcing strict change management procedures around the use of the account.

The following page provides more information on managing the AWS root account securely:

[https://summitroute.com/blog/2018/06/20/managing_aws_root_passwords_and_mfa/]()
