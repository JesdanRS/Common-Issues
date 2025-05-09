---
category: "{==APP-CNF/CNF==}"
cvss: "5.3"
---
### SQL Server UDP Query Remote Version Disclosure
The Microsoft SQL Server instance{s||} on the affected system{s||} {have||has} the SQL Server Browser service enabled, allowing an attacker to query version information by sending a SQL ping request to the server over UDP port 1434.

An example of the information returned by a SQL ping request to the host {==HOST==} is shown below:

{==HOSTNAME==}
```
ServerName   : EXAMPLE
InstanceName : MSSQLSERVER
IsClustered  : No
Version      : 9.00.5000.00
tcp          : 1433
np           : \\HOSTNAME\pipe\sql\query
```

The version information returned by this query is no longer updated when SQL Server updates are installed and as such may not reflect the true version installed.

Please note that UDP port 1434 is also used to handle the mapping of multiple SQL Server instances on the same machine.
#### Impact: Low
Unnecessary system information is exposed which could aid an attacker in exploiting other vulnerabilities.
#### Likelihood: Medium
This information can be quickly obtained with a SQL Server UDP ping request. SQL Server Management Studio and the related command-line utilities include the ability to do this natively.
#### Recommendation
For systems that only have a single SQL Server instance, consider disabling the SQL Browser service. If this is not possible then update the local firewall rules to restrict access to UDP port 1434. The following TechNet article contains further information:

[https://docs.microsoft.com/en-gb/sql/tools/configuration-manager/sql-server-browser-service]()
