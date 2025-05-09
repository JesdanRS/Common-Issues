---
category: "{==APP-DAT/NET==}"
cvss: "6.5"
---
### Unencrypted SQL Server Traffic
The {==FIXME thick client==} connects directly to the SQL server{s||} listed above (as discussed in section {==XREFThickClientSQLAccount==}) using the clear text TDS protocol. Although the login is encrypted with TLS, all other traffic sent between the client and the database{s||} is unencrypted, as shown in the packet capture below:

{==XREFScreenshot==}
#### Impact: High
If an attacker is able to intercept this traffic, they would be able to view and potentially modify any information sent between the client and the database server{s||}. This could include sensitive {==personal or financial==} information.
#### Likelihood: Low
An attacker would need to intercept the traffic as part of an active or passive Man in the Middle (MitM) attack. There are a number of techniques that could be used to carry out this attack, such as compromising network infrastructure or ARP poisoning.
#### Recommendation
Configure both the client application and the server to use TLS encryption, as discussed in the following Microsoft article:

[https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/enable-encrypted-connections-to-the-database-engine]()
