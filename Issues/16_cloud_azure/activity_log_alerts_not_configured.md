---
category: "TBA"
cvss: "TBA"
---
### Activity Log Alerts Not Configured
No custom Activity Log alerts have been configured to monitor and alert to specific privileged or sensitive actions being performed in the tenant.

The CIS Microsoft Azure Foundations Benchmark recommends that alerts be configured for the following events:

* Create Policy Assignment
* Delete Policy Assignment
* Create or Update Network Security Group
* Delete Network Security Group
* Create or Update Network Security Group Rule
* Delete Network Security Group Rule
* Create or Update Security Solution
* Delete Security Solution
* Create or Update or Delete SQL Server Firewall Rule

Please note that the events for which alerts should be configured varies between organisations and the specific services and resources in use within the tenant.
#### Impact: Medium
Privileged or sensitive actions may be performed within the tenant, either by a malicious actor or otherwise outside of normal change control processes and may not be detected due to a lack of alerting. This could also result in a compromise of the tenant going unnoticed.
#### Likelihood: Low
An attacker would first need to compromise the tenant in order to exploit this issue.
#### Recommendation
Review the available alerts within Activity Monitor and configure appropriate alerts when sensitive or privileged actions are performed. Further information regarding Activity Monitor alerts is available at the following URL:

<https://docs.microsoft.com/en-us/azure/azure-monitor/alerts/activity-log-alerts>
