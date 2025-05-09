---
category: "{==APP-DAT/NET==}"
cvss: "TBC"
---
### SNMP Externally Available
The affected system{s||} ALLOW{s||} external connections using the Simple Network Messaging Protocol (SNMP) over UDP port {==161==}.

By default SNMP is a clear text protocol, and is also vulnerable to brute-force or dictionary attacks against the community string. {==OPTION SNMPv3==} Please note that in this case SNMP v3, which offers encryption and secure authentication mechanisms, appears to be in place.
#### Impact: Medium
{==OPTION SNMPv1,2==} An attacker could obtain potentially sensitive information relating to network devices if they intercept SNMP traffic or successfully identify a valid community string. {==OPTION SNMPv3==} An attacker exploiting a misconfiguration or vulnerability in the SNMP service could potentially obtain sensitive information relating to network devices.
#### Likelihood: Low
An attacker would need to intercept the SNMP communication, or successfully identify a weak community string. {==OPTION SNMPv3==} Currently there are no known vulnerabilities for SNMP v3, however an attacker could attempt to guess or brute-force credentials to successfully authenticate to the service.
#### Recommendation
If SNMP is not required externally, it should be disabled, or filtered to only allow access from trusted IP addresses. {==OPTION SNMPv1,2==} Consider using SNMPv3 which supports username and password authentication, and encrypted communication. {==OPTION SNMPv3:==}Ensure that SNMP is configured to use the security mechanisms for authentication and privacy. Please see the following URL for further information:

[https://www.snmp.com/snmpv3/snmpv3_intro.shtml]()
