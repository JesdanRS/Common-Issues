---
category: "TBA"
cvss: "TBA"
---
### Network Devices Use Insecure SNMP Versions
Inspection of the configuration of the network devices listed below revealed that SNMP is used to monitor the devices. {==OPTION SNMP v1 || SNMP v2c==} is a clear text protocol, and is also vulnerable to brute force or dictionary attacks against the community string.

{==List devices using version 1 or 2c in table==}
#### Impact: Medium
An attacker could obtain potentially sensitive information relating to network devices if they intercept SNMP traffic or successfully identify a valid community string.
#### Likelihood: Low
An attacker would need to gain access to the internal network, in order to intercept the SNMP communication or successfully identify a weak community string in use.
#### Recommendation
Consider using SNMPv3 which supports username and password authentication, and encrypted communication. Please refer to the following  article for more information:

{==OPTION Cisco==} https://www.dionach.com/blog/cisco-asa-firewall-hardening/#snmp
{==OPTION other==} Link to vendor SNMP documentation
