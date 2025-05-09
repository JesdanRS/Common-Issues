---
category: "PRV"
cvss: "8.8"
---
### Files Contain Credentials in Clear Text
A review of the file shares available to the domain user "{==USER==}" revealed several files which contained credentials, and other potentially sensitive system information {==such as connection strings==}, in clear text. Some examples of these are shown below, with passwords masked where displayed. Please note that other files, not identified during testing, may also be present which contain credentials in clear text.

{==EXAMPLES==}
#### Impact: High
Anyone obtaining these credentials could use them to authenticate to other systems. Attackers would also test any obtained passwords against other user accounts to attempt to escalate privileges or access sensitive data.
#### Likelihood: High
These credentials would be identified through manual inspection of available network shares (see section {==XREF==}).
#### Recommendation
Ensure that files containing clear text credentials are created only when absolutely necessary, and that these are stored securely to prevent disclosure. {==OPTIONConnectionString==} Where possible, consider using integrated Windows authentication rather than mixed mode authentication (see section {==XREFMixedModeAuth==}) to avoid the need to store credentials in connection strings.

Also consider performing a regular review of network shares to ensure no sensitive content is stored inappropriately. The following link provide guidelines on how to find sensitive information in file shares:

[https://www.dionach.com/blog/discovering-sensitive-information-in-file-shares]()
