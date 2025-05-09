---
category: "{==APP-CNF/CNF==}"
cvss: "5.3"
---
### NTP Reveals Host Information
Information about the affected system{s||} can be determined by querying the Network Time Protocol (NTP) variables, including the OS descriptor and time settings, as shown below.
#### Impact: Low
Although this does not allow an attacker to cause any immediate damage to the network, it does unnecessarily give away useful information that may help formulate an attack strategy.
#### Likelihood: Medium
Sending a query to NTP is a simple and common information gathering technique.
#### Recommendation
Restrict default access to ignore all NTP information packets. Update the NTP server software if required. Ensure that the NTP server{s are|| is} updated to the latest available version, as older releases have been vulnerable to buffer overflow issues.
