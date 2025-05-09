---
category: "UPD"
cvss: "TBC"
---
### Inconsistent Installation of Windows Updates
The affected servers {were||was} seen to have the latest Windows updates installed at the time of testing; however inspection of the update history showed that no updates have been installed between the {==DATE==} and the {==DATE==}:

{==SCREENSHOT==}
#### Impact: High
The server{s||} received no updates for approximately {==NUMBER==} months, and as such became increasingly vulnerable during this time to both remote exploitation and local privilege escalation.
#### Likelihood: High
A large number of vulnerabilities were published during this period, some of which had public exploit code available. {==OPTION==} Automatic updates are not configured on the server{s||}, which suggests that these updates were manually installed, and that this issue is likely to re-occur in future.
#### Recommendation
Review existing patch management processes to ensure that updates are installed consistently and in a timely manner; for example as part of a monthly patching cycle. Consider also carrying out regular authenticated vulnerability scanning of the systems in order to identify missing updates.
