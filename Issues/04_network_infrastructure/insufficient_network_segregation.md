---
category: "NET"
cvss: "6.1"
---
### Insufficient Network Segregation
{==OPTION1==}There is insufficient network segregation without clear separation of systems by sensitivity in the {==CLIENTNAME==}'s internal network. As result, an attacker with an access to the internal network would be able to launch further attacks against sensitive servers or applications.
{==OPTION2==}The {==CLIENTNAME==}'s internal network is separated into different subnets. However, there is no segregation between these subnets and no clear separation of systems by sensitivity. As such, an attacker compromising a host in any one of these subnets will gain unrestricted access to all of {==CLIENTNAME==}'s internal networks or resources.
#### Impact: Medium
An attacker compromising an internal system will gain unrestricted access to {==CLIENTNAME==}'s internal network. This will potentially allow them to access and compromise key systems in order to gain access to confidential data. {==OPTION==} Additionally, broadcast protocols were seen to be enabled (see section {==XREF_Broadcast_Protocols==}), giving the opportunity to the attacker to capture NTLM hashes in order to crack them or execute SMB relay attacks.
#### Likelihood: Medium
An attacker would need access to the internal network in order to exploit this issue. For example, this attack can be performed by a disgruntled employee, through a compromised internal system, via {==OPTION==} the guest wireless network or gaining physical access to {==CLIENTNAME==}'s office.
#### Recommendation
Segregate the internal network so that systems are grouped according to functionality and sensitivity levels. Use VLAN, routing, and firewall configurations to enable tightly controlled traffic flows. Ensure that any systems which process, store, or transmit data are appropriately isolated and access is tightly controlled.

The use of jump boxes or bastion hosts can be used to allow administrative access to systems in a segregated environment in a controlled manner. Please refer to the following NCSC article for further information:

[https://www.ncsc.gov.uk/collection/secure-system-administration/protect-your-administration-interfaces]()
