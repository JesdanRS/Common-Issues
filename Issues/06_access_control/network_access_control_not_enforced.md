---
category: "NET"
cvss: "4"
---
### Network Access Control Not Enforced
It was possible to connect any network device to the internal network and begin accessing network services, provided that an active and patched network port was available. This indicates that no centralised access control is enforced on the network itself, although access control to specific resources is enforced by use of local or Active Directory domain authentication and authorisation.
#### Impact: Medium
An internal user could connect their own laptop or network device to the internal network in order to gather information, bypass restriction policies, or attempt to compromise the internal network.
#### Likelihood: Low
The layout of the office and the working pattern of {==CLIENTNAME==} makes it likely that an attempt to attach local network devices would be unnoticed. Exploiting this issue to access internal resources would require the use of valid credentials, or would require an attacker to exploit other vulnerabilities in the network, which may deter internal users.
#### Recommendation
Consider implementing network access control. There are a number of potential mechanisms for achieving this, including anti-virus quarantining, remote access filtering and patch scanning. The following articles give examples of potential solutions:

Microsoft Network Access Protection
[https://learn.microsoft.com/en-us/previous-versions/windows/it-pro/windows-server-2012-R2-and-2012/hh831683(v=ws.11)]()

Cisco Network Admission Control
[https://www.cisco.com/c/en/us/products/collateral/security/nac-appliance-clean-access/product_data_sheet0900aecd802da1b5.html]()
