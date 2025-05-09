---
category: "APP-LOG"
cvss: "N/A"
---
### Potentially Insufficient Logging and Monitoring
During testing Dionach observed behaviour that may indicate potentially insufficient logging and monitoring{==, although this cannot be positively verified from the viewpoint of a web application penetration test==}. Details are listed below{==OPTION==}, however, note that the points below may be false positives as {==CLIENTNAME==} may have sufficient logging and monitoring controls in place within the infrastructure to cover all relevant areas.

{==OPTION==}
 * {==Examination of the administrative panel indicated that there is no logging and monitoring functionality in place, in particular with login events.==}
 * {==Discussions with relevant IT staff indicated that no alerts were received during submission of numerous failed login attempts and vulnerability scans.==}
 * {==During the time period of testing, Dionach have not been contacted to confirm whether potential alerts or logs generated on the {==CLIENTNAME==}'s systems were triggered by Dionach tools and methodologies.==}
 * {==...==}
#### Impact: Medium
Lack of logging and monitoring deprives organisations of sufficient oversight in the context of identifying and managing potential attacks. Additionally, logs which could be used for forensic investigations or incident response plans might not be available.
#### Likelihood: Low
Attackers commonly rely on the lack of sufficient logging and monitoring when targeting organisations. Security logs can very often be found within the infrastructure such as in databases, firewalls or system backups.{==OPTION: Remove if strong evidence==} As the above points may be false positives, this issue is included for completeness to align with the OWASP Top 10 requirements.
#### Recommendation
Liaise with relevant IT staff and investigate the application and server logs that have been generated following this security assessment to ensure that logging and monitoring is sufficient. Additionally, review the current logging and monitoring procedures in place, and if required update them to accommodate all logging and monitoring security needs. Undertake a risk assessment to decide whether implementing further logging and monitoring within the application is required.

{==OPTION: WordPress==}For WordPress a number of plugins exist that can aid logging and monitoring, such as "WP Security Audit Log".

For further information, see the following article:

[https://owasp.org/Top10/A09_2021-Security_Logging_and_Monitoring_Failures/]()