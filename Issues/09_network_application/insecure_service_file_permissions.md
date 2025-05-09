---
category: "PRV"
cvss: "7.8"
---
### Insecure Service File Permissions
A review of the services running on sample server{s||} and workstation{s||} identified that some services and executables have permissive access rights on the above host{s||}. The {==built-in==} "{==GROUP==}" has full permission over the following executables.

{==Table==}
{==|Host|Executatble Path|Used by Service==}

As such, a low privileged user could modify or overwrite these executables, allowing them to execute malicious code when the services will restart. {==OPTION1==} If the services are running under the "NT AUTHORITY\SYSTEM" account, the code will be run with administrative permissions, granting the attacker full control of the affected host{s||}. {==OPTION2==} As these services are running under SYSTEM privilege, the code will be run with administrative permissions, granting the attacker full control of the affected host{s||}.
#### Impact: High
An attacker with access to the affected host{s||} {==may be able to/could==} escalate their privileges on the local system. Should administrative access be gained, the attacker could attempt further exploits, such as retrieving cached logged-in domain user credentials, in an effort to compromise the domain.
#### Likelihood: Low
An attacker will first need to gain or be granted access to the above system{s||} to exploit this issue.
#### Recommendation
Review service file permissions and restrict write/full control permissions to only those responsible for maintaining the software. Additionally, review and reduce the privileges assigned to these services. There are very few situations where services require privileged permissions such as "LocalSystem", and typically the local "Network Service" account, or a named low-privileged domain account, would be sufficient.