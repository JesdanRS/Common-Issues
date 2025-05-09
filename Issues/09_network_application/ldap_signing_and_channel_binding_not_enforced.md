---
category: "CNF"
cvss: "5.3"
---
### LDAP Signing and Channel Binding Not Enforced
LDAP signing and channel binding are not enforced within the {==DOMAINNAME==} Active Directory domain{==s==}. As a result, any systems that do not use these features will not require LDAP or LDAPS communication to be mutually authenticated. This can be seen below on the {==XREF_HOSTNAME==} domain controller:

{==Screenshot_DC_Local_Security_Policy / Get-ItemProperty...==}
#### Impact: Medium
An attacker that has successfully intercepted an NTLM authentication request would be able to relay it to any machine over LDAP or LDAPS. This would allow an attacker to move laterally or potentially elevate privileges within the domain.
#### Likelihood: Medium
This weakness requires the use of another attack such as broadcast protocol spoofing, DNS poisoning, or replying to NTLM authentication requests.
#### Recommendation
Consider enforcing LDAP signing and channel binding by setting the following Group Policy values to "Require Signing" and "Always", respectively:

```
Computer Configuration -> Windows Settings -> Security Settings -> Security Options -> "Domain controller: LDAP server signing requirements"
```

```
Computer Configuration -> Windows Settings -> Security Settings -> Security Options -> "Domain controller: LDAP server channel binding token requirements"
```

More details about these configurations can be found in the article at the following URL:

[https://support.microsoft.com/en-us/topic/2020-ldap-channel-binding-and-ldap-signing-requirements-for-windows-kb4520412-ef185fb8-00f7-167d-744c-f299a66fc00a]()

Please note, clients that do not support LDAP channel binding will be unable to execute LDAP queries against domain controllers that enforce these settings. As such, ensure appropriate planning and testing is performed before enforcing this policy.