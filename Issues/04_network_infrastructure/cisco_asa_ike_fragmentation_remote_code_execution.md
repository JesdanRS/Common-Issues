---
category: "CNF"
cvss: "9.8"
---
### Cisco ASA IKE Fragmentation Remote Code Execution
The Cisco device{s||} listed above {are||is} is affected by a vulnerability in the Internet Key Exchange (IKE) implementation in the service running on port 500 (CVE-2016-1287).

An overflow condition can be achieved due to improper validation of user-supplied input when handling UDP packets. An unauthenticated attacker could exploit this issue to execute malicious code remotely in order to completely compromise the affected Firewall device. This could lead to exposure of internal services and allowing unintended inbound connections.

The example below shows crafted UDP packets being sent to the device using an open source verification script. The response indicates that the device is vulnerable.

{==PoC/script output==}

More information relating to this issue can be found at the following URL:

[https://tools.cisco.com/security/center/content/CiscoSecurityAdvisory/cisco-sa-20160210-asa-ike]()

Please note that whilst Dionach have confirmed that the device is vulnerable as shown above, active exploitation to gain remote code execution was not attempted, as this has a high likelihood of crashing the device, which would impact business operations.
#### Impact: High
An attacker could leverage this vulnerability to execute code remotely on the affected device and potentially perform privileged actions on the device, such as allowing inbound connections into the network or exposing internal services. This could lead to remote access to and compromise of the internal network. Additionally, an attacker could cause a denial of service by crashing the device.
#### Likelihood: High
This vulnerability has been publicly disclosed and exploits are available to actively exploit this overflow condition. Automated scanning tools are able to detect this vulnerability remotely. Additionally, no authentication is required in order to exploit this vulnerability.
#### Recommendation
Install the latest version of Cisco ASA software on the device. Consult the following resources for more information on updating Cisco ASA software:

[https://www.cisco.com/c/en/us/td/docs/security/asa/upgrade/asa-upgrade.html]()