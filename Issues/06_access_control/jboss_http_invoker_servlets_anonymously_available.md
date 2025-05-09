---
category: "APP-CNF"
cvss: "10.0"
---
### JBoss HTTP Invoker Servlets Anonymously Available
The JBoss HTTP Invoker servlets are enabled and anonymously available on the JBoss server{s||} at the following URL{s||}:

{==URL/invoker/EJBInvokerServlet==}

The EJBInvoker servlet can be used to deploy arbitrary web applications to a JBoss server by making a specially crafted POST request to the "/invoker/EJBInvokerServlet" page. This could be exploited by an unauthenticated attacker to upload a command shell web application to the affected JBoss servers, allowing arbitrary commands to be executed on the hosting server within the context of the JBoss service user.

{==OPTION==} Please note that, during testing, the sampled JBoss servers were identified as running with SYSTEM level privileges, as discussed in section {==XREFOverPrivilegedServices==}.

{==OPTION==} During testing, this issue was exploited to deploy a command shell web application to the JBoss server at URL. Once deployed, it was possible to execute system commands in order to {==add a local administrator user to the systems in order to further compromise network resources==}, as shown in the examples below:

{==URL==}/cmd/cmd.jsp?cmd=whoami

```
{==nt authority\system==}
```

{==OPTION==} Using the created local administrator accounts, it was possible to use privilege escalation attacks to completely compromise the Active Directory domain.

Further information regarding this vulnerability is available from the following URL:

[https://www.imperva.com/blog/archive/threat-advisory-a-jboss-as-exploit-web-shell-code-injection/]()
#### Impact: High
An attacker can deploy arbitrary web applications to the affected servers and execute arbitrary code within the context of the JBoss service user. This could be used to completely compromise the hosting servers and further target network resources.
#### Likelihood: High
This issue can be exploited by an unauthenticated attacker. Public exploit code is freely available and this is a widely known and commonly exploited vulnerability.
#### Recommendation
If the HTTP invokers are not required, they should be disabled as part of the server hardening procedures. Further information regarding disabling the HTTP invokers, as well as general JBoss hardening guidelines, is available from the following URL:

[https://developer.jboss.org/docs/DOC-12188]()

If the HTTP invokers are specifically required, ensure that they are secured by both requiring authentication and only being available from the local host. {==OPTION REDHAT==} Further information regarding securing the HTTP invokers is available from the following URL:

{==OPTION RHEL5==} [https://access.redhat.com/documentation/en-us/jboss_enterprise_application_platform_common_criteria_certification/5/html/administration_console_quick_start_guide/ch04s02]()

{==OPTION==} Additionally, consider running the JBoss services under a lower privileged account. Typically applications do not require SYSTEM level permissions and the built-in "Network Service" or another low privileged local or domain account will suffice.
