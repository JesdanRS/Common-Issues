---
category: "PRV"
cvss: "N/A"
---
### Over Privileged Service Bus Accounts
A review of the Azure service bus accounts revealed that the following service buses have no restricted or lower-privileged accounts configured. The following service buses only have a single shared access policy configured ("{==POLICY_NAME==}"), which has full control over them:

{==SERVICE_BUSES==}

{==OPTION==}The following service buses have an additional shared access policy ("admin"), which also has full control:

{==SERVICE_BUSES==}
#### Impact: Medium
Any authenticated access to these service buses would be made using an account with full control over them, including the ability to manage or reconfigure them. If a system using these service buses was compromised, an attacker would gain full control over the services buses, allowing them to cause a denial of service, or potentially to send arbitrary messages or intercept messages intended for other systems.
#### Likelihood: Low
An attacker would need to compromise a system using one of the service buses in order to gain access to them.
#### Recommendation
Where full management rights over the services buses are not required by the application, ensure that the created shared access policies provide only the minimum rights required for the application. Additionally, where possible these should be applied to the individual queues or topics, rather than to the service bus itself.