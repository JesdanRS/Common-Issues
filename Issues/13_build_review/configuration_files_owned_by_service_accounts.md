---
category: "CNF"
cvss: "N/A"
---
### Configuration Files Owned By Service Accounts
The configuration file{s for the services below are| for the SERVICENAME service is} owned by the respective service account{s||}, as shown in the example{s||} below:

```
$ ls -l /etc/{==CONFIGFILE==}
{==OUTPUT==}
```
#### Impact: Medium
If an attacker is able exploit a vulnerability in {one of these services|this service}, they would be able to modify the configuration file{s||}. This could allow them to re-configure the service to disable other security features, or to allow exploitation of other systems.
#### Likelihood: Low
An attacker would need to identify and exploit a vulnerability in {one of these services||this service} in order to take advantage of this issue.
#### Recommendation
Ensure that service configuration files are owned by root, and that the service user account does not have permissions to write to the files.
