---
category: "CNF"
cvss: "5.3"
---
### SQL Query String Concatenation
A number of instances were identified in the {==APPLICATION==} application source code, where database queries were generated based on concatenation of strings with variables obtained from the application user. An example is shown below, taken from the "{==CLASS==}" class:

```
{==CODE==}
```

This type of string concatenation is the most common cause of SQL injection vulnerabilities within applications. Note that vulnerable fields may exist which were not identified as the functionality of the application was not tested exhaustively.
#### Impact: High
If an application user can identify vulnerable functionality within the application, they could potentially compromise the supporting database and so gain access to sensitive data or launch further attacks.
#### Likelihood: Medium
Concatenated string queries appear to be the standard mechanism for database querying within the application, and the functionality calling these queries is used on publicly accessible pages, such as {==the forgotten password system==}.
#### Recommendation
Review the code used by the {==APPLICATION==} application suite and ensure that single quotes for strings used in all SQL statements are escaped and dynamic SQL statements are replaced with data type casting and parameterised stored procedure calls where possible.

{==OPTION==} For PHP consider the use of the PDO library and prepared statements, as discussed on the following page:

[https://php.net/manual/en/pdo.prepared-statements.php]()
