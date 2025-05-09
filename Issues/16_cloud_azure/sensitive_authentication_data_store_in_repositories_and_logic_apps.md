---
category: "PWD"
cvss: "7.2"
---
### Sensitive Authentication Data Store in Repositories and Logic Apps
A number of Logic Apps reviewed were seen to have sensitive authentication data, such Azure client IDs and secrets, stored in clear text in the Logic app code, as shown in the examples below.

{==LogicAppName==}

```MASKED SENSITIVE DATA```
#### Impact: High
An attacker gaining access to the credentials, such as {==corporate credentials, API keys and tenant secrets will be able to authenticate to systems using those credentials==}. This will potentially give them permissions to access and modify {==CLIENTNAME==} data.
#### Likelihood: Low
API and tenant secret keys will be accessible to unauthorised Azure portal operators, however an attacker would need to have a valid Azure account to access the keys in the Logic App code.
#### Recommendation
Do not store any secret values as part of code. Consider using a managed identity and Key Vault to allow the Logic Apps to retrieve secrets with secure Key Vault access policies and firewall rules. Additionally, ensure that secrets are hidden from Runs History using Secure Input/Secure Output configuration which is available for Logic Apps Actions and Triggers.

Please refer to the following URL for more information:

[https://learn.microsoft.com/en-us/azure/logic-apps/logic-apps-securing-a-logic-app?tabs=azure-portal]()
