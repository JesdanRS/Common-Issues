---
category: "MAL"
cvss: "5.3"
comment: |
  Decrease likelihood depending on how common this finding is on systems within the tested environment.
---
### Outdated Antivirus Signature Definitions
The following hosts were running outdated antivirus signature definitions. Although these definitions should be updated daily, the last definitions were several {==days/weeks/years==} old on several hosts.

{==TABLE==}

{==OPTION==}Note that due to the large number of servers and workstations within the scope of the test, a sampling approach was used, and other hosts may use outdated definitions.
#### Impact: High
The antivirus definitions are outdated, which means that any virus signatures released since the last update will not be included in the software. This could result in the systems being infected with known malware.
#### Likelihood: Medium
An out-of-date antivirus database will not detect known malware identified after the database release date. {==OPTION==}However, most systems within the {==CLIENTNAME==} network had up to date antivirus signatures.
#### Recommendation
Ensure that all systems are configured to receive automatic updates of antivirus definitions and antivirus software as soon as they are released. Ensure that there is a process to monitor or alert on active hosts without recent definition updates so that issues can be triaged and remediated.
