---
category: "APP-CNF"
cvss: "N/A"
report_on_external_network_test: false
---
### Insufficient Application Memory Protection
The {==APPLICATION NAME==} application does not provide sufficient security protections against sensitive data being stored in clear text in memory. An attacker with access to the {==SERVER/WORKSTATION==} running the application could extract sensitive information, such as {==CLEAR TEXT DATABASE USER CREDENTIALS==}.
The following examples show how it was possible to read the {==CLEAR TEXT DATABASE USER CREDENTIALS==} in {==APPLICATION NAME==} application by exporting memory data using the "Process Hacker" tool, with credentials masked where displayed.
{==SCREENSHOT==}
#### Impact: Medium
An attacker can obtain clear text {==CLEAR TEXT DATABASE USER CREDENTIALS==} from memory. An attacker extracting these credentials would potentially be able to {==EXAMPLE SCENARIO - logon to the SQL server instance as the {==system administrator (sa)==} account (see section {==XREFSQL Server Login Unnecessary Privileges==) and compromise the supporting SQL database, as well as accessing any sensitive data stored within it, or any other database on the system.==}
#### Likelihood: Low
The techniques for obtaining clear text passwords from memory are well known, and a number of publicly available tools exist to perform these attacks. However, an attacker would need to gain physical or logical access to the device where the application is installed and executed in order to read data from memory.
#### Recommendation
While there is no definitive solution to preventing attackers from accessing data in clear text in memory, consider zeroing or otherwise clearing memory containing any sensitive data immediately after use and ensure that memory cannot be accessed by other applications. Alternatively, consider encrypting data in memory.