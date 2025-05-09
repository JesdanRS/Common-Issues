---
category: "MAL"
cvss: "N/A"
---
### Database Advanced Threat Protection Not Configured
{== OPTION As with all cloud issues, be careful of recommending vendors paid features. This issue relates to a paid feature. Depending on the customers scenario you may wish to make this an informational issue and change the wording to say that this is available if they want it.==}

The "{==DATABASE NAME==}" database does not use the "Advanced Threat Protection" (ATP) option offered by Microsoft, as shown in the screenshot below. ATP detects anomalous activities indicating unusual and potentially harmful attempts to access or exploit the database.

{==XREF_SCREENSHOT==}
#### Impact: Medium
Attacks on the core database may not be detected in a timely manner, which could result in serious ramifications for {==CLIENTNAME==}.
#### Likelihood: Low
An attacker would need to exploit another vulnerability in order to leverage on this issue.
#### Recommendation
Consider enabling the "Advanced Threat Protection" option on critical Azure assets. Further details can be found at the following URL:

[https://docs.microsoft.com/en-us/azure-advanced-threat-protection/what-is-atp]()