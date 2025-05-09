---
category: "TBC"
cvss: "TBC"
---
### Insufficient Event Logs Rotation Policy and Management
Systems {==within the domain==} were found to only retain audit logs locally for a short period of time. For example, the domain controller {==DCNAME==} was seen to have approximately {==NUMBER==} days of security logs stored, as shown below:

{==SCREENSHOT==}
#### Impact: Medium
Events recorded by domain controllers and other servers may not be available when required for investigation. Information critical to post-incident analysis may be lost as a result.
#### Likelihood: Medium
Windows systems generate a large quantity of event log information by default and will quickly reach the maximum default log size.
#### Recommendation
Review event log configurations on the domain controllers, and on any other production systems. Where possible, centralise log collection with an appropriate retention policy. Determine appropriate events to record, such as login success and failure, appropriate metrics by which these events can be assessed, and an appropriate log review schedule to process recorded events. Further information on how to configure the retention policy can be found at the following URL:

[https://docs.microsoft.com/en-us/troubleshoot/windows-server/group-policy/set-event-log-security-locally-or-via-group-policy]()

Although log retention time should depend on the type and the criticality of logs, as well as the Group policy in use, consider keeping logs for at least 90 days.
