---
category: "PRV"
cvss: "TBC"
---
### Inconsistent and Inappropriate Access Control
Inspection of a number of network shares on the target systems revealed that access control is not applied consistently, and in some cases, access to sensitive data such as passwords or backups could be obtained by a low privileged user ("{==USER==}"), as shown in the following examples, {==with sensitive information masked where displayed==}.

{==EXAMPLES==}

Additionally, a number of shares were writable by a low privilege user ("{==USER==}"). As an example, the following directory was seen to contain {==OPTION installation files|software updates|live website files==} and can be written to:

{==EXAMPLE==}

As a result, malware would be able to spread to these shares, which could enable ransomware to spread over the {==CLIENT==} network quickly. Additionally, there are several techniques to capture domain users' Windows password hashes by modifying the content of writable shares, which could allow an attacker to either crack these hashes offline or relay users' net-NTLM connections to other systems in order to compromise those systems. For a full list of identified writable file shares, please see {==APPENDIX==}.

{==OPTION: Please note that due to the large number of servers and workstations within the scope of the test, a sampling approach was used to discover sensitive files. As a result, there might be additional sensitive files accessible by low privileged users which are not listed above.==}
#### Impact: High
A large amount of sensitive data can be accessed inappropriately by the low privileged user "{==USER==}", including configuration files which contain passwords. {==OPTIONAL It is also possible to modify data, or add malicious application code or malware intended to enable further network compromise.==}
#### Likelihood: High
The network shares and access control settings identified could be found and exploited by an attacker with access to the internal network.
#### Recommendation
Review all network shares{==, including those created by other applications or systems,==} to ensure that appropriate access control is enforced. Ensure that this access control is enforced in a consistent manner, using domain security group membership where possible. The following article contains further information about auditing file shares:

[https://www.dionach.com/blog/shareaudit-the-file-share-auditing-tool]()
