---
category: "APP-CNF"
cvss: "5.3"
---
### JBoss Admin Pages Available Externally
The Web and JMX JBoss admin console page{s were|| was} found to be accessible externally at the following URL{s||}. Please note that authentication is required to access {these pages||this page}.

{==OPTION URL/web-console/==}
{==OPTION URL/jmx-console/==}

{==OPTION==} Additionally, the following JBoss Web Services related page{s were|| was} found accessible by anonymous users, although it seems like the functionality has not been configured:

{==URL/jbossws/==}
#### Impact: High
An attacker gaining access to the JBoss administrative console page{s||} could potentially compromise the server and gain access to other internal systems.
#### Likelihood: Low
These resources would be quickly identified by an attacker; however they would also need valid credentials in order to further compromise the system.
#### Recommendation
Consider restricting access to trusted IP addresses. Further information can be found at the following link:

[https://tomcat.apache.org/tomcat-7.0-doc/config/filter.html#Remote_Address_Filter]()

Ensure that complex passwords are used to protect the admin consoles.
