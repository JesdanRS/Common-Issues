---
category: "CNF"
cvss: "5.2"
---
### Windows Auto Logon Enabled
The affected Windows system{s||} {have||has} the automatic logon feature enabled using the {indicated||following} credentials:

{==HOSTS==}

Auto logon credentials are stored in clear text in the following registry keys:

```
HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\AutoAdminLogon
HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\DefaultPassword
```
#### Impact: Medium
Clear text domain credentials are available in the system registry, although discussions with IT staff indicated that the relevant account{s are|| is} specifically locked down for auto logon purposes.
#### Likelihood: Low
The credentials can be obtained by manual or automated inspection of the registry, through physical access to the system{s||} or through the exploitation of another vulnerability, such as the registry being remotely accessible. As an attacker would most likely need domain user credentials in order to access the auto logon credentials, there is little motivation to exploit this vulnerability.
#### Recommendation
Unless auto logon is specifically required it should be disabled. If there is a specific business requirement for the use of auto logon, ensure that the auto logon accounts are appropriately restricted and monitored for any suspicious activity.
