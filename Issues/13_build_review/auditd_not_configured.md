---
category: "LOG"
cvss: "N/A"
---
### Auditd Not Configured
The Auditd access monitoring and accounting service is installed on the {servers below||HOSTNAME server}; however, it does not appear to be configured. Auditd is integrated tightly with the Linux kernel and provides detailed access monitoring and accounting. The server{s||} do not have any rules configured in Auditd, and as a result, only the default auditing is in place.
#### Impact: Medium
The lack of sufficient audit logs could impact {==CLIENTNAME==}'s ability to identify suspicious activities and could hinder post incident investigations.
#### Likelihood: Low
Linux systems provide a level of logging by default, although it is not as granular as the logs provided by Auditd. These logs would typically only be required in the event of a system compromise.
#### Recommendation
Consider configuring Auditd rules and enabling the service. Please refer to the following article for further information:

[https://access.redhat.com/documentation/en-us/red_hat_enterprise_linux/6/html/security_guide/chap-system_auditing]()
