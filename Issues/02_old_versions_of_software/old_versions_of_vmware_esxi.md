---
category: "UPD"
cvss: "TBC"
---
### Old Versions of VMware ESXi
The affected system{s||} {was||were} running an outdated version of the VMware ESXi hypervisor. At the time of writing, the latest build of ESXi 5.0 is {==BUILD==}, corresponding to version "{==NAME==}". The latest build of ESXi 5.1 is {==BUILD==}, corresponding to version "{==NAME==}". Please note that ESXi {==5.5==} {==NAME==} ({==BUILD==}) is also available. {==See [https://kb.vmware.com/s/article/2143832]() for further information regarding ESXi versions.==}

{==HOSTS==}
#### Impact: High
There have been a number of reported security vulnerabilities in the version{s of ESXi listed|| of ESXi} above, which could lead to a compromise of either the various guest virtual machines or the hypervisor{s||} itself, or could be used to cause a denial of service.
#### Likelihood: Medium
The vulnerabilities reported in the versions above are well documented. As the servers above are operationally critical, they are more likely to be actively targeted for an internal attack.
#### Recommendation
Test and upgrade to the latest version of ESXi. Review patch management processes to ensure that hypervisor hosts are patched and updated in a timely manner. vCenter Update Manager (VUM), which may be included with current vCenter licensing, could be used to automate this process. Further information regarding VUM is available from the following URL:

[https://www.vmware.com/support/pubs/vum_pubs.html]()
