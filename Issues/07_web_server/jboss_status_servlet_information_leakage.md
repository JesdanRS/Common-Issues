---
category: "APP-CNF"
cvss: "5.3"
---
### JBoss Status Servlet Information Leakage
The JBoss server{s||} listed above {display||displays} the status servlet at the following URL{s||}:

{==URL/status?full=true==}
{==SCREENSHOT==}
#### Impact: Low
System information is unnecessarily revealed.
#### Likelihood: Medium
The status servlet is enabled by default and will be detected by automated vulnerability scanners.
#### Recommendation
If the status servlet is not required, it should be disabled. If the status servlet is required, restrict access to trusted management IP addresses only. The status servlet can be disabled by commenting out the following section of the JBoss configuration file:

{JBoss root}/deploy/jbossweb.deployer/ROOT.war/WEB-INF/web.xml
```
<servlet>
  <servlet-name>Status Servlet</servlet-name>
  <servlet-class>org.jboss.web.tomcat.service.StatusServlet</servlet-class>
</servlet>
<servlet-mapping>
  <servlet-name>Status Servlet</servlet-name>
  <url-pattern>/status</url-pattern>
</servlet-mapping>
```
