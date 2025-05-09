---
category: "UPD"
cvss: "TBC"
---
### Old Versions of vCenter
The affected system{s||} {were||was} running {||an }outdated version{s||} of VMware vCenter. The latest version of vCenter is {==VERSION==} (build {==BUILD==}). {==Check [https://kb.vmware.com/s/article/1014508]() and update as appropriate ==}

{==HOSTS==}
#### Impact: High
There have been a number of reported security vulnerabilities in the version{s||} of vCenter listed above, which could lead to {==privilege escalation, authentication bypass and code execution, or could be used to cause a denial of service==}. Additionally, old versions of vCenter include bundled installations of outdated versions of third-party software such as Java and Apache Tomcat.
#### Likelihood: Medium
The majority of the vulnerabilities reported in the version{s||} above have been privately disclosed and as such no exploit code is publicly available. As the server{s||} above are critical to operations, {they are||it is} more likely to be the target of an internal attack than other less critical systems would be.
#### Recommendation
Test and upgrade to the latest version of vCenter. Review patch management processes to ensure that all hosts are patched and updated in a timely manner.
