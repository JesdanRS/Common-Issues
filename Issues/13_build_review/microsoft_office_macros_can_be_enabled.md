---
category: TBA
cvss: TBA
---
### Microsoft Office Macros Can be Enabled
A review of the {==laptop==} showed that Microsoft Office macros can be allowed and executed. Although macros are currently disabled by default, they can be enabled by the user, as shown below:

{==PoC==}

As a result, any malicious macro contained in Microsoft Office documents could execute arbitrary code in the background without the user being aware.
#### Impact: High
Malicious code could be executed through Microsoft Office documents sent to users. This could allow remote attackers to compromise {==the host==} and gain an initial foothold in the internal network, which would allow them to compromise further systems and data.
#### Likelihood: Low
Although security warnings will be shown, an attacker could trick users into enabling malicious content. An element of social engineering would be required for this attack to be successful.
#### Recommendation
If macros are not specifically required, they should be fully disabled by enforcing the "Disable all macros without notification" setting under "File > Options > Trust Center > Trust Center Settings > Macro Settings" for all Microsoft Office software. Please refer to the following article for further information:

[https://www.microsoft.com/en-us/security/blog/2016/03/22/new-feature-in-office-2016-can-block-macros-and-help-prevent-infection/?source=mmpc]()

Finally, the following article from NCSC provides advice in mitigating the risk from macros in corporate environments in detail:

[https://www.ncsc.gov.uk/guidance/macro-security-for-microsoft-office]()
