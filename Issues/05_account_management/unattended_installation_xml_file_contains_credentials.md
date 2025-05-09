---
category: "PWD"
cvss: "8.4"
---
### Unattended Installation XML File Contains Credentials
An unattended installation XML file was found in the {==C:\Windows\Panther==} directory on the affected system{s||}, which contained the password for the local administrator account, as shown below.

C:\Windows\Panther\unattend.xml
```
<UserAccounts>
  <AdministratorPassword>
    <PlainText>true</PlainText>
    <Value>MASKEDPASSWORD</Value>
  </AdministratorPassword>
</UserAccounts>
```

The "unattend.xml" file is used by Sysprep as part of the unattended installation process.

{==OPTION==} Note that this password is also re-used on {==other systems in the domain.==}
#### Impact: High
An attacker obtaining this password would gain full control over the system, allowing them to access any data stored on it. {==OPTION==} As this password is re-used on other systems, this would quickly allow them to compromise the entire network, as discussed in section {==XREFLocalAdminPasswordReuse==}.
#### Likelihood: High
Unattended XML files are common source of passwords, and the file could be read by any authenticated user.
#### Recommendation
If the local Administrator account is not required then consider disabling it. Alternatively, consider implementing the Windows Local Administrator Password Solution (Windows LAPS), which automatically changes the Administrator password to a strong unique password on each system, changes the password every two weeks and stores the passwords in Active Directory. Please see the following article for further information:

[https://learn.microsoft.com/en-us/windows-server/identity/laps/laps-overview]()