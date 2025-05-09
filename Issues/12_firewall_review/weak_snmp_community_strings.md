---
category: "TBA"
cvss: "TBA"
---
### Weak SNMP Community Strings
The network devices below were seen to make use of SNMP, and used a weak SNMP community string, which allows an attacker to read and potentially modify configuration information on the devices.

{==List devices, snmp version, access type (read/write), and MASKED community strings==}
#### Impact: Medium
An attacker with read access to the SNMP service would be able to enumerate a large amount of information about the device, its configuration, network details and more. This information could subsequently be used as part of a targeted attack.
{==OPTION write access==} An attacker with write access to the SNMP service may be able to retrieve and modify the full device configuration. This could lead to an attacker gaining complete control of the device and traffic that is permitted through.
#### Likelihood: Medium
Weak community strings increase the chance of a successful dictionary-based or brute-force attack. There are a number of tools available that an attacker could use for this and they do not require any advanced skills on behalf of the attacker.
#### Recommendation
If SNMP access is not required, it should be disabled. If SNMP is required, upgrade the service to make use of version 3 only, and ensure that authentication and encryption are enabled. If the device does not support version 3 or as a temporary short-term fix, ensure that the community string is changed to a value that is unique and difficult to guess. {==OPTION if Cisco==} For more information on configuring this for Cisco ASA, please see the following link:

[https://www.dionach.com/blog/cisco-asa-firewall-hardening/#use_non_default_community]()
