---
category: "CNF"
cvss: "N/A"
---
### Diagnostic Settings Not Configured
A large number of resources were found to not have diagnostic settings enabled, as shown in the example below:

{==https://portal.azure.com/#view/Microsoft_Azure_Monitoring/AzureMonitoringBrowseBlade/~/diagnosticsLogs==}

{==SCREENSHOT==}
#### Impact: Medium
Should an incident occur, an investigation may be hindered by insufficient availability of logs about Azure resources.
#### Likelihood: Low
An incident requiring logs for investigation would need to occur for this issue to have an impact for the organisation.
#### Recommendation
Review the above resources and ensure that any diagnostic settings reflect the log retention requirements of organisational policies. Ensure that production resources have diagnostic settings enabled.
